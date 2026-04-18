// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");


int n = 5;
for (int i = 1; i <= n; i++) {

    if (i % 2 == 0)
    {
        for (int j = i; j >= 1; j--)
        {
            Console.Write(j);
            

        }
        Console.WriteLine(" ");
    }
    else {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(j);
            

        }
        Console.WriteLine(" ");
    }

}
Console.WriteLine("########## task 2 #############");


for (int i = 1; i <= n; i++) {
    

    for (int j = 1; j <= i; j++) {
        Console.Write(j);
    }

    Console.Write(" ");

    for (int j = i; j >= 1; j--)
    {
        Console.Write(j);
    }
    Console.WriteLine(" ");

}


Console.WriteLine("########## task 3 #############");


for (int i = 1; i <= n; i++)
{

    for (int z = 0; z < (n - i); z++)
    {
    Console.Write(" ");

}

for (int j = 1; j < i; j++)
    {
        Console.Write(j);
    }
   
    //Console.Write(" ");

    for (int j = i; j >= 1; j--)
    {
        Console.Write(j);
    }
    Console.WriteLine(" ");

}


Console.WriteLine("########## task 4 #############");


for (int i = 1; i <= n; i++)
{

    for (int j = 1; j <= (2 * i - 1); j+=2)
    {
            Console.Write(j);  
    }

    Console.WriteLine(" ");

}


Console.WriteLine("########## task 5 #############");

int one = 1;
for (int i = 1; i <= n; i++)
{

    for (int j = 1; j <=i; j ++)
    {
        Console.Write( one + " ");
    }

    Console.WriteLine(" ");
    one *= 2;
}

Console.WriteLine("########## task 6 #############");

for (int i = 1; i <= n; i++)
{

    if (i % 2 == 0)
    {
        for (int j = i; j >= 1; j--)
        {
            Console.Write(j);


        }
        Console.WriteLine(" ");
    }
    else
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(j);


        }
        Console.WriteLine(" ");
    }

}

Console.WriteLine("########## task 7 #############");


//for (int i = 1; i <= n; i++)
//{

//    if (i == n)
//    {
//        for (int j = 1; j <= n; j++)
//        {
//            Console.Write(1);
//        }

//    }
//    else {

//        for (int j = 1; j <= i; j++)
//        {
//            if (j == 1)
//            {
//                Console.Write(1);
//            }
//            else if (j == i)
//            {
//                Console.Write(1);
//            }
//            else { 
//                Console.Write(" ");
//            }
//        }
//    }

//    Console.WriteLine(" ");
//}



for (int i = 1; i <= n; i++)
{

    if (i == n)
    {

        for (int j = 1; j < i; j++)
        {
            Console.Write(1);
        }

        for (int j = i; j >= 1; j--)
        {
            Console.Write(1);
        }


    }
    else { 

        for (int z = 0; z < (n - i); z++)
        {
            Console.Write(" ");

        }

    for (int j = 1; j < i; j++)
    {
        if (j == 1)
        {
            Console.Write(1);
        }
        else {
            Console.Write(" ");
        }
    }

    //Console.Write(" ");

    for (int j = i; j >= 1; j--)
    {
        if (j == 1)
        {
            Console.Write(1);
        }
        else
        {
            Console.Write(" ");
        }
    }

    }
    Console.WriteLine(" ");

}


Console.WriteLine("########## task 8 #############");





Console.WriteLine("########## task 9 #############");
int ink =1;
for (int i = 1; i <= n; i++)
{

    for (int j = 0; j < i; j++)
    {
        Console.Write(ink++ + " ");
    }

    Console.WriteLine(" ");

}

Console.WriteLine("########## task 10 #############");


for (int i = 1; i <= n; i++)
{

    if (i == n)
    {
        for (int j = 1; j <= n; j++)
        {
            Console.Write(1);
        }

    }
    else
    {

        for (int j = 1; j <= i; j++)
        {
            if (j == 1)
            {
                Console.Write(1);
            }
            else if (j == i)
            {
                Console.Write(1);
            }
            else
            {
                Console.Write(" ");
            }
        }
    }

    Console.WriteLine(" ");
}





