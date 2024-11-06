using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_homework
{
    internal class Program
    {
        class student
        {
            private int studentNo { get; set; }
            private string studentName { get; set; }
            private string studentSurName { get; set; }
            private int midterm1 { get; set; }
            private int midterm2 { get; set; }
            private int final { get; set; }
            private string schoolName { get; set; }

            public student (int studentNo, string studentName, string studentSurName, int midterm1, int midterm2, int final, string schoolName)
            {
                this.studentNo = studentNo;
                this.studentName = studentName;
                this.studentSurName = studentSurName;
                this.midterm1 = midterm1;
                this.midterm2 = midterm2;
                this.final = final;
                this.schoolName = schoolName;
            }

            public string showStudentInformations()
            {
                return studentName + " " + studentSurName + " Score: " +  calculateStudentPoint();
            }

            public double calculateStudentPoint()
            {
                return (midterm1 * 0.2 + midterm2 * 0.2 + final * 0.6);
            }

            public string showSchool()
            {
                return schoolName;
            }
        }
        static void Main(string[] args)
        {
            student ogrenci = new student(1, "Enes", "Çelebi", 57, 85, 92, "Karabük University");

            while (true)
            {
                Console.WriteLine("\nBir seçim yapınız:\n" +
                                  "1-Öğrenci bilgilerini göster\n" +
                                  "2-Öğrenci ortalamasını göster\n" +
                                  "3-Öğrencinin okulunu göster\n" +
                                  "4-Çıkış yap\n");

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                char selection = keyInfo.KeyChar;
                switch (selection)
                {
                    case '1':
                        Console.WriteLine(ogrenci.showStudentInformations());
                        break;
                    case '2':
                        Console.WriteLine("Ortalama: " + ogrenci.calculateStudentPoint());
                        break;
                    case '3':
                        Console.WriteLine("Okul: " + ogrenci.showSchool());
                        break;
                    case '4':
                        return;
                    
                }
            }
            Console.ReadLine();
        }
    }
}
