using System.Collections.Generic;
using System.Threading.Tasks;

using JetBrains.Annotations;

namespace Tota.Core.Modularity;

/// <summary>
/// 模块管理器
/// 负责管理应用程序中所有模块的生命周期，包括初始化和关闭
/// </summary>
public class ModuleManager : IModuleManager
{
    /// <summary>
    /// 异步初始化所有模块
    /// 按照依赖顺序依次调用每个模块的初始化方法
    /// </summary>
    /// <param name="context">应用程序初始化上下文</param>
    public Task InitModulesAsync([NotNull] AppInitContext context)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// 异步关闭所有模块
    /// 按照依赖顺序的反序依次调用每个模块的关闭方法
    /// </summary>
    /// <param name="context">应用程序关闭上下文</param>
    public Task ShutdownModulesAsync([NotNull] AppShutdownContext context)
    {
        throw new System.NotImplementedException();
    }
}