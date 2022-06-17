
Console.Clear();

string[] myArray1 = new string[6] { "1,2,3,4", "2", "hello", "world", "res", ":-)"};
string[] myArray2 = new string[myArray1.Length];
void TwoArrayFill(string[] myArray1, string[] myArray2)
{
    int count = 0;
    for (int i = 0; i < myArray1.Length; i++)
    {
    if(myArray1[i].Length <= 3)
        {
        myArray2[count] = myArray1[i];
        count++;
        }
    }
}
void PrintArray(string[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"{myArray[i]} ");
    }
    Console.WriteLine();
}


TwoArrayFill(myArray1, myArray2);
PrintArray(myArray2);