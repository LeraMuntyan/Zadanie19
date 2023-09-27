using System;

class MainClass
{
    public static void Main()
    {
        int n = 5; 
        int[,] arr = new int[n, n]; 

       
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                { 
                    arr[i, j] = i;
                }
                else if (i + j == n - 1)
                { 
                    arr[i, j] = j;
                }
                else
                { 
                    arr[i, j] = new Random().Next(1, 10);
                }
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
            
            {
                Console.WriteLine("Esli hotite povtorit vvod, vvedite 1, inache lubuyu dr cifru");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1) Main();
                return;
            }
            

        }
    }
}
