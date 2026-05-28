using System.Text;

string? userInput;
int[] arrNum;

/*************************************************
 *                   從以下開始                   *
 *************************************************/

/*
 *  習題 3-1：寫一程式，輸入 10 個整數，求其最小值。
 */
//Console.WriteLine("此程式可從一組數值中，求得最小值");
//Console.WriteLine("請輸入 10 個整數");
//arrNum = new int[10];
//Console.WriteLine();
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
//Console.WriteLine("此程式可從一組數值中，求得最小值");
//Console.Write("請輸入 N 個整數：");
//int N;
//userInput = Console.ReadLine();
//_ = int.TryParse(userInput, out N);
//arrNum = new int[N];
//Console.WriteLine();
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
//Console.WriteLine();
//Console.WriteLine("此 {0} 個數值中，最小值是： {1}", N, arrNum[0]);

/*
 *  習題 3-3：寫一程式，輸入 10 個整數，列出其中所有大於 12 的數字。
 */
//Console.WriteLine("請輸入 10 個整數");
//Console.WriteLine();
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
//Console.Write("所有大於 12 的數字為：");
//int counter = 0;
//foreach (int num in arrNum) {
//    if (num > 12) {
//        Console.Write("{0} ", num.ToString().PadRight(5));        
//        counter++;
//    }   
//}
//if (counter == 0) {
//    Console.Clear();
//    Console.WriteLine("沒有大於 12 的整數。");
//}

/*
 *  習題 3-4：寫一程式，輸入 10 個整數，列出其中所有大於 12 的數字的總和。
 */
//Console.WriteLine("請輸入 10 個整數");
//Console.WriteLine();
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

/*
 *  習題 3-5：寫一程式，輸入 N 個數字，求其所有奇數中的最大值。例如輸入 11, 12, 3, 24, 15，答案是15。
 */
//Console.WriteLine("此程式，可求得所有奇數中的最大值");
//Console.Write("請輸入 N 個數字：");
//int N;
//userInput = Console.ReadLine();
//_ = int.TryParse(userInput, out N);
//arrNum = new int[N];
//Console.WriteLine();
//for (int i = 0; i < N; i++) {
//    int num;
//    Console.Write($"第 {i + 1} 個數：");
//    userInput = Console.ReadLine();
//    _ = int.TryParse(userInput, out num);
//    if (num % 2 != 0) {
//        arrNum[i] = num;
//    }
//    for (int j = i; j > 0; j--) {
//        if (arrNum[j - 1] < arrNum[j]) {
//            num = arrNum[j - 1];
//            arrNum[j - 1] = arrNum[j];
//            arrNum[j] = num;
//        } else {
//            break;
//        }
//    }
//}
//Console.WriteLine("所有奇數中，最大的奇數為：{0}", arrNum[0]);

/*
 *  習題 3-6：寫一程式，輸入 N 個數字，求其所有正數之平方的加總。例如輸入 1, -2, 3, -4, 5，五個數字，得到
    12 + (-2)^2 + 32 + (-4)^2 + 52  = 1 + 9 + 25 = 35。
 */
//Console.WriteLine("此程式可求，對所有數字平方後，再進行加總後的數值");
//Console.Write("請輸入 N 個數字：");
//int N;
//userInput = Console.ReadLine();
//_ = int.TryParse(userInput, out N);
//arrNum = new int[N];
//Console.WriteLine();
//for (int i = 0; i < N; i++) {
//    int num;
//    Console.Write($"第 {i + 1} 個數：");
//    userInput = Console.ReadLine();
//    _ = int.TryParse(userInput, out num);
//    arrNum[i] = num;
//}
//int sum = 0;
//foreach (int num in arrNum) {
//    sum += (int)Math.Pow(num, 2);
//}
//Console.WriteLine();
//Console.WriteLine("所有正數之平方的加總為為：{0}", sum);


/*
 *  習題 3-7：寫一程式，輸入 N 個數字，其中有些是負數，將這些負數轉換成正數，例如 -7 會被轉換成 7。
 */
