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
 * 利用 while 寫一程式，讀入 N 個數字，然後找出所有小於 13 的數，再求這些數字的和。
 */
Console.WriteLine("此程式可求得所有整數中，小於 13 的整數和。");
Console.Write("請輸入想輸入的整數個數：");
int N = 0;
userInput = Console.ReadLine();
_ = int.TryParse(userInput, out N);
int counter = 0;
int sum = 0;
while (N > 0) {
    int num = 0;
    Console.Write($"請輸入第 {counter + 1} 個數：");
    userInput = Console.ReadLine();
    _ = int.TryParse(userInput, out num);
    if (num < 13) {
        sum += num;
    }
    counter++;
    N--;
}
Console.WriteLine();
Console.WriteLine("所有整數中，小於 13 的整數和，為：{0}", sum);
