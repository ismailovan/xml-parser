using Contracts;
using WorkerXML.Services;

namespace WorkerXML
{
    public class Worker : BackgroundService
    {
        private readonly ILoggerManager _logger;
        private readonly MetDataService _userService;

        public Worker(ILoggerManager logger, MetDataService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInfo($"Worker running at: { DateTimeOffset.Now}");

                var result = await _userService.ExecuteService(stoppingToken);

                string resultLogMessage = result ? "Successfully processed" : "Processed with failure";

                _logger.LogInfo(resultLogMessage);

                _logger.LogInfo("Stoping service...");

                await Task.Delay(30000, stoppingToken);
            }
        }
    }
}