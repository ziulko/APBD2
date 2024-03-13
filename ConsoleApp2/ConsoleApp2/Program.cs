// See https://aka.ms/new-console-template for more information

public class Program {
    public static void Main(string[] args) {
        int[] numbers = { 10, 20, 30, 40, 50 };
        double average = CalculateAverage(numbers);
        Console.WriteLine("Średnia: " + average);
    }

    public static double CalculateAverage(int[] numbers) {
        if (numbers == null || !numbers.Any()) {
            throw new ArgumentException("Tablica liczb nie może być pusta.");
        }

        return numbers.Average();
    }
}
