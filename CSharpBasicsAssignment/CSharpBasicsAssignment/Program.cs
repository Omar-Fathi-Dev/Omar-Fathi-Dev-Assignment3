namespace CSharpBasicsAssignment;

#region  Part A — Project & Structure

    #region the role of: .csproj, Program.cs, obj/, and bin/.

        /*
         *.csprog : it contains project configuration it specifies 1- target framework.
         *          2- enable and disable features. 3- version of packages.
         *
         * program,cs : it has the entry point of the project where the program starts running.
         *
         * obj/ : It stores temporary files used during build.
         *
         * bin/ : It stores the final built files that the program can run
         * 
         */

    #endregion

    #region why file-scoped namespace removes a level of indentation?

    /*
     * It removes a level of indentation
     * because we no longer need the curly braces { } to wrap the entire file.
     */

    #endregion

    #region a classic .sln or the newer .slnx format,

    /*
     * I am using the classic .sln format.
     * One advantage of .slnx is that it uses XML,
     * which makes it more readable than the classic .sln format.
     */

    #endregion

#endregion

internal class Program
{
    static void Main(string[] args)
    {
        RunTypesDemo();
    }

    #region Part B — Variables, Types & Casting

    static void RunTypesDemo()
    {
        Console.WriteLine("============================================");
        Console.WriteLine("Part B — Variables, Types & Casting");
        Console.WriteLine("============================================");

        #region Declaring a variable of every type

        Console.WriteLine("1 -  Declaring a variable of every type:");
        Console.WriteLine("--------------------------------------------");

        
        int intValue = 5;
        Console.WriteLine($"Int Value: {intValue} - Runtime Type:  {intValue.GetType()}");
        
        long longValue = 3;
        Console.WriteLine($"Long Value: {longValue} - Runtime Type:  {longValue.GetType()}");
        
        double doubleValue = 1.5;
        Console.WriteLine($"Double Value: {doubleValue} - Runtime Type:  {doubleValue.GetType()}");
        
        decimal decimalValue = 1.25m;
        Console.WriteLine($"Decimal Value: {decimalValue} - Runtime Type: {decimalValue.GetType()}");
        
        bool boolValue = true;
        Console.WriteLine($"Bool Value: {boolValue} - Runtime Type: {boolValue.GetType()}");
        
        char charValue = 'A';
        Console.WriteLine($"Char Value: {charValue} - Runtime Type:  {charValue.GetType()}");
        
        string stringValue = "Hello World";
        Console.WriteLine($"String Value: {stringValue} - Runtime Type:  {stringValue.GetType()}");
        
        var varValue = 10;
        Console.WriteLine($"Var Value: {varValue} - Runtime Type: {varValue.GetType()}");
        
        Console.WriteLine("--------------------------------------------");

        #endregion

        #region Implicit conversion

        Console.WriteLine("2 -  Implicit conversion:");
        Console.WriteLine("--------------------------------------------");

        int num1 = 10;
        long num2 = num1;
        Console.WriteLine($"int: num1: {num1} ");
        Console.WriteLine($"long: num2: {num2} ");
        // Implicit conversion is possible because long can represent all int values without data loss.
        
        char ch = 'A';
        int num = ch;
        Console.WriteLine($"char: ch: {ch} ");
        Console.WriteLine($"int: num: {num} ");
        // Implicit conversion is possible because a char has a numeric Unicode value that can be represented by an int.
        
        Console.WriteLine("--------------------------------------------");
        #endregion

        #region  Explicit conversion

        Console.WriteLine("3 -  Explicit conversion:");
        Console.WriteLine("--------------------------------------------");

        double n1 = 3.6;
        int n2 = (int)n1;
        int n3 = Convert.ToInt32(n1);

        Console.WriteLine($"Double: n1 = {n1}");
        Console.WriteLine($"Int: n2 = {n2}");
        Console.WriteLine($"Int: n3 = {n3} using Convert.ToInt32()");
        Console.WriteLine("--------------------------------------------");
        /*
         * The difference between (int) and Convert.ToInt32() is:
         * (int) deletes the fractional part without rounding.
         * Convert.ToInt32() rounds the value to the nearest integer.
         */


        #endregion

        #region The integer division trap: 

        Console.WriteLine("4 -  The integer division trap: ");
        Console.WriteLine("--------------------------------------------");
        
        int a = 5 / 2;
        double b = 5.0 / 2;
        Console.WriteLine($"int: a = 5 / 2 = {a}");
        Console.WriteLine($"double: b = 5.0 / 2 = {b}");
        Console.WriteLine("--------------------------------------------");
        
        // Integer division discards the fractional part, while floating-point division preserves it.

        #endregion

        #region  Boxing/unboxing: 

        Console.WriteLine("5 -  Boxing/unboxing:  ");
        Console.WriteLine("--------------------------------------------");

        int number = 10;
        object ob = number;
        Console.WriteLine($"boxing: object ob = number = {ob}");
        number = (int)ob;
        Console.WriteLine($"unboxing: number = (int)ob = {number}");
        Console.WriteLine("--------------------------------------------");

        #endregion

        #region Parsing:

        Console.WriteLine("6 -  Parsing: ");
        Console.WriteLine("--------------------------------------------");

        string str1 = "42";
        int strToInt = int.Parse(str1);
        Console.WriteLine($"int.Parse(str1) = {strToInt}");
        string str2 = "abc";
        bool flag = int.TryParse(str2, out int result);
        if(flag)
            Console.WriteLine($"TryParse succeeded, result = {result} ");
        else 
            Console.WriteLine($"TryParse failed, result is invalid");

        Console.WriteLine("--------------------------------------------");
        #endregion

        #region  float → decimal: 

        Console.WriteLine("7 -   float → decimal: : ");
        Console.WriteLine("--------------------------------------------");
        
        float f = 4.2f;
        // decimal d = f;          //implicit assignment failed
         decimal d = (decimal)f;  //explicit assignment success
         Console.WriteLine($"decimal d = (decimal)f = {d}");
         
        // decimal can't represent float because decimal is base 10 and float is base 2 so converting  may cause a loss of data.
        
        #endregion





    }

    #endregion
    
    
}