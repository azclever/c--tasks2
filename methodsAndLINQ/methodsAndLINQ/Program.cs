// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Hello, World!");


// required Tasks 
Console.WriteLine("############# task 1 ###############");

static float CalculateAverage(int a, int b ,int c) { 

    return (a + b + c)/3;

}

Console.WriteLine(CalculateAverage(5,3,6));

Console.WriteLine("############# task 2 ###############");
List<string> names = new List<string>();
names.Add("ahmad");
names.Add("abd");
names.Add("ali");
names.Add("sara");
names.Add("mona");

foreach (String name in names) {
    Console.WriteLine(name);
}

names.Remove("sara");

Console.WriteLine("############# task 3 ###############");

Dictionary<int, string> students = new Dictionary<int, string>();

students.Add(1, "Ali");
students.Add(2, "Omar");
students.Add(3, "farah");

foreach (var item in students) {
    Console.WriteLine(item.Key + " - " + item.Value);
}

Console.WriteLine("############# task 4 ###############");

int[] numbers = { 5, 10, 15, 20, 25, 30 };
string[] namess = { "Ahmad", "Ali", "Sara", "Mona", "Omar" };

var graterThan15 = numbers.Where(n => n > 15);

foreach (var val in graterThan15)
{
    Console.WriteLine(val);
}


Console.WriteLine("# task 4.2 #");


var evenNumbers = numbers.Where(n => n %2 == 0 );

foreach (var val in evenNumbers)
{
    Console.WriteLine(val);
}


Console.WriteLine("# task 4.3 #");


var ascNumbers = numbers.OrderBy(n => n );

var desNumbers = numbers.OrderDescending();

foreach (var val in ascNumbers)
{
    Console.WriteLine(val);
}

Console.WriteLine();

foreach (var val in desNumbers)
{
    Console.WriteLine(val);
}


Console.WriteLine("# task 4.4 #");


var startWithA = namess.Where(n => n.StartsWith("A"));

foreach (var name in startWithA)
{
    Console.WriteLine(name);
}


Console.WriteLine("# task 4.5 #");

var graterThan10 = numbers.FirstOrDefault(n => n > 10);

    Console.WriteLine(graterThan10);



Console.WriteLine("# bounus #");

var multipliedBy2 = numbers.Select(n => n * 2);

foreach (var val in multipliedBy2)
{
    Console.WriteLine(val);
}

Console.WriteLine("############# task 5 ###############");

static void Welcome() {
    Console.WriteLine("welcome");
}

static void Greeting(String name) {
    Console.WriteLine("Hello" + name);
}

static void age(int age = 18)
{
    Console.WriteLine("your age is " + age);
}

static int summ(int a , int b)
{
    return a + b;
}

static void printArr(int[] arr) { 

    foreach (var i in arr) Console.Write(i +", ");

    Console.WriteLine();
}

Welcome();
Greeting("abd");
age();

Console.WriteLine(summ(5,3));

printArr([1, 3, 4, 2, 5]);



Console.WriteLine("welcome");


Console.WriteLine("##################################");
Console.WriteLine();

Console.WriteLine("########### section 1 ############");

Console.WriteLine();
Console.WriteLine("##################################");


List<int> listNumbers = new List<int>();

listNumbers.Add(5);
listNumbers.Add(4);
listNumbers.Add(8);
listNumbers.Add(9);
listNumbers.Add(9);
listNumbers.Add(2);
listNumbers.Add(2);


var evenNumList = listNumbers.Where(i => i %2 == 0).ToList();
printArr(evenNumList.ToArray());


Console.WriteLine("########### task 2 ############");

var nodublicate =  listNumbers.Distinct();

printArr(nodublicate.ToArray());

Console.WriteLine("########### task 3 ############");
var maxVal = listNumbers.Max();
Console.WriteLine(maxVal);

Console.WriteLine("########### task 4 ############");

var reversedVal = listNumbers.ToArray().Reverse();
printArr(reversedVal.ToArray());

