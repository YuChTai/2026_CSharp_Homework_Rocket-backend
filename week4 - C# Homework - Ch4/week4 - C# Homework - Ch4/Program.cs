using System;
using System.Runtime.Loader;

string? userInput;
int[] arrNum;

/*************************************************
 *                   從以下開始                   *
 *************************************************/

/* 
 * 習題 4-1：利用 while 寫一程式求 N 個數字的最大值。
 */
//Console.WriteLine("此程式可求得所有整數中的最大值");
//Console.Write("請輸入想輸入的整數個數：");
//int N = 0;
//userInput = Console.ReadLine();
//_ = int.TryParse(userInput, out N);
//int maxNum = 0;
//int counter = 0;
//while (N > 0) {
//    int num = 0;
//    Console.Write($"請輸入第 {counter + 1} 個數：");
//    userInput = Console.ReadLine();
//    _ = int.TryParse(userInput, out num);
//    if (counter == 0) {
//        maxNum = num;
//    }
//    if (maxNum < num) {
//        maxNum = num;
//    }
//    counter++;
//    N--;
//}
//Console.WriteLine();
//Console.WriteLine("所有整數中的最大值為：{0}", maxNum);

/* 
 * 習題 4-2：利用 while 寫一程式，求一個等差級數數字的和。一共有 N 個數字，程式應該輸入最小的起始值以及數字間的差。(即從起始值開始，間格差，共 N 個的總和。)
 */
//Console.WriteLine("此程式可求一組等差級數的和");
//int N = 0;
//Console.Write("請輸入等差級數的個數：");
//userInput = Console.ReadLine();
//_ = int.TryParse(userInput, out N);
//int spacing;
//Console.Write("請輸入等差級數的間距（公差）：");
//userInput = Console.ReadLine();
//_ = int.TryParse(userInput, out spacing);
//int startingNum;
//Console.Write("請輸入起始值：");
//userInput = Console.ReadLine();
//_ = int.TryParse(userInput, out startingNum);
//int sum = 0;
//int counter = 0;
//while (N > 0) {
//    if (counter == 0) {
//        sum = startingNum;
//        counter++;
//        N--;
//        continue;
//    }
//    startingNum += spacing;
//    sum += startingNum;
//    counter++;
//    N--;
//}
//Console.WriteLine("此一等差級數的和為：{0}", sum);

/* 
 * 習題 4-3：利用 while 寫一程式，讀入 N 個數字，然後找出所有小於 13 的數，再求這些數字的和。
 */
//Console.WriteLine("此程式可求得所有整數中，小於 13 的整數和。");
//Console.Write("請輸入想輸入的整數個數：");
//int N = 0;
//userInput = Console.ReadLine();
//_ = int.TryParse(userInput, out N);
//int counter = 0;
//int sum = 0;
//while (N > 0) {
//    int num = 0;
//    Console.Write($"請輸入第 {counter + 1} 個數：");
//    userInput = Console.ReadLine();
//    _ = int.TryParse(userInput, out num);
//    if (num < 13) {
//        sum += num;
//    }
//    counter++;
//    N--;
//}
//Console.WriteLine();
//Console.WriteLine("所有整數中，小於 13 的整數和，為：{0}", sum);

/* 
 * 習題 4-4：利用 while 寫一程式，讀入 N 個數字，找到第一個大於 7 而小於 10 的數字就停止，而且列印出這個數字。
 */
//Console.WriteLine("此程式可求得已讀取的所有整數中，第一個大於 7 但小於 10 的數值。");
//Console.Write("請輸入想輸入的整數個數：");
//int N = 0;
//userInput = Console.ReadLine();
//_ = int.TryParse(userInput, out N);
//int counter = 0;
//arrNum = new int[N];
//while (N > 0) { 
//    int num = 0;
//    Console.Write($"請輸入第 {counter + 1} 個數：");
//    userInput = Console.ReadLine();
//    _ = int.TryParse(userInput, out num);
//    arrNum[counter] = num;
//    counter++;    
//    N--;
//}
//while (counter > 0) {
//    if ((arrNum[N] > 7) && (arrNum[N] < 10)) {
//        break;
//    }
//    N++;
//    counter--;
//}
//if (N >= 5) {
//    N--;
//}
//if ((arrNum[N] > 7) && (arrNum[N] < 10)) {

