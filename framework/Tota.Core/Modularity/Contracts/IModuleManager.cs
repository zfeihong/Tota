using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Tota.Modularity;

/// <summary>
/// Defines a module manager that is used to manage modules.
/// </summary>
public interface IModuleManager
{
    Task InitModulesAsync([NotNull] AppInitContext context);

    void InitModules([NotNull] ApplInitContext context);

    void ShutdownModules([NotNull] AppShutdownContext context);

    Task ShutdownModulesAsync([NotNull] AppShutdownContext context);
}
