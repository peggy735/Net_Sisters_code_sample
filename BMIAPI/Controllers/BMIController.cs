using BMIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BMIAPI.Controllers
{
    public class BMIController : ApiController
    {
        public async Task<string> Woman()
        {
            var forms = await Request.Content.ReadAsFormDataAsync();

            string inputHeight = forms["height"];
            double height = 0.0d;

            if (!double.TryParse(inputHeight, out height))
            {
                return "您輸入的不是數字。";
            }


            string inputＷeight = forms["weight"];
            double weight = 0.0d;
            if (!double.TryParse(inputＷeight, out weight))
            {
                return "您輸入的不是數字。";

            }
            //double height = double.Parse(inputHeight);
            //double weight = double.Parse(inputＷeight);
            double bmi = weight / (height * height);

            IBodyMeasureIndex bmiservice = new WomanBodyMeasureIndex();

           
            MeasureResult result = bmiservice.Calculate(height, weight, out bmi);
            switch (result)
            {
                case MeasureResult.Less:
                    return "太瘦";
                   
                case MeasureResult.Normal:
                    return "剛剛好";
                    
                case MeasureResult.More:
                    return "太胖";
                
                default:
                    return"剛剛好";
                    
            }
        }
    }
}
