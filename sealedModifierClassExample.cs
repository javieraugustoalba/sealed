class ParentClass
{
    protected virtual void FunctionOne() { Console.WriteLine("ParentClass.FunctionOne"); }
    protected virtual void FunctionTwo() { Console.WriteLine("ParentClass.FunctionTwo"); }
}

class ChildClass : ParentClass
{
    sealed protected override void FunctionOne() { Console.WriteLine("ChildClass.FunctionOne"); }
    protected override void FunctionTwo() { Console.WriteLine("ChildClass.FunctionTwo"); }
}

class AdditionalClass : ChildClass
{
    // Attempting to override FunctionOne causes compiler error CS0239. because FunctionOne is protected
    // protected override void FunctionOne() { Console.WriteLine("AdditionalClass.FunctionOne"); }

    // Overriding FunctionTwo is allowed.
    protected override void FunctionTwo() { Console.WriteLine("Z.FunctionTwo"); }
}


//The Good Guy
//the sealed modifier prevents other classes from inheriting from it

sealed class SealedClass
{
    public int x;
    public int y;
}

class SealedTest2
{
    static void Main()
    {
        //Sealed class can't inherit but can instanced. 
        var sc = new SealedClass();
        sc.x = 110;
        sc.y = 150;
        Console.WriteLine($"x = {sc.x}, y = {sc.y}");
    }
}
// Output: x = 110, y = 150