Console.WriteLine("########## array task 1  #############");

void printArr(int[] arr) {

    foreach (int el in arr) { 
        Console.Write(el + ", ");
    }
    Console.WriteLine();

}

void printArrstr(string[] arr)
{

    foreach (string el in arr)
    {
        Console.Write(el + ", ");
    }
    Console.WriteLine();

}


int[] arr = [1, 2, 1, 3, 4];

int[] newArr = new int[arr.Length];
int ind = 0;
for (int i = 0; i < arr.Length; i++) {

    if (newArr.Contains(arr[i])) {
        break;
    }
    newArr[ind++] = arr[i];

}
Array.Resize(ref newArr, ind);
printArr(newArr);


Console.WriteLine("########## array task 2  #############");

int[] arr2 = { 1, 2, 1, 2, 1, 2 };

int[] accArr = new int[arr.Length];
int[] rejArr = new int[arr.Length];


int accind = 0;
int rejind = 0;

int currentindex = 0;

for (int i = 0; i < arr2.Length - 1; i++)
{
    int space = 0;
    int j =0;

    if (accArr.Contains(arr2[i]) || rejArr.Contains(arr2[i])) {
        continue;
    }

    for (j = i + 1; j < arr2.Length; j++)
    {
        if (arr2[j] == arr2[i])
        {
            if (space == 0)
            {
                space = j - i;
                currentindex = j;
            }
            else
            {
                if (space != j - currentindex)
                {
                    rejArr[rejind++] = arr[i];
                    break;
                }
                
                currentindex = i;
            }


        }

    }
    if (j >= arr2.Length) {

            accArr[accind++] = arr2[i];
    }
}

Array.Resize(ref accArr, accind);
printArr(accArr);

Console.WriteLine("reg");

Array.Resize(ref rejArr, rejind);
printArr(rejArr);



Console.WriteLine("########## array task 3  #############");

//int[][] jaggedArray = new int[sblitArr.Length][];

int[] sblitArr = { 1, 1, 2, 2, 3, 1 };

string[] strArray = new string[sblitArr.Length];

int start = 0;
int index = 0;

for (int i = 1; i < sblitArr.Length; i++)
{
    if (sblitArr[i] != sblitArr[i - 1])
    {
        // build chunk from start → i-1
        string chunk = "";

        for (int j = start; j < i; j++)
        {
            chunk += sblitArr[j] + " ";
        }

        strArray[index++] = chunk.Trim();
        start = i;
    }
}


string lastChunk = "";
for (int j = start; j < sblitArr.Length; j++)
{
    lastChunk += sblitArr[j] + " ";
}
strArray[index++] = lastChunk.Trim();

Array.Resize(ref strArray, index);
printArrstr(strArray);



Console.WriteLine("########## array task 4  #############");

int[] almostSorted = { 1, 3, 2, 4 };
int swaped = 0;
int tem = 0;
bool isSwap = true;
for (int i = 1; i < almostSorted.Length; i++) {
    if (almostSorted[i] < almostSorted[i - 1]) {
        swaped++;
        if (swaped > 1) {
            isSwap=false;
            break;
        }
        tem=almostSorted[i];
        almostSorted[i] = almostSorted[i - 1];
        almostSorted[i - 1] =tem;

        if (almostSorted[i - 1] < almostSorted[i - 2]) {
            isSwap = false;
            break;
        }
    }
    

}

Console.WriteLine(isSwap);


Console.WriteLine("########## array task 5  #############");

int [] longestStableSegment = { 1, 2, 2, 3, 1, 2 };

//int[][] jaggedArray = new int[longestStableSegment.Length][];

int longestStableSegmentStartInd =0;
int longestStableSegmentStartMaxLength = 0;

