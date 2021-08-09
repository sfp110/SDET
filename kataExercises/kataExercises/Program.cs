using System;

namespace kataExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(CurrencySplitter(29.37));
        }


        public static string CurrencySplitter(double totalAmout) 
        {

            double remaining = totalAmout;

            int numberOfFifties = (int)(totalAmout / 50);

            remaining -= numberOfFifties * 50;

            int numberOfTwenties = (int)(remaining / 20);

            remaining -= numberOfTwenties * 20;

            int numberOfTens = (int)(remaining / 10);

            remaining -= numberOfTens * 10;

            int numberOfFivers = (int)(remaining / 5);

            remaining -= numberOfFivers * 5;

            int numberOf2PoundCoins = (int)(remaining / 2);

            remaining -= numberOf2PoundCoins * 2;

            int numberOf1PoundCoins = (int)(remaining / 1);

            remaining -= numberOf1PoundCoins * 1;

            int numberOf50PiCoins = (int)(remaining / 0.5);

            remaining -= numberOf50PiCoins * 0.5;

            int numberOf20PiCoins = (int)(remaining / 0.2);

            remaining -= numberOf20PiCoins * 0.2;

            int numberOf10PiCoins = (int)(remaining / 0.1);

            remaining -= numberOf10PiCoins * 0.1;

            int numberOf05PiCoins = (int)(remaining / 0.05);

            remaining -= numberOf05PiCoins * 0.05;

            int numberOf02PiCoins = (int)(remaining / 0.02);

            remaining -= numberOf10PiCoins * 0.02;

            int numberOf01PiCoins = (int)(remaining / 0.01);

            remaining -= numberOf01PiCoins * 0.01;

            int a = 15;
            int b = -5;

            Console.WriteLine(a += b); // a is now 10
            Console.WriteLine(a = +b); // a is now -5

            Console.WriteLine("The total amount is : " + "£" + totalAmout);

            return $"£50: {numberOfFifties}\n£20: {numberOfTwenties}\n£10: {numberOfTens}\n £5: {numberOfFivers}\n £2: {numberOf2PoundCoins}\n £1: {numberOf1PoundCoins}\n50p: {numberOf50PiCoins}\n20p: {numberOf20PiCoins}\n10p: {numberOf10PiCoins}\n 5p: {numberOf05PiCoins}\n 2p: {numberOf02PiCoins}\n 1p: {numberOf01PiCoins}";
        }
    }
}
