string? userInput;
int[] arrNum;
/* 
 * 習題 5-1：寫一程式，將 10 個數字，讀入 A 陣列，然後逐一檢查此陣列。如 A[i] > 5，則令 A[i] = A[i] - 5，否則 A[i] = A[i] + 5。
 */
//Console.WriteLine("此程式，可逐一檢查某一陣列裡的元素值，並觀其值是否大於 5。若是則 -5，否則 + 5。");
//Console.WriteLine("請輸入 10 個整數");
//Console.WriteLine("-----");
//Console.WriteLine();
//Console.WriteLine();
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
 * 習題 5-2：寫一程式，將 10 個數字，讀入 A 陣列，對每一個數字，令 A[i] = A[i] + i。
 */
//Console.WriteLine("此程式，可計算陣列之元素值與其所在的位置之索引值之和，並將其結果，再次指派給相同索引值之位置。");
//Console.WriteLine("請輸入 10 個整數");
//Console.WriteLine("-----");
//Console.WriteLine();
//Console.WriteLine();
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
//Console.WriteLine();
//Console.WriteLine("若 A 陣列的某索引值之元素值大於或等於零，則 B 陣列相同索引之元素，其值為 1，否則為 0。");
//Console.WriteLine();
//Console.WriteLine("A 陣列與 B 陣列，各自可儲存 10 個整數值。");
//Console.WriteLine("-----");
//Console.WriteLine("請輸入 10 個整數");
//Console.WriteLine("-----");
//Console.WriteLine();
//Console.WriteLine();
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
//int column = 5;
//int row = 3;
//int[,] arrNum2D = new int[row, column];
//Console.WriteLine("此程式，可對某二維陣列的列和行，分別計算其同列之總和及同行之總和。");
//Console.WriteLine();
//Console.WriteLine("此二維陣列，可儲存 15 個整數值。");
//Console.WriteLine("-----");
//Console.WriteLine("請輸入 15 個整數");
//Console.WriteLine("-----");
//Console.WriteLine();
//Console.WriteLine();
//int N = 15;
//int rowloop = 0;
//int columnloop = 0;
//while (N > 0) {
//    Console.WriteLine($"當前是第 {rowloop + 1} 列，第 {columnloop + 1} 行。");
//    int num;
//    Console.Write($"第 {15 - (N - 1)} 個數：");
//    userInput = Console.ReadLine();
//    _ = int.TryParse(userInput, out num);
//    if (((columnloop + 1) % column) == 0) {
//        arrNum2D[rowloop, columnloop] = num;
//        rowloop++;
//        columnloop = 0;
//        N--;
//        continue;
//    }
//    arrNum2D[rowloop, columnloop] = num;
//    columnloop++;
//    N--;
//}
//Console.WriteLine();
//int sumRow = 0;
//int sumRowPre = 0;
//for (int i = 0; i < row; i++) {
//    sumRowPre = sumRow;
//    for (int j = 0; j < column; j++) {
//        sumRow += arrNum2D[i, j];
//    }
//    sumRow -= sumRowPre;
//    Console.WriteLine($"第 {i + 1} 列的總和為：{sumRow}");
//}
//int sumColumn = 0;
//int sumColumnPre = 0;
//columnloop = 0;
//while (columnloop < 5) {
//    sumColumnPre = sumColumn;
//    for (int i = 0; i < row; i++) {
//        sumColumn += arrNum2D[i, columnloop];
//    }
//    sumColumn -= sumColumnPre;
//    Console.WriteLine($"第 {columnloop} 行的總和為：{sumColumn}");
//    columnloop++;
//}
//Console.WriteLine();

/* 
 * 習題 5-5：寫一程式，將 15 個數字，存入 3 x 5 的二維陣列 A 中，求每一行及每一列數字的最小值。
 */
//int column = 5;
//int row = 3;
//int[,] arrNum2D = new int[row, column];
//Console.WriteLine("此程式，可求某二維陣列的列和行之最小值。");
//Console.WriteLine();
//Console.WriteLine("此二維陣列，可儲存 15 個整數值。");
//Console.WriteLine("-----");
//Console.WriteLine("請輸入 15 個整數");
//Console.WriteLine("-----");
//Console.WriteLine();
//Console.WriteLine();
//int N = 15;
//int rowloop = 0;
//int columnloop = 0;
//while (N > 0) {
//    Console.WriteLine($"當前是第 {rowloop + 1} 列，第 {columnloop + 1} 行。");
//    int num;
//    Console.Write($"第 {15 - (N - 1)} 個數：");
//    userInput = Console.ReadLine();
//    _ = int.TryParse(userInput, out num);
//    if (((columnloop + 1) % column) == 0) {
//        arrNum2D[rowloop, columnloop] = num;
//        rowloop++;
//        columnloop = 0;
//        N--;
//        continue;
//    }
//    arrNum2D[rowloop, columnloop] = num;
//    columnloop++;
//    N--;
//}
//Console.WriteLine();
//int minRow = 0;
//for (int i = 0; i < row; i++) {
//    for (int j = 0; j < column; j++) {
//        if (j == 0) {
//            minRow = arrNum2D[i, j];
//        }
//        if (arrNum2D[i, j] < minRow) {
//            minRow = arrNum2D[i, j];
//        }
//    }
//    Console.WriteLine($"第 {i + 1} 列的最小值為：{minRow}");
//}
//int minColumn = 0;
//columnloop = 0;
//while (columnloop < 5) {
//    for (int i = 0; i < row; i++) {
//        if (i == 0) {
//            minColumn = arrNum2D[i, columnloop];
//        }
//        if (arrNum2D[i, columnloop] < minRow) {
//            minRow = arrNum2D[i, columnloop];
//        }
//    }
//    Console.WriteLine($"第 {columnloop} 行的最小值為：{minColumn}");
//    columnloop++;
//}
//Console.WriteLine();

