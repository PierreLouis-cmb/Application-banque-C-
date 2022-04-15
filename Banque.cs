using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours_23032022
{
    internal class Banque
    {
        private string name;// nom (string) (il faut definir les getters et les setters)
        private string adresse; //adresse (string) (il faut definir les getters et les setters)
        private List<Utilisateur> liste_utilisateur = new List<Utilisateur>();// liste-utilisateurs (List[Utilisateur]) (Utiliser la collection List) (il faut definir les getters et les setters et utiliser les indexeurs )

        public Banque(string name, string adresse)
        {
            Name = name;
            Adresse = adresse;
          
        }

        public string Name { get => name; set => name = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        internal List<Utilisateur> Liste_utilisateur { get => liste_utilisateur; set => liste_utilisateur = value; }


        //Il faut mettre quoi dans cette methode ? 
        public override string ToString()
        {
            string chaine = "";
            foreach (Object obj in liste_utilisateur)
            {
                chaine +=  "{0}{1}" + " - "+ obj;
               
            }
          return chaine + " Nom : " + this.name + " Adresse : " + this.adresse;
        }

        
    }
}
