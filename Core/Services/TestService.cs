namespace Core.Services
{
    public interface ICoreTestService
    {
        public void Test();
    }

    public class CoreTestService : ICoreTestService
    {
        public int Counter = 0;
        public void Test()
        {
            Console.WriteLine($"Core test {Counter++}");
        }
    }
}