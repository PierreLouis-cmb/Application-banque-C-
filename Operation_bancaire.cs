using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours_23032022
{
    internal class Operation_bancaire
    {
        private string type_operation; // type_opration (string) (il faut definir les getters et les setters)
        private string date_operation; // date_operation (string) { retrait-crediter-afficher information compte  (il faut definir les getters et les setters)


        //// une methode qui va etre declenché au moment ou l'utilisateur
        //voudra faire un retrait et que son solde est négatif(Gestion erreurs
        //personnalisé) (Decouvert non autorisé)
       
        
        //A déclancger dans le constructeur pour lancer la gestion d'erreur automatiquepent a l'instication de l'erreur
        public Operation_bancaire(string type_operation, string date_operation,Utilisateur utilisateur)
        {
            this.type_operation = type_operation;
            this.date_operation = date_operation;

            int solde_user = utilisateur.Solde;

            try
            {
                if (solde_user < 0)
                {
                    Console.WriteLine("Vous pouvez faire des opérations");
                    // deduire le montant demander par l'utilisateur de son solde
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Votre solde est négatif {0}", ex);
            }

            //Faire methode pour le retrait 
            // créditer
            //consultation
            //enregistrer les opérations



   //         if (solde_user < 0)
   //         {
   //             Console.WriteLine("Votre solde est négatif");
   //         }
  //          else
 //           {
                Console.WriteLine ("vous pouvez retirer");
 //           }

        }


        public int crediter(int montant, Utilisateur utilisateur)
        {
            return utilisateur.Solde += montant;
          

           
        }
        public int debiter(int montant, Utilisateur utilisateur)
        {
            return utilisateur.Solde -= montant;
        }

        public String consulter(Utilisateur utilisateur)
            
        {
            //Console.WriteLine("Votre solde est de : " + utilisateur.Solde);
            return "Votre solde est de : " + utilisateur.Solde;
        }

        public void consulterAll(Utilisateur utilisateur)

        {

            Console.WriteLine("Votre solde est de : " + utilisateur.Solde);
            
        }



    }
}
