using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace placeDuMarchéV1
{
    internal class Producteur
    {
        public int placeNumber;
        public string name;
        public List<Produit> produits = new List<Produit>();
        public Producteur(int modelPlaceNumber, string modelName, List<Produit> modelProduits) 
        {
            placeNumber = modelPlaceNumber;
            name = modelName;
            produits = modelProduits;
        }
    }
}
