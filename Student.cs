
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace Kursklasser
{
    internal class Student
    {
        public string Navn { get; }
        public int Alder { get; }
        public string Kurs { get; }

        public Student(string navn, int alder, string kurs)
        {
            Navn = navn;
            Alder = alder;
            Kurs = kurs;
        }
    }
}
