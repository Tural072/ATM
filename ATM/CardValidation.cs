using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class CardValidation
    {
        static public User[] Users;
        static public User User;
        static public User User1;
        static public DateTime current = DateTime.Now;
        public static bool ChechkPan(string pan)
        {
            if (pan.Length == 16)
            {
                return true;
            }
            throw new System.Exception("Pan character count must be equal 16");
        }

        public static bool ChechkPin(string pin)
        {
            if (pin.Length == 4)
            {
                return true;
            }
            throw new System.Exception("Pan character count must be equal 4");
        }
        public static bool ChechkExpireDate(Card bankCard)
        {
            if (bankCard.ExpireDate >= DateTime.Now)
            {
                return true;
            }
            throw new System.Exception("Pan character count must be equal 4");
        }
        public static bool ChechkUserPin(string pin) {
            foreach (var item in Users)
            {
                if (pin==item.CreditCard.Pin)
                {
                    User = item;
                    Console.WriteLine($"{item.Name} {item.Surname} xos gelmisiniz zehmet olmasa asagidakilardan birini secerdiniz");
                    Console.Clear();
                    return true;
                }
            }
            Console.WriteLine("Pine uygun istifadeci tapilmadi");
            Menu();
            return false;
        }
        private static void Menu()
        {
            throw new NotImplementedException();
        }
        public static void CaheckBalance(User user,decimal balance) {
            if (user.CreditCard.Balance>balance)
            {
                user.CreditCard.Balance = user.CreditCard.Balance - balance;
            }
            else
            {
                throw new System.ApplicationException("Balansda yeterli mebleg yoxdur");
            }
        }
        public static bool SearchUser(string pin) {
            foreach (var item in Users)
            {
                if (pin==item.CreditCard.Pin)
                {
                    User1 = item;
                    return true;
                }
            }
            return false;
        }
        public static void CardToCard(User user,decimal money) {
            if (User.CreditCard.Balance >= money)
            {
                User.CreditCard.Balance -= money;
                User1.CreditCard.Balance += money;
            }
            else
            {
                throw new System.ApplicationException("Yetersiz mebleg");
            }
        }
    }
}
