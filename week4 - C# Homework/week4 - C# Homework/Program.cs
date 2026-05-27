string? userInput;
int[] arrNum;
Console.WriteLine("此程式可從一組數值中，求得最小值");

/*************************************************
 *                   從以下開始                   *
 *************************************************/

/*
 *  習題 3-1：寫一程式，輸入 10 個整數，求其最小值。
 */
//Console.WriteLine("請輸入 10 個整數");
//arrNum = new int[10];
//for (int i = 0; i < 10; i++) {
//    int num;
//    Console.Write($"第 {i + 1} 個數：");
//    userInput = Console.ReadLine();
//    _ = int.TryParse(userInput, out num);
//    arrNum[i] = num;
//    for (int j = i; j > 0; j--) {
//        if (arrNum[j - 1] > arrNum[j]) {
//            num = arrNum[j - 1];
//            arrNum[j - 1] = arrNum[j];
//            arrNum[j] = num;
//        } else {
//            break;
//        }
//    }
//}
//Console.WriteLine();
//Console.WriteLine("此 10 個數值中，最小值是： {0}", arrNum[0]);


/*
 *  習題 3-2：寫一程式，輸入 N 個整數，求其最小值。
 */
//Console.WriteLine("請輸入 N 個整數");
//int N;
//userInput = Console.ReadLine();
//_ = int.TryParse(userInput, out N);
//arrNum = new int[N];
//for (int i = 0; i < N; i++) {
//    int num;
//    Console.Write($"第 {i + 1} 個數：");
//    userInput = Console.ReadLine();
//    _ = int.TryParse(userInput, out num);
//    arrNum[i] = num;
//    for (int j = i; j > 0; j--) {
//        if (arrNum[j - 1] > arrNum[j]) {
//            num = arrNum[j - 1];
//            arrNum[j - 1] = arrNum[j];
//            arrNum[j] = num;
//        } else {
//            break;
//        }
//    }
//}
//Console.WriteLine("此 10 個數值中，最小值是： {0}", arrNum[0]);

/*
 *  習題 3-3：寫一程式，輸入 10 個整數，列出其中所有大於 12 的數字。
 */
//Console.WriteLine("請輸入 10 個整數");
//arrNum = new int[10];
//int arrIndicator = 0;
//for (int i = 0; i < 10; i++) {
//    int num;
//    Console.Write($"第 {i + 1} 個數：");
//    userInput = Console.ReadLine();
//    _ = int.TryParse(userInput, out num);
//    if (num > 12) {
//        arrNum[arrIndicator] = num;
//    }
//    arrIndicator++;
//    for (int j = i; j > 0; j--) {
//        if (arrNum[j - 1] > arrNum[j]) {
//            num = arrNum[j - 1];
//            arrNum[j - 1] = arrNum[j];
//            arrNum[j] = num;
//        } else {
//            break;
//        }
//    }
//}
//Console.WriteLine();
//foreach (int num in arrNum) {
//    if (num > 12) {
//        Console.WriteLine("所有大於 12 的數字為：{0}", num.ToString().PadRight(5));
//    }
//}

/*
 *  習題 3-4：寫一程式，輸入 10 個整數，列出其中所有大於 12 的數字的總和。
 */
//Console.WriteLine("請輸入 10 個整數");
//arrNum = new int[10];
//int arrIndicator = 0;
//for (int i = 0; i < 10; i++) {
//    int num;
//    Console.Write($"第 {i + 1} 個數：");
//    userInput = Console.ReadLine();
//    _ = int.TryParse(userInput, out num);
//    if (num > 12) {
//        arrNum[arrIndicator] = num;
//    }
//    arrIndicator++;
//    for (int j = i; j > 0; j--) {
//        if (arrNum[j - 1] > arrNum[j]) {
//            num = arrNum[j - 1];
//            arrNum[j - 1] = arrNum[j];
//            arrNum[j] = num;
//        } else {
//            break;
//        }
//    }
//}
//int sum = 0;
//foreach (int num in arrNum) {
//    sum += num;
//}
//Console.WriteLine();
//Console.WriteLine("所有大於 12 的數字的總和為：{0}", sum.ToString());