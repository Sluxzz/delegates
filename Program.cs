using System;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
namespace Delegates
{
    class Program
    {
        static int CountLat(string s)
        {
            int count=0;
            foreach(char c in s)
            {
                if("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".Contains(c)) count++;
            }
            return count;
        }

        static int CountRus(string s)
        {
            int count=0;
            foreach(char c in s)
            {
                if("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя".Contains(c)) count++;
            }
            return count;
        }

        static int CountDigits(string s)
        {
            int count=0;
            foreach(char n in s)
            {
                if("0123456789".Contains(n)) count++;
            }
            return count;
        }


        delegate bool Uslovie(char c);

        static int Count(string s, Uslovie u)
        {
            int count=0;
            foreach(char c in s)
            {
                if(u(c)) count++;
            }
            return count;
        }        

        static bool IsLat(char c)
        {
            return "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".Contains(c);
        }
        static bool IsRus(char c)
        {
            return "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя".Contains(c);
        }
        static bool IsDigit(char c)
        {
            return "0123456789".Contains(c);
        }


        static void Main()
        {
            System.Console.WriteLine(CountLat("Hello! Меня зовут андрей!"));
            System.Console.WriteLine(CountRus("Hello! Меня зовут андрей!"));
            System.Console.WriteLine(Count("Hello! Меня зовут андрей!",IsLat));
            System.Console.WriteLine(Count("Hello! Меня зовут андрей!",IsRus));
            System.Console.WriteLine(Count("28 лет", IsDigit));
        }
    }
}