namespace Kursklasser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new Student[]
            {
                new Student("Heibert", 42, "Radiobilkjøring"),
                new Student("Bertil", 24, "Modællfly"),
                new Student("Kurt", 46, "Modællfly"),
                new Student("Sonja", 32, "Radiobilkjøring"),
                new Student("Line", 25, "Flyskytter"),
                new Student("Stine", 34, "Flyskytter"),
                new Student("Kåre", 41, "Radiobilkjøring"),
                new Student("Willy", 28, "Modællfly"),
                new Student("Lise", 33, "Radiobilkjøring")
            };
            var kurs = FetchKurs(students);
            Console.WriteLine(@"Hei, og velkommen til Svai I Ryggen AS
Skriv inn tallet ved siden av navnet på et av våre kurs for å se hvem som er med på kurset!
Våre kurs er for tiden:");
            for (int i = 0; i < kurs.Length; i++)
            {
                if (kurs[i] != null)
                {

                    Console.WriteLine($"{i + 1}. {kurs[i]}");
                }
            }

            var userRequest = Console.ReadLine();
            ShowStudents(userRequest, students, kurs);

        }

        private static void ShowStudents(string? userRequest, Student[] students, string[] kurs)
        {
            var kursnummer = Convert.ToInt32(userRequest) - 1;
            Console.WriteLine($"På kurset {kurs[kursnummer]} er for øyeblikket:");
            foreach (var student in students)
            {
                if (student.Kurs.Contains(kurs[kursnummer]))
                {
                    Console.WriteLine(student.Navn);
                }
            }
        }

        private static string[] FetchKurs(Student[] students)
        {
            var kurs = new string[students.Length];
            int index = 0;
            foreach (var student in students)
            {
                if (!kurs.Contains(student.Kurs))
                {
                    kurs[index] = student.Kurs;
                    index++;
                }
            }

            return kurs;
        }
    }
}