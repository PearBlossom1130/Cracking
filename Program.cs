using System;

namespace chap1
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = CheckPermutation2("Welcome","dsghjkt");
            var c = Urlify("   Hello World    ");

            var d = IsSubstring("WaterBottle", "terBottleWa");
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

        static string Urlify(string s) {
            var trimmedString = s.Trim();
            int count = 0;
            foreach(var c in trimmedString) {
                if(c == 32) count++;
            }

            var dd = new char[trimmedString.Length+count*2];
            int j = 0;
            for(var i = 0; i < trimmedString.Length; i++) {
                if(trimmedString[i] == 32) {
                    dd[j++] = '%';
                    dd[j++] = '2';
                    dd[j++] = '0';
                }
                else {
                    dd[j++] = trimmedString[i];
                }
            }
    
            return new string(dd);
        }

        static bool IsPermutationOfPalindrome(string phase) {
            // int[] table = BuildCharFrequencyTable(phase);

            // return CheckMaxOneOdd(table);
            return true;
        }

        static bool CheckMaxOneOdd(int[] table) {
            bool foundOdd = false;
            for(int i =0; i < table.Length; i++) {
                if(i % 2 == 1) {
                    if(foundOdd) {
                        return false;
                    }
                }
                return true;
            }

            return true;
        }

        static int GetCharNumber(char c) {
            int a = 'a';
            int z = 'z';

            int val =  c;

            if (a <= val && val <= z) {
                return val - a;
            }

            return -1;
        }

        static bool IsSubstring(string s1, string s2)
        {
            if(s1.Length != s2.Length) return false;

            var s1s1 = s1+s1;
            return s1s1.Contains(s2) ? true : false;
        }
    }
}
