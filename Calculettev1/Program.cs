// brief Calculette//




// déclaration d'un double pour initier le dernier résultat afin de pouvoir enregister la dernière opération 
    double dernierResultat = 0;
// déclaration d'un bool à true pour réaliser une boucle entre le premier calcul et les suivants 
    bool newCalcul = true;
// création d'une fonction pour réaliser un visuel d'une calculette 
void CalculatriceVisuel()
{

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("\n" + new string('\u2550', 25));
    Console.ResetColor();
    Console.WriteLine("      CALCULATRICE    ");
    Console.ForegroundColor= ConsoleColor.DarkGray;
    Console.WriteLine( new string('\u2550', 25));
    Console.ResetColor();

    Console.WriteLine("     [7] [8] [9]");
    Console.WriteLine("     [4] [5] [6]");
    Console.WriteLine("     [1] [2] [3]");
    Console.WriteLine("     [0] [+] [-]");
    Console.WriteLine("     [*] [/] [=]\n");
}
// utilisation d'une boucle while afin que l'utilisateur reste dans l'interface autant que nécessaire 
        while (true)
        {
            // initialisation du premier et second nombre en double pour la futur saisi utilisateur et d'un char pour l'opérateur
            double Number1;
            char opérateur = '\0' ;
            double Number2;

            // utilisation d'un if afin que si newCalcul = true alors il doit demander le Number1
            if (newCalcul)
            {
              
                CalculatriceVisuel();
                // utilisation d'un try/ catch pour éviter une mauvaise saisie utilisateur qui ferait crasher le programme
                try
                {
                  
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Entrez le premier nombre :");
                    Console.ResetColor();                    
                    Number1 = double.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Saisie invalide !");
                    Console.ResetColor();
                    continue;
                }
            }
            // Dans le cas où ce n'est pas un nouveau calcul alors Number1 devient notre dernier résultat 
            else
            {
                Number1 = dernierResultat;
                Console.WriteLine($"Votre résultat : {Number1}");                  
                
            }


            // utilisation d'une boucle afin de s'assurer que l'utilisateur ne peut pas réaliser de mauvaise manip 
            // si tout  les critères sont  valide on sort de la boucle 
            while (true)
            {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Entrez l'opérateur (+, -, *, /) :");                   
                    Console.ResetColor();
                    // déclaration d'un string afin de pouvoir compter le nombre avec un point lenght
                    string saisie = Console.ReadLine();
                    // mise en place d'un condition pour que si saisi est strictement différent de 1, 
                    //un message d'erreur est envoyer
                    if (saisie.Length != 1)
                    {
                        Console.WriteLine("Veuillez entrer un seul caractère.");
                     continue;
                    }
                    // réaffecte saisie à l'operateur en char
                    opérateur = char.Parse(saisie);
                    // avec cette condition je mets en place le fait que la saisi ne peut être autre que " +, - , * ,/ "
                    if (opérateur != '+' && opérateur != '-' && opérateur != '*' && opérateur != '/')
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Veuillez utiliser seulement +, -, *, /");
                        Console.ResetColor();
                        continue;
                    }

                    break; // Sortir de la boucle si tout est valide
                
                
            }

            // Je réalise un second try/catch pour la saisi du deuxieme nombre
            try
            {
                
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Entrez le deuxième nombre :");               
                Console.ResetColor();
                Number2 = double.Parse(Console.ReadLine());
                // déclaration de la condition pour que lors d'une divison si le nombre2 est égale à zéro
                // alors un message indique que la division est impossible 
                if (opérateur == '/' && Number2 == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Division par zéro impossible !");
                    Console.ResetColor();
                    continue;
                }
            }
            catch
            {
                Console.Clear() ;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saisie invalide !");
                Console.ResetColor();
                continue;
            }

            // J'utilise un switch afin d'effectuer mes calculs selon l'opérateur choisi par l'utilisateur 
            switch (opérateur)
            {
                case '+': dernierResultat = Number1 + Number2; break;
                case '-': dernierResultat = Number1 - Number2; break;
                case '*': dernierResultat = Number1 * Number2; break;
                case '/': dernierResultat = Number1 / Number2; break;
            }
            // j'affiche le résultat de mon opération avec un contour
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n" + new string('\u2550', 25));
            Console.ResetColor();
            Console.WriteLine($" Résultat : {Number1} {opérateur} {Number2} = {dernierResultat}");
            Console.ForegroundColor= ConsoleColor.DarkGray;
            Console.WriteLine(  new string('\u2550', 25));
            Console.ResetColor();

            // Afin de donner la possibilité à mon utilisateur de continuer à effectuer son opération.
            // De recommencer son calcul.
            // ou sortir de l'application
            Console.ForegroundColor= ConsoleColor.DarkGray;
            Console.WriteLine("\nVoulez-vous continuer ? (o/n/x) x pour quitter :");
            Console.ResetColor();
            // déclare le choix utilisateur 
            string input = Console.ReadLine();
            // grâce à une condition if, else if et else je peux indiquer avec newCalcul selon si il est true ou false 
            // au programme ce qu'il doit effectuer selon le choix utilisateur 
            if (input == "o")
            {
                newCalcul = false;
            }
            else if (input == "n")
            {
                newCalcul = true;
            }
            else if (input == "x")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Option non reconnue");
                Console.ResetColor();
                newCalcul = false;
            }
        }
    



