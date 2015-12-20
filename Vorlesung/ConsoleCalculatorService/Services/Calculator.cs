using System.Security.Principal;
using System.ServiceModel;
using CalculatorService.Dto;
using CalculatorService.Interfaces;

namespace CalculatorService.Services
{
    public class Calculator : ICalculator
    {
        public Result Add(Arguments args)
        {
            var requestIdentity = ServiceSecurityContext.Current.WindowsIdentity;
            var threadIdentity = WindowsIdentity.GetCurrent();

            var result = new Result {Value = args.Arg1 + args.Arg2};
            return result;
        }
    }
}