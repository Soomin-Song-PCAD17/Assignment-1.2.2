/* 
    Write a C# Sharp program to find the sum of first 10 natural numbers.
    Expected Output :
    The first 10 natural number is :
    1 2 3 4 5 6 7 8 9 10
    The Sum is : 55
*/

int count = 10;
//Console.Write("How many numbers? ");
//count = Convert.ToInt32(Console.ReadLine());
int runningSum = 0;
Console.WriteLine($"The first {count} natural number is :");
for ( int i = 1; i <= count; i++ )
{
    Console.Write($"{i} ");
    runningSum += i;
}
Console.WriteLine($"\nThe Sum is : {runningSum}");
