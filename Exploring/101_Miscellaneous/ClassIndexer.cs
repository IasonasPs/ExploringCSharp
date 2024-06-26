﻿namespace Exploring._101_Miscellaneous
{
    public class ClassIndexer
    {
        public static void ClassIndexersMain()
        {
            #region Simple Indexer 
                        //Student student = new Student(12, "Noone");

                        //student[0] = 14;
                        //student[2] = 15;
                        //student[3] = 16;
                        //student[4] = 17;
                        //student[5] = 18;

                        //Console.WriteLine(student[0]);
                        //Console.WriteLine(student[1]);

                        //int count = 0;
                        //for (int i = 2; i < 14; i++)
                        //{
                        //    Console.WriteLine("  " + student[i]);
                        //    count++;
                        //}

                        //Console.WriteLine("Count = {0}", count); 
            #endregion
        }
    }

    public class Student
    {
        private int? Id { get; set; }
        private string Name { get; set; }

        private int[] ints;
        public Student(int id, string name)
        {
            Id = id;
            Name = name;

            ints = Enumerable.Repeat(0, 12).ToArray();
        }

        //Indexer implementation
        public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return Id;
                }
                else if (index == 1)
                {
                    return Name;
                }
                else
                {
                    return ints[index - 2];
                }
            }
            set
            {
                if (index == 0)
                {
                    Id = value as int?;
                }
                else if (index == 1)
                {
                    Name = value as string;
                }
                else
                {
                    ints[index - 2] = (int)value;
                }
            }
        }
    }

    public class Space
    {
        private string Name { get; set; }

        private int Dimensions { get; set; }



        //public object this[int x, int y, int z]
        //{
        //    get { }
        //    set 
        //    {
        //        if (x==0 || y==0 || z==0)
        //        {
        //            Dimensions = 2;

        //        }


        //    }
        //}





    }
}
