using Cats_FTW.Migrations;
using Cats_FTW.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cats_FTW.Classes
{
    public class CatFactGenerator
    {
        public SQLDbContext DbContext { get; set; }
        public InMemoryCache Cache { get; set; }

        public CatFactGenerator()
        {
            DbContext = new SQLDbContext();
            Cache = new InMemoryCache();
        }

        public CatImageWithFact GetRandomImageAndFact()
        {
            List<string> facts = Cache.GetOrSet("CatFacts", () => GetFacts());
            string fact = facts.OrderBy(x => Guid.NewGuid()).First();

            List<string> images = Cache.GetOrSet("CatImages", () => GetImagesAsBase64String());
            var base64Image = images.OrderBy(x => Guid.NewGuid()).First();

            CatImageWithFact catImageWithFacts = new CatImageWithFact();
            catImageWithFacts.Fact = fact;
            catImageWithFacts.Img = base64Image;
            return catImageWithFacts;
        }

        private List<string> GetFacts()
        {
            return DbContext.CatFacts.Where(item => item.IsActive).Select(item => item.Text).ToList();
        }

        private List<string> GetImagesAsBase64String()
        {
            return DbContext.CatImages.Where(item => item.IsActive).Select(item => item.BinaryData).ToList();
        }
    }
}