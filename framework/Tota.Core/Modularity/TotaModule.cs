namespace Tota.Modularity;

/// <summary>
/// 
/// </summary>
public abstract class TotaModule :
    ITotaModule,
    IOnPreApplicationInitialization,
    IOnApplicationInitialization,
    IOnPostApplicationInitialization,
    IOnApplicationShutdown,
    IPreConfigureServices,
    IPostConfigureServices
{
    // ... existing code ...
}