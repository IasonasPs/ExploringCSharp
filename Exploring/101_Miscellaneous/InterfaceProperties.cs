using System.CodeDom.Compiler;
using System.Globalization;

namespace Exploring._101_Miscellaneous
{
    internal class InterfaceProperties
    {
        public static void InterfacePropertiesMain()
        {

            //https://learn.microsoft.com/en-us/dotnet/api/microsoft.csharp.csharpcodeprovider?view=dotnet-plat-ext-8.0&redirectedfrom=MSDN


            FileInfo sourceFile = new FileInfo("ITest.cs");
            CodeDomProvider provider = null;
            bool compileOk = false;
            string sourceName = "ITest.cs";

            if(sourceFile.Extension.ToUpper(CultureInfo.InvariantCulture) == ".CS")
            {
                provider = CodeDomProvider.CreateProvider("CSharp");
            }

            if(provider != null)
            {

                // Format the executable file name.
                // Build the output assembly path using the current directory
                // and <source>_cs.exe or <source>_vb.exe.

                var namereplace = sourceFile.Name.Replace(".", "_");
                //var dir = System.Environment.CurrentDirectory.;// .CurrentDirectory;

                String exeName = String.Format(@"{0}\{1}.exe",
                    System.Environment.CurrentDirectory,
                    sourceFile.Name.Replace(".", "_"));

                CompilerParameters cp = new CompilerParameters();

                // Generate an executable instead of
                // a class library.
                cp.GenerateExecutable = true;

                // Specify the assembly file name to generate.
                cp.OutputAssembly = exeName;

                // Save the assembly as a physical file.
                cp.GenerateInMemory = false;

                // Set whether to treat all warnings as errors.
                cp.TreatWarningsAsErrors = false;

                // Invoke compilation of the source file.
                CompilerResults cr;
                try
                {

                    cr = provider.CompileAssemblyFromFile(cp,
                       sourceName);
                }
                catch(Exception e)
                {
                    throw e;
                }


                if(cr.Errors.Count > 0)
                {
                    // Display compilation errors.
                    Console.WriteLine("Errors building {0} into {1}",
                        sourceName, cr.PathToAssembly);
                    foreach(CompilerError ce in cr.Errors)
                    {
                        Console.WriteLine("  {0}", ce.ToString());
                        Console.WriteLine();
                    }
                }
                else
                {
                    // Display a successful compilation message.
                    Console.WriteLine("Source {0} built into {1} successfully.",
                        sourceName, cr.PathToAssembly);
                }

                // Return the results of the compilation.
                if(cr.Errors.Count > 0)
                {
                    compileOk = false;
                }
                else
                {
                    compileOk = true;
                }
            }

        }
    }

    public abstract class myClass
    {
        public int MyProperty3 { get; set; }
        public string MyProperty4 { get; set; }
        public List<int> MyProperty5 { get; set; }
    }
}
