using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment23Day18
{
    internal class Program
    {
        public delegate void Spin(ref int EnergyLevel, ref int probality);
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to spin game");
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            int EnergyLevel = 1;
            int probality = 100;
            int noOfSpin = 5;

            Spin spinDelegate = spin;

            for (int i = 0; i <noOfSpin; i++)
            {
                spinDelegate.Invoke(ref EnergyLevel,ref probality);
                if(EnergyLevel>=4 && probality > 60)
                {
                    Console.WriteLine($"Conratulation Mr/Ms.: {name} You are winner");
                    
                }
                else if(EnergyLevel>=1 && EnergyLevel<4 && probality > 50)
                {
                    Console.WriteLine($"Mr/Ms: {name} You are runner up");
                   
                }
                else if(i==noOfSpin-1)
                {
                    Console.WriteLine("Better luck next time");
                }

            }

            
        }
         static void spin(ref int EnergyLevel,ref int probality)
        {
            switch (EnergyLevel)
            {
                case 1:
                    {
                        EnergyLevel += 1;
                        probality += 10;
                        break;
                    }
                case 2:
                    {
                        EnergyLevel += 2;
                        probality += 20;
                        break;
                    }
                case 3:
                    {
                        EnergyLevel -= 3;
                        probality -= 30;
                        break;
                    }
                case 4:
                    {
                        EnergyLevel += 4;
                        probality += 40;
                        break;
                    }
                case 5:
                    {
                        EnergyLevel += 5;
                        probality += 50;
                        break;
                    }
                case 6:
                    {
                        EnergyLevel -= 1;
                        probality -= 60;
                        break;
                    }
                case 7:
                    {
                        EnergyLevel += 1;
                        probality +=70;
                        break;
                    }
                case 8:
                    {
                        EnergyLevel -=2;
                        probality -= 20;
                        break;
                    }
                case 9:
                    {
                        EnergyLevel -= 3;
                        probality -= 30;
                        break;
                    }
                case 10:
                    {
                        EnergyLevel +=10;
                        probality += 100;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You lost");
                        break;
                    }
            }
            Console.ReadKey();

        }
    }
}
