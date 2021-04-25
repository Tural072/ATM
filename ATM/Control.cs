using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Control
    {
        public static void Run()
        {
            User user1 = new User()
            {
                Name = "Tural",
                Surname = "Tahirli",
                CreditCard = new Card()
                {
                    Pan = "4169741434549786",
                    Pin = "4169",
                    Cvc = "319",
                    ExpireDate = new DateTime(2022, 2, 2),
                    Balance = 2500
                }
            };
            User user2 = new User()
            {
                Name = "Cavid",
                Surname = "Mahsunov",
                CreditCard = new Card()
                {
                    Pan = "4169741444449786",
                    Pin = "4139",
                    Cvc = "318",
                    ExpireDate = new DateTime(2024, 12, 2),
                    Balance = 3500
                }
            };
            User user3 = new User()
            {
                Name = "Murad",
                Surname = "Sadixov",
                CreditCard = new Card()
                {
                    Pan = "4169741446449786",
                    Pin = "4119",
                    Cvc = "317",
                    ExpireDate = new DateTime(2025, 11, 11),
                    Balance = 3000
                }
            };
            User user4 = new User()
            {
                Name = "Elxan",
                Surname = "Atayev",
                CreditCard = new Card()
                {
                    Pan = "4169741446469786",
                    Pin = "4519",
                    Cvc = "316",
                    ExpireDate = new DateTime(2021, 1, 1),
                    Balance = 2000
                }
            };
            User user5 = new User()
            {
                Name = "Eli",
                Surname = "Ibadov",
                CreditCard = new Card()
                {
                    Pan = "4169741546469786",
                    Pin = "4218",
                    Cvc = "315",
                    ExpireDate = new DateTime(2026, 10, 21),
                    Balance = 4000
                }
            };
            User[] users = { user1, user2, user3, user4, user5 };
            CardValidation.Users = users;
            string pin = null;
            int choose = 0;
            Console.WriteLine("Enter pin : ");
            pin = Console.ReadLine();
            System.Text.StringBuilder text = new System.Text.StringBuilder("========EMELIYYATLARIN SIYAHISI========\n");
            void AddPin()
            {
                text.Append("Kartdan karta kocurme edildi! Date : ").Append(DateTime.Now).Append("\n");
                Console.WriteLine("Kocurme etmek istediyiniz kartin pinini daxil edin : ");
                string Pin = Console.ReadLine();
                if (CardValidation.SearchUser(Pin))
                {
                    Console.WriteLine("Gondermek istediyini mebleg : ");
                    decimal money = 0;
                    money = decimal.Parse(Console.ReadLine());
                    CardValidation.CardToCard(CardValidation.User1, money);
                    Menu();
                }
                else
                {
                    Console.Clear();
                    AddPin();
                }
            }
            void Menu()
            {
                Console.WriteLine("1)Balance");
                Console.WriteLine("2)Nagd pul");
                Console.WriteLine("3)Edilen emeliyyatlarin siyahisi");
                Console.WriteLine("4)Kartdan karta pul kocurme");
                Console.WriteLine("Enter choice : ");
                choose = int.Parse(Console.ReadLine());
                Console.Clear();
                if (choose == 1)
                {
                    Console.WriteLine($"Your balance : {CardValidation.User.CreditCard.Balance}");
                    text.Append("Balansa baxildi! Date : ").Append(DateTime.Now).Append("\n");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Menu();
                }
                else if (choose == 2)
                {
                    int chooseOther = 0;
                    Console.WriteLine("1)10 AZN");
                    Console.WriteLine("2)20 AZN");
                    Console.WriteLine("3)50 AZN");
                    Console.WriteLine("4)100 AZN");
                    Console.WriteLine("5)Other");
                    Console.WriteLine("Enter choice : ");
                    chooseOther = int.Parse(Console.ReadLine());
                    if (chooseOther == 1)
                    {
                        CardValidation.CaheckBalance(CardValidation.User, 10);
                        text.Append("10 AZN chixarildi! Date : ").Append(DateTime.Now).Append("\n");
                        Console.Clear();
                        Menu();
                    }
                    else if (chooseOther == 2)
                    {
                        CardValidation.CaheckBalance(CardValidation.User, 20);
                        text.Append("20 AZN chixarildi! Date : ").Append(DateTime.Now).Append("\n");
                        Console.Clear();
                        Menu();
                    }
                    else if (chooseOther == 3)
                    {
                        CardValidation.CaheckBalance(CardValidation.User, 50);
                        text.Append("50 AZN chixarildi! Date : ").Append(DateTime.Now).Append("\n");
                        Console.Clear();
                        Menu();
                    }
                    else if (chooseOther == 4)
                    {
                        CardValidation.CaheckBalance(CardValidation.User, 100);
                        text.Append("100 AZN chixarildi! Date : ").Append(DateTime.Now).Append("\n");
                        Console.Clear();
                        Menu();
                    }
                    else if (chooseOther == 5)
                    {
                        decimal other = 0;
                        other = decimal.Parse(Console.ReadLine());
                        CardValidation.CaheckBalance(CardValidation.User, other);
                        text.Append($"{other}AZN chixarildi! Date : ").Append(DateTime.Now).Append("\n");
                        Console.Clear();
                        Menu();
                    }
                }
                else if (choose == 3)
                {
                    text.Append("Emeliyyatlarin siyahisina baxildi! Date : ").Append(DateTime.Now).Append("\n");
                    Console.WriteLine(text);
                    Menu();
                }
                else if (choose == 4)
                {
                    AddPin();
                }
                else
                {
                    Console.WriteLine("Wrong choice");
                    text.Append("Yalnish secim edildi! Date : ").Append(DateTime.Now).Append("\n");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Menu();
                }
            }
            if (CardValidation.ChechkPin(pin) && CardValidation.ChechkUserPin(pin) && CardValidation.ChechkExpireDate(CardValidation.User.CreditCard))
            {
                Menu();
            }
        }
    }
}
