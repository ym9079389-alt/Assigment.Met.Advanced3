using System.Reflection;

namespace Assigment.Met.Advanced3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
            //PrintColliction("Grades", grades);
            //Console.WriteLine($"Count: {grades.Count}");
            //Console.WriteLine($"First: {grades[0]}");
            //Console.WriteLine($"Last: {grades[grades.Count - 1]}");
            //grades.Sort();
            //PrintColliction("After Sorting:", grades);
            //Console.WriteLine($"Grades greater than 90: {grades.Find(g => g > 90)}");
            //Console.WriteLine($"Grades less than 75: {string.Join(", ", grades.FindAll(g => g < 75))}");
            //grades.RemoveAll(g => g < 75);
            //PrintColliction("After Removing Grades less than 75:", grades);
            //Console.WriteLine($"100: {grades.Contains(100)}");
            //List<string> gradestring = grades.ConvertAll(g => $"Grade: {g}");
            //PrintColliction("Grade Labels:", gradestring);
            #endregion

            #region Task 2
            //Dictionary<int, string> Leaderboard = new Dictionary<int, string>
            //{
            //    { 500, "Ahmed" },
            //    { 200, "Sara" },
            //    { 800, "Ali" },
            //    { 350, "Mona" }
            //};

            //PrintColliction("Leaderboard", Leaderboard);

            //Console.WriteLine($"First Key: {Leaderboard.Keys.First()}");
            //Console.WriteLine($"Last Key: {Leaderboard.Keys.Last()}");
            //Console.WriteLine($"500 Key: {Leaderboard.ContainsKey(500)}");
            //Console.WriteLine($"999 Key: {Leaderboard.ContainsKey(999)}");
            //Leaderboard.Remove(200);
            //PrintColliction("After Removing:", Leaderboard);
            #endregion

            #region Task 3
            Dictionary<int, string> PhoneBook = new Dictionary<int, string>();
            PhoneBook[01075618170] = "Ahmed";
            PhoneBook[01011226169] = "Aliaa";
            PhoneBook[01113370769] = "Youssef";
            PhoneBook[01146818023] = "Mona";
            try
            {
                PhoneBook.Add(01075618170, "Ahmed");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine(PhoneBook.TryAdd(01075618170, "Ahmed"));
            Console.WriteLine(PhoneBook.ContainsValue("Aliaa"));
            bool res = PhoneBook.ContainsValue("Ali");
            Console.WriteLine(res == false ? "Not Found" : "Found");

            foreach(var key in PhoneBook.Keys)
            {
                Console.Write($"Key: {key}, ");
            }
            Console.WriteLine();
            foreach (var value in PhoneBook.Values)
            {
                Console.Write($"Value: {value}, ");
            }
            #endregion
        }
        static void PrintColliction<T>(string name, IEnumerable<T> collection)
        {
            Console.WriteLine(name);
            Console.WriteLine(string.Join(", ", collection));
            
        }
    }
}
