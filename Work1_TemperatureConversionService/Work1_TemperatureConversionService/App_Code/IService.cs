using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface ITemperatureService
{
    [OperationContract]
    int c2f(int c);  // 将摄氏温度转换为华氏温度

    [OperationContract]
    int f2c(int f);  // 将华氏温度转换为摄氏温度
}