Console.WriteLine("########### task 5 ############");

var numberGreaterThanX =  listNumbers.Where(i => i > 5).Count();
Console.WriteLine(numberGreaterThanX);

Console.WriteLine("##################################");
Console.WriteLine();
Console.WriteLine("########### section 2 ############");
Console.WriteLine();
Console.WriteLine("##################################");

static void printStringArr(String[] arr) {

    foreach (var el in arr) { 
        Console.Write(el + ", ");  
    }
    Console.WriteLine();
}
Dictionary<string, int> studentsDictionary = new Dictionary<string, int>();

studentsDictionary.Add("abd", 100);
studentsDictionary.Add("safa", 70);
studentsDictionary.Add("mohsen", 95);
studentsDictionary.Add("rashed", 45);

var studentsWith80 = studentsDictionary.Where(i => (i.Value > 80)).Select(i => i.Key);
printStringArr(studentsWith80.ToArray());


Console.WriteLine("########### task 7 ############");

Console.WriteLine("enter name");
try
{
    String name = Console.ReadLine();
    if (studentsDictionary.ContainsKey(name))
    {
        Console.WriteLine(studentsDictionary[name]);

    }
    else
    {
        Console.WriteLine("Not Found");


    }
}
catch (FormatException) {
    Console.WriteLine("inter student name");
}

Console.WriteLine("########### task 8 ############");

var totalScore = studentsDictionary.Values.Sum();
Console.WriteLine(totalScore);

Console.WriteLine("########### task 9 ############");

var studentLess50 = studentsDictionary.Where(i => i.Value < 50).ToDictionary().Keys;
foreach (var st in studentLess50) {
    studentsDictionary.Remove(st);
}
printStringArr(studentsDictionary.Keys.ToArray());

Console.WriteLine("########### task 10 ############");
Console.WriteLine(studentsDictionary.Values.ToArray().Max());

Console.WriteLine("##################################");
Console.WriteLine();
Console.WriteLine("########### section 3 ############");
Console.WriteLine();
Console.WriteLine("##################################");

Console.WriteLine("########### task 11 ############");

LinkedList<string> linkedlist = new LinkedList<string>();

linkedlist.AddFirst("node");
linkedlist.AddFirst("node");
linkedlist.AddFirst("node");
linkedlist.AddFirst("firstNode");
linkedlist.AddLast("lastNode");

Console.WriteLine("########### task 12 ############");

linkedlist.Remove(linkedlist.ElementAt(linkedlist.Count / 2));

Console.WriteLine("########### task 13 ############");

LinkedListNode<string> node = linkedlist.Find("node");
linkedlist.AddAfter(node, "addAfer");
linkedlist.AddBefore(node, "addBefore");

Console.WriteLine("########### task 14 ############");

LinkedListNode<string> current = linkedlist.First;

while (current != null)
{
    Console.WriteLine(current.Value);
    current = current.Next; // Move to the next node
}

Console.WriteLine("########### task 15 ############");
LinkedListNode<string> firstNode = linkedlist.First;
LinkedListNode<string> lastNode = linkedlist.Last;

Console.WriteLine(firstNode);
Console.WriteLine(lastNode);

Console.WriteLine("##################################");
Console.WriteLine();
Console.WriteLine("########### section 4 ############");
Console.WriteLine();
Console.WriteLine("##################################");

Console.WriteLine(listNumbers.Average());

Console.WriteLine("##################################");
Console.WriteLine();
Console.WriteLine("########### section 5 ############");
Console.WriteLine();
Console.WriteLine("##################################");

List<string> listOne = new List<string>();
List<string> listTwo = new List<string>();

listOne.Add("first");
listOne.Add("seconed");
listOne.Add("thired");
listOne.Add("fourth");

listTwo.Add("first");
listTwo.Add("seconed");
listTwo.Add("thired");
listTwo.Add("fourth");
listTwo.Add("fifth");
listTwo.Add("sixth");

