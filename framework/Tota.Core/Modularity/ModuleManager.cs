
namespace Tota.Modularity;

/// <summary>
/// ModuleManager is a class that manages modules.
/// </summary>
public class ModuleManager : IModuleManager
{
    private readonly List<IModule> _modules = new List<IModule>();

    public void AddModule(IModule module)
    {
        _modules.Add(module);
    }

    public void InitializeAll()
    {
        foreach (var module in _modules)
        {
            module.Initialize();
        }
    }

    public void ShutdownAll()
    {
        foreach (var module in _modules)
        {
            module.Shutdown();
        }
    }
}