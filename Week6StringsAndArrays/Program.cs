
string hello = "hello, world! ";   //suured andmed   heapis


int stringLength = hello.Length;
string trimmedString = hello.Trim(); // .Trim  removes juhuslikud tühikud enne ja pärast sõnu
//Console.WriteLine(stringLength);  // =14


hello = hello.Trim(); //Selle käsuga kustutakse mälust 2 rida tühikutega, ja salvestakse uus väärtus
char firstLetter = hello[0];  //kuvamine, millega hakkame tööd tegema
Console.WriteLine(firstLetter); //=h
hello = hello.Replace(hello[0], 'H');  // hello = hello.Replace(hello[0], char.ToUpper(hello[0])) SAAB MUUTUDA 2 rea lause
//ello = hello.Replace(hello[0], char.ToUpper(hello[0])).REPLACE('', '') -||-||-||-||-
firstLetter = hello[0]; 
Console.WriteLine(firstLetter);//=H
Console.WriteLine(hello); //=Hello world!

//int wordCounter = 1; //1!

//for (int i = 0; i < hello.Length; i++)
////{
////    Console.WriteLine($"{i} symbol in string: {hello[i]}");
////}
//{
//    if (hello[i] == ' ')
//    {
//        wordCounter++;
//    }
//}
//Console.WriteLine($"Word count in {hello}: {wordCounter} words");

//for (int i = 0; i < hello.Length; i++)
//{
//    if (char.IsWhiteSpace(hello[i]))  //kontrollib kas sümbol on tühik või mitte --> true/false
//    {
//         wordCounter++;
//    }

//}
//Console.WriteLine($"Word count in {hello}: {wordCounter} words");

//Console.WriteLine(trimmedString.Length); // =13

// "hello"  ---> 5
// h - [0]
// e - [1]
// l - [2]
// l - [3] 
// o - [4] viimane täht [lenght -1]