var commonVal = listOne.Where(x => listTwo.Contains(x));

printStringArr(commonVal.ToArray());

Console.WriteLine("########### task 22 ############");

listOne.AddRange(listTwo);
printStringArr(listOne.ToArray());


Console.WriteLine("########### task 23 ############");

var nodublicate2 = listOne.Distinct();
printStringArr(nodublicate2.ToArray());

Console.WriteLine("########### task 24 ############");

printStringArr(studentsDictionary.Keys.ToArray());

Console.WriteLine("########### task 25 ############");

printStringArr(studentsWith80.ToArray());

Console.WriteLine("##################################");
Console.WriteLine();
Console.WriteLine("########### section 6 ############");
Console.WriteLine();
Console.WriteLine("##################################");


foreach (var item in listOne) {
    if (item.Equals("first")) {
        Console.WriteLine(item);
    }
}

Console.WriteLine("########### task 27 ############");
int evenCount =0;
foreach (var item in listNumbers)
{
    if (item % 2 == 0)
    {
        evenCount++;
    }
}
Console.WriteLine(evenCount);


Console.WriteLine("########### task 28 ############");

while (listTwo.Count > 0) { 
    listTwo.RemoveAt(0);
}
Console.WriteLine("########### task 29 ############");

int maxnumber = listNumbers[0];
int seconedMaxNumber = 0;
foreach (var item in listNumbers)
{
    if (item > maxnumber)
    {
        maxnumber = item;
    }
}

foreach (var item in listNumbers)
{
    if (item > seconedMaxNumber && seconedMaxNumber < maxnumber)
    {
        seconedMaxNumber = item;
    }
}

Console.WriteLine(seconedMaxNumber);

Console.WriteLine("##################################");
Console.WriteLine();
Console.WriteLine("##### Advanced Logic Taasks ######");
Console.WriteLine();
Console.WriteLine("##################################");

Dictionary<int , int> appearingNumbers = new Dictionary<int , int>();

int[] arrWithDublicate = { 1, 3, 2, 4, 2, 3, 7, 5, 2, 9, 2, 2 };

for (int i = 0; i < arrWithDublicate.Length; i++) {
    if (appearingNumbers.ContainsKey(arrWithDublicate[i]))
    {
        appearingNumbers[arrWithDublicate[i]]++;
    }
    else {
        appearingNumbers.Add(arrWithDublicate[i], 1);
    }
}
int keyIndex = 0;
int valueIndex = 0;
foreach (var item in appearingNumbers) {
    if (item.Value > valueIndex) { 
        valueIndex = item.Value;
        keyIndex = item.Key;
    }
}

Console.WriteLine($"The most number appeared is {keyIndex} with {valueIndex} times" );

Console.WriteLine("########### task 2 ############");
printArr(arrWithDublicate);
int numberOFRotate = 2;
for (int i = 0; i < numberOFRotate; i++) { 
    int tempRotate = arrWithDublicate[arrWithDublicate.Length-1];

    for (int j = 0; j < arrWithDublicate.Length-1; j++) {
            arrWithDublicate[arrWithDublicate.Length - 1 - j]= arrWithDublicate[arrWithDublicate.Length -2 -j];
    }
    arrWithDublicate[0]=tempRotate;
}
printArr(arrWithDublicate);

Console.WriteLine("########### task 3 ############");
Stack<int> stack = new Stack<int>();
int[] symmetricArr = { 1, 2, 3, 2, 1 };
for (int i = 0; i < symmetricArr.Length; i++)
{
        if (i < symmetricArr.Length / 2) {
            stack.Push(symmetricArr[i]);
        }

        if (symmetricArr.Length % 2 != 0) {
            if (i == symmetricArr.Length % 2) {
            continue;
            }
        }
        if (i > symmetricArr.Length / 2) {
        if (stack.Peek() == symmetricArr[i]) {
            stack.Pop();
        }
    
        }

}

