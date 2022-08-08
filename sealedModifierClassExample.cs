class ParentClass
{
    //The "protected" keyword is a member access modifier.
    //A protected member is accessible within its class and by derived class instances.
    protected string myString = "Hello World";
}

class ChildClass : ParentClass
{
    static void Main()
    {
        var parentClass = new ParentClass();
        var childClass = new ChildClass();
        
        /*
            Error CS1540, because "myString" can only be accessed by classes derived from ParentClass.
            parentClass.myString = "Hi World";
        */

        // Ok because this class derives from ParentClass.
        childClass.myString = "Hi World";
        Console.Write(childClass.myString);
    }
    
}