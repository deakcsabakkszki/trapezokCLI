namespace trapezokCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Trapez> trapezok = new List<Trapez>();
            string[] fajlTartalom = File.ReadAllLines("trapezok.csv");

            foreach (var sor in fajlTartalom)
            {
                trapezok.Add(new Trapez(sor));
            }
        }
    }
}
