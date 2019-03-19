using System;

namespace ooad__t1__primjer1
{
    class Program
    {
        const int BROJ_UNOSA = 6;

        static void Main(string[] args)
        {
            String unesi;
            int[] niz;

            // "{0}" je kao placeholder za bilo koji tip podataka, a ako ih se unosi vise ide {1}...
            Console.WriteLine("Unesite niz od {0} brojeva odvojenih zarezom. Unesite q za prekid unosa", BROJ_UNOSA);

            do
            {
                unesi = Console.ReadLine();
                //staticka metoda mora pozivati staticku metodu ili 
            } while (ispravanUnos(unesi, out niz)== false);

                                                    // if ? then : else - druga sintaksa
            String pozitivniBrojevi = daLiSuSviPozitivniBrojevi(niz) ? "jesu" : "nisu";
            String neparniBrojevi = imaLiNeparnihBrojeva(niz) ? "ima" : "nema";


            Console.WriteLine("U nizu svi brojevi {0} pozitivni, te {1} nepranih brojeva", pozitivniBrojevi, neparniBrojevi);

            ispisiNiz(niz);

            Console.ReadLine();
        }

        //pisanjem "out" se salje paramtear po referenci, te obavezno se mora inicijalizirati u funkciji
        //ne zahtjeva da se varijabli parametra dodijeli vrijednost prije predaje varijable parametra metodi
        static public Boolean ispravanUnos(String unesi, out int[] niz)
        {
            String[] brojeviString = unesi.Split(",");
            niz = new int[6];

            if (brojeviString.Length != BROJ_UNOSA)
            {
                Console.WriteLine("pogresan unos, unesite ponovno\n");
                return false;
            }

            for (int i = 0; i < BROJ_UNOSA; i++)
                if (Int32.TryParse(brojeviString[i], out niz[i]) == false)
                {
                    Console.WriteLine("pogresan unos, unesite ponovno\n");
                    return false;
                }

            return true;
        }

        public static Boolean daLiSuSviPozitivniBrojevi(int[] niz)
        {
            for (int i = 0; i < BROJ_UNOSA; i++)
                if (niz[i] < 0)
                    return false;

            return true;
        }

        public static bool imaLiNeparnihBrojeva(int[] niz)
        {
            for (int i = 0; i < BROJ_UNOSA; i++)
                if (niz[i] % 2 == 1)
                    return true;

            return false;
        }

        public static void ispisiNiz(int[] niz)
        {
            for(int i=0; i<niz.Length; i++)
            {
                //metoda "Write" radi isto sto i metoda "WriteLine", osim sto ne stavlja \n na kraj
                Console.Write("{0}", niz[i]);
                if (i != niz.Length - 1)
                    Console.Write(", ");
                
            }
        }

        public static void nista()
        {
        }
    }
}
