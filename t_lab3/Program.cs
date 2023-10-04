namespace t_lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the numeral system:");
            Console.WriteLine("1 - Binary");
            Console.WriteLine("2 - Octal");
            Console.WriteLine("3 - Hexadecimal");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter the first number: ");
            string num1 = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string num2 = Console.ReadLine();

            switch (choice)
            {
                case 1:
                    PerformBinaryOperations(num1, num2);
                    break;
                case 2:
                    PerformOctalOperations(num1, num2);
                    break;
                case 3:
                    PerformHexadecimalOperations(num1, num2);
                    break;
                default:
                    Console.WriteLine("Incorrect numeral system choice");
                    break;
            }

            Console.ReadLine();
        }

        static void PerformBinaryOperations(string binaryNum1, string binaryNum2)
        {
            int num1 = Convert.ToInt32(binaryNum1, 2);
            int num2 = Convert.ToInt32(binaryNum2, 2);

            Console.WriteLine($"Addition: {binaryNum1} + {binaryNum2} = {Convert.ToString(num1 + num2, 2)}");
            Console.WriteLine($"Subtraction: {binaryNum1} - {binaryNum2} = {Convert.ToString(num1 - num2, 2)}");
            Console.WriteLine($"Multiplication: {binaryNum1} * {binaryNum2} = {Convert.ToString(num1 * num2, 2)}");

            if (num2 != 0)
            {
                Console.WriteLine($"Division: {binaryNum1} / {binaryNum2} = {Convert.ToString(num1 / num2, 2)}");
            }
            else
            {
                Console.WriteLine("Division by zero is impossible");
            }
        }

        static void PerformOctalOperations(string octalNum1, string octalNum2)
        {
            int num1 = Convert.ToInt32(octalNum1, 8);
            int num2 = Convert.ToInt32(octalNum2, 8);

            Console.WriteLine($"Addition: {octalNum1} + {octalNum2} = {Convert.ToString(num1 + num2, 8)}");
            Console.WriteLine($"Subtraction: {octalNum1} - {octalNum2} = {Convert.ToString(num1 - num2, 8)}");
            Console.WriteLine($"Multiplication: {octalNum1} * {octalNum2} = {Convert.ToString(num1 * num2, 8)}");

            if (num2 != 0)
            {
                Console.WriteLine($"Division: {octalNum1} / {octalNum2} = {Convert.ToString(num1 / num2, 8)}");
            }
            else
            {
                Console.WriteLine("Division by zero is impossible");
            }
        }

        static void PerformHexadecimalOperations(string hexNum1, string hexNum2)
        {
            int num1 = Convert.ToInt32(hexNum1, 16);
            int num2 = Convert.ToInt32(hexNum2, 16);

            Console.WriteLine($"Addition: {hexNum1} + {hexNum2} = {Convert.ToString(num1 + num2, 16)}");
            Console.WriteLine($"Subtraction: {hexNum1} - {hexNum2} = {Convert.ToString(num1 - num2, 16)}");
            Console.WriteLine($"Multiplication: {hexNum1} * {hexNum2} = {Convert.ToString(num1 * num2, 16)}");

            if (num2 != 0)
            {
                Console.WriteLine($"Division: {hexNum1} / {hexNum2} = {Convert.ToString(num1 / num2, 16)}");
            }
            else
            {
                Console.WriteLine("Division by zero is impossible");
            }
        }
    }
}