using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_17_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер счета: ");
            int accNumInt=0;
            try
            {
                accNumInt = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            { 
            Console.Write("{0},Введите целочисленное значение: ", ex.Message);
                accNumInt = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();        
            }
            catch (OverflowException ex)
            {
                Console.Write("{0},Введите номер счета: ", ex.Message);
                accNumInt = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();
            }
            Console.Write("Введите баланс счета: ");
            double accBalance=0;
            try
            {
                accBalance = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.Write("{0} , введите баланс счета: ", ex.Message);
                accBalance = Convert.ToDouble(Console.ReadLine());

            }
            Console.Write("Введите ФИО владельца счета: ");
            string accOwner = Console.ReadLine();
            Account<int> account1 = new Account<int>(accNumInt, accBalance, accOwner) ;


            Console.Write("Введите номер счета: "); 
            string accNumString = Console.ReadLine();
            Console.Write("Введите баланс счета: ");
            try
            {
                accBalance = Convert.ToDouble(Console.ReadLine()); 
            }
            catch (FormatException ex) 
            {
                Console.Write("{0} , введите баланс счета: ", ex.Message);
                accBalance = Convert.ToDouble(Console.ReadLine());

            }
            Console.Write("Введите ФИО владельца счета: ");
            accOwner = Console.ReadLine();
            Account<string> account2 = new Account<string>(accNumString, accBalance, accOwner);

            Account<int> account3 = new Account<int>(14334455, 244, "Иванов Иван Иванович");
            Account<string> account4 = new Account<string>("4666665544457778883332аа", 345.5, "Сергеев Сергей Сергеевич");
            account1.AccInfo();
            account2.AccInfo();
            account3.AccInfo();
            account4.AccInfo();
            Console.ReadKey();
        }
    }
    class Account<T>
    {
        T AccNum { get; set; }
        double AccBalance { get; set; }
        string AccOwner { get; set; }

       
        public Account(T accNum, double accBalance, string accOwner)
        {
            AccNum = accNum;
            AccBalance = accBalance;
            AccOwner = accOwner;
        }
        public void AccInfo()
        {
            Console.WriteLine(AccNum);
            Console.WriteLine(AccBalance);
            Console.WriteLine(AccOwner);
        }
    }
}
