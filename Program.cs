// Write a C# program to print the result of dividing two numbers. Print the quotient and remainder as well. Get the input from the user. //

Console.WriteLine("Please input value number 1:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input value number 2:");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = num1 / num2;

Console.WriteLine("The quotient is " + result);
Console.WriteLine("The remainder is " + num1 % num2);
