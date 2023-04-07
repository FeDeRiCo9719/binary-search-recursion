// See https://aka.ms/new-console-template for more information



int[] numbers = { 2, 7, 3, 5, 9, 13, 1, 8, 0, 10, 6, 4, 12, 11 };

// Sorting the Array 
sortNumbers(numbers);

// Binary Search 
binarySearch(numbers, 0, numbers.Length - 1, 5);


/*
 * Functions /-----------------------------------------------
*/
void sortNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int a = array[i];
                int b = array[j];

                array[i] = b;
                array[j] = a;
            }
        }
    }

    Console.WriteLine($"Hi there, this is the Sorted Array ->");
    foreach (int n in array)
    {
        Console.Write(n + " | ");
    }
    Console.WriteLine("\n---------------------------------");
}

bool binarySearch(int[] array, int left, int right, int target)
{
    // Set middle 
    int index = (left + right) / 2;
    int middle = array[index];

    Console.Write($"{array[left]}, {array[middle]}, {array[right]} | ");

    // Recursion
    if (target < middle && left != right)
    {
        return binarySearch(array, left, middle-1, target);
    }
    // Recursion
    else if (middle < target && left != right)
    {
        return binarySearch(array, middle+1, right, target);
    }
    else if (middle == target)
    {
        Console.WriteLine($"Here it is: {middle}");
        return true;
    }
    else 
    {
        Console.WriteLine($"Not found");
        return false;
    }
}