/* 
 * 習題 5-6：寫一程式，輸入兩組數字：a1, a2, ..., a5 和 b1, b2, ..., b5。求 ai + bi, i = 1 到 i = 5。
 */
//Console.WriteLine("此程式，可將兩組陣列，相同索引之元素值相加，而後得解。");
//Console.WriteLine();
//Console.WriteLine("兩組陣列，各自可儲存 5 個整數值。");
//Console.WriteLine("-----");
//Console.WriteLine("請輸入 5 個整數");
//Console.WriteLine("-----");
//Console.WriteLine();
//Console.WriteLine();
//int N = 5;
//int count = 0;
//int NA = N;
//int[] arrNumA = new int[NA];
//int countA = count;
//while (NA > 0) {
//    int num;
//    Console.Write($"第 {countA + 1} 個數：");
//    userInput = Console.ReadLine();
//    _ = int.TryParse(userInput, out num);
//    arrNumA[countA] = num;
//    countA++;
//    NA--;
//}
//int NB = N;
//int[] arrNumB = new int[NB];
//int countB = count;
//while (NB > 0) {
//    int num;
//    Console.Write($"第 {countB + 1} 個數：");
//    userInput = Console.ReadLine();
//    _ = int.TryParse(userInput, out num);
//    arrNumB[countB] = num;
//    countB++;
//    NB--;
//}
//for (int i = 0; i < N; i++) {
//    Console.WriteLine("兩陣列之索引 {0} 的和：{1}", i, (arrNumA[i] + arrNumB[i]));
//}
//Console.WriteLine();

/* 
 * 習題 5-7：寫一程式，輸入兩組數字：a1, a2, ..., a5 和 b1, b2, ..., b5。令 x 為 a 中的最大值，令 y 為 b 中的最大值，求 x 與 y 中，較小者。
 */
Console.WriteLine("此程式，可得兩組陣列中，各自最大的元素值，並且相比較，而後求得二者之中的較小者。");
Console.WriteLine();
Console.WriteLine("兩組陣列，各自可儲存 5 個整數值。");
Console.WriteLine("-----");
Console.WriteLine("請輸入 5 個整數");
Console.WriteLine("-----");
Console.WriteLine();
Console.WriteLine();
int N = 5;
int count = 0;
int NA = N;
int[] arrNumA = new int[NA];
int countA = count;
Console.WriteLine("陣列 A");
Console.WriteLine("-----");
while (NA > 0) {
    int num;
    Console.Write($"第 {countA + 1} 個數：");
    userInput = Console.ReadLine();
    _ = int.TryParse(userInput, out num);
    arrNumA[countA] = num;
    countA++;
    NA--;
}
Console.WriteLine();
Console.WriteLine();
int NB = N;
int[] arrNumB = new int[NB];
int countB = count;
Console.WriteLine("陣列 B");
Console.WriteLine("-----");
while (NB > 0) {
    int num;
    Console.Write($"第 {countB + 1} 個數：");
    userInput = Console.ReadLine();
    _ = int.TryParse(userInput, out num);
    arrNumB[countB] = num;
    countB++;
    NB--;
}
int maxNumA = 0;
for (int i = 0; i < arrNumA.Length; i++) {
    if (i == 0) {
        maxNumA = arrNumA[i];
    }
    if (arrNumA[i] > maxNumA) {
        maxNumA = arrNumA[i];
    }
}
int maxNumB = 0;
for (int i = 0; i < arrNumB.Length; i++) {
    if (i == 0) {
        maxNumB = arrNumB[i];
    }
    if (arrNumB[i] > maxNumB) {
        maxNumB = arrNumB[i];
    }
}
Console.WriteLine();
if (maxNumA == maxNumB) {
    int maxNum = maxNumA = maxNumB;
    Console.WriteLine("兩陣列的最大值，一樣大。值為：{0}", maxNum);
    return;
}
if (maxNumA < maxNumB) {
    Console.WriteLine("兩陣列的最大值相比較後，A 陣列的較小，值為：{0}", maxNumA);
} else {
    Console.WriteLine("兩陣列的最大值相比較後，B 陣列的較小，值為：{0}", maxNumB);
}
Console.WriteLine();