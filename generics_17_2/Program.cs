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
            Account<int> account1 = new Account<int>(12, 125000, "Сергей") ;
            Console.WriteLine(account1.AccOwner);

            Console.ReadKey();
        }
    }
    class Account<T>
    {
        private T accNumPole;
        private double accBalancePole;
        private string accOwnerPole;

        public T AccNum
        {
            set
            { accNumPole = value; }
            get
            { return accNumPole; }
        }
        public double AccBalance
        {
            set { accBalancePole = value; }
            get { return accBalancePole; }  
        }
        public string AccOwner
        {
            set { accOwnerPole = value; }  
            get { return accOwnerPole; }
        }
        public Account(T accNum, double accBalance, string accOwner)
        {
            AccNum = accNum;
            AccBalance = accBalance;
            AccOwner = accOwner;
            AccNum = accNum;
            AccBalance = accBalance;
            AccOwner = accOwner;
        }
        public void SetAccount()
        {
            Console.Write("Введите номер счета: ");
            
        }
    }
}
