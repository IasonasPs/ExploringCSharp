using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exploring._101_Miscellaneous
{
    internal class Dispose_vs_Finalize
    {
        public static void DvsFMain()
        {
            var filename = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (Filereader filereader = new Filereader("C:/Users/iasonas.psomadakis/Desktop/test.txt",2))
            {
                filereader.ReadFile();
                Console.WriteLine("---->{0}",filereader.myReadonly);
            }//Dispose is called here

        }
    }

    public class Filereader : IDisposable
    {
        public readonly int myReadonly = 2;

        bool disposed = false;
        StreamReader file;

        public Filereader(string fileName)
        {
            file = new StreamReader(fileName);
        }

        public Filereader(string fileName,int x)
        {
            file = new StreamReader(fileName);
            myReadonly = x;
        }

        public void ReadFile()
        {
            var s = file.ReadToEnd();
            Console.WriteLine(s);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if(!disposed)
            {
                if(disposing)
                {
                    file?.Close();
                }
                disposed = true;
            }
        }
        ~Filereader() 
        {
            Dispose(false); 
        }
    }






}
