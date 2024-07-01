﻿using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Channels;

// This is implementation for the recursion tasks


namespace Program {
    class Recursion {

        // Q1
        // num with default value of 50
        public static void Print50NaturalNums(int num = 50) {
            // print till num is 0
            if (num == 0) return;

            // called the method with num - 1
            Print50NaturalNums(num - 1);

            // print the current value
            Console.WriteLine(num);
        }

        // Q2
        public static int SumTillN(int num) {
            if (num == 0) return 0;

            return num + SumTillN(num - 1);
        }

        // Q3
        // fibonacci is a series of numbers and there sum
        public static int Fibonacci(int num) {
            if (num <= 1) return num;

            //  
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }

        // Q4
        // start with default value of index = 0
        public static void PrintArray(int[] arr, int index = 0) {
            // call the method till index is out of range
            if (index > arr.Length) return;

            // print the value
            Console.WriteLine(arr[index]);

            // call the method
            PrintArray(arr, index + 1);
        }


        // Q5
        public static int CountNumOfDigits(int num, int counter = 0) {
            // keep calling until num equal 0
            if (num == 0) return counter;


            // recurive call to reduce num by one digit
            // increment counter by one with each call
            // 50 / 10 = 5
            // 5 / 10 = 0 
            return CountNumOfDigits(num / 10, counter + 1);
        }

        // Q6
        // defalult value sum = 0
        public static int SumOfNumDigits(int num, int sum = 0) {
            if (num == 0) return sum;

            // call the method with num divided by 10 to reduce the value
            // by one digit
            // send the sum with the remainder of division num by 10
            // 25 / 10 = 2
            // 25 % 10 = 5
            // 2 / 10 = 0
            // 2 % 10 = 2
            return SumOfNumDigits(num / 10, (num % 10) + sum);
        }

        // Q7
        // Greatest Common Divisor (GCD)
        // greatest number both sides can be divide on it
        public static int GreatestCommonDivisor(int a, int b) {
            // when b reach 0 return a
            if (b == 0) return a;

            // b = 10, a = 50
            // 50 % 10 = 0
            return GreatestCommonDivisor(b, a % b);
        }


        // Q8
        // assume the largest num is the first value
        public static int LargestElementInArray(int[] arr, int max, int index = 0) {
            // when index is out of range return max
            if (index >= arr.Length) return max;

            // if current num is bigger than max 
            // let max = current num
            if (max < arr[index])
                max = arr[index];

            // recursive call
            return LargestElementInArray(arr, max, index + 1);
        }


        // Q9
        public static void PrintStringInReverse(string str) {
            if (str.Length == 0) return;

            // gonna keep the recurion till I reach last letter 
            // Hello => ello
            // elllo => llo
            PrintStringInReverse(str.Substring(1));
            
            // after the the last call is over, print letter
            // o => l => l => e => H
            Console.Write(str[0]);
        }


        // Q10
        // factorial is series n * n - 1... * n * 1
        // 7! = 7 * 7 - 1 * 7 - 2...* 7 - 6
        public static int Factorial(int num) {
            // shouldn't reach 0, the whole value will become 0
            if (num <= 1) return 1;

            // return the number multiply by num - 1
            return num * Factorial(num - 1);
        }

        // Q11 -> ?? TO DO


        // Q12
        // Prime numbers are number that only accept the divsion
        // by one OR itself without remainder.
        // 2, 3, 5, 7, 11...etc
        public static bool IsPrimeOrNot(int num, int n = 2) {

            // no number less than 2 is prime
            if (num < 2) return false;

            // 2 & 3 are prime numbers 
            if (num == 2 || num == 3) return true;

            // if the remainder of the division of num on n is 0
            // and it same number as num return true
            if (num % n == 0 && num == n) return true;

            // if remainder of division is zero and it wasn't
            // the same number return false
            if (num % n == 0 && num != n) return false;

            return IsPrimeOrNot(num, n + 1);
        }

        // Q13 ?? TO DO



        // Q14
        public static void PrintEven(int start, int end) {
            if (start > end) return;

            if (start % 2 == 0)
                Console.Write(start);

            PrintEven(++start, end);
        }
        public static void PrintOdd(int start, int end) {
            if (start > end) return;

            if (start % 2 != 0)
                Console.Write(start);

            PrintOdd(++start, end);
        }
        public static void PrintTheEvenAndOdd(int rangeStart, int rangeEnd) {
            PrintEven(rangeStart, rangeEnd);
            Console.WriteLine();
            PrintOdd(rangeStart, rangeEnd);
        }

        // Q15 -> ?? TO DO

        // Q16 -> ?? TO DO

        // Q17
        public static int Power(int num, int power) {
            // when the power reach 1 or it's one return num
            if (power == 1) return num;

            // return the number mulitplied by returned value
            return num * Power(num, power - 1);
        }


        // Q18 -> ?? TO DO

        // Q19
        public static string CopyString(string originalString, string copiedString = "") {
            if (originalString.Length == 0) return copiedString;

            // send the original string minus one letter
            // concatinate the copied string with first letter
            // "" + H
            // H + e
            // He + l
            // ..etc
            return CopyString(originalString.Substring(1), copiedString + originalString[0]);
        }


        // Q20
        public static string FindFirstCapital(string str, int index = 0) {
            // if length is 0 or didn't find capital letter
            if (str.Length == 0 || index == str.Length) return "";

            // check if letter in current index is equal
            // to itself if capital
            // teSt
            // cureent t ?= T
            if (str[index] == char.ToUpper(str[index]))
                return Convert.ToString(str[index]);

            // recurive call to the method
            return FindFirstCapital(str, index + 1);
        }


        public static void Main(string[] args) {
            int n = 10;
            for (int i = 1; i <= n; i++) {
                Console.Write(Fibonacci(i));
                Console.Write(" ");
            }
        }
    }
}











