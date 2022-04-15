using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours_23032022
{
    internal class Utilisateur
    {
        private string nom;// nom(string) (il faut definir les getters et les setters)

        private string prenom;// prenom(string) (il faut definir les getters et les setters)

        private int solde; // solde (int) (il faut definir les getters et les setters)

        // operations_bancaires (List[operation_bancaire]) (il faut definir les getters et les setters et utiliser les indexeurs )
        public List<Operation_bancaire> operatiouns_bancaires = new List<Operation_bancaire>(); //Ilfaut sérialisé cart c'est un tableau d'objet 


        public Utilisateur(string nom, string prenom, int solde)
        {
            Nom = nom;
            Prenom = prenom;
            Solde = solde;
            
         
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Solde { get => solde; set => solde = value; }
        internal List<Operation_bancaire> Operatiouns_bancaires {

            get => operatiouns_bancaires; set => operatiouns_bancaires = value; 
        }


        //Afficher les informations de quoi ? 
        public override String ToString()
        {
            return nom + "" + prenom + "" + solde+ "" + Operatiouns_bancaires;

            //pour parcour les opération banquer il faut utiliser la methode de la classe Operation_bancaire toString
        }
    }
}
