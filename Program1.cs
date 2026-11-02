using System;

Console.WriteLine("Write num: ");
int n = int.Parse(Console.ReadLine()!);
int sum = 1;
for (int i = 1; i <=n; i++)
{
    sum*=i;
}
if (n >= 200 || n<=0)
{
    Console.WriteLine("Write from 1-200");
}
if (n >= 5)
{
    Console.WriteLine(0);
}
else if (n < 5)
{
    Console.WriteLine(sum%10);
}
// Retrieve an integer n between 0 and 200. Display the last digit of the expression n! (n is strong). See also Task 16. 
// Examples:
// 3! = 6 The program should display 6.
// 4! = 24. The program should display 4.
// A very large non-negative integer is given, having from 1 to 1000 digits. Check if it is divisible by 3, by 5 or by 15. 
// Example:
// 1233452346234562346524572472475 divisible by 5
// 1233452346234562346524572472476 divisible by 3
// 11526612175561985128272129755241495 divisible by 15
// We have a drink vending machine that accepts change and spends change. Write a program that will spend change correctly for 
// the given deposit using as few coins as possible. Example:
// Krzesław threw 5 zlotys into the vending machine to buy craft and ecological chewing gum for 2.97 zlotys. 
// So he should get 2.03 zlotys of change. The smallest number of coins to use is 2 zlotys, 2gr, 1 gr. 
// Assume that the machine has an infinite amount of coins to spend.
// The same case, but the slot machine has a finite number of coins of each type: 
// 5zł, 2zł, 1zł, 50gr, 20gr, 10gr, 5gr, 2gr, 1gr. Let's assume that the machine has:
// 3 x 1zł
// 2 x 2gr
// 5 x 1gr
// In this case, the change must be spent as 2 x 1zł, 1 x 2gr and 1 x 1gr. 
// You need 4 coins for this, because the machine only currently has them. 
// If the balance of the machine does not allow you to spend change, you should display the message: "Cannot spend change. 
// I return the coin".