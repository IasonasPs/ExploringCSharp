using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exploring
{
    internal class DiscardVariable
    {
        public static void discardsMain(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            ValidateDate(dateTime);

            var tuple = (1," ",4);
        }

        public static void ValidateDate(DateTime dateTime)
        {
            var subject = dateTime.Date;
            var subjectString = subject.ToString();
            var dateString = subjectString.Replace(subject.TimeOfDay.ToString(), String.Empty);

            #region Without Discards Variable
            //DateTime result;
            //if (DateTime.TryParse(dateString,out result))
            //{
            //    Console.WriteLine("result is valid {0}",result);
            //}
            //else
            //    Console.WriteLine("result is not valid");
            #endregion

            #region With discards variable
            if (DateTime.TryParse(dateString, out _))
            {
                Console.WriteLine("Data is valid : {0}", dateString);
            }
            else
            {
                Console.WriteLine("Data is not ");
            }
            #endregion
        }














    }



}
