// See https://aka.ms/new-console-template for more information


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
