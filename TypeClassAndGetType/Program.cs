namespace TypeClassAndGetType
{
    /* We only mentioned it briefly, but
    here’s a reminder that you can nest
    classes inside of each other. Program
    contains NestedClass, which contains
    DoubleNestedClass. */
    public class Program
    {
        public class NestedClass
        {
            public class DoubleNestedClass
            {
                // Nested class contents...
            }
        }

        // entry point
        public static void Main(string[] args)
        {
            if (args is null)
                throw new ArgumentNullException(nameof(args));

            /* You can use the typeof keyword to turn a
            type (like Guy, int, or DateTime) into a Type
            object. Then you can find out its full name
            and base type (and if it didn’t inherit from
            anything, its base type is System.Object). */
            Type guyType = typeof(Guy);

            // output: TypeExamples.Guy extends System.Objec
            Console.WriteLine("{0} extends {1}",
                guyType.FullName,
                guyType.BaseType.FullName);

            // output: TypeExamples.Program+NestedClass+DoubleNestedClas
            Type nestedClassType = typeof(NestedClass.DoubleNestedClass);
            Console.WriteLine(nestedClassType.FullName);

            // output: List`1
            List<Guy> guyList = new();
            Console.WriteLine(guyList.GetType().Name);

            // output: Dictionary`2
            Dictionary<string, Guy> guyDictionary = new();
            Console.WriteLine(guyDictionary.GetType().Name);

            // output: TypeExamples.Program
            /* This is the System.Type class.
            The GetType() method returns a Type object. */
            Type t = typeof(Program);
            /* The FullName property we
            used in the first part of
            this program is a member of
            System.Type. */
            Console.WriteLine(t.FullName);

            // System.Int32 - System.Int32
            Type intType = typeof(int);
            Type int32Type = typeof(Int32);
            /* float is an alias for System. 
            Single and int is an alias for System. Int32. */
            Console.WriteLine("{0} - {1}", intType.FullName, int32Type.FullName);


            /* Numeric value types and DateTime have
            MinValue and MaxValue properties that
            return the lowest and highest valid value */
            // output:-3.402823E+38 3.402823E+38
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            // output:-2147483648 2147483647
            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);

            // output: 1/1/0001 12:00:00 AM 12/31/9999 11:59:59 PM
            Console.WriteLine("{0} {1}", DateTime.MinValue, DateTime.MaxValue);

            // output: System.Int32
            /* Literals have types, too! And you can use
            GetType() to get those types. */
            Console.WriteLine(12345.GetType().FullName);

            Console.ReadKey();
        }
    }
}