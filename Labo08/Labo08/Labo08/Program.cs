using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo08
{
    class Program
    {
        private static List<Produit> lstProduits = new List<Produit>();
        private static List<Client> lstClients = new List<Client>();

        static void Main(string[] args)
        {
            // Remplissage des produits
            lstProduits.Add(new Produit(1, 10));
            lstProduits.Add(new Produit(2, 20));
            lstProduits.Add(new Produit(3, 30));
            lstProduits.Add(new Produit(4, 40));
            lstProduits.Add(new Produit(5, 50));
            lstProduits.Add(new Produit(6, 60));

            // Remplissage des clients
            Client unClient = new Client("Joseph", "Montréal", "Canada");
            unClient.ajouteCommande(new Commande(1, 3, false, Mois.Janvier, 1));
            unClient.ajouteCommande(new Commande(2, 5, true, Mois.Mai, 2));
            lstClients.Add(unClient);

            unClient = new Client("John", "Winnipeg", "Canada");
            unClient.ajouteCommande(new Commande(3, 10, false, Mois.Juillet, 1));
            unClient.ajouteCommande(new Commande(4, 20, true, Mois.Decembre, 3));
            lstClients.Add(unClient);

            unClient = new Client("James", "Dallas", "USA");
            unClient.ajouteCommande(new Commande(5, 20, true, Mois.Decembre, 3));
            lstClients.Add(unClient);

            unClient = new Client("Frank", "Seatle", "USA");
            unClient.ajouteCommande(new Commande(6, 20, false, Mois.Juillet, 5));
            lstClients.Add(unClient);

            //requete 2
            var lesProduits30 = from unProduit in lstProduits where unProduit.prix > 30 select unProduit;

            foreach (var item in lesProduits30)
            {
                Console.WriteLine(item.produitID + " " + item.prix);
                
            }
            //requete 3
            Console.WriteLine("Requete 3");
            Console.WriteLine(lesProduits30.Count());
            Console.WriteLine(lesProduits30.Average(un => un.prix));

            Console.WriteLine("Requete 4");
            lstProduits.Add(new Produit(7, 70));
            Console.WriteLine(lesProduits30.Count());
            Console.WriteLine(lesProduits30.Average(un => un.prix));

            Console.WriteLine("Partie 2");
            Console.WriteLine("Requete 1");
            var commandePasseesAmericains = from unClient2 in lstClients
                                            where unClient2.pays == "USA"
                                            from uneCommande in unClient2.listeCommandes
                                            select uneCommande;

            foreach (var item in commandePasseesAmericains)
            {
                Console.WriteLine(item.commandeID+" "+item.quantite+" "+item.expedie+" "+item.mois+" "+item.idproduit);
            }
            Console.WriteLine("Requete 2");

            var commandePasseesCanadiens = from unClient3 in lstClients
                                           where unClient3.pays == "Canada"
                                           from uneCommande in unClient3.listeCommandes
                                           from unProduit in lstProduits
                                           where uneCommande.idproduit == unProduit.produitID
                                           select unProduit;


            foreach (var item in commandePasseesCanadiens)
            {
                Console.WriteLine(item.produitID+" "+item.prix);
            }
            Console.WriteLine("Requete 3");

            var ClientsCommandesCout = from unClient4 in lstClients
                                       from uneCommande in unClient4.listeCommandes
                                       from unProduit in lstProduits
                                       where uneCommande.idproduit == unProduit.produitID
               
                                       select new { unClient4.nom, cout = uneCommande.quantite * unProduit.prix };

            Console.WriteLine("Nom        Cout");

            foreach (var item in ClientsCommandesCout)
            {

                Console.WriteLine( item.nom + "         " + item.cout);
            }

            Console.WriteLine("Requete 4");
            








        }
    }
}


