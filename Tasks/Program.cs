

namespace Tasks
{
    public class Movie
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Author: {Author}, Year: {Year}, Category: {Category}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Завдання 1:");
            Task1();

            Console.WriteLine("\n--- Завдання 2:");
            Task2();

            Console.WriteLine("\n--- Завдання 3:");
            Task3();

            Console.WriteLine("\n--- Завдання 4:");
            Task4();

            Console.WriteLine("\n--- Завдання 5:");
            Task5();

            Console.WriteLine("\n--- Завдання 6:");
            Task6();
            Console.ReadLine();
        }

        static void Task1()
        {
            int[] ratings = { 95, 45, 62, 88, 55, 92, 75, 30, 99, 59, 100, 40 };

            Console.WriteLine("Рейтинги: " + string.Join(", ", ratings));

            int countLow = ratings.Count(r => r < 60);

            int countHigh = ratings.Count(r => r > 90);

            Console.WriteLine($"Кількість студентів з рейтингом < 60: {countLow}");
            Console.WriteLine($"Кількість студентів з рейтингом > 90: {countHigh}");
        }

        static void Task2()
        {
            string[] words = { "університет", "програмування", "інформатика", "алгоритм", "LINQ", "дані" };
            string foundWord = words.FirstOrDefault(w => w == "інформатика");
            if (foundWord != null)
            {
                Console.WriteLine($"Слово '{foundWord}' знайдено.");
            }
            else
            {
                Console.WriteLine("Слово не знайдено.");
            }
        }

        static void Task3()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie { Name = "Гаррі Поттер 1", Author = "Роулінг", Year = 2001, Category = "Фентезі" },
                new Movie { Name = "Володар перснів", Author = "Толкін", Year = 2003, Category = "Фентезі" },
                new Movie { Name = "Матриця", Author = "Вачовскі", Year = 1999, Category = "Фантастика" },
                new Movie { Name = "Хроніки Нарнії", Author = "Льюїс", Year = 2005, Category = "Фентезі" },
                new Movie { Name = "Аватар", Author = "Кемерон", Year = 2009, Category = "Фантастика" },
                new Movie { Name = "Гобіт", Author = "Толкін", Year = 2012, Category = "Фентезі" }, // Рік 2012 (не входить в 2000 < x < 2012)
                new Movie { Name = "Зоряний пил", Author = "Гейман", Year = 2007, Category = "Фентезі" },
                new Movie { Name = "Інтерстеллар", Author = "Нолан", Year = 2014, Category = "Фантастика" },
                new Movie { Name = "Гаррі Поттер 2", Author = "Роулінг", Year = 2002, Category = "Фентезі" },
                new Movie { Name = "Кінг-Конг", Author = "Джексон", Year = 1933, Category = "Пригоди" }
            };

            var filteredMovies = movies.Where(m => m.Category == "Фентезі" && m.Year > 2000 && m.Year < 2012).ToList();

            Console.WriteLine("Відфільтровані фільми (Фентезі, 2001-2011):");
            foreach (var movie in filteredMovies)
            {
                Console.WriteLine(movie);
            }

            var oldestMovie = movies.OrderBy(m => m.Year).FirstOrDefault();
            Console.WriteLine($"\nФільм з найменшим роком: {oldestMovie?.Name} ({oldestMovie?.Year})");
        }

        static void Task4()
        {
            List<string> sites = new List<string>
            {
                "google.com", "youtube.com", "microsoft.com", "facebook.com", "twitter.com",
                "instagram.com", "linkedin.com", "reddit.com", "wikipedia.org", "amazon.com"
            };

            string target = "facebook.com";
            string foundSite = sites.FirstOrDefault(s => s.Equals(target, StringComparison.OrdinalIgnoreCase));

            if (foundSite != null)
            {
                Console.WriteLine($"Сайт {foundSite} знайдено у списку.");
            }
            else
            {
                Console.WriteLine($"Сайт {target} відсутній у списку.");
            }
        }

        static void Task5()
        {
            int[] numbers = { 42, 32, 25, 18, 27, 58, 78 };
            Console.WriteLine("Числа: " + string.Join(", ", numbers));

            int sum = numbers.Sum();
            Console.WriteLine($"Сума: {sum}");

            int diff = numbers.Aggregate((acc, next) => acc - next);
            Console.WriteLine($"Різниця (послідовна): {diff}");
        }

        static void Task6()
        {
            int[] numbers = { 42, 32, 25, 18, 27, 58, 78 };

            var selectedNumbers = numbers.Skip(2).Take(3);

            Console.WriteLine("3 числа, починаючи з третього: " + string.Join(", ", selectedNumbers));
        }
    }
}