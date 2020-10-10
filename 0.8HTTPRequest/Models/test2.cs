using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0._8HTTPRequest.Models
{
    public class test2
    {
        public Standard standard { get; set; }
        public string longt { get; set; }
        public Alt alt { get; set; }
        public Elevation elevation { get; set; }
        public string latt { get; set; }
    }
    public class Addresst
    {
    }

    public class Postal
    {
    }

    public class Standard
    {
        public Addresst addresst { get; set; }
        public string city { get; set; }
        public string prov { get; set; }
        public string countryname { get; set; }
        public Postal postal { get; set; }
        public string confidence { get; set; }
    }

    public class Region
    {
    }

    public class Loc
    {
        public string longt { get; set; }
        public string prov { get; set; }
        public string city { get; set; }
        public string countryname { get; set; }
        public string postal { get; set; }
        public Region region { get; set; }
        public string latt { get; set; }
    }

    public class Alt
    {
        public Loc loc { get; set; }
    }

    public class Elevation
    {
    }

   

}
