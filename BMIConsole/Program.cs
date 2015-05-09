using BMIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入身高(公尺):");
            string inputHeight = Console.ReadLine();
            double height = 0.0d;
 
            if (!double.TryParse(inputHeight, out height))
            {
                Console.WriteLine("您輸入的不是數字。");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("請輸入體重(公斤):");
            string inputＷeight = Console.ReadLine();
            double weight = 0.0d;
            if (!double.TryParse(inputＷeight, out weight))
            {
                Console.WriteLine("您輸入的不是數字。");
                Console.ReadLine();
                return;
            }
            //double height = double.Parse(inputHeight);
            //double weight = double.Parse(inputＷeight);

            Console.WriteLine("請問你的性別?");
            string inputSex = Console.ReadLine();
            bool isMale = (inputSex == "M");

            double bmi = weight / (height * height);
            Console.WriteLine("結果是："+bmi);
            if (bmi < 18)
            {
                Console.WriteLine("太瘦");
            }//ssss
            else
            {
                if (bmi > 22)
                {
                    Console.WriteLine("太胖");
                }
                else
                {
                    Console.WriteLine("剛剛好");
                }
            }

            IBodyMeasureIndex bmiservice = null;

            if (isMale)
            {
                bmiservice = new ManBodyMeasureIndex();

            }
            else
            {
                bmiservice = new WomanBodyMeasureIndex();
            }
            MeasureResult result = bmiservice.Calculate(height, weight, out bmi);
            switch (result)
            {
                case MeasureResult.Less:
                    Console.WriteLine("太瘦");
                    break;
                case MeasureResult.Normal:
                    Console.WriteLine("剛剛好");
                    break;
                case MeasureResult.More:
                    Console.WriteLine("太胖");
                    break;
                default:
                    break;
            }

            Console.ReadLine();
             
        }
    }
}
