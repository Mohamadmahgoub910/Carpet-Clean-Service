class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        string value;

        do
        {
            ShowMenu();
            Console.Write("Enter your choice: ");
            value = Console.ReadLine().Trim().ToLower();

            string result = "";

            switch (value)
            {
                case "p":
                    result = PrintNumbers(numbers);
                    break;
                case "a":
                    Console.WriteLine("Add Numbers Only Cause if u entered text program will crash");
                    result = AddNumberToList(numbers);
                    break;
                case "m":
                    result = CalculateMean(numbers);
                    break;
                case "s":
                    result = GetSmallest(numbers);
                    break;
                case "l":
                    result = GetLargest(numbers);
                    break;
                case "f":
                    result = FindNumber(numbers);
                    break;
                case "c":
                    result = ClearNumbers(numbers);
                    break;
                case "q":
                    result = "Goodbye";
                    break;
                default:
                    result = "Unknown selection, please try again";
                    break;
            }

            Console.WriteLine(result);

        } while (value != "q");
    }

    static void ShowMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("P - Print numbers");
        Console.WriteLine("A - Add a number");
        Console.WriteLine("M - Display mean of the numbers");
        Console.WriteLine("S - Display the smallest number");
        Console.WriteLine("L - Display the largest number");
        Console.WriteLine("F - Find a number");
        Console.WriteLine("C - Clear the Whole list");
        Console.WriteLine("Q - Quit");
    }

    static bool IsListEmpty(List<int> numbers)
    {
        return numbers.Count == 0;
    }
    static string PrintNumbers(List<int> numbers)
    {
        if (IsListEmpty(numbers))
            return "[] - The list is empty";


        string result = "[ ";
        for (int i = 0; i < numbers.Count; i++)
            result += numbers[i] + " ";
        result += "]";
        return result;
    }

    static string AddNumberToList(List<int> numbers)
    {
        Console.Write("Enter number to add: ");
        int value = Convert.ToInt32(Console.ReadLine());

        // Check for duplicates manually
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == value)
            {
                return $"Number  {value} Is Already in the List.";
            }
        }
        numbers.Add(value);
        return $"{value} added";
    }

    static string CalculateMean(List<int> numbers)
    {
        if (IsListEmpty(numbers))
            return "Unable to calculate the mean - no data";


        int sum = 0;
        for (int i = 0; i < numbers.Count; i++)
            sum += numbers[i];

        double mean = (double)sum / numbers.Count;
        return $"Mean is {mean}";
    }

    static string GetSmallest(List<int> numbers)
    {
        if (IsListEmpty(numbers))
            return "Unable to determine the smallest number - list is empty";


        int smallest = numbers[0];
        for (int i = 1; i < numbers.Count; i++)
            if (numbers[i] < smallest)
                smallest = numbers[i];

        return $"The smallest number is {smallest}";
    }

    static string GetLargest(List<int> numbers)
    {
        if (IsListEmpty(numbers))
            return "Unable to determine the largest number - list is empty";


        int largest = numbers[0];
        for (int i = 1; i < numbers.Count; i++)
            if (numbers[i] > largest)
                largest = numbers[i];

        return $"The largest number is {largest}";
    }

    static string FindNumber(List<int> numbers)
    {
        if (IsListEmpty(numbers))
            return "Unable to search - the list is empty";


        Console.Write("Enter the number to search: ");
        int findVal = Convert.ToInt32(Console.ReadLine());
        int foundIndex = -1;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == findVal)
            {
                foundIndex = i;
                break;
            }
        }

        if (foundIndex != -1)
            return $"Needed number in index {foundIndex} ";
        else
            return $"Needed number not in the list !!";
    }

    static string ClearNumbers(List<int> numbers)
    {
        numbers.Clear();
        return "List clear successed";
    }
}