for (int i =1; i< longestStableSegment.Length;i++) {
    if (longestStableSegment[i - 1] == longestStableSegment[i] - 1 || longestStableSegment[i - 1] == longestStableSegment[i] + 1 || longestStableSegment[i - 1] == longestStableSegment[i])
    {
        continue;
    }
    else {

        if (i - longestStableSegmentStartInd > longestStableSegmentStartMaxLength) { 
            longestStableSegmentStartMaxLength=i - longestStableSegmentStartInd;
        }

        longestStableSegmentStartInd = i;
    }

}

Console.WriteLine(longestStableSegmentStartMaxLength);



Console.WriteLine("########## array task 6  #############");

int[] dublicateWindowArray = { 1, 2, 3, 2, 4 };

int dublicateWindowArrayMinStartInd = 0;
int dublicateWindowArrayMinEndInd = dublicateWindowArray.Length;

for (int i = 0; i < dublicateWindowArray.Length -1; i++) {

    for (int j = i + 1; j < dublicateWindowArray.Length; j++) {
        if (dublicateWindowArray[i] == dublicateWindowArray[j]) {
            if (j - i < dublicateWindowArrayMinEndInd - dublicateWindowArrayMinStartInd) {
                dublicateWindowArrayMinEndInd = j;
                dublicateWindowArrayMinStartInd = i;
            }

        }
    }

}

for (int i = dublicateWindowArrayMinStartInd; i <= dublicateWindowArrayMinEndInd ; i++) {

    Console.Write(dublicateWindowArray[i] + ", ");
}

Console.WriteLine();

Console.WriteLine("########## array task 7  #############");

int[] progressiveDifference = { 5, 7, 10 };
int[] newProgressiveDifference = new int[progressiveDifference.Length];
newProgressiveDifference[0] = progressiveDifference[0];
for (int i = 1; i < progressiveDifference.Length; i++) {
    newProgressiveDifference[i] = progressiveDifference[i] - progressiveDifference[i - 1];
}

printArr(newProgressiveDifference);

Console.WriteLine("########## array task 8  #############");


Console.WriteLine("########## array task 9  #############");


Console.WriteLine("########## array task 10  #############");

int[] hiddenIncreasingSequence = {3, 1, 2, 5, 4, 6};
int[] sequenceArr = new int[hiddenIncreasingSequence.Length] ;
int val = hiddenIncreasingSequence[0];

for (int i = 0; i < hiddenIncreasingSequence.Length; i++)
{
    sequenceArr[i] = 1;
}

    for (int i = 1; i < hiddenIncreasingSequence.Length; i++) {
    
        for(int j = 0; j < i; j++)
    {

    if (hiddenIncreasingSequence[j] < hiddenIncreasingSequence[i])
    {
            sequenceArr[i]= Math.Max(sequenceArr[i], sequenceArr[j] + 1);


    }

    }
}

Console.WriteLine(sequenceArr.Max());


Console.WriteLine("########## String task 1  #############");


String str = "aAbBcC";

for (int i = 1; i < str.Length; i++)
{
    if (str[i - 1] != str[i] && str[i - 1].ToString().ToLower() != str[i].ToString().ToLower())
    {
        
        str= str.Remove(i, 2);
        i = Math.Max(0, i - 2);

       

    }


   


}

Console.WriteLine(str.Length);

if (str.Length == 2)
{
    if (str[0] != str[1] && str[0].ToString().ToLower() == str[1].ToString().ToLower())
    {
        str = " ";
    }
}

Console.WriteLine(str);


Console.WriteLine("########## String task 2  #############");

Console.WriteLine("########## String task 3  #############");

String str2 = "aabbcb";

char[] chars = str2.ToCharArray();

for (int i = 1; i < chars.Length; i++)
{
    if (chars[i - 1] == chars[i])
    {

        chars[i - 1] = char.ToLower(chars[i - 1]);
        chars[i] = char.ToUpper(chars[i]);
    }

}

foreach (char c in chars)
{
    Console.WriteLine(c);

}
