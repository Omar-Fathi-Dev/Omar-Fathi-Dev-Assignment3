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
        

        #region Run Part B 

        //RunTypesDemo();

        #endregion
        
        #region Run Part C 

        //RunValueVsReferenceDemo();

        #endregion

        #region Run Part D => D2

        //CompoundAssignmentOperators();

        #endregion
        
        #region Run Part D => D3

        //DemonstrateBitwiseOperators();

        #endregion
        
        

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

    #region Part C — Value vs. Reference Types 
    
    struct Point { public int X; public int Y; }
    
    static void RunValueVsReferenceDemo()
    {
        Console.WriteLine("============================================");
        Console.WriteLine("Part C — Value vs. Reference Types ");
        Console.WriteLine("============================================");

        #region Experiment 1 — struct copy semantics

        Console.WriteLine("Experiment 1 — struct copy semantics");
        Console.WriteLine("---------------------------------------------");
        
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1;
        p2.X = 99;
        Console.WriteLine($"p1.X = {p1.X}");
        Console.WriteLine($"p2.X = {p2.X}");
        // Point is a struct so it is a value-type and When we copy p1 to p2, p2 gets just a copy of the value . 

        Console.WriteLine("---------------------------------------------");
        
        #endregion

        #region Experiment 2 — class reference semantics (Order class)
        
        Console.WriteLine("Experiment 2 — class reference semantics (Order class)");
        Console.WriteLine("---------------------------------------------");
        
        Order o1 = new Order
        {
            _orderId = 1,
            _customerName = "Omar",
            _quantity = 5,
            _unitPrice = 250.50m,
            _totalPrice = 1252.50m,
            _isPaid = false,
            _discountPercent = 10.0,
            _shippingCity = "Cairo",
            _priority = 'H',
            _itemCode = 9876543210L
        };

        o1.CalculateTotal();
        Order o2 = o1;
        o2._isPaid = true;
        
        Console.WriteLine($"o1.Ispaid = {o1._isPaid}");
        Console.WriteLine($"o2.Ispaid = {o2._isPaid}");
        
        // class Order is a reference type , when we copy reference o1 to reference o2 we copy the address that refer to the oblect in Heap.
        Console.WriteLine("----");
        Console.WriteLine("Work with object:");
        object boxedOrder = o1;
        Order o3 = (Order)boxedOrder;
        Console.WriteLine($"object.ReferenceEquals(o1,o3) : {object.ReferenceEquals(o1,o3)}");
        Console.WriteLine("----");
        o2.PrintSummary();
        
        // value data type lives in stack and reference data type its address lives in stack and its actual data in heap.
        // assignment in value tpye copies actual value ,and assignment in reference type copies the address.
        //storing a reference type inside an object variable does not create a new object : Both variables still refer to the same object in the heap.
        
        Console.WriteLine("---------------------------------------------");
        
        

        #endregion




    }

    #endregion

    #region Part D — Scope & Operators


    #region D1 — Scope
    
    //Field scope
    
    private int _number = 10;

    void Method1()
    {
        Console.WriteLine($"Filed Number = {_number}");
    }
    void Method2()
    {
        Console.WriteLine($"Filed Number + 10 = {_number + 10}");
    }
    
    //Method scope

    void Method3()
    {
        int numberInMethod3 = 10;
        Console.WriteLine($"Test method scope: {numberInMethod3}");
    }

    void Method4()
    {
        //Console.WriteLine($"Test method3 scope: {numberInMethod3}");
        //This causes a compile error because numberInMethod3 is only accessible inside the Method3 block.
    }
    
    // For loop scope 

    void TryForScope()
    {
        for (int i = 0;i < 5; i++)
        {
            int currentIndex = i;
        }

        // int lastOndex = currentIndex;
        // This causes a compile error because currentIndex is only accessible inside the loop block.
        

    }
    
    #endregion

    #region D2 — Composite (compound assignment) operators

    static void CompoundAssignmentOperators()
    {
        Console.WriteLine("============================================");
        Console.WriteLine("Part D — Scope & Operators - D2");
        Console.WriteLine("============================================");
        int total = 100;
        //total = total + 100;
        Console.WriteLine($"total += 100 :  {total += 100}");
        //total = total - 50;
        Console.WriteLine($"total -= 50 :  {total -= 50}");
        //total = total * 2;
        Console.WriteLine($"total *= 2 :  {total *= 2}");
        //total = total / 2;
        Console.WriteLine($"total /= 2 :  {total /= 2}");
        //total = total % 10;
        Console.WriteLine($"total %= 10 :  {total %= 10}");
        
        
        
        
    }

    #endregion

    #region D3 — Bitwise operators (not logical operators)

    static void DemonstrateBitwiseOperators()
    {
        Console.WriteLine("============================================");
        Console.WriteLine("Part D — Scope & Operators - D3");
        Console.WriteLine("============================================");
        
        int a = 12;
        int b = 10;
        //1100 & 1010 = 1000 (8)
        Console.WriteLine($"a & b  = {a & b}");
        //1100 | 1010 = 1110 (14)
        Console.WriteLine($"a | b  = {a | b}");
        //1100 ^ 1010 = 0110 (6)
        Console.WriteLine($"a ^ b  = {a ^ b}");
        
        // &: checks both operands, but &&: if the left operand is false, it does not check the right operand.


        
    }

    #endregion

    #endregion
    
    


}