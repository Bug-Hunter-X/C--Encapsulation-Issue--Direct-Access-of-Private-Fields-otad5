public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // Accessing the field directly from another method in the same class
        int temp = _myField; 
        //This might work as intended, but it's a bad practice because it breaks encapsulation and makes the code harder to maintain and debug.
    }
}