//    Console.WriteLine();
//    Console.WriteLine("已讀取的所有整數中，第一個大於 7 但小於 10 的數值為：{0}", arrNum[N]);
//} else {

//    Console.WriteLine();
//    Console.WriteLine("已讀取的所有整數中，沒有符合條件的數值。");
//}

/* 
 * 習題 4-5：利用 while 寫一程式，讀入 a1, a2, …, a5 和 b1, b2, …, b5。找到第一個 ai > bi，即停止，並列印出 ai 及 bi。
 */
//Console.WriteLine("此程式可求得已讀取的兩組數量為 5 的整數中，第一個第一組的數大於第二組的數的數值。");
//Console.WriteLine();
//int N = 5;
//int counter = 0;
//int[] arrNum_First = new int[N];
//int[] arrNum_Second = new int[N];
//while (N > 0) {
//    int num = 0;
//    Console.Write($"請輸入第一組整數的第 {counter + 1} 個數：");
//    userInput = Console.ReadLine();
//    _ = int.TryParse(userInput, out num);
//    arrNum_First[counter] = num;
//    counter++;
//    N--;
//}
//Console.WriteLine();
//N = 5;
//counter = 0;
//while (N > 0) {
//    int num = 0;
//    Console.Write($"請輸入第二組整數的第 {counter + 1} 個數：");
//    userInput = Console.ReadLine();
//    _ = int.TryParse(userInput, out num);
//    arrNum_Second[counter] = num;
//    counter++;
//    N--;
//}
//Console.WriteLine();
//while (counter > 0) {
//    if (arrNum_First[N] > arrNum_Second[N]) {
//        Console.WriteLine($"第一個第一組的整數大於第二個第二組的整數的數值為：{arrNum_First[N]}（第一組）、{arrNum_Second[N]}（第二組）");
//        break;
//    }
//    N++;
//    counter--;
//}
//if(arrNum_First[N - 1] < arrNum_Second[N - 1]) {
//    Console.WriteLine("第一組的所有整數，都比第二組的所有整數小。");
//}

/* 
 * 補充題目 1：Eric 覺得麥蒂勞的 39 元漢堡實在太便宜、太好吃了，因此他決定晚餐要把口袋裡所有錢通通拿來吃 39 元漢堡。假設他每 5 分鐘就能吃一個漢堡，請隨意輸入一個時間，輸出這段時間吃漢堡的紀錄。
 */
//Console.WriteLine("此程式可根據所輸入的時間（分鐘），求得 Eric 所吃的漢堡數以及所花費的金錢。");
//Console.Write("請輸入一個時間（分鐘）：");
//userInput = Console.ReadLine();
//int T;
//int hamburgerPrice = 39;
//int spent = 0;
//int eaten = 0;
//_ = int.TryParse(userInput, out T);
//while (T >= 5) {    
//    T -= 5;
//    spent += hamburgerPrice ;    
//    eaten ++ ;
//}
//Console.WriteLine("Eric 一共吃了 {0} 個漢堡，以及花費了 {1} 元", eaten, spent);

/* 
 * 補充題目 2：小明貸款買房花 560 萬，每個月可還 4 萬，每還 12 個月，因為年終獎金可以多還一萬，請問需要幾個月還清。
 */
Console.WriteLine("此程式可知道小明需要耗費幾個月，才有辦法把房貸給繳清。");
Console.WriteLine();
int loanHouse = 560;
int monthCounter = 0;
int counter = 0;
while (loanHouse > 0) {
    counter++;
    if (counter == 12) {
        loanHouse -= 5;
        counter = 0;
    } else {
        loanHouse -= 4;
    }
    monthCounter++;
}
Console.WriteLine("以求得：小明必須耗費 {0} 個月的時間，才有辦法把房貸給繳清。", monthCounter);

/* 
 * 補充題目 3：系統隨機產生一個數字，讓使用者數入數字，直到猜中才離開程式！，猜錯時，要提示是比較大還是比較小。
 */
