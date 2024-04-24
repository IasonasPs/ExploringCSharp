namespace Exploring._101_Miscellaneous
{
    internal class MiscellaneousMain
    {
        public static void MiscellaneousMainMethod(string[] args)
        {
         

            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

            #region Out_and_Ref
            //int y;
            //Out_and_Ref.Square(5, out y);
            //Console.WriteLine("here y is the square of the first parameter and need not be initialized : {0}", y);

            //int z = 2 ;
            //Out_and_Ref.Square2(5, ref z);
            //Console.WriteLine("here z is changed within the method and needs to be initialized : {0}", z);

            //var result3 = Out_and_Ref.Square3(5, out y);
            //Console.WriteLine("Result is {0} and y is {1}", result3, y);

            //var result4 = Out_and_Ref.Square4(5, ref z);
            //Console.WriteLine("Result is {0} and z is {1}", result3, z);

            #endregion

            #region Memory Allocated
            //Console.WriteLine(GC.GetTotalAllocatedBytes());

            //Gc gc = new Gc();

            //var memoryBeforeAllocation = GC.GetTotalMemory(false);
            //gc.AllocateMemory();

            //var memoryAfterAllocation = GC.GetTotalMemory(false);

            //Console.WriteLine($"Memory allocated to list : {memoryAfterAllocation - memoryBeforeAllocation} bytes");

            //Gc gc01 = new Gc();

            //var memoryBeforeAllocation01 = GC.GetTotalMemory(false);
            //gc01.AllocateMemory();

            //var memoryAfterAllocation01 = GC.GetTotalMemory(false);


            //Console.WriteLine($"Memory allocated to list : {memoryAfterAllocation01 - memoryBeforeAllocation01} bytes");

            //Console.WriteLine(GC.GetTotalAllocatedBytes());
            #endregion

            //Dispose_vs_Finalize.DvsFMain();

            //Abstract_vs_Interface.Abstract_vs_InterfaceMain();

            #region Custom Exceptions
            //try
            //{
            //    if(true)
            //    {
            //        throw new MyCustomException("iasonas", new MyBetterCustomexception());
            //    }
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.InnerException.Message);
            //} 
            #endregion

            ////ClassIndexer.ClassIndexersMain();

            ////BitWiseOperators.BitWiseOperatorsMain();

            ////DisposeCheck.DisposeCheckMain();

            ////Test.testMain();
            //ListWindowsServices.ListDevices();

            //ConcurretnBagAndList.bagToListMain();
            //ParallelForeach.parallelMain();

            //InterfaceProperties.InterfacePropertiesMain();

            //IEnumProgram.iEnumMain();

            //InterfaceInheritance.InterfaceInheritanceMain();

            //Yield.YieldMain();

            SelectMany.ManyMain();


            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
        }
    }



}
