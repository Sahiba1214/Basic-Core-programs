﻿ using System;

namespace BasicCoreProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Program number which is to be executed \n 1. Flip Coin \n 2. Leap year \n 3. Power Of Two \n 4. Harmonic Number \n 5. Factors \n 6. Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            while (flag)
            {
                switch (option)
                {
                    case 1:
                        FlipCoin coin = new FlipCoin();
                        coin.Play();
                        break;
                    case 2:
                        LeapYear check = new LeapYear();
                        check.Leap();
                        break;
                    case 3:
                        PowerOfTwo res = new PowerOfTwo();
                        res.square();
                        break;
                    case 4:
                        HarmonicNumber Sum = new HarmonicNumber();
                        Sum.Harmonic();
                        break;
                        case 5:
                          new Factorial().Factorization();
                        break;
                    case 6:
                    flag = false;
                     break; 
                 }
            }
        }
    }
}
