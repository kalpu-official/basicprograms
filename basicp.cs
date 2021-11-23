using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
public class Swapping

{
    public static void Main(string[] args)
    {
        Console.Clear();
        //fibonnaci(15);
        //primenumber(4);
        //sumofdigit(124);
        //swapping(1, 9);
        //factorial(5);
        //reverse(63);
        //swap_two_var(8, 9);
        //dectobin(7);
        //armstrong(2);
        //Palindrome(1);
        Console.ReadLine();

    }
    //Write a c# program to print fibonacci series without using recursion and using recursion.
    private static void fibonnaci(int num)
    {
        int a = 0, b = 1, c = 0;
        Console.Write("{0} {1}", a, b);
        for (int i = 2; i < num; i++)
        {
            c = a + b;
            Console.Write(" {0}", c);
            a = b;
            b = c;
        }
    }
    //Write a c# program to check prime number.
    private static void primenumber(int p)
    {
        int a = 0;
        a = p / 2;
        for (int i = 2; i <= p; i++)
        {
            if (p % i == 0)
            {
                Console.Write(" not a prime number", p);
                break;
            }
            else
                Console.Write(" it is a prime number ", p);
        }
    }
    //Write a c# program to print sum of digits.
    private static void sumofdigit(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine(sum);
    }
    //Write a c# program to swap two numbers without using third variable.
    private static void swapping(int a, int b)
    {
        int n = 0, j = 0, temp;
        {
            temp = n;
            n = j;
            j = temp;
        }
        Console.Write(n + b);
        Console.Write(j + a);
    }
    //Write a c# program to print factorial of a number.
    private static void factorial(int q)
    {
        int i, f = 1;
        for (i = 1; i <= q; i++)
            f = f * i;
        Console.Write("The Factorial of {0} is: {1}", q, f);
    }
    //Write a c# program to reverse given number.
    private static void reverse(int a)
    {
        int i, j = 0;
        while (a > 1)
        {
            i = a % 10;
            j = (j * 10) + i;
            a = (a / 10);
        }
        Console.Write("number in reverse order", +j);
    }
    //Write a c# program to swap two numbers without using third variable.
    private static void swap_two_var(int a, int b)

    {
        int f, s;
        {
            f = 1;
            s = 2;
            f = f + s;
            s = f - s;
            f = f - s;
        }
        Console.WriteLine(a.ToString());
        Console.WriteLine(b.ToString());
        Console.ReadLine();
    }
    //Write a c# program to convert decimal number to binary.
    private static void dectobin(int n)
    {
        int i;
        int[] a = new int[100];
        for (i = 0; n > 0; i++)
        {
            a[i] = n % 2;
            n = n / 2;
        }
        Console.Write("Binary of the given number= ", n);
        for (i = i - 1; i >= 0; i--)
        {
            Console.Write(a[i]);
        }
    }
    //Write a c# program to check armstrong number.
    private static void armstrong(int p)
    {
        int val=1, sum = 0; int rem;
        for (int i = val; i > 0; i = i / 10)
        {
            rem = i % 10;
            sum = sum + rem * rem * rem;
        }

        if (sum == val)
        {
            Console.Write("It Is a Armstrong Number",p);
        }
        else
        {
            Console.Write("Not an Armstrong Number",p);
        }
    }
    //Write a c# program to check palindrome number.
    private static void Palindrome(int p)
    {      int r, sum = 0, temp;

        temp = p;
        while (p > 0)
        {
            r = p % 10;
            sum = (sum * 10) + r;
            p = p / 10;
        }
        if (temp == sum)
            Console.Write("Number is Palindrome.");
        else
            Console.Write("Number is not Palindrome");
    }
}


