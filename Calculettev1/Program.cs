// brief Calculette//

// déclaration de variable pour demander à l'utilisateur son opération

using System.Data.SqlTypes;

bool continuer = true;
double dernierResultat = 0;

bool premierCalcul = true;
do {

        double Number1;
        char opérateur;
        double Number2;
        
    Console.Clear();
        if (premierCalcul)
        {
                
            try
            {
                Console.WriteLine("Entrez le premier nombre :");
                 Number1 = double.Parse(Console.ReadLine());
            }
            catch {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("saisi invalid !");
                Console.ResetColor();
            continue;
            }
     
        }
        else
        {
            try
            {

                Number1 = dernierResultat;
                Console.WriteLine($"Premier nombre (résultat précédent) : {Number1}");
            }
            catch
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("saisi invalid !");
                Console.ResetColor();
            continue;
            }
        }
                
                    Console.WriteLine("Entrez l'opérateur (+, -, *, /) ou r pour effacer les résultat :");
                    opérateur = char.Parse(Console.ReadLine());
                        if (opérateur != '+' && opérateur != '-' && opérateur != '*' && opérateur != '/' && opérateur != 'r')
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Veuillez utiliser seulement +, -, *, / ou r");
                            Console.ResetColor();
                            continue;
                        }

                          
    
    try
            {

            Console.WriteLine("Entrez le deuxième nombre :");
                Number2 = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("saisi invalid");
                Console.ResetColor();
                
                continue;
            }
    

    string ResultatCalcul = "Votre opération : " + Number1 + opérateur + Number2;
        Console.WriteLine(ResultatCalcul);

    switch (opérateur)
    {

        case '+': dernierResultat = Number1 + Number2;break;

            case '-':dernierResultat= Number1 - Number2;break;

                case '*':dernierResultat = Number1 * Number2; break;

             
                  case '/':
                    if (Number2 == 0)  
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Division par zéro impossible!");
                        Console.ResetColor();
                        continue;
                    }
                    dernierResultat = Number1 / Number2;
                    
                  break;
                        case 'r':

                                if (opérateur == 'r' || opérateur == 'R')
                                {
                                    premierCalcul = true;
                                    double resultat = 0;
                                    Console.WriteLine("Calculatrice réinitialisée !");
                                    continue;
                                }

                        break;

    }
            Console.WriteLine($"Résultat : {dernierResultat}");
            premierCalcul = false;

            Console.WriteLine("\nVoulez-vous continuer? (o/n)");
            continuer = Console.ReadLine() == "o";
            
} while (continuer);