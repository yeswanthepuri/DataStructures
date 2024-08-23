// See https://aka.ms/new-console-template for more information
using Searching;

Console.WriteLine("Hello, World!");

LinearSearch<string> linearSearch = new LinearSearch<string>();
string[] array = ["Delhi", "Hyderabad", "Vizag"];
int result = linearSearch.Search(array, "Vizag");
if (result > 0)
{
    Console.WriteLine(array[result]);
}
