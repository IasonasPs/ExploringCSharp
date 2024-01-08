using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exploring._100_DataStructures
{
    internal class HashSet
    {
        public static void HashSetMain()
        {

            #region MyRegion
            //Declaration
            //HashSet<int> set = new HashSet<int>(2);

            ////Add entries
            //set.Add(11);
            //set.Add(21);

            //#region Duplicates check
            //if(set.Add(11)) //duplicates arent added and .Add() method returns false
            //{
            //    Console.WriteLine("added 11");
            //}
            //if(set.Add(13)) //returns True
            //{
            //    Console.WriteLine("added 13");
            //}
            //#endregion

            //foreach(var item in set)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            var c = Check("abcca");
            var cc = IsPalindrome("abcca");
            Console.WriteLine(c);
            Console.WriteLine(cc);

        }

        public static bool Check(string str)
        {
            str = str.ToLower();
            str = str.Trim();

            HashSet<char> set = new HashSet<char>();

            var charArray = str.ToCharArray();

            foreach(char item in charArray)
            {
                _ = set.Contains(item) ? set.Remove(item) : set.Add(item);
            }
            Console.WriteLine(new String((char[])set.ToArray()));


            if(set.Count > 1)
                return false;
            else
                return true;

        }

        public static bool IsPalindrome(string word)
        {
            HashSet<char> set = new HashSet<char>(word);
            int count = 0;
            foreach(char c in set)
            {
                if(word.Count(x => x == c) % 2 != 0)
                {
                    count++;
                }
            }
            return count <= 1;
        }
    }
}






#region Comments
/*
  doesnt accept duplicate entries
  if we try to add a duplicate : set.Add('duplicate') simply doesnt add this entry and returns false 
 */
#endregion





