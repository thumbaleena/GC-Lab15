using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber15
{
    class Country
    {
        private string name;
//        private string continent;

        public Country(string name)
        {
            getName = name;
 //           this.continent = continent;
        }

        public string getName { get; set; }
 //       public string getContinent { get; set; }
        public override string ToString()
        {
            return getName;
        }
    }

}
