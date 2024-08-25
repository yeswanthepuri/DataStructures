// See https://aka.ms/new-console-template for more information
using Searching;

Console.WriteLine("Hello, World!");
#region LinearSearch
//LinearSearch<string> linearSearch = new LinearSearch<string>();
//string[] array = ["Delhi", "Hyderabad", "Vizag"];
//int result = linearSearch.Search(array, "Vizag");
//if (result > 0)
//{
//    Console.WriteLine(array[result]);
//}
#endregion

#region Binary Search
int[] arraySorted = [10, 40, 45, 80, 100, 200, 420, 500, 520];
BinarySearch binarySearch = new BinarySearch();
//Console.WriteLine(binarySearch.SearchIterative(arraySorted, 520)); 
Console.WriteLine(binarySearch.SearchRecursive(arraySorted, 200,0, arraySorted.Length -1)); 
#endregion
