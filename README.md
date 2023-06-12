# MMGuideQuestion3

For the method AreAnagram the time complexity is O(n log n). This is derived by the fact that the Array.Sort method is the
determining factor, the slowest operation. Source: microsoft "This method is an O(n log n) operation, where n is the Length of array." 
(https://learn.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-7.0#system-array-sort(system-array)).
The ToCharArray() is of time complexity O(n), dependent on the lenght of the strings. And Enumerable.SequenceEqual() is of time complexity O(n), dependent on the lenght of the arrays.
The space complexity is O(n), we have to use space for the arrays depending on the amount of characters in the strings.

For the second method AreAnagramNoSort the space time complexity is O(n). Both the linq method where we check if we have no elements in the dictionary that have a value greater
than 0 and the looping through the strings are of time complexity O(n). 
The space complexity is also O(n), the disctionary characterCount is dependent on the input string.
