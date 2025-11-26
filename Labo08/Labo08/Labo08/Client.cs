using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo08
{
    internal class Client
    {
        public string nom { get; private set; }
        public string ville { get; private set; }
        public string pays { get; private set; }
        public List<Commande> listeCommandes { get; private set; }

        public Client(string nom, string ville, string pays)
        {
            this.nom = nom;
            this.ville = ville;
            this.pays = pays;
            this.listeCommandes = new List<Commande>();
        }

        public void ajouteCommande(Commande uneCommande)
        {
            this.listeCommandes.Add(uneCommande);
        }

        public override string ToString()
        {
            String retour = String.Format("nom: {0}- ville: {1}- pays: {2} commandes -",
                this.nom, this.ville, this.pays);
            foreach (Commande uneCommande in listeCommandes)
                retour += "Commande[" + uneCommande.ToString() + "]";
            return retour;
        }
    }
}
