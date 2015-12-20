using System.ServiceModel;
using CalculatorService.Dto;

namespace CalculatorService.Interfaces
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        Result Add(Arguments args);
    }
}