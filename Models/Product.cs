using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lopushok.Models
{

    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CountInStock { get; set; }
        public string ArticleNumber { get; set; }
        public int MinPrice { get; set; }
        public string Image { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public string ImageUri => string.IsNullOrEmpty(Image)
            ? "/Properties/box.png"
            : Path.Combine("http://169.254.131.1/", "images", Path.ChangeExtension(Image, "jpeg"));
    }
}