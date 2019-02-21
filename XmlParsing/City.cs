using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlParsing
{
    public class City
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public bool IsCapital { get; set; }
        public string CountryName { get; set; }

        public City()
        {
            Id = Guid.NewGuid();
        }
    }
}
