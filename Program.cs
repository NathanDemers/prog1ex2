namespace Devoirs_semaine_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //compteArebours();
            //nbOccurences();
            //moyenne();
            //money();
        }

        static void compteArebours()
        {
            int nbUti = 0;
            

            Console.WriteLine("Combiens de temps?");
            int.TryParse(Console.ReadLine(), out nbUti);

            while(nbUti >= 0)
            {
                Console.WriteLine(nbUti);
                nbUti--;
            }
        }

        static void nbOccurences()
        {
            int nb = 0;
            int posi = 0;
            int nega = 0;
            Console.WriteLine("Entrer des nombres entier et entrer 0 quand vous avez fini");
            int.TryParse(Console.ReadLine(), out nb);


            while(nb != 0)
            {
                Console.WriteLine("Entrer des nombres entier et entrer 0 quand vous avez fini");
                int.TryParse(Console.ReadLine(), out nb);

                if (nb > 0)
                {
                    posi++;
                }
                else if (nb < 0)
                {
                    nega++;
                }
            }

            Console.WriteLine("Positif : " + posi);
            Console.WriteLine("Negatif : " + nega);           

        }

        static void moyenne()
        {
            int notes = 0;
            double nbDeNotes = 0;
            double moyenne = 0;
            double total = 0;

            Console.WriteLine("Entrer Vos notes et entrer un nombre negatif pour terminer");
            int.TryParse(Console.ReadLine(), out notes);


            while (notes >= 0)
            {
                Console.WriteLine("Entrer Vos notes et entrer un nombre negatif pour terminer");
                int.TryParse(Console.ReadLine(), out notes);

                if(notes >= 0)
                {
                    total = total + notes;
                    nbDeNotes++;
                }
            }

            moyenne = total / nbDeNotes;
            
            Console.WriteLine("La moyenne est : " + moyenne);
        }

        static void money()
        {
            double article = 0;
            double totalarticle = 0;


            Console.WriteLine("total");
            double.TryParse(Console.ReadLine(), out article);

            
            if (article < 0)
            {
                Console.WriteLine("Calcule de votre total");

                if (article >= 100)
                {
                    totalarticle = article * 0.9;

                }

                else
                {
                    Console.WriteLine("Votre total est : " + totalarticle);
                }
            }

            
        }
    }
}