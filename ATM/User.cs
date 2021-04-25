using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Card CreditCard { get; set; }
        public void Show() {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("=========USERINFO========");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Surename : {Surname}");
            CreditCard.Show();
        }
    }
}
