using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace C_PRAC
{
 internal class StringDemo
 {
 static void Main()
 {
 Console.WriteLine("Enter the string: ");
 string s1 = Console.ReadLine();
 // 1. Length of the string
 Console.WriteLine("1. Length of the string: " + s1.Length);
 // 2. Convert to uppercase
 Console.WriteLine("2. Uppercase string: " + s1.ToUpper());
 // 3. Convert to lowercase
 Console.WriteLine("3. Lowercase string: " + s1.ToLower());
 // 4. Contains check for the word "test"
 bool containsTest = s1.Contains("test");
 Console.WriteLine("4. Contains 'test': " + containsTest);
 // 5. Starts with "t"
 Console.WriteLine("5. Starts with 't': " + s1.StartsWith("t"));
 // 6. Ends with "t"
 Console.WriteLine("6. Ends with 't': " + s1.EndsWith("t"));
 // 7. Replace all occurrences of 't' with 'r'
 Console.WriteLine("7. Replace 't' with 'r': " + s1.Replace('t', 'r'));
4
 // 8. Split the string by space and display each part
 string[] splitString = s1.Split(' '); // Split based on spaces
 Console.WriteLine("8. Split string:");
 foreach (string part in splitString)
 {
 Console.WriteLine(part);
 }
 // 9. Equals method
 Console.WriteLine("9. Equals 'test': " + s1.Equals("test"));
 // 10. IndexOf first occurrence of 't'
 Console.WriteLine("10. Index of 't': " + s1.IndexOf('t'));
 // 11. LastIndexOf method to find the last occurrence of 't'
 Console.WriteLine("11. Last index of 't': " + s1.LastIndexOf('t'));
 // 12. Concatenate with another string
 Console.WriteLine("Enter another string: ");
 string s2 = Console.ReadLine();
 Console.WriteLine("12. Concatenated string: " + string.Concat(s1, s2));
 // 13. Substring: extracting from the 6th position (index starts at 0)
 if (s1.Length >= 9)
 {
 string substring = s1.Substring(6, 3); // Extract a substring from index 6
 Console.WriteLine("13. Substring (from index 6, length 3): " + substring);
 }
 }
 }
}