//Console.WriteLine("此程式可把所輸入的負數轉變為正數，而正數依然是正數。");
//Console.Write("請輸入 N 個數字：");
//int N;
//userInput = Console.ReadLine();
//_ = int.TryParse(userInput, out N);
//arrNum = new int[N];
//Console.WriteLine();
//for (int i = 0; i < N; i++) {
//    int num;
//    Console.Write($"第 {i + 1} 個數：");
//    userInput = Console.ReadLine();
//    _ = int.TryParse(userInput, out num);
//    arrNum[i] = num;
//}

//Console.Write("所輸入的所有數字，在經過轉換後，依序為：");
//foreach (int num in arrNum) {
//    long lnum = (num < 0) ? -(long)num : num;
//    Console.Write(lnum.ToString().PadRight(5));
//}
//Console.WriteLine();

/*
 *  補充習題 1：判斷 101-200 之間有多少個質數，並輸出所有質數。
 */
//int[] arrPrime = new int[100];
//int counter = 0;
//for (int i = 101; i < 201; i++) {
//    bool isPrime = true;
//    float boundary = (float)Math.Sqrt(i);
//    for (int j = 2; j <= boundary; j++) {
//        if (i % j == 0) {
//            isPrime = false;
//            break;
//        }
//    }
//    if (isPrime) {
//        arrPrime[counter] = i;
//        counter++;
//    }
//}
//Console.WriteLine("101-200 之間，有 {0} 個質數", counter);

//Console.Write($"其中的質數有：");
//foreach (int numPrime in arrPrime) {
//    int loopCounter = 0;
//    if (numPrime == 0) {
//        continue;
//    }
//    if (loopCounter == 5) {
//        Console.WriteLine();
//    }
//    Console.Write($"{numPrime}".PadRight(5));
//    loopCounter++;
//}

/*
 *  補充習題 2：輸入一個數，輸出其質因數。
 */
//Console.WriteLine("此程式可求得，某個數的所有質因數，並列出。");
//Console.Write("請輸入一個整數：");
//int counter = 0;
//int num;
//arrNum = new int[100];
//userInput = Console.ReadLine();
//_ = int.TryParse(userInput, out num);
//while (num % 2 == 0) {
//    arrNum[counter] = 2;
//    num /= 2;
//    counter++;
//}
//for (int i = 3; i * i <= num; i += 2) {
//    while (num % i == 0) {
//        arrNum[counter] = i;
//        num /= i;
//        counter++;
//    }
//}
//if (num > 2) {
//    arrNum[counter] = num;
//}
//Console.Write($"此數的質因數有：");
//StringBuilder stringBuilder = new StringBuilder();
//int preNumPrime = 0;
//foreach (int factorPrime in arrNum) {
//    if (factorPrime == 0) {
//        break;
//    }
//    if (factorPrime == preNumPrime) {
//        continue;
//    }
//    if (preNumPrime != 0) {
//        stringBuilder.Append("、".PadRight(2));
//        stringBuilder.Append(factorPrime);
//        //Console.Write("、".PadRight(2) + "{0}", factorPrime);
//    } else {
//        stringBuilder.Append(factorPrime);
//        //Console.Write("{0}", factorPrime);
//    }
//    preNumPrime = factorPrime;
//}
//Console.WriteLine(stringBuilder);

/*
 *  補充習題 3：求 100 到 300 中，可以被 3 與 7 整除的個數。
 */
//int counter = 0;
//arrNum = new int[150];
//for (int i = 100; i < 301; i++) {
//    if ((i % 3 == 0) && (i % 7 == 0)) {
//        arrNum[counter] = i;
//        counter++;
//    }
//}
//counter = 0;
//foreach (int num in arrNum) {
//    if (num == 0) {
//        break;
//    }
//    counter++;
//}
//Console.WriteLine("可以同時被 3 與 7 整除的個數有：{0} 個", counter);
