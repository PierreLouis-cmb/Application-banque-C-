using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours_23032022
{
    internal class Gestiuonnaire_banque
    {
        // methode qui permet d'ajouter un utilisateur a une banque
        public void AddUserToBank(Banque banque,Utilisateur utilisateur)
        {
          

            if(banque.Liste_utilisateur == null)
            {
                if(utilisateur != null)
                {
                    banque.Liste_utilisateur.Add(utilisateur);
                }
                else
                {
                    Console.WriteLine("Veulliez renseinger un Utilisateur");
                }
                
            }
        }



        // méthode qui permet ajouter une opération bancaire
        public void AddOpBank(string type_operation, string date_operation,Utilisateur utilisateur,int montant)
        {
            Operation_bancaire operation_Bancaire = new Operation_bancaire(type_operation, date_operation, utilisateur);

            //Ici j'enregistre l'historique des opérations passé par l'utilisateur
            utilisateur.operatiouns_bancaires.Add(operation_Bancaire);

            //Traitement des opérations
            switch (type_operation)
            {
                case "crediter":
                    Console.WriteLine(operation_Bancaire.crediter(montant, utilisateur));
                    Console.WriteLine(operation_Bancaire.consulter(utilisateur));
                    break;

                case "debiter":
                    Console.WriteLine(operation_Bancaire.debiter(montant, utilisateur));
                    Console.WriteLine(operation_Bancaire.consulter(utilisateur));
                    break;
                case "consulter":
                    Console.WriteLine(operation_Bancaire.consulter(utilisateur));
                    break;

            }
        }



        // méthode qui permet lister les opérations bancaires par rapport a un utilisateur


        //Retourner la liste des user de la banque 

        
    }
}
