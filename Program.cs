namespace trapezokCLI
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Trapez> trapezok = new List<Trapez>();
            string[] fajlTartalom = File.ReadAllLines("trapezok.csv");

            foreach (var sor in fajlTartalom)
            {
                trapezok.Add(new Trapez(sor));
            }
            foreach(var trapez in trapezok)
            {
                Console.WriteLine(trapez);

               
            }
            Console.WriteLine("Szerkeszthető: ");
            foreach(var trapez in trapezok)
            {
                if (trapez.szerkesztheto())
                {
                    Console.WriteLine(trapez);
                }
            }
            Console.WriteLine("Derékszögűek: ");
            int derekszoguek = 0;
            foreach (var trapez in trapezok)
            {
                if (trapez.derekszogu())
                {
                    Console.WriteLine(trapez);
                    derekszoguek++;
                }
            }
            Console.WriteLine($"Összesen {derekszoguek} trapéz van.");
            Console.WriteLine("Téglalapok: ");
            int teglalapok =0;
            foreach(var teglalap in trapezok)
            {
                if (teglalap.teglalap())
                {
                    Console.WriteLine(teglalap);
                    teglalapok++;   
                }
                
            }
            Console.WriteLine($"Összesen {teglalapok} téglalap van.");
        }
    }
}
