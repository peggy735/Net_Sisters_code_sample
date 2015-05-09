using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIService
{
    public class ManBodyMeasureIndex : IBodyMeasureIndex
    {

        public MeasureResult Calculate(double Height, double Weight, out double BMI)
        {
            BMI = Weight / (Height * Height);

            if (BMI < 20)
            {
                return MeasureResult.Less;
            }//ssss
            else
            {
                if (BMI > 25)
                {
                    return MeasureResult.More;
                }
                else
                {
                    return MeasureResult.Normal;
                }
            }
        }
    }
}
