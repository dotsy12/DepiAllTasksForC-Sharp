using System;

namespace DepiAllTasksForC_Sharp
{
    public class Person
    {
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem 1: Add Comments
            

            //int x = 10; 
            /*
            int y = 20; 
            int sum = x + y; 
            Console.WriteLine(sum); 
            */
            // Question: What is the shortcut to comment and uncomment a selected block of code in Visual Studio?
            // Answer: Use **Ctrl + K + C** to comment and **Ctrl + K + U** to uncomment.
            #endregion

            #region Problem 2: Fix Code Errors
            int a = 10; // Fixed: changed from string to int
            int b = 5;
            Console.WriteLine(a + b); // Fixed: Console with capital 'C'

            // Question: Explain the difference between a runtime error and a logical error with examples.
            // Answer: A runtime error causes the program to crash (e.g., divide by zero), while a logical error produces incorrect results (e.g., wrong formula).
            // Example: Runtime – `int x = 5 / 0;`, Logical – `area = width + height;`
            #endregion

            #region Problem 3: Declare Variables with Proper Naming
            string FullName = "John Doe";
            int Age = 25;
            decimal MonthlySalary = 4500.75m;
            bool IsStudent = true;

            // Question: Why is it important to follow naming conventions such as PascalCase in C#?
            // Answer: Naming conventions improve code readability and maintainability. PascalCase helps distinguish identifiers like class or property names.
            #endregion

            #region Problem 4: Reference Type Behavior
            Person person1 = new Person();
            person1.Name = "Ali";

            Person person2 = person1;
            person2.Name = "Sara";

            Console.WriteLine(person1.Name); // Output: Sara

            // Question: Explain the difference between value types and reference types in terms of memory allocation.
            // Answer: Value types are stored directly in the stack and hold data, while reference types store a reference in the stack and data in the heap.
            #endregion

            #region Problem 5: Arithmetic Operations
            int x1 = 15;
            int y1 = 4;
            Console.WriteLine("Sum: " + (x1 + y1));
            Console.WriteLine("Difference: " + (x1 - y1));
            Console.WriteLine("Product: " + (x1 * y1));
            Console.WriteLine("Division: " + ((double)x1 / y1));
            Console.WriteLine("Remainder: " + (x1 % y1));

            // Question: What will be the output of the following code? Explain why:
            // int a = 2, b = 7; Console.WriteLine(a % b);
            // Answer: The output is 2 because 2 divided by 7 leaves a remainder of 2.
            #endregion

            #region Problem 6: Check Number >10 and Even
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 10 && num % 2 == 0)
                Console.WriteLine("Number is greater than 10 and even.");
            else
                Console.WriteLine("Number does not meet both conditions.");

            // Question: How does the && (logical AND) operator differ from the & (bitwise AND) operator?
            // Answer: `&&` evaluates the second condition only if the first is true, while `&` always evaluates both.
            #endregion

            #region Problem 7: Casting Double to Int
            Console.Write("Enter a decimal number: ");
            double d = double.Parse(Console.ReadLine());

            int explicitCast = (int)d; // Explicit
            double implicitCast = 50; // Implicit from int to double

            Console.WriteLine("Explicit (double to int): " + explicitCast);
            Console.WriteLine("Implicit (int to double): " + implicitCast);

            // Question: Why is explicit casting required when converting a double to an int?
            // Answer: Because precision may be lost (fractional part is removed), and the compiler forces you to confirm that intentionally.
            #endregion

            #region Problem 8: Parse age and validate
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            try
            {
                int age = int.Parse(input);

                if (age > 0)
                {
                    Console.WriteLine("Your age is valid: " + age);
                }
                else
                {
                    Console.WriteLine("Age must be greater than 0.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input: Please enter a valid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid input: Number too large.");
            }
            #endregion


            #region Q1: What exception might occur and how can you handle it?
            // Answer:
            // FormatException if the input is not a number, and OverflowException if the number is too big.
            // You can handle it using try-catch blocks, as shown above.
            #endregion


            #region Problem 9: Prefix vs Postfix increment
            int x = 5;
            int y = ++x + x++; // y = 6 + 6 = 12, then x becomes 7

            Console.WriteLine($"Final x: {x}"); // 7
            Console.WriteLine($"Value of y: {y}"); // 12
            #endregion



            #region Q2: What is the value of x after execution and why?
            // Answer:
            // x = 7 because ++x makes it 6, and then x++ uses 6 and increments x to 7 after.
            #endregion


            //////////////Part 2 in task //////////////
            #region 2- Compiled vs Interpreted Languages

            // Compiled languages are translated into machine code before execution.
            // Interpreted languages are executed line-by-line during runtime.
            // C# is a compiled language; it's compiled to IL (Intermediate Language) then JIT-compiled to machine code.

            #endregion

            #region 3- Implicit vs Explicit vs Convert vs Parse

            // Implicit: automatic casting, no data loss (e.g., int to double).
            // Explicit: manual casting, possible data loss (e.g., double to int).
            // Convert: handles nulls and exceptions better (e.g., Convert.ToInt32("123")).
            // Parse: faster, but throws if input is invalid (e.g., int.Parse("123")).

            #endregion

            #region 5- What is Meant by Managed Code in C#

            // Managed code is code executed by the CLR, which handles memory management, security, and exceptions.
            // C# code runs in the .NET runtime environment, so it's considered managed.

            #endregion

            #region 6- Struct is Considered like Class Before

            // Structs are value types that behave like classes in having fields, methods, and constructors.
            // Unlike classes (reference types), structs are stored on the stack and do not support inheritance.

            #endregion
            //////////////Self study///////////////////

            #region 7- How to Customize the Garbage Collector

            // You can’t fully control the GC, but you can suggest collection using:
            // GC.Collect(), GC.SuppressFinalize(object), and use IDisposable pattern for clean-up.
            // Use `using` for automatic disposal of unmanaged resources.

            #endregion

            #region 8- Bitwise Operators

            // Bitwise operators work on binary bits: & (AND), | (OR), ^ (XOR), ~ (NOT), << (Left Shift), >> (Right Shift).
            //int a = 5;    // 0101
            //int b = 3;    // 0011
            //int result = a & b; // 0001 => 1

            #endregion

        }
    }
}
