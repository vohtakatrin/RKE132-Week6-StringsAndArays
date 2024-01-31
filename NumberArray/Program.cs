//int[] myNums = { 2, 3, 4 };
using System.Globalization;

int[] myNums = new int[10];
Random rnd = new Random();
//populating the array with a random numbers
int sum = 0;
for (int i = 0; i < myNums.Length; i++)
{
    myNums[i] = rnd.Next(1, myNums.Length +1 );
    sum = sum + myNums[i];
}
foreach (int element in myNums)
{
    Console.WriteLine(element);
}
Console.WriteLine($"Total: {sum}");

//int myNumsArrayLength = myNums.Length;
//Console.WriteLine($"Massiivi/kogumiku suurus on {myNums.Length}");
//myNums[0] = '2';
//myNums[1] = '3';
//myNums[2] = '4';

//Console.WriteLine($"Kogumikus on järgmised numbrid:{myNums[0]}, {myNums[1]}, {myNums[2]}");