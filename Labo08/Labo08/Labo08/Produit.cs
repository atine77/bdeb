using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo08
{
    internal class Produit
    {
        public int produitID { get; private set; }
        public double prix { get; private set; }

        public Produit(int produitID, double prix)
        {
            this.produitID = produitID;
            this.prix = prix;
        }

        public override string ToString()
        {
            return String.Format("produitID: {0}- prix: {1}",
                this.produitID, this.prix);
        }
    }
}
