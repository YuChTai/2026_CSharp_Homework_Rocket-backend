using System;

namespace week2_CSharp_Homework {
    internal class Ch2 {
        // 2-1：寫一程式，輸入x和y，如果x>=y，則列印x，否則列印y
        static public void Homework2_1() {
            int x, y;
            Console.WriteLine("此程式可比較 x 與 y，並輸出較大的那一個。");
            Console.Write("請輸入 x：");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入 y：");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > y) {
                Console.WriteLine($"x 較大，值是 {x}。");
            } else {
                Console.WriteLine($"y 較大，值是 {y}。");
            }
        }

        // 2-2：寫一程式，輸入x和y，如果x和y都是正數，令z=1，如兩者均為負數，令z=-1，否則令z=0
        static public void Homework2_2() {
            int x, y;
            int z;
            Console.WriteLine("此程式可判斷 x 與 y，並依據結果，指派數值給 z。若都為正，則令 z = 1，若都為負，則令 z = -1，若都不是正，也不是負，則令 z = 0。");
            Console.Write("請輸入 x：");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入 y：");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0) {
                z = 1;
                Console.WriteLine($"z 的值是 {z}");
            } else if (x < 0 && y < 0) {
                z = -1;
                Console.WriteLine($"z 的值是 {z}");
            } else {
                z = 0;
                Console.WriteLine($"z 的值是 {z}");
            }
        }

        // 2-3：寫一程式，輸入x、y、u、v，如果(x+y)>(u+v)，則令z=x+y，否則令z=u+v
        static public void Homework2_3() {
            int x, y, u, v;
            int z;
            Console.WriteLine("有變數 x、y、u、v 與 z。此程式可判斷 x + y 是否大於 u + v。若大於則令 z = x + y，否則 z = u + v。");
            Console.Write("請輸入 x：");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入 y：");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入 u：");
            u = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入 v：");
            v = Convert.ToInt32(Console.ReadLine());
            if ((x + y) > (u + v)) {
                Console.WriteLine("z 的值是 {0}", x + y);
            } else {
                Console.WriteLine("z 的值是 {0}", u + v);
            }
        }

        // 2-4：寫一程式，輸入 x、y、u、v，如果 ((x + y) / (u + v)) >= 2，則令 z = x + y，否則令 z = u + v
        static public void Homework2_4() {
            int x, y, u, v;
            int z;
            Console.WriteLine("有變數 x、y、u、v 與 z。此程式可判斷 ((x + y) / (u + v)) 是否大於等於 2。若大於等於，則令 z = x + y，否則 z = u + v。");
            Console.Write("請輸入 x：");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入 y：");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入 u：");
            u = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入 v：");
            v = Convert.ToInt32(Console.ReadLine());
            if (u + v == 0)
            {
                Console.WriteLine("除數為「0」，故本次判斷，無意義。");
            } else if (((x + y) / (u + v)) >= 2) {
                Console.WriteLine("z 的值是 {0}", x + y);
            } else {
                Console.WriteLine("z 的值是 {0}", u + v);
            }
        }

        // 2-5：寫一程式，輸入 x、y，如果 x >= y，則令 z = x^2，否則令 z = y^2。
        static public void Homework2_5() {
            int x, y;
            int z;
            Console.WriteLine("有變數 x、y 與 z。此程式可判斷 x 是否大於等於 y。若是，則令 z = x^2，否則 z = y^2。");
            Console.Write("請輸入 x：");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入 y：");
            y = Convert.ToInt32(Console.ReadLine());
            if (x >= y) {
                Console.WriteLine("z 的值是 {0}", Math.Pow(x, 2));
            } else {
                Console.WriteLine("z 的值是 {0}", Math.Pow(y, 2));
            }
        }

        // 2-6：依照流程圖，撰寫出程式
        static public void Homework2_6() {
            int income;
            double rate;
            double tax;
            int difference;
            Console.WriteLine("此程式可根據 income，判斷所適用之稅率，並計算得出最終所需繳納的稅費。");
            Console.Write("請輸入 income：");
            income = Convert.ToInt32(Console.ReadLine());
            if (income > 4090000) {
                rate = 0.4f;
                difference = 721100;
                tax = Math.Truncate(((income * rate) - difference));
            } else if (income > 2180000) {
                rate = 0.3f;
                difference = 312100;
                tax = Math.Truncate(((income * rate) - difference));
            } else if (income > 1090000) {
                rate = 0.21f;
                difference = 115900;
                tax = Math.Truncate(((income * rate) - difference));
            } else if (income > 410000) {
                rate = 0.13f;
                difference = 28700;
                tax = Math.Truncate(((income * rate) - difference));
            } else {
                rate = 0.06f;
                difference = 0;
                tax = Math.Truncate(((income * rate) - difference));
            }
            Console.WriteLine($"所需繳納的稅費為 {tax}");
        }

        // 2-7：依照流程圖，撰寫出程式
        static public void Homework2_7() {
            int x, y;
            Console.WriteLine("此程式可依據 x 與 y，進行一系列的判斷。");
            Console.Write("請輸入 x：");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入 y：");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > 0) {
                if (y > 0) {
                    Console.Write("1st quadrant\n");
                } else if (y == 0) {
                    Console.Write("x-axis\n");
                } else {
                    Console.Write("4th quadran\n");
                }
            } else if (x == 0) {
                if (y == 0) {
                    Console.Write("Origin\n");
                } else {
                    Console.Write("y-axis\n");
                }
            } else {
                if (y > 0) {
                    Console.Write("2nd quadran\n");
                } else if (y == 0) {
                    Console.Write("X-axisS\n");
                } else {
                    Console.Write("3th quadran\n");
                }
            }
        }

        // 補充 1：依據解出的題數，計算出對應的得分。（輸入答對的題數，輸出統計後分數 。）
        // 規則：
        // 答對題數在 0~10 者，每題給6分。
        // 題數在 11~20 者，從第11題開始，每題給2分。(前10題還是每題給6分)
        // 題數在 21~40 者，從第21題開始，每題給1分。
        // 題數在 40 以上者，一律100分。
        static public void Homework2_additional1() {
            int num;
            int score;
            Console.WriteLine("此程式可依據所解出的題數，計算與得出所應得的分數。");
            Console.Write("請輸入所解出的題數：");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 40) {
                score = 100;
            } else if (num >= 21) {
                score = 10 * 6 + 10 * 2 + (num - 20) * 1;
            } else if (num >= 11) {
                score = 10 * 6 + (num - 10) * 2;
            } else {
                score = num * 6;
            }
            Console.WriteLine($"分數為 {score}");
        }

        // 補充 2：請輸入身高體重，輸出BMI並顯示這樣的BMI是正常還是過輕、過重。
        static public void Homework2_additional2() {
            int weight;
            float height;
            float bmi;
            Console.WriteLine("此程式可計算 BMI，並且判斷是過重、正常，或者是過輕。");
            Console.Write("請輸入體重（單位：公斤）：");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入身高（單位：公尺）：");
            height = Convert.ToSingle(Console.ReadLine());
            bmi = Convert.ToSingle(weight / Math.Pow(height, 2));
            Console.WriteLine("結果：BMI = {0}", bmi);
            if (bmi >= 24.0 && bmi < 27.0) {
                Console.WriteLine("體重過重");
            } else if (bmi >= 18.5) {
                Console.WriteLine("正常");
            } else {
                Console.WriteLine("過輕");
            }
        }


        // 補充 3：請隨意輸入三個數，請由大到小依序印出。
        static public void Homework2_additional3() {
            float x, y, z;
            Console.WriteLine("此程式可根據使用者所輸入的三個數值，進行數值大小的比較，並且以大至小的順序，依序由上往下排列。");
            Console.Write("請輸入第一個數值：");
            x = Convert.ToSingle(Console.ReadLine());
            Console.Write("請輸入第二個數值：");
            y = Convert.ToSingle(Console.ReadLine());
            Console.Write("請輸入第三個數值：");
            z = Convert.ToSingle(Console.ReadLine());
            // 3! = 3 * 2 * 1 = 6
            // 6 * 2 + 1
            if (x > y && x > z && y > z) {
                Console.Write($"{x}\n{y}\n{z}"); // x > y > z --- 1
            } else if (x > y && x > z && z > y) {
                Console.Write($"{x}\n{y}\n{z}"); // x > z > y --- 2
            } else if (y > x && y > z && x > z) {
                Console.Write($"{y}\n{x}\n{z}"); // y > x > z --- 3
            } else if (y > x && y > z && z > x) {
                Console.Write($"{y}\n{z}\n{x}"); // y > z > x --- 4
            } else if (z > x && z > y && x > y) {
                Console.Write($"{z}\n{x}\n{y}"); // z > x > y --- 5
            } else if (z > x && z > y && y > x) {
                Console.Write($"{z}\n{y}\n{x}"); // z > y > x --- 6
            } else if (x == y && y > z) {
                Console.Write($"{x}、{y}\n{z}"); // x == y > z  --- 7
            }
            else if (x == y && z > y) {
                Console.Write($"{z}\n{x}、{y}"); // z > x == y  --- 8
            } else if (x == z && z > y) {
                Console.Write($"{x}、{z}\n{y}"); // x == z > y  --- 9
            } else if (x == z && y > z) {
                Console.Write($"{y}\n{x}、{z}"); // y > x == z  --- 10
            } else if (y == z && z > x) {
                Console.Write($"{y}、{z}\n{x}"); // y == z > x  --- 11
            } else if (y == z && x > z) {
                Console.Write($"{x}\n{y}、{z}"); // x > y == z  --- 12
            } else {
                Console.Write($"{x}、{y}、{z}"); // x == y == z --- 13
            }
        }

        // 補充 4：請寫一程式，輸入當月利潤，輸出發放獎金總數。
        static public void Homework2_additional4() {
            double profit;
            double bonus;
            Console.WriteLine("此程式可依據相關之規則，進行利潤提成之獎金的計算。");
            Console.WriteLine("請輸入一數值，作為利潤，以用於計算：");
            profit = Convert.ToDouble(Console.ReadLine());            
            if (profit <= 100000) { 
                bonus = 
                    profit * 0.1; 
            } else if (100000 < profit) { 
                bonus = 
                    (profit - 100000) * 0.075 + 
                    100000 * 0.1; 
            } else if (200000 < profit) {
                bonus = 
                    (profit - 200000) * 0.05 + 
                    (profit - (profit - 200000) - 100000) * 0.075 + 
                    100000 * 0.1;        
            } else if (400000 < profit) {
                bonus = 
                    (profit - 400000) * 0.03 + 
                    (profit - (profit - 400000) - 200000) * 0.05 + 
                    (profit - (profit - 400000 - 200000) - 100000) * 0.075 + 
                    100000 * 0.1;
            } else if (600000 < profit && profit <= 1000000) {
                bonus = 
                    (profit - 600000) * 0.015 + 
                    (profit - (profit - 600000) - 400000) * 0.03 + 
                    (profit - (profit - 600000 - 400000) - 200000) * 0.05 + 
                    (profit - (profit - 600000 - 400000 - 200000) - 100000) * 0.075 + 
                    100000 * 0.1;
            } else {
                bonus = 
                    (profit - 1000000) * 0.01 + 
                    (profit - (profit - 1000000) - 600000) * 0.015 + 
                    (profit - (profit - 1000000 - 600000) - 400000) * 0.03 + 
                    (profit - (profit - 1000000 - 600000 - 400000) - 200000) * 0.05 + 
                    (profit - (profit - 1000000 - 600000 - 400000 - 200000) - 100000) * 0.075 + 
                    100000 * 0.1;
            } 
            Console.WriteLine($"可獲得獎金：{bonus}");
        }
    }
}
