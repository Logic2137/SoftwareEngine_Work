using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public class TemperatureService : ITemperatureService
{
    public int c2f(int c)
    {
        return (int)((c * 9.0 / 5) + 32);  // 摄氏转华氏公式
    }

    public int f2c(int f)
    {
        return (int)((f - 32) * 5.0 / 9);  // 华氏转摄氏公式
    }
}
