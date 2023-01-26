using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cats_FTW.Models
{
    public class CatImage : BaseModel
    {
        public string BinaryData { get; set; }
        public string Url { get; set; }
        public string AltText { get; set; }
        public int LikesCount { get; set; }
    }
}