Console.WriteLine(!stack.Any());


Console.WriteLine("########### task 4 ############");
int[] missingNumberArr = { 1, 2, 4, 5, 6 };

int missingNumber = 1;
//bool missingFound = false;
for (missingNumber =1 ; missingNumber < missingNumberArr.Length; missingNumber++) {

    if (missingNumberArr.Contains(missingNumber)) {
        continue;
    }
    else
    {
        break;
    }
} 

Console.WriteLine(missingNumber);

Console.WriteLine("########### task 5 ############");

int sumOfTheArr = listNumbers.Sum();
List<int> firstSplit = new List<int>();
List<int> secondSplit = new List<int>();
int sumForSplit = 0;
int correctIndexForSplit =0;

for (int i = 0; i < listNumbers.Count(); i++) { 
    sumForSplit += listNumbers[i];
    if (sumForSplit >= sumOfTheArr / 2) {
        correctIndexForSplit = i;
        break;
    }
}


firstSplit= listNumbers.Slice(0, correctIndexForSplit);
secondSplit= listNumbers.Slice(correctIndexForSplit, listNumbers.Count() - correctIndexForSplit);

printArr(listNumbers.ToArray());
printArr(firstSplit.ToArray());
printArr(secondSplit.ToArray());

Console.WriteLine("########### task 6 ############");


int[] increasingSequenceArr = { 1, 2, 2, 3, 4, 1, 2, 3 };
int longestSequence = 0;
int indexOflongestSequence = 0;
int tempLongestSequence = 0;
for (int i = 0; i < increasingSequenceArr.Length-1; i++) {
    if (increasingSequenceArr[i] == increasingSequenceArr[i + 1] - 1)
    {
        tempLongestSequence++;
    }
    else {
        if (tempLongestSequence > longestSequence) { 
            longestSequence = tempLongestSequence;
            indexOflongestSequence= i - longestSequence;
        }
    }
}

for (int i = indexOflongestSequence +1; i <= indexOflongestSequence + longestSequence; i++) {
    Console.Write(increasingSequenceArr[i] + ", ");
}
Console.WriteLine();

Console.WriteLine("########### task 7 ############");

int[] duplicateDistanceArr = { 1, 2, 3, 1, 4, 2, 1 };
int shortestDistance = duplicateDistanceArr.Length;
int valueOfshortestDistance = 0;
for (int i = 0; i < duplicateDistanceArr.Length -1; i++)
{
    for (int j = i+1; j < duplicateDistanceArr.Length; j++) {
        
        if (duplicateDistanceArr[i] == duplicateDistanceArr[j])
        {
            if (shortestDistance > j - i) {
                shortestDistance = j-i;
                valueOfshortestDistance = duplicateDistanceArr[i];
            } 
            break;
        }

    }
   
}

Console.Write("shortest distance of " +valueOfshortestDistance + " = " + shortestDistance);
Console.WriteLine();

Console.WriteLine("########### task 8 ############");

Queue<int> evenQueue = new Queue<int>();
Queue<int> oddQueue = new Queue<int>();

for (int i = 0; i < duplicateDistanceArr.Length; i++) {
    if (duplicateDistanceArr[i] % 2 == 0)
    {
        evenQueue.Enqueue(duplicateDistanceArr[i]);
    }
    else { 
        oddQueue.Enqueue(duplicateDistanceArr[i]);
    }   

}

int[] resultArr = evenQueue.Concat(oddQueue).ToArray();

printArr(resultArr);
Console.WriteLine("########### task 9 ############");

List<int> peaks = new List<int>();
int[] peakArr = { 1, 3, 2, 4, 1 };

for (int i = 1; i < peakArr.Length - 1; i++) {
    if (peakArr[i] > peakArr[i - 1] && peakArr[i] > peakArr[i + 1]) { 
        peaks.Add(peakArr[i]);
    }
}

printArr(peaks.ToArray());

Console.WriteLine("########### task 10 ############");

