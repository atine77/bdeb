using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo08
{
    public enum Mois { Janvier, Fevrier, Mars, Avril, Mai, Juin, Juillet, Aout, Septembre, Octobre, Novembre, Decembre };
    internal class Commande
    {
        public int commandeID { get; private set; }
        public int quantite { get; private set; }
        public bool expedie { get; private set; }
        public Mois mois { get; private set; }
        public int idproduit { get; private set; }

        public Commande(int commandeID, int quantite, bool expedie, Mois mois, int idproduit)
        {
            this.commandeID = commandeID;
            this.quantite = quantite;
            this.expedie = expedie;
            this.mois = mois;
            this.idproduit = idproduit;
        }

        public override string ToString()
        {
            return String.Format("commandeID: {0}- idproduct: {1}- quantite: {2}- expedie: {3}- mois: {4}",
                this.commandeID, this.idproduit, this.quantite, this.expedie, this.mois);
        }
    }
}
