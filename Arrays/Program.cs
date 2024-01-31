//massiv - heap

//string[] fruit = { "apple", "banana", "orange" };// string []- andme kogumik
using System;

string[] fruit = new string[3]; //koht salvestamiseks [0] [1] [2] 
fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";
Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArrayLength = fruit.Length;
Console.WriteLine($"Massiivi/kogumiku suurus on {fruit.Length}");

for (int i = 0; i < fruitArrayLength; i++) //can replace
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}
//foreach (string element in fruit) //cant replace
//{
//    Console.WriteLine(element);
//}

