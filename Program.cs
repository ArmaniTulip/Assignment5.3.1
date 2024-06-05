namespace Assignment5._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] flowerbed = {1,0,0,0,1};
            int n = 1;

            bool canPlant = PlaceFlowers(flowerbed, n);
            Console.WriteLine(canPlant? "true" : "false");
            

        }

        static bool PlaceFlowers(int[] flowerbed, int n)
        {
            int counter = 0;
            for (int i = 0; i < flowerbed.Length && counter < n; i++)
            {
                if (flowerbed[i] == 0)
                {
                    bool before = (i == 0) || (flowerbed[i] == 1);
                    bool after = (i == flowerbed.Length - 1) || (flowerbed[i+1] == 0);

                    if (before && after)
                    {
                        flowerbed[i] = 1; // plant a flower
                        counter++; // go next
                    }
                }
            }
            return counter == n;
        }

        

        

    }
}
