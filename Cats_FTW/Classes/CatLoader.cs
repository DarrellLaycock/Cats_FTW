using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.IO;
using System.Data.Linq;
using System.Linq;
using System.Net;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Newtonsoft.Json.Linq;

namespace Cats_FTW.Classes
{
    public class CatLoader
    { 
        public static void LoadCatImagesToTable()
        {
            int desiredImageCountInTable = 150;
            int minumumImageWidth = 450;
            int maximumImageWidth = 550;
            int minimumImageHeight = 300;
            int maximumImageHeight = 350;

            //TruncateCatImageTable();

            //get all existing images from database
            List<string> existingUrls = GetImageUrlsInCatImages();

            while (existingUrls.Count < desiredImageCountInTable)
            {
                var imageUrls = GetImages(minumumImageWidth, maximumImageWidth, minimumImageHeight, maximumImageHeight);

                foreach (var url in imageUrls)
                {
                    if (existingUrls.Contains(url) == false)
                    {
                        string imageAsBinary = ImageUrlToBase64String(url);
                        InsertImageUrl(url, imageAsBinary);
                        existingUrls.Add(url);
                    }
                }
            }
        }

        private static List<string> GetImages(int minimumWidth, int maximumWidth, int minimumImageHeight, int maximumImageHeight)
        {           
            List<string> imageUrls = new List<string>();
            Stream dataStream = null;
            WebRequest request = null;
            HttpWebResponse response = null;

            int attempts = 1;
            const int MAX_ATTEMPTS = 10;

            while (attempts < MAX_ATTEMPTS)
            {
                try
                {
                    dataStream = null;
                    string url = @"https://api.thecatapi.com/v1/images/search?limit=10";
                    request = WebRequest.Create(url);
                    request.Timeout = 4000;
                    request.Timeout += attempts;
                    System.Threading.Thread.Sleep(100);
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    // Skip validation of SSL/TLS certificate
                    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                    response = (HttpWebResponse)request.GetResponse();

                    // Get the stream containing content returned by the server.
                    dataStream = response.GetResponseStream();

                    attempts = MAX_ATTEMPTS;
                }
                catch (Exception ex)
                {
                    attempts++;
                }
            }

            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

            // response example:[{"id":"24n","url":"https://cdn2.thecatapi.com/images/24n.jpg","width":950,"height":668}] Stream dataStream = null;
            dynamic arrayOfCatImageUrls = Newtonsoft.Json.JsonConvert.DeserializeObject(responseFromServer);

            foreach (var item in arrayOfCatImageUrls)
            {
                if (Convert.ToInt32(item["width"])> minimumWidth 
                    && Convert.ToInt32(item["width"]) < maximumWidth
                    && Convert.ToInt32(item["height"]) > minimumImageHeight
                    && Convert.ToInt32(item["height"]) < maximumImageHeight)
                {
                    imageUrls.Add(item["url"].ToString());
                }
            }

            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();

           return imageUrls;
        }


        private static List<string> GetImageUrlsInCatImages()
        {
            int count = 0;

            string sql = "SELECT Url FROM dbo.CatImages";

            List<string> existingUrls = new List<string>();

            string connectionString = ConfigurationManager.ConnectionStrings["SQLDbContext"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            using (var conn = sqlConnection)
            {
                using (var reader = new SqlCommand(sql, conn).ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            existingUrls.Add(reader.GetString(0).ToString());
                        }
                    }
                }
            }

            return existingUrls;
        }

        static void InsertImageUrl(string url, string imageAsBinary)
        {
            string connectionString  = ConfigurationManager.ConnectionStrings["SQLDbContext"].ConnectionString;
            string sql = "INSERT INTO dbo.CatImages(Uid, Url, BinaryData, LikesCount, IsActive) VALUES(@Uid, @Url, @BinaryData, 0, 1)";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
            {
                sqlCommand.Parameters.Add("@Uid", SqlDbType.VarChar).Value = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8);
                sqlCommand.Parameters.Add("@Url", SqlDbType.VarChar).Value = url;
                sqlCommand.Parameters.Add("@BinaryData", SqlDbType.VarChar).Value = imageAsBinary;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        static void TruncateCatImageTable()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SQLDbContext"].ConnectionString;
            string sql = "TRUNCATE TABLE dbo.CatImages";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public static string ImageUrlToBase64String(string url)
        {
            byte[] raw;
            using (var client = new WebClient())
            { 
                raw = client.DownloadData(url);
            }
            var binary = new Binary(raw);
            return "data:image/" + Path.GetExtension(url).Substring(1) + ";base64," + Convert.ToBase64String(binary.ToArray());
        }
    }
}