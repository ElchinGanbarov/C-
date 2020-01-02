using Data;
using System;
using Laborotory.Story;
using Data.Amazing;

namespace Laborotory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Input the number of elements to be stored in the array :");
            //int count = 0;
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Element {0}:", i);
            //    array[i] = int.Parse(Console.ReadLine());

            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {

            //        if (array[i] == array[j])
            //        {
            //            count++;
            //        }
            //    }

            //}
            //Console.WriteLine("Total number of duplicate elements found in the array is: {0}", count);

            // Console.Write("Input the size of array :");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input {0} elements in the array in ascending order:",n);
            //int[] array = new int[n];
            //for(int i = 0; i < n; i++)
            //{
            //    Console.Write("Element {0}:", i);
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Input the position where to delete: 2");
            //Console.Write("The new list is : ");
            //for (int i = 0; i < n; i++)
            //{
            //    if (i == 2)
            //    {
            //        continue;
            //    }

            //    Console.Write(+array[i] + " ");
            // }

            //Person person = new Person();
            //person.Name = "Elcin";
            //person.SurName = "Qenberov";
            //Lead lead = new Lead
            //{
            //    _person = person
            //};

            //Console.WriteLine(lead._person.FullName());

            //    int[,,] array =
            //    {
            //        {
            //            {12,14 }
            //        },
            //        {
            //            {13,15 }
            //        },
            //        {
            //            {18,19 }
            //        }
            //    };
            //    Console.WriteLine(array.Rank);

            //User user = new User();

            //Admin admin = new Admin(23);
            //Console.WriteLine(admin.Age);
            //Person person = new Person();
            //person.Order = OrderStatus.Doktorantura;
            //Console.WriteLine((int)person.Order);

            //string[] names = { "Elcin", "Rovsen", "Ali", "Huseyn", "Elekber" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine("Ad:" + names[i]);
            //}
            //int[] count = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for(int i = 0; i < count.Length; i++)
            //{
            //    Console.WriteLine("Element[{0}]={1}",i,count[i]);
            //}
            //foreach(string item in names)
            //{
            //    Console.WriteLine("Ad: " + item);
            //}
            //string NewNames = string.Join("-", names);
            //Console.WriteLine("Array to String: " + NewNames);
            //Console.WriteLine("============================");
            //string country = "Naxcivan,Baki,Agdam,Agdere";
            //string[] Aray = country.Split(",");
            //foreach(string item in Aray)
            //{
            //    Console.WriteLine("String to Array: "+item);
            //}
            //string name = "             ";
            //Console.WriteLine(string.IsNullOrEmpty(name.Trim()));
            //Console.WriteLine(string.IsNullOrWhiteSpace(name));
            //string count = Console.ReadLine();
            //int a= 0;
            //while(!int.TryParse(count,out a))
            //{
            //    Console.WriteLine("Secimi duzgun edin");
            //    count = Console.ReadLine();
            //}
            //Console.Write("Input the string :");
            //string space = Console.ReadLine();
            //Console.Write("The characters of the string are :");
            //for (int i = 0; i < space.Length; i++)
            //{

            //    Console.Write(space[i]+" ");
            //}
            //Console.Write("Input the string :");
            //string a = Console.ReadLine();
            //Console.Write("The substring retrieve from the string is :");

            //for(int i = 5; i <10; i++)
            //{
            //    Console.Write(a[i]);
            //}
            //string country = " This is a test string";
            //char[] Xchar = country.ToCharArray(5, 5);
            //foreach(char item in Xchar)
            //{
            //    Console.Write("{0}", item);
            //}

            // string string1 = Console.ReadLine();
            // string string2 = Console.ReadLine();
            // if (string1.Length == string2.Length && string1==string2)
            // {
            //     Console.WriteLine("The length of both strings are equal and also, both strings are equal.");
            // }
            //else if(string1.Length == string2.Length && string1 != string2)
            // {
            //     Console.WriteLine("eyni uzunluqdadirlar ve ferlidirler");
            // }
            // else
            // {
            //     Console.WriteLine("Tamam Ferqlidirler");
            // }
            // int digitCount = 0;
            // int n = 0;
            // int count = 0;
            // Console.Write("Input the string :");
            // string digit = Console.ReadLine();
            //for(int i = 0; i < digit.Length; i++)
            // {
            //     if (digit[i] >= '0' && digit[i] <= '9')
            //     {
            //         digitCount++;
            //     }
            //     else if ((digit[i] >='a' && digit[i]<='z')||(digit[i]>='A' && digit[i]<= 'Z'))
            //     {
            //         count++;
            //     }
            //     else
            //     {
            //         n++;
            //     }
            // }


            // Console.WriteLine("Number of Alphabets in the string is :{0} ", count);

            // Console.WriteLine("Number of Digits in the string is :{0}", digitCount);

            // Console.WriteLine("Number of Special characters in the string is :{0}", n);

            //Console.Write("Input the string : ");
            //string first = Console.ReadLine();
            //string second = first;
            //Console.WriteLine("The First string is : {0}", first);
            //Console.WriteLine("The Second string is : {0}", second);
            //int l = first.Length;
            //Console.WriteLine("Number of characters copied :{0}", l);

            //Console.Write("Input the string ");
            //string digit = Console.ReadLine();

            //byte VowelCount = 0;
            //byte ConsonantCount = 0;

            //for(int i = 0; i < digit.Length; i++)
            //{
            //    if (digit[i] =='a'||digit[i]=='i'||digit[i]=='o' ||digit[i]=='u' || digit[i] == 'e')
            //    {
            //        VowelCount++;
            //    }
            //    else if ((digit[i] > 'a' && digit[i] < 'z') || (digit[i] > 'A' && digit[i] < 'Z'))
            //    {
            //        ConsonantCount++;
            //    }

            //}

            //Console.WriteLine("The total number of vowel in the string is :{0}",VowelCount);
            //Console.WriteLine("The total number of consonant in the string is :{0}",ConsonantCount);

            Console.Write("Input the string :");
            string str = Console.ReadLine();
            int count = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'e')
                {
                    count++;
                }
            }
            Console.WriteLine("The Highest frequency of character 'e' ");
            Console.WriteLine("appears number of times : {0}", count);

        }
    }
}
