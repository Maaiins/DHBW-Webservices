using Contracts.Interfaces;

namespace HttpService
{
    public class Service : IService
    {
        public int AddOne(int value)
        {
            return value + 1;
        }
    }
}