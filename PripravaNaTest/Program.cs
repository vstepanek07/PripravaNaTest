namespace PripravaNaTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hodyKostkou = new int[5];
            hodyKostkou[0] = 0;
            hodyKostkou[1] = 0;
            hodyKostkou[2] = 0;
            hodyKostkou[3] = 0;
            hodyKostkou[4] = 0;

            string[] hrac = new string[5];

            hrac[0] = "Petr";
            hrac[1] = "Kuba";
            hrac[2] = "Ondra";
            hrac[3] = "Vašek";
            hrac[4] = "Jirka";

            int pole = 0;



            for (int index = 0; index < hrac.Length; index++)
            {

                Console.WriteLine($"Hraje hráč: {hrac[index]}. Zadej svůj hod");
                hodyKostkou[index] = int.Parse(Console.ReadLine());

            }

            static void StatistikaHodu(int[] hodyKostkou)
            {
                int soucetHodu = 0;
                int maxHod = hodyKostkou[0];
                int i = 0;

                while (i < hodyKostkou.Length)
                {
                    if (hodyKostkou[i] < 1 || hodyKostkou[i] > 6)
                    {
                        Console.WriteLine($"Pole {i + +1}  obsahuje neplatnou hodnotu hodu kostkou!!!!");
                        return;
                    }
                    soucetHodu = soucetHodu + hodyKostkou[i];

                    if (hodyKostkou[i] > maxHod)
                    {
                        maxHod = hodyKostkou[i];
                    }
                    i++;

                }

                Console.WriteLine($"Součet všech hodů je: {soucetHodu}");
                Console.WriteLine($"Největší hod je: {maxHod}");

            }

            StatistikaHodu(hodyKostkou);

        }
    }
}
