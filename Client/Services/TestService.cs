namespace Client.Services
{
    public interface IClientTestService
    {
        public void Test();
    }

    public class ClientTestService : IClientTestService
    {
        public int Counter = 0;
        public void Test()
        {
            Console.WriteLine($"Client test {Counter++}");
        }
    }
}