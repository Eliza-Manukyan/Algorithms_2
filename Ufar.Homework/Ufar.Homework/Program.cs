using Ufar.Homework;

Console.WriteLine("Hello, World!");

EasyStack<int> easyStack = new EasyStack<int>();
easyStack.Push(1);
easyStack.Push(2);
easyStack.Push(3);
easyStack.Push(4);


easyStack.Pop();

ArrayStack<string> arrayStack = new ArrayStack<string>();

arrayStack.Push("Hello");
arrayStack.Push("World");
arrayStack.Push("!");
arrayStack.Push("!");
arrayStack.Push("!");

arrayStack.Pop();
arrayStack.Pop();
arrayStack.Pop(); 

Console.WriteLine(arrayStack.Peek()); 

int[] array = { 64, 34, 25, 12, 22, 11, 90 };
SortingAlgorithms.BubbleSortRecursive(array);

foreach (var item in array)
{
    Console.WriteLine(item);
}
CustomQueue<string> stringQueue = new CustomQueue<string>();

Console.WriteLine("Enqueueing names to the string queue:");

stringQueue.Enqueue("Alice");
stringQueue.Enqueue("Bob");
stringQueue.Enqueue("Charlie");
stringQueue.Enqueue("Diana");


Console.WriteLine($"Peek: {stringQueue.Peek()}");  

Console.WriteLine($"Dequeue: {stringQueue.Dequeue()}");  

Console.WriteLine($"Peek after dequeue: {stringQueue.Peek()}");  

stringQueue.Enqueue("Eve");

Console.WriteLine("\nDequeuing all elements:");
while (!stringQueue.IsEmpty)
{
    Console.WriteLine($"Dequeue: {stringQueue.Dequeue()}");
}

Console.WriteLine($"\nQueue count: {stringQueue.Count}");


// Example array
int[] array_sel = { 29, 10, 14, 37, 14 };

// Print the original array
Console.WriteLine("Original Array: " + string.Join(", ", array_sel));

// Call the RecursiveSelectionSort method from the SelectionSorter class
SortingAlgorithms.RecursiveSelectionSort(array_sel, 0);

// Print the sorted array
Console.WriteLine("Sorted Array: " + string.Join(", ", array_sel));
    