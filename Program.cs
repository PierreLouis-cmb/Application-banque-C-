// See https://aka.ms/new-console-template for more information
using cours_23032022;
using System;
using System.Collections;


String nom, prenom,type_operation,date_operation;
int solde, action,choix;


Banque banqueCaisse = new Banque("Caisse d'epargne","Paris 3 rue de truc");
Banque banquebnp = new Banque("Bnp ","Paris 4 rue de truc");



Console.WriteLine("///////////////////////BANQUE///////////////////////");
Console.WriteLine(" ");
Console.WriteLine("Créer votre compte");

Console.WriteLine("Votre nom");
    nom = Console.ReadLine();
Console.WriteLine("Votre prénom");
    prenom = Console.ReadLine();
Console.WriteLine("Votre solde");
    solde = Int32.Parse(Console.ReadLine());


Utilisateur utilisateur = new(nom,prenom,solde);

Console.WriteLine("Ajouter votre banque ");
Console.WriteLine(" 1 " + banquebnp.Name);
Console.WriteLine(" 2 " + banqueCaisse.Name);
choix = Int32.Parse(Console.ReadLine());


Gestiuonnaire_banque gestiuonnaire_Banque = new Gestiuonnaire_banque();
if (choix == 1)
{
    gestiuonnaire_Banque.AddUserToBank(banquebnp, utilisateur);
}
else if (choix == 2)
{
    gestiuonnaire_Banque.AddUserToBank(banqueCaisse, utilisateur);
}
Console.WriteLine("Quelle opération voulez-vous faire (Taper le nombre)");

//Console.WriteLine("2 - Faire une Operation bancaire ");
       // action = Int32.Parse(Console.ReadLine());


        Console.WriteLine("Choisir votre type d'opération");
        Console.WriteLine(" 1 - Créditer");
        Console.WriteLine(" 2 - Débiter");
        Console.WriteLine(" 3 - Consulter mon solde");
        Console.WriteLine(" 4 - quitter");
        choix = Int32.Parse(Console.ReadLine());
        bool restart = true;


switch (choix)
{
    case 1:
        Console.WriteLine(" Tapez le montant à crediter");
        int montant = Int32.Parse(Console.ReadLine());
        type_operation = "crediter";
        date_operation = DateTime.Now.Date.ToString();
        gestiuonnaire_Banque.AddOpBank(type_operation, date_operation, utilisateur, montant);

       // Console.WriteLine(" Revenir au menu ? si oui tapez 1");
       // int restartUser = Int32.Parse(Console.ReadLine());

        break;
    case 2:
        Console.WriteLine(" Tapez le montant à debiter");
        montant = Int32.Parse(Console.ReadLine());
        type_operation = "debiter";
        date_operation = DateTime.Now.Date.ToString();
        gestiuonnaire_Banque.AddOpBank(type_operation, date_operation, utilisateur, montant);

        break;
    case 3:
        Console.WriteLine(" Consulter votre solde");
        type_operation = "consulter";
        date_operation = DateTime.Now.Date.ToString();

        gestiuonnaire_Banque.AddOpBank("consulter", date_operation, utilisateur, 0);

        break;
    case 4:

        restart = false;
        break;


}


//int montantRetirer = Int32.Parse(Console.ReadLine());
    for (int i = 0; i < utilisateur.operatiouns_bancaires.Count; i++)
    {
        Console.WriteLine(utilisateur.operatiouns_bancaires[i]);
    }

//Modifier get de la liste Operatiouns_bancaires dans la classe USER 
Console.ReadLine();
