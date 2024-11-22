using Hangfire;
using Hangfire.Console;
using Hangfire.Server;

namespace Worker.Services;

public class MonitorService : IHostedService
{
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        await AddJobHangFire();
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    private async Task AddJobHangFire()
    {
        //Agendado
        BackgroundJob.Schedule(() => Print("Schedule", null), TimeSpan.FromSeconds(5));

        //Fila
        var jobId = BackgroundJob.Enqueue("test", () => Print("Test in Queue", null));

        //Roda um processo a partir de um Id Pai
        BackgroundJob.ContinueJobWith(jobId, () => Print("Starts after you finish JobId", null));
        
        //Recorrente
        RecurringJob.AddOrUpdate("ReccuringJob", ()=> Print("Recurring", null), MinuteInterval(5));
    }

    public void Print(string message, PerformContext? context)
    {
        context.WriteLine(message);
    }
    
    private static string MinuteInterval(int interval)
    {
        return $"*/{interval} * * * *";
    }
}