int target = 7;
int fisrtNumberOftarget=0;
int secondNumberOftarget=0;

for (int i = 0; i < duplicateDistanceArr.Length; i++) {

    if (duplicateDistanceArr.Contains(target - duplicateDistanceArr[i])) {
        fisrtNumberOftarget= i;
        secondNumberOftarget = target - i;
    }
}

Console.WriteLine($"the target is {target}, the first number is {fisrtNumberOftarget} and the second number is {secondNumberOftarget}");

Console.WriteLine("########### task 11 ############");

int[] shiftZerosArr = { 0, 1, 0, 3, 12 };

Queue<int> zerosQueue = new Queue<int>();
Queue<int> noZerosQueue = new Queue<int>();

foreach (int el in shiftZerosArr) {
    if (el == 0)
    {
        zerosQueue.Enqueue(el);
    }
    else { 
        noZerosQueue.Enqueue(el);
    }

}

printArr(noZerosQueue.Concat(zerosQueue).ToArray());

Console.WriteLine("########### task 12 ############");

int[] alternatingMergeArrOne = { 1, 2, 3 };
int[] alternatingMergeArrTwo = { 4, 5, 6 };
int[] alternatingMergeArr = new int[alternatingMergeArrOne.Length + alternatingMergeArrTwo.Length];
int alternatingIndexOne=0, alternatingIndexTwo=0;
for (int i = 0; i < alternatingMergeArr.Length;) {

    alternatingMergeArr[i++] = alternatingMergeArrOne[alternatingIndexOne++];
    alternatingMergeArr[i++] = alternatingMergeArrTwo[alternatingIndexTwo++];
}

printArr(alternatingMergeArr);

Console.WriteLine("########### task 13 ############");
Console.WriteLine("########### ch ############");

int[] countFrequenciesArr = { 4, 2, 4, 3, 2, 4, 1 };
bool[] visited = new bool[countFrequenciesArr.Length];

for (int i = 0; i < countFrequenciesArr.Length; i++)
{
    if (visited[i]) continue;

    int count = 1;

    for (int j = i + 1; j < countFrequenciesArr.Length; j++)
    {
        if (countFrequenciesArr[i] == countFrequenciesArr[j])
        {
            count++;
            visited[j] = true;
        }
    }

    Console.WriteLine($"{countFrequenciesArr[i]} appears {count} times");
}

Console.WriteLine("########### task 14 ############");

int maximumNumber = 0;
int secondMaximumNumber = 0;

for (int i = 0; i < countFrequenciesArr.Length; i++) {
    if (countFrequenciesArr[i] > maximumNumber) { 
        maximumNumber = countFrequenciesArr[i];
    }
}

for (int i = 0; i < countFrequenciesArr.Length; i++)
{
    if (countFrequenciesArr[i] > secondMaximumNumber && countFrequenciesArr[i] < maximumNumber)
    {
        secondMaximumNumber = countFrequenciesArr[i];
    }
}

Console.WriteLine(secondMaximumNumber);

Console.WriteLine("########### task 15 ############");
Queue<int> subarrySum = new Queue<int>();
int targetNum = 12;
int[] targetArr = { 1, 2, 3, 7, 5 };

for (int i = 0; i < targetArr.Length; i++) { 
    subarrySum.Enqueue(targetArr[i]);

    while (subarrySum.Sum() > targetNum)
    {
        subarrySum.Dequeue();
    }
    if (subarrySum.Sum() == targetNum) {
        printArr(subarrySum.ToArray());
        break;
    }
}

Console.WriteLine("########### task 16 ############");

int[] reversePartArr = { 1, 2, 3, 4, 5 };

int leftPoint = 1;
int rightPoint = 3;

while (leftPoint < rightPoint)
{
    int temp = reversePartArr[leftPoint];
    reversePartArr[leftPoint] = reversePartArr[rightPoint];
    reversePartArr[rightPoint] = temp;

    leftPoint++;
    rightPoint--;
}

