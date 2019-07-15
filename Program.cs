using System;

namespace chap1
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = CheckPermutation2("Welcome","dsghjkt");
        }

        static bool IsUnique(string s) {


            return true;
        }

        static bool IsUnique2(string s) {

            return true;
        }

        static bool CheckPermutation1(string s1, string s2) 
        {
            if(s1.Length != s2.Length) return false;

            //shows how to convert a string to char array
            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();

            Array.Sort(c1);
            Array.Sort(c2);
            
            //shows how to create a string from char array
            // new string(c1)
            return new string(c1).Equals(new string(c2));
        }

        static bool CheckPermutation2(string s1, string s2) 
        {
            if(s1.Length != s2.Length) return false;

            int[] letters = new int[128]; // ASCII code // should consider extended ASCII or unicode as well

            foreach(var a in s1) {
                letters[a]++;
            }

            foreach(var a in s2)  {
                letters[a]--;
                if(letters[a] < 0) return false;
            }

            return true;
        }


    }
}
