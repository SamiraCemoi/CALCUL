// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using System;     // directive essentielle qui permet d'importer le namespace qui contient des classes et va faciliter l'utilisation de celles ci dans namespace


namespace Calculatrice  // je crée ma boîte générale qui regroupe les classes et structures 
{
    class program // classe qui est le point d'entree de mon programme
    {
        static void Main(string[] args) // static veut dire que la méthode appartient à la classe et pas aux objets qui sont dans la classe
            // nom de la méthode qui est executée + paramètre de la méthode
        {
            int res;
            

                switch (operateur) // dans cette boucle on demande d'executer un calcul selon chaque operateur
                {
                    case "+":
                        res = n1 + n2;
                        Console.WriteLine("Addition:" + res);
                        break;

                    case "-":
                        res = n1 - n2;
                        Console.WriteLine("Soustraction:" + res);
                        break;

                    case "*":
                        res = n1 * n2;
                        Console.WriteLine("Multiplication:" + res);
                        break;

                    default:
                        Console.WriteLine("Wrong input");
                        break;

                    

                        
                }

            
        }
    }
}
