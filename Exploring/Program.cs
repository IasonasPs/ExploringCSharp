﻿using Exploring._01_User_defined_conversion_operators;
using Exploring._102_Checked_Unchecked;
using System.Management;

namespace Exploring
{
    internal class Program
    {
        delegate void Del();
        public static void Main(string[] args)
        {

#if DEBUG
            args = new string[] { "12", "13", "14" };
#else
            args = new string[] { "16", "17", "18" };
#endif

            //args.ToList().ForEach(x => Console.WriteLine(x));

            //Tuples.tuplesMain(args);

            //DiscardVariable.discardsMain(args);

            //Convertor.ConvertorMain(args);

            //StaticKeyword.SkMain(args);

            //UserDefinedConversions.udcMain();

            Checked_UnChecked.cUMain();

            Console.ReadKey();
        }
    }
 













}