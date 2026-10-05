namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { };
            char choise;
            do
            {
                Console.WriteLine("P- print numbers ");
                Console.WriteLine("A- add a number");
                Console.WriteLine("C- clear the list");
                Console.WriteLine("M- display mean of numbers");
                Console.WriteLine("S- display the smallest numbers");
                Console.WriteLine("L- display the largest numbers");
                Console.WriteLine("F- find a number");
                Console.WriteLine("Q- quit");
                Console.WriteLine( "O- display the odd numbers");
                choise = Console.ReadKey().KeyChar;
                choise = char.ToUpper(choise);


                switch (choise)
                {
                    case 'P':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                        }
                        else
                        {
                            Console.Write("[");
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                Console.Write(numbers[i] + " ")                                 ;
                            }
                            Console.WriteLine("]");
                        }    

                        break;
                    case 'A':
                        int newNumber;
                        bool found2 = false;

                        Console.WriteLine("Enter a number to add:");

                        newNumber = Convert.ToInt32(Console.ReadLine());

                        numbers.Add(newNumber);
                       for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == newNumber)
                            {
                               
                                found2 = true;
                            }
                        }
                        if (!found2)
                        {
                            Console.WriteLine($" {newNumber} Added");
                        }
                        else
                        {
                            Console.WriteLine($" {newNumber} is already in the list");
                        }
                        break;
                    case 'C':
                        numbers.Clear();
                        Console.WriteLine("List cleared");

                        break;
                    case 'M':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to calculate the mean - no data");
                        }
                        else
                        {
                            int sum = 0;

                            for (int i = 0; i < numbers.Count; i++)
                            {
                                sum += numbers[i];
                            }
                                double mean = sum / numbers.Count;
                                Console.WriteLine($"The average is: {mean}");
                        }
                        break;
                    case 'S':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to calculate the smallest - no data");

                        }
                        int smallest = numbers[0];
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < smallest)
                            {
                                smallest = numbers[i];
                            }
                        }
                        Console.WriteLine($"The smallest number is: {smallest}");

                        break;

                    case 'L':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to calculate the largest - no data");
                        }
                        int largest = numbers[0];
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > largest)
                            {
                                largest = numbers[i];
                            }
                        }
                        Console.WriteLine($"The largest number is: {largest}");

                        break;
                    case 'O':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("The list is empty");
                        }
                        else
                        {
                            Console.Write("[");
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] % 2 != 0)
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                            Console.WriteLine("]");
                        }

                        break;
                    case 'F':
                        Console.WriteLine("enter a number to find:");
                        int findNumber = Convert.ToInt32(Console.ReadLine());
                        bool found = false;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == findNumber)
                            {
                                Console.WriteLine($"The number {findNumber} was found at index {i}");
                                found = true;
                            }
                        }
                        if (found== false )
                        {
                            Console.WriteLine($"The number {findNumber} was not found in the list");
                        }
                        break;
                    default:
                        Console.WriteLine("unknown selection please try again");
                        break;
                    case 'Q':
                        Console.WriteLine("Goodbye!");
                        break;


                }
                ;


                //ssss
            }while (choise != 'Q');
    } }
}