printArr(reversePartArr);

Console.WriteLine("########### task 17 ############");

int MinSwapsSimple(int[] arr)
{
    int swaps = 0;

    // Create a sorted copy
    int[] sorted = (int[])arr.Clone();
    Array.Sort(sorted);

    for (int i = 0; i < arr.Length; i++)
    {
        // if already correct → skip
        if (arr[i] == sorted[i])
            continue;

        // find where the correct element is
        int correctIndex = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] == sorted[i])
            {
                correctIndex = j;
                break;
            }
        }

        // swap
        int temp = arr[i];
        arr[i] = arr[correctIndex];
        arr[correctIndex] = temp;

        swaps++;
    }

    return swaps;
}

Console.WriteLine(MinSwapsSimple(increasingSequenceArr));

Console.WriteLine("########### task 18 ############");

int[] trickyReorderingArr = { 1, 2, 3, 4, 5 };

Array.Sort(trickyReorderingArr);

int[] trickyReorderingResultArr = new int[trickyReorderingArr.Length];

int trickyReorderingLeftIndex = 0;
int trickyReorderingRightIndex = trickyReorderingArr.Length - 1;
int trickyReorderingIndex = 0;

while (trickyReorderingLeftIndex < trickyReorderingRightIndex)
{
    // smallest
    trickyReorderingResultArr[trickyReorderingIndex++] =
        trickyReorderingArr[trickyReorderingLeftIndex++];

    // largest
    trickyReorderingResultArr[trickyReorderingIndex++] =
        trickyReorderingArr[trickyReorderingRightIndex--];
}

// handle middle element (if odd length)
if (trickyReorderingLeftIndex == trickyReorderingRightIndex)
{
    trickyReorderingResultArr[trickyReorderingIndex] =
        trickyReorderingArr[trickyReorderingLeftIndex];
}
printArr(trickyReorderingResultArr);

Console.WriteLine("########### task 19 ############");

int[] longestPatternArr = { 1, 2, 1, 2, 1, 3 };

int n = longestPatternArr.Length;

int left = 1;
int right = n / 2;

int bestLen = 0;
int bestStart = -1;

while (left <= right)
{
    int mid = (left + right) / 2;

    int startIndex = FindRepeated(longestPatternArr, mid);

    if (startIndex != -1)
    {
        bestLen = mid;
        bestStart = startIndex;
        left = mid + 1;
    }
    else
    {
        right = mid - 1;
    }
}

// print result
if (bestStart != -1)
{
    for (int i = 0; i < bestLen; i++)
    {
        Console.Write(longestPatternArr[bestStart + i] + " ");
    }
}

int FindRepeated(int[] longestPatternArr, int len)
{
    if (len == 0) return -1;

    long hash = 0;
    long baseVal = 1000003;
    long mod = 1000000007;

    long power = 1;

    for (int i = 0; i < len - 1; i++)
        power = (power * baseVal) % mod;

    HashSet<long> seen = new HashSet<long>();

    for (int i = 0; i < len; i++)
        hash = (hash * baseVal + longestPatternArr[i]) % mod;

    seen.Add(hash);

    for (int i = len; i < longestPatternArr.Length; i++)
    {
        hash = (hash - longestPatternArr[i - len] * power % mod + mod) % mod;
        hash = (hash * baseVal + longestPatternArr[i]) % mod;

        if (seen.Contains(hash))
            return i - len + 1;

        seen.Add(hash);
    }

    return -1;
}


Console.WriteLine("########### task 20 ############");
//int[] inputArr = { 1, 2, 3, 2, 4, 2, 5 };
//int removeValue = 2;

//List<int> temp = new List<int>();

//for (int i = 0; i < inputArr.Length; i++)
//{
//    if (inputArr[i] != removeValue)
//    {
//        temp.Add(inputArr[i]);
//    }s
//}

//int[] resultDeletedArr = temp.ToArray();
//printArr(resultDeletedArr);
