using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###Problem 1###");
            /*need 10 even numbers so from 0 to 20 
             use loop to go through the numbers
            to check if number is even we gonna get the numnber and divid it with two and see if theres a remind (if there is its odd) */
            for (int i = 0; i < 20; i++) {
                if (i %2== 0) {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("###Problem 2###");
            /*fibonacci series start with 0 and 1 then we add the new number with the previos 
             `so we assign 3 vars
            one for the first number 0
            then one for the second number 1
            and last the sum to calculate the first and second numbers to make the third
            then we reassign to give the first vars the second number and the second the new value and so on*/

            int num1 = 0;
            int num2 = 1;
            int num3;
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(num1);
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                
            }
            Console.WriteLine("###Problem 3###");
            /*we need 2 numbers the 2 and the power by so 2 vars
             after multipli them i need to increase the power by so am taking the result of the number * the power and store it in the power*/
            int number = 2;
            int power = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(power);
                power *= number;


            }
            Console.WriteLine("###Problem 4###");
            /*i need to make an array first then make a var thats emphty to compare it with every element in the array and if the element bigger then to store it in that var and go to the next element*/
            int[] numbers = new int[10] {12,14,13,43,65,34,87,45,54,90};
            int bigger = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > bigger)
                {
                    bigger = numbers[i];
                }
            }
            Console.WriteLine(bigger);

            Console.WriteLine("###Problem 5###");
            //i first create what the shape made of and put it in a val (*) then print it by 2 loops first for the colmun  then another one in to print the rows
            string elem = "*";

            for (int i = 0;i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(elem);
                }
                Console.WriteLine();
            }
            Console.WriteLine("###Problem 6###");
            /*first am gonna take an input from the user thn i need to make a bool to know if its a prime or notthen first i need to check if its greater than 1 (no prime number is less than2)
              then we need to do a loop to check if theres no remind(if theres its not prime)
              if its not prime we change the bool to false*/
            Console.WriteLine("enter a number to check if its a prime number");
            int prime = int.Parse(Console.ReadLine());

            bool isprime = true;
            if (prime < 2)
            {
                isprime = false;
            }
            else
            {
                for (int i = 2; i < prime; i++)
                {
                    if(prime % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
            }
            if(isprime ==true)
            {
                Console.WriteLine("the number is prime");
            }
            else
            {
                Console.WriteLine("the number is not prime");
            }


            Console.WriteLine("###Problem 7###");
            // first we take two input from the user then we make a var called sum and calculate the sum in it then print it

            Console.WriteLine("Enter a number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number");
            int number2 = int.Parse(Console.ReadLine());

            int summ = number1 + number2;

            Console.WriteLine($"the total is {summ}");

            Console.WriteLine("###Problem 8###");
            //first am gonna take a string then make a emphty var that we gonna store the reverse string in via a loop then print

            Console.WriteLine("Enter a string to reverse");
            string sent = Console.ReadLine();

            string reve = "";

            for (int i = sent.Length - 1; i >= 0; i--)
            {
                reve += sent[i];
            }
            Console.WriteLine(reve);

            Console.WriteLine("###Problem 9###");
            //we gonna make a var that name count then take the string then we gonna go index by index to check with if statment if theres a vowel then add it to count

            Console.WriteLine("Enter a sentens");
            string vowels = Console.ReadLine();

            int counter = 0;

            for (int i = 0; i < vowels.Length; i++)
            {
                char cha = vowels[i];
                if (cha == 'a' || cha== 'e' || cha== 'i' || cha == 'o' || cha == 'u' || cha == 'y')
                {
                    counter++;
                }
            }
            Console.WriteLine("number of vowels :"+counter);

            Console.WriteLine("###Problem 10###");
            //first we make a var called sum then we do a loop that loop 100 time inside it we check for even number if its even we add it to the sum

            int sum2 = 0;

            for (int i = 1; i <=100; i++)
            {
                if (i % 2 == 0)
                {
                    sum2 += i;
                }
            }
            Console.WriteLine(sum2);

            Console.WriteLine("###Problem 11###");
            // first we take a number from the user and save it then we loop from the number going down and every time we do we multipile it and save it in a sum of produc't

            Console.WriteLine("enter a number");
            int numberr = int.Parse(Console.ReadLine());
            int totalofproduct =1;

            for (int i = numberr; i > 0; i--)
            {
                totalofproduct *= i;
            }
            Console.WriteLine(totalofproduct);


            Console.WriteLine("###Problem 12###");
            //first we gonna make an array then am gonna use a  bubble sort so its can compare a number to the number next to it and save it in a temp then put it back in an array

            int[] array = new int[5] {2,3,5,1,8};

            for (int i = 0; i < array.Length -1; i++)
            {
                for (int j = 0; j < array.Length -1 -i; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            foreach(int i in array)
            {
                Console.WriteLine(i + " ");
            }

        }
    }
}
