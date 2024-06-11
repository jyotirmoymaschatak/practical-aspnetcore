using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1_manage_recipe
{
    public class Recipe
    {
        public string Title { get; set; }
        public string Instructions { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Categories { get; set; }
    }
}
