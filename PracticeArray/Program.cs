// See https://aka.ms/new-console-template for more information

using System.Globalization;




// Define an array to hold 10 integer values
int[] numbers = new int[10];

for (int i = 0; i < numbers.Length; i++)
{
    Random random = new Random();
    int randomNumber = random.Next(1, 50);
    numbers[i] = randomNumber;


}

// Fill the array with values using a for loop and display them using a foreach loop
Console.WriteLine("Dizinin Elemanlari:");
foreach (int number in numbers)
{

    Console.WriteLine(number);
}

// Add a new value to the array user input
Console.Write("Lutfen bir sayi giriniz:");
int userInput = int.Parse(Console.ReadLine());
Array.Resize(ref numbers, numbers.Length + 1);
numbers[numbers.Length - 1] = userInput;

// Sort the array in descending order and display it
Array.Sort(numbers);
Array.Reverse(numbers);
Console.WriteLine("Dizi buyukten kucuge siralandi");

foreach (int number in numbers)
{
    Console.WriteLine(number);
}