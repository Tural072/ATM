using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Card
    {
        public string Pan { get; set; }
        public string Pin { get; set; }
        public string Cvc { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Balance { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=========CARDINFO========");
            Console.WriteLine($"PAN : {Pan}");
            Console.WriteLine($"PIN : {Pin}");
            Console.WriteLine($"CVC : {Cvc}");
            Console.WriteLine($"Expire date : {ExpireDate.ToShortDateString()}");
            Console.WriteLine($"Balance : {Balance}");
        }
    }
}
