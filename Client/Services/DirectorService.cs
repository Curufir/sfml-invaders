namespace Client.Services
{
    public interface IDirectorService
    {
        Task Execute();
    }

    /// <summary>
    /// Handles setting up the various components of the client.
    /// </summary>
    public class DirectorService : IDirectorService
    {
        private readonly IClientTestService _clientTestService;

        public DirectorService(IClientTestService clientTestService)
        {
            _clientTestService = clientTestService;
        }

        public async Task Execute()
        {
            _clientTestService.Test();

            await Task.Delay(50);
        }
    }
}