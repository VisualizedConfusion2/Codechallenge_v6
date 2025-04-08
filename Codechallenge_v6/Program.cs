namespace Codechallenge_v6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Ingredienser = new List<string>();
            Ingredienser.Add("200g hvedemel");
            Ingredienser.Add("2 teskefuld Bagepulver");
            Ingredienser.Add("½ teskefuld fint salt");
            Ingredienser.Add("2 æg");
            Ingredienser.Add("150g sukker");
            Ingredienser.Add("1 teskefuld vaniljesukker");
            Ingredienser.Add("125g smeltet smør");
            Ingredienser.Add("2 modne bananer");
            Ingredienser.Add("100g mørk chokolade");


            foreach (string ingrediens in Ingredienser)
            {
                Console.WriteLine($"-ingrediens");
            }
        }
    }
}
