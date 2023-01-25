using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Security;
using System.Net.WebSockets;

namespace _24._01_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //string word = "Baku2023";

            // var result = HasNum(word);
            // Console.WriteLine(result);




            //string fullname = "Nazila FarajOva";
            //var result = IsFullName(fullname);
            //Console.WriteLine(result);

            //int[] numbers = { 12, 5, 96, 4 };
            //Resize(ref numbers, 6);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Add(ref numbers, 45);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //string[] fullnames = { "Leyla Quliyeva", "Gunay Veliyeva", "Fuad Aliyev", "Nicat Bayramov" };

            //var names = MakeNames(fullnames);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}


            //int[] array = { 12, 75, 88, 2, 9, 12, 75 };

            //var newlist = NewArray(array);
            //for (int i = 0; i < newlist.Length; i++)
            //{
            //    Console.WriteLine(newlist[i]);
            //}

            //string email = "nazilamf@code.edu.az";
            //var result = Getdomain(email);
            //Console.WriteLine(result);

            //string[] emails = { "nazilamf@code.edu.az", "leylanf@code.edu.az", "gunaymff@code.edu.az" };
            // var domains = GetDomains(emails);
            //for (int i = 0; i < domains.Length; i++)
            //{
            //    Console.WriteLine(domains[i]);
            //}






            ////cosole-da email deyeri istenilsin. Eger deyerde @ xarakteri yoxdursa yeniden istenilsin
            //string email;
            //do
            //{
            //    Console.WriteLine("Emailinizi daxil edin:");
            //    email = Console.ReadLine();

            //} while (!email.Contains('@'));

            string word = "Baku.I.love.you" ;

            var result = SizeCount(word);

            Console.WriteLine(result);


        }

        
        //Yazinin ad olub olmadigini teyin et

        static bool IsName(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                return false;
            }


            if (!char.IsUpper(str[0]))
            {
                return false;
            }
            for (int i = 1; i < str.Length; i++)
            {
                if (!char.IsLower(str[1]))
                {
                    return false;
                }
            }
            return true;
        }



        //array yeni olcu teyin etmek

        static void Resize(ref int[] arr, int newsize)
        {
            int[] newarr = new int[newsize];
            for (int i = 0; i < arr.Length; i++)
            {
                newarr[i] = arr[i];
            }

            arr = newarr;
        }


        //Array-ye yeni reqem elave etmek

        static void Add(ref int[] num, int number)
        {
            int[] newnum = new int[num.Length +1];
            for (int i = 0; i < num.Length; i++)
            {
                newnum[i]= num[i];
            }

            newnum[newnum.Length -1] = number;

            num = newnum;
        }


        //fullname siyahisindan  ad kesmek method

        static string[] MakeNames(string[] arr)
        {
            string[] newnames = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                var fullname = arr[i].TrimStart();
                var name = arr[i].TrimStart().Substring(0, fullname.IndexOf(' '));
                newnames[i] = name;
            }

            return newnames;

        }



        //Verilmis emaildan domainlari kesmek
        static string Getdomain(string str)
        {
            var atIndex = str.IndexOf('@');
            var domain = str.Substring(atIndex +1);

            return domain;
        }





        //Verilmiş yazıda rəqəm olub olmadığını tapan metod

        static bool HasNum(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    return true;
            }

            return false;

        }


        //- Verilmiş yazının fullname olub olmadığını tapan metod
        //(fullname olması üçün iki sozdən ibarət olmalıdır və hər bir söz
        //böyük hərflə başlayıb kiçik hərflərlə davam etməlidir)



        static bool IsFullName(string str)
        {

            for (int i = 0; i < str.Length; i++)

            {

                if (str[i] != ' ')
                {
                    return false;
                }
                string name = str.Substring(0, str.IndexOf(' ')-1);
                string fullname = str.Substring(str.IndexOf(' ')+1);


                if (!IsName(name))
                {
                    return false;
                }
                if (!IsName(fullname))
                {
                    return false;
                }
            }

            return true;

        }




        // Verilmiş ədədlər siyahısından yeni bir array düzəldib
        //qaytaran metod.Yeni arrayə elementlər təkrarlanmamaq şərti ilə yerləşdirilsin.


        static int[] NewArray(int[] arr)
        {
            int[] Newarray = new int[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (Array.IndexOf(Newarray, arr[i]) == -1)
                {
                    Array.Resize(ref Newarray, Newarray.Length+1);
                    Newarray[Newarray.Length-1] = arr[i];

                }
            }

            return Newarray;

            



        }




        //- Verilmiş email-lər siyahısından domainlər siyahısı düzəldən metod.
        //Domainlər arrayondə təkrarlanmamlıdır domainlər!

        static string[] GetDomains(string[] arr)
        {
            string[] newdomains = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                
                 newdomains[i] = Getdomain(arr[i]);

            }

            return newdomains;
        }



         //Verilmiş yazının içindəki cümlələrin sayını tapan metod.


        static int SizeCount(string str)
        {
            int size = 0;

            var strarray = str.Split('.');
            for (int i = 0; i < strarray.Length; i++)
            {
                size = i+1;
            }


            return size;
        }
        
    }

}


    


