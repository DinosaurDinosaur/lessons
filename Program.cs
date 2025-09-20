int[] ints1= {1,2,3};
int[] ints2= new int[3]; // 0,0,0

Console.WriteLine("ints1 length is {0}", ints1.Length);
Console.WriteLine("ints1[1] is {0}",ints2[1]);

int[,] ints3 =
{
   {1,2,3},
   {4,5,6}

};

Console.WriteLine("ints3[1,1] is {0}", ints3[1,1]);
Console.WriteLine("ints3[1,2] is {0}", ints3[1,2]);

string[] s = 
{ 
    "string1",
    "string2",
    "string3",
    "string4",
};


// 在這裡宣告 ints5，只宣告一次
int[] ints5 = { 1, 2, 3 };

Console.WriteLine("For loop");

// 使用正確的變數名 ints5
for (int i = 0; i < ints5.Length; i++)
{
    // 使用正確的變數名 ints5
    Console.WriteLine("ints5[{0}] is {1}", i, ints5[i]);
}

Console.WriteLine("While loop");
int j =0;
while(true){
    Console.WriteLine("ints5[{0}] is {1}", j, ints5[j]);
    j++;
    if(j == ints5.Length) break;
}

Console.WriteLine("do......while loop");
int k = 0;
do {
    Console.WriteLine($"ints5[{k}] is {ints5[k]}");
    k++;
} while(k < ints5.Length);
// 01:28
Console.WriteLine("for loop, to print odd numbers");
// 修正：宣告 i 的型別
for (int i = 0; i < ints5.Length; i++) 
{
    // 如果是偶數，就跳過
    if (ints5[i] % 2 == 0) continue; 
    
    // 修正：使用正確的陣列名稱 ints5
    Console.WriteLine($"ints5[{i}] = {ints5[i]}");
}