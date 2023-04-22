string name = "developer@example.com";
char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
// int count = 0;

// for (int i = 0; i < name.Length; i++)
// {
//   char currChar = name[i];
//   if(vowels.Contains(currChar))
//   {
//     count++;
//   }
// }

// using Linq

Console.WriteLine(name.Count(ch => vowels.Contains(ch)));

// Console.WriteLine(count);