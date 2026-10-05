namespace Assigment.Met.Advanced3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
            PrintColliction("Grades", grades);
            Console.WriteLine($"Count: {grades.Count}");
            Console.WriteLine($"First: {grades[0]}");
            Console.WriteLine($"Last: {grades[grades.Count - 1]}");
            grades.Sort();
            PrintColliction("After Sorting:", grades);
            Console.WriteLine($"Grades greater than 90: {grades.Find(g => g > 90)}");
            Console.WriteLine($"Grades less than 75: {string.Join(", ", grades.FindAll(g => g < 75))}");
            grades.RemoveAll(g => g < 75);
            PrintColliction("After Removing Grades less than 75:", grades);
            Console.WriteLine($"100: {grades.Contains(100)}");
            List<string> gradestring = grades.ConvertAll(g => $"Grade: {g}");
            PrintColliction("Grade Labels:", gradestring);
            #endregion
        }
        static void PrintColliction<T>(string name, IEnumerable<T> collection)
        {
            Console.WriteLine(name);
            Console.WriteLine(string.Join(", ", collection));
            
        }
    }
}
