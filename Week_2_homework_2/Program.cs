using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_homework_2
{
    internal class Program
    {

        public class person
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public DateTime DogumTarihi { get; set; }

            public int yas
            {
                get
                {
                    return DateTime.Now.Year - DogumTarihi.Year;
                }
            }
        }
        static void Main(string[] args)
        {
            List<person> persons = new List<person>
            {
                new person { Ad = "Ahmet", Soyad = "Yılmaz", DogumTarihi = new DateTime(1990, 5, 12) },
                new person { Ad = "Mehmet", Soyad = "Kaya", DogumTarihi = new DateTime(1985, 3, 28) },
                new person { Ad = "Ayşe", Soyad = "Demir", DogumTarihi = new DateTime(2000, 11, 5) },
                new person { Ad = "Fatma", Soyad = "Çelik", DogumTarihi = new DateTime(1995, 9, 23) },
                new person { Ad = "Ali", Soyad = "Arslan", DogumTarihi = new DateTime(1992, 6, 18) },
                new person { Ad = "Emre", Soyad = "Kurt", DogumTarihi = new DateTime(1988, 4, 30) },
                new person { Ad = "Zeynep", Soyad = "Yavuz", DogumTarihi = new DateTime(1998, 7, 8) },
                new person { Ad = "Mustafa", Soyad = "Kara", DogumTarihi = new DateTime(1994, 12, 15) },
                new person { Ad = "Elif", Soyad = "Öztürk", DogumTarihi = new DateTime(1997, 1, 20) },
                new person { Ad = "Berk", Soyad = "Uysal", DogumTarihi = new DateTime(2001, 8, 2) }

            };
            var orderedPersons = persons.OrderBy(p => p.yas).ToList();
            Console.WriteLine("Sıralanmış kişiler:");
            foreach(person person in orderedPersons) Console.WriteLine($"{person.Ad} {person.Soyad}, Yaş: {person.yas}");
            Console.ReadLine();
        }
    }
}
