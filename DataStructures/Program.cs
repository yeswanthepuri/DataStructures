// See https://aka.ms/new-console-template for more information
using Searching;
using Sorting;

Console.WriteLine("Hello, World!");
#region Search
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
//int[] arraySorted = [10, 40, 45, 80, 100, 200, 420, 500, 520];
//BinarySearch binarySearch = new BinarySearch();
////Console.WriteLine(binarySearch.SearchIterative(arraySorted, 520)); 
//Console.WriteLine(binarySearch.SearchRecursive(arraySorted, 200,0, arraySorted.Length -1));
#endregion
#endregion


#region Search
#region Selection Sort
//int[] unsortSorted = [3,200,2,68,15,44,23,89,3];
//SelectionSort sorting = new SelectionSort();
//Print.WriteList(sorting.Sort(unsortSorted));
#endregion

#region Insertion Sort
int[] unsortSorted = [3, 200, 2, 68, 15, 44, 23, 89, 3];
InsertionSorting sorting = new InsertionSorting();
Print.WriteList(sorting.Sort(unsortSorted));
#endregion
#endregion