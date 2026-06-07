using System.Runtime.InteropServices;

string? userInput;
int[] arrNum;
/* 
 * 習題 5-1：寫一程式，將 10 個數字，讀入 A 陣列，然後逐一檢查此陣列。如 A[i] > 5，則令 A[i] = A[i] - 5，否則 A[i] = A[i] + 5。
 */
//Console.WriteLine("請輸入 10 個整數");
//Console.WriteLine("-----");
//int N = 10;
//arrNum = new int[N];
//int count = 0;
//while(N > 0) {
//    int num;
//    Console.Write($"第 {count + 1} 個數：");
//    userInput = Console.ReadLine();
//    _ = int.TryParse(userInput, out num);    
//    arrNum[count] = num;
//    count++;
//    N--;
//}
//Console.WriteLine();
//for (int i = 0; i < arrNum.Length; i++) {
//    if (arrNum[i] > 5) {
//        arrNum[i] = arrNum[i] - 5;
//    } else {

//        arrNum[i] = arrNum[i] + 5;
//    }
//}
//Console.WriteLine();
//bool firstLoop = true;
//int countNum = 0;
//foreach (int num in arrNum) {
//    if (num > 5 && firstLoop) {
//        Console.Write("A[i] > 5 的有：");
//        firstLoop = false;
//    }
//    if (num < 5 && !firstLoop) {
//        Console.WriteLine();
//        Console.WriteLine();
//        countNum = 0;
//        Console.Write("A[i] < 5 的有：");
//        firstLoop = true;
//    }
//    if(countNum == 1) {
//        Console.Write("、".ToString().PadRight(2));
//        Console.Write(num.ToString());
//    }    
//    if(countNum == 0) {
//        Console.Write(num.ToString());
//        countNum = 1;
//    }
//}
//Console.WriteLine();

/* 
 * 習題 5-2：寫一程式，將 10 個數字，讀入 A 陣列，對每一個數字，令 A[i] = A[i] + i。
 */
//Console.WriteLine("此程式，可計算陣列之元素與其所在的位置之索引值之和，並將其結果，再次指派給相同索引值之位置。");
//Console.WriteLine("請輸入 10 個整數");
//Console.WriteLine("-----");
//int N = 10;
//arrNum = new int[N];
//int count = 0;
//while (N > 0) {
//    int num;
//    Console.Write($"第 {count + 1} 個數：");
//    userInput = Console.ReadLine();
//    _ = int.TryParse(userInput, out num);
//    arrNum[count] = num;
//    count++;
//    N--;
//}
//for (int i = 0; i < arrNum.Length; i++) {
//    arrNum[i] = arrNum[i] + i;
//}
//int countNum = 0;
//Console.WriteLine();
//Console.Write("陣列各索引的最終之元素值為：");
//foreach (int num in arrNum) {
//    if (countNum == 1) {
//        Console.Write("、".ToString().PadRight(2));
//        Console.Write(num.ToString());
//    }
//    if (countNum == 0) {
//        Console.Write(num.ToString());
//        countNum = 1;
//    }
//}
//Console.WriteLine();

/* 
 * 習題 5-3：寫一程式，將 10 個數字，讀入 A 陣列，並建立一個 B 陣列，如 A[i] >= 0，令 B[i] = 1，否則令 B[i] = 0。
 */
//Console.WriteLine("此程式，可判斷 A 陣列的某索引，其值是否大於或等於零，並根據其是否大於或等於零，對 B 陣列相同之索引，指派相應之元素值。");
//Console.WriteLine("若 A 陣列的某索引值之元素值大於或等於零，則 B 陣列相同索引之元素，其值為 1，否則為 0。");
//Console.WriteLine("A 陣列與 B 陣列，各自可儲存 10 個整數值。");
//Console.WriteLine("-----");
//Console.WriteLine("請輸入 10 個整數");
//Console.WriteLine("-----");
//int N = 10;
//int[] arrNumA = new int[N];
//int[] arrNumB = new int[N];
//int count = 0;
//while (N > 0) {
//    int num;
//    Console.Write($"第 {count + 1} 個數：");
//    userInput = Console.ReadLine();
//    _ = int.TryParse(userInput, out num);
//    arrNumA[count] = num;
//    count++;
//    N--;
//}
//for (int i = 0; i < arrNumA.Length; i++) {
//    if (arrNumA[i] >= 0) {
//        arrNumB[i] = 1;
//    } else {
//        arrNumB[i] = 0;
//    }
    
//}
//int countNum = 0;
//Console.WriteLine();
//Console.Write("B 陣列，各索引的最終之元素值為：");
//foreach (int num in arrNumB) {
//    if (countNum == 1) {
//        Console.Write("、".ToString().PadRight(2));
//        Console.Write(num.ToString());
//    }
//    if (countNum == 0) {
//        Console.Write(num.ToString());
//        countNum = 1;
//    }
//}
//Console.WriteLine();

/* 
 * 習題 5-4：寫一程式，將 15 個數字，存入 3 x 5 的二維陣列 A 中，求每一行及每一列數字的和。
 */
int column = 5;
int row = 3;
int[,] arrNum2D = new int[row, column];
Console.WriteLine("此程式，可對某二維陣列的列和行，分別計算其同列之總和及同行之總和。");
Console.WriteLine("此二維陣列，可儲存 15 個整數值。");
Console.WriteLine("-----");
Console.WriteLine("請輸入 15 個整數");
Console.WriteLine("-----");
int N = 15;
int rowloop = 0;
int columnloop = 0;
while (N > 0) {
    Console.WriteLine($"當前是第 {rowloop + 1} 列，第 {columnloop + 1} 行。");
    int num;
    Console.Write($"第 {15 - (N - 1)} 個數：");
    userInput = Console.ReadLine();
    _ = int.TryParse(userInput, out num);
    if (((columnloop + 1) % column) == 0) {
        arrNum2D[rowloop, columnloop] = num;
        rowloop++;
        columnloop = 0;
        N--;
        continue;
    }
    arrNum2D[rowloop, columnloop] = num;
    columnloop++;
    N--;
}
Console.WriteLine();
int sumRow = 0;
int sumRowPre = 0;
for (int i = 0; i < row; i++) {
    sumRowPre = sumRow;
    for (int j = 0; j < column; j++) {
        sumRow += arrNum2D[i, j];        
    }
    sumRow -= sumRowPre;
    Console.WriteLine($"第 {i + 1} 列的總和為：{sumRow}");   
}
int sumColumn = 0;
int sumColumnPre = 0;
columnloop = 0;
while (columnloop < 5) {
    sumColumnPre = sumColumn;
    for (int i = 0; i < row; i++) {
        sumColumn += arrNum2D[i, columnloop];
    }
    sumColumn -= sumColumnPre;
    Console.WriteLine($"第 {columnloop} 行的總和為：{sumColumn}");
    columnloop++;
}
Console.WriteLine();




