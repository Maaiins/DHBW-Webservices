using Contracts.Interfaces;

namespace TcpService
{
    public class Service : IService
    {
        public int AddOne(int value)
        {
            return value + 1;
        }
    }
}