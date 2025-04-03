// See https://aka.ms/new-console-template for more information

//Step 2: Instantiate a delegate
using C_sharpConcepts;

DelegateClass delegateClass = new DelegateClass();
AddDelegates add = delegateClass.AddNum;
AddDelegates add2 = delegateClass.Multiply;
add(3, 7); //calling a delegate method
add.Invoke(3, 7);

//multicast delegate: using one delegate we can access multiple methods
//multicast delegate holds the reference of multiple methods4
add2(2, 3);


//anonymous delegates
PrintMessage Print = delegate (string mssg)
{
    Console.Write(mssg);
};

Print("This is an anonymous delegate");
