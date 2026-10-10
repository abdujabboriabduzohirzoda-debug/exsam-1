// int n = Convert.ToInt32(Console.ReadLine());

// int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

// int k = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < n; i++)
// {
//     if (i != k)
//     {
//         Console.Write(a[i] + " ");
//     }
// }
// TASK 1


// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Even:" + EvenCount(n));
// Console.WriteLine("Odd:" + OddCount(n));
// Console.WriteLine("Digits:" + DigitCount(n));
// Console.WriteLine("Sum:" + SumDigit(n));

// int EvenCount(int n)
// {
//     int cnt = 0;
//     for (; n > 0; n /= 10)
//         if ((n % 10) % 2 == 0)
//             cnt++;
//     return cnt;
// }

// int OddCount(int n)
// {
//     int cnt = 0;
//     for (; n > 0; n /= 10)
//         if ((n % 10) % 2 != 0)
//             cnt++;
//     return cnt;
// }

// int DigitCount(int n)
// {
//     int cnt = 0;
//     for (; n > 0; n /= 10)
//         cnt++;
//     return cnt;
// }

// int SumDigit(int n)
// {
//     int sum = 0;
//     for (; n > 0; n /= 10)
//         sum += n % 10;
//     return sum;
// }
// TASK 2


// string IsPalindrome(int n)
// {
//     int a = n / 1000;
//     int b = n / 100 % 10;
//     int c = n / 10 % 10;
//     int d = n % 10;

//     if (a == d && b == c)
//         return "YES";

//     return "NO";
// }

// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(IsPalindrome(n));
// TASK 3


// int SumOfDigits(int n)
// {
//     int sum = 0;

//     for (; n > 0; n /= 10)
//         sum += n % 10;

//     return sum;
// }

// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("The sum of the digits of the number " + n + " is : " + SumOfDigits(n));
// TASK 4


// void IncrementArrayElements(ref int[] arr, ref int n)
// {
//     for (int i = 0; i < arr.Length; i++)
//         arr[i] += n;
// }

// int size = Convert.ToInt32(Console.ReadLine());
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int n = Convert.ToInt32(Console.ReadLine());

// IncrementArrayElements(ref arr, ref n);

// Console.WriteLine("[" + string.Join(", ", arr) + "]");
// TASK 5


// void Swap(ref int a, ref int b)
// {
//     int temp = a;
//     a = b;
//     b = temp;
// }

// int x = 5;
// int y = 10;

// Swap(ref x, ref y);

// Console.WriteLine("x = " + x);
// Console.WriteLine("y = " + y);
// TASK 6


// int SumDigit(int n)
// {
//     if (n == 0)
//         return 0;

//     return n % 10 + SumDigit(n / 10);
// }

// Console.WriteLine(SumDigit(111));
// Console.WriteLine(SumDigit(222));
// Console.WriteLine(SumDigit(333));
// TASK 7


// string repetition(string txt, int n)
// {
//     if (n == 0)
//         return "";

//     return txt + repetition(txt, n - 1);
// }

// Console.WriteLine(repetition("ab", 3));
// Console.WriteLine(repetition("kiwi", 1));
// Console.WriteLine(repetition("cherry", 2));
// TASK 8