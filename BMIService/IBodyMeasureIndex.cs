using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIService
{
    public interface IBodyMeasureIndex
    {
        MeasureResult Calculate(double Height, double Weight, out double BMI);
    }
}
