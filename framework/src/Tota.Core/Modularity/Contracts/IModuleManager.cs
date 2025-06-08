using System.Threading.Tasks;
using JetBrains.Annotations;

using Tota.Core;

namespace Tota.Core.Modularity;

/// <summary>
/// 模块管理器接口
/// </summary>
public interface IModuleManager
{
    /// <summary>
    /// 异步初始化所有模块
    /// </summary>
    /// <param name="context">应用程序初始化上下文</param>
    Task InitModulesAsync([NotNull] AppInitContext context);

    /// <summary>
    /// 异步关闭所有模块
    /// </summary>
    /// <param name="context">应用程序关闭上下文</param>
    Task ShutdownModulesAsync([NotNull] AppShutdownContext context);
}
