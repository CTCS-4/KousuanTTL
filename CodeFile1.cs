using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        List<int[]> add = new List<int[]>();
        int[] num = new int[2];
        Random ro = new Random();
        int i;
        for (i = 0; i < 300; i++)
        {
            int num1; num1 = ro.Next(1, 200);
            int num2; num2 = ro.Next(1, 200);
            if (num1 > num2)
            {
                num[0] = num1; num[1] = num2;
            }
            else
            {
                num[0] = num2; num[1] = num1;
            }
            if (add.Exists(o => o[0] == num1)) continue;
            add.Add(num);
            Console.WriteLine("{0}+{1}=\n",add[i][0],add[i][1]);
        }
        Console.ReadLine();
    }
}