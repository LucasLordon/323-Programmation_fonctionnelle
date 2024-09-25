using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace placeDuMarchéV1
{
    internal class Produit
    {
        public string name;
        public int prix;
        public string unite;
        public int number;
        public Produit(string modelName,int modelPrix,string modelUnite,int modelNumber) 
        {
            name = modelName;
            prix = modelPrix;
            unite = modelUnite;
            number = modelNumber;
        }
    }
}
