using placeDuMarchéV1;
using System.Collections.Generic;
using System.Xml.Linq;

static void Main(string[] args)
{
    List<Producteur> Producteurs = new List<Producteur>();
    Producteurs.Add(new Producteur(
        1,
        "Bernard",
        new List<Produit>()
   ));
    Producteurs[0].produits.Add(new Produit("pomme", 12, "kg",12));

}
