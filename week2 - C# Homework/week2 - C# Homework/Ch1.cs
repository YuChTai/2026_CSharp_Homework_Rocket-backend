using System;

namespace week2_CSharp_Homework {
    internal class Ch1 {
        static void Main(string[] args) {

            // 1-1：寫一程式，輸入a,b,c,d，計算((𝑎+𝑏))/((𝑐−𝑑))×2。            
            //int a, b, c, d;
            //Console.WriteLine("此程式可計算 ((a+b)/(c-d))*2");
            //Console.Write("請輸入 a 值：");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入 b 值：");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入 c 值：");
            //c = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入 d 值：");
            //d = Convert.ToInt32(Console.ReadLine());
            //if (c - d == 0) {
            //    Console.WriteLine("除數為「0」，故本次計算，無意義。");
            //} else {
            //    Console.WriteLine("答案： {0}", ((a + b) / (c - d)) * 2);
            //}

            // 1-2：寫一程式，輸入一組二元一次方程式之係數，輸出方程式的解。
            //int a1, b1, c1;
            //int a2, b2, c2;
            //Console.WriteLine("有一組二元一次方程式，分別為\n " +
            //    "─────────────────────────\n" +
            //    "| (a1 * x) + (b1 * y) = c1 |\n" +
            //    " ─────────────────────────\n" +
            //    "            與\n " +
            //    "─────────────────────────\n" +
            //    "| (a1 * x) + (b2 * y) = c2 |\n" +
            //    " ─────────────────────────\n" +
            //    "其中的 x 和 y 可分別透過\n" +
            //    " ──────────────────────────────────────────────────\n" +
            //    "| ((c1 * b2) - (c2 * b1)) / ((a1 * b2) - (a2 * b1)) |\n" +
            //    " ──────────────────────────────────────────────────\n" +
            //    "            和\n" +
            //    " ──────────────────────────────────────────────────\n" +
            //    "| ((c1 * a2) - (c2 * a1)) / ((b1 * a2) - (a1 * b2)) | 求得\n" +
            //    " ──────────────────────────────────────────────────"
            //    );
            //Console.WriteLine();
            //Console.WriteLine("請分別輸入以下的係數： ");            
            //Console.Write("a1: ");           
            //a1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b1: ");
            //b1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("c1: ");
            //c1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("a2: ");
            //a2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b2: ");
            //b2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("c2: ");
            //c2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("x = {0}", ((c1 * b2) - (c2 * b1)) / ((a1 * b2) - (a2 * b1)));
            //Console.WriteLine("y = {0}", ((c1 * a2) - (c2 * a1)) / ((b1 * a2) - (a1 * b2)));

            // 1-3：輸入a和b，求：y = a^2 + b^2 / a^2 - b^2
            //int a, b;
            //Console.WriteLine("此程式可計算 (y = ((a^2) + (b^2)) / ((a^2) - (b^2)))");
            //Console.Write("請輸入 a：");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入 b：");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("答案：y = {0}", (Math.Pow(a, 2) + Math.Pow(b, 2)) / (Math.Pow(a, 2) - Math.Pow(b, 2)));

            // 1-4：輸入a和b，求：y = √(a^2 + b^2)
            //int a, b;
            //Console.WriteLine("此程式可計算 (y = ((a^2) + (b^2))^0.5)");
            //Console.Write("請輸入 a：");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入 b：");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("答案：y = {0}", Math.Pow(Math.Pow(a, 2) + Math.Pow(b, 2), 0.5));

            // 1-5：輸入a、b和c，求：y = a - (b + c)(3a - c)
            //int a, b, c;
            //Console.WriteLine("此程式可計算 (y = (a - (b + c) * (3 * a - c)");
            //Console.Write("請輸入 a：");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入 b：");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入 c：");
            //c = Convert.ToInt32(Console.ReadLine());
            //Console.Write("答案：y = {0}", (a - (b + c) * (3 * a - c)));

            // 1-6：請隨意輸入正負數，取絕對值輸出
            //int num;
            //Console.WriteLine("此程式可取正負數的絕對值");
            //Console.Write("請輸入數值：");
            //num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("絕對值：{0}", Math.Abs(num));

            // 1-7：輸入的西元年份轉換成民國年份後輸出
            //int num;
            //Console.WriteLine("此程式可把西元為民國");
            //Console.Write("請輸入西元年：");
            //num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("結果：民國 {0} 年", num - 1911);

            // 1-8：請輸入身高體重，輸出BMI
            // 公式：BMI＝體重(公斤) ÷ 身高 (公尺) ÷ 身高 (公尺)
            //int weight;
            //float height;
            //Console.WriteLine("此程式可計算 BMI");
            //Console.Write("請輸入體重（單位：公斤）：");
            //weight = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入身高（單位：公尺）：");
            //height = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("結果：BMI = {0}", (weight / Math.Pow(height, 2)));

            // 2-1
            //Ch2.Homework2_1();

            // 2-2
            //Ch2.Homework2_2();

            // 2-3
            //Ch2.Homework2_3();

            // 2-4
            //Ch2.Homework2_4();

            // 2-5
            //Ch2.Homework2_5();

            // 2-6
            //Ch2.Homework2_6();

            // 2-7
            //Ch2.Homework2_7();

            // 2_additional1
            //Ch2.Homework2_additional1();

            // 2_additional2
            //Ch2.Homework2_additional2();

            // 2_additional3
            //Ch2.Homework2_additional3();

            // 2_additional4
            //Ch2.Homework2_additional4();
        }
    }
}
