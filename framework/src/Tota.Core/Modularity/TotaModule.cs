using System.Threading.Tasks;

using JetBrains.Annotations;

using Modularity.Contracts;

namespace Tota.Core.Modularity;

/// <summary>
/// Tota模块实例
/// 提供了模块生命周期中各个阶段的默认实现
/// 包括服务配置、应用程序初始化和关闭等
/// </summary>
public abstract class TotaModule :
    ITotaModule,
    IOnPreAppInit,
    IOnAppInit,
    IOnPostAppInit,
    IOnAppShutdown,
    IPreCfgSvcs,
    IPostCfgSvcs
{
    /// <summary>
    /// 同步配置模块服务
    /// </summary>
    /// <param name="context">服务配置上下文</param>
    public void CfgSvcs(SvcCfgContext context)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// 异步配置模块服务
    /// </summary>
    /// <param name="context">服务配置上下文</param>
    public Task CfgSvcsAsync(SvcCfgContext context)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// 同步执行应用程序初始化
    /// </summary>
    /// <param name="context">应用程序初始化上下文</param>
    public void OnAppInit([NotNull] AppInitContext context)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// 异步执行应用程序初始化
    /// </summary>
    /// <param name="context">应用程序初始化上下文</param>
    public Task OnAppInitAsync([NotNull] AppInitContext context)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// 同步执行应用程序关闭
    /// </summary>
    /// <param name="context">应用程序关闭上下文</param>
    public void OnAppShutdown([NotNull] AppShutdownContext context)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// 异步执行应用程序关闭
    /// </summary>
    /// <param name="context">应用程序关闭上下文</param>
    public Task OnAppShutdownAsync([NotNull] AppShutdownContext context)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// 同步执行应用程序后初始化
    /// </summary>
    /// <param name="context">应用程序初始化上下文</param>
    public void OnPostAppInit([NotNull] AppInitContext context)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// 异步执行应用程序后初始化
    /// </summary>
    /// <param name="context">应用程序初始化上下文</param>
    public Task OnPostAppInitAsync([NotNull] AppInitContext context)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// 同步执行应用程序预初始化
    /// </summary>
    /// <param name="context">应用程序初始化上下文</param>
    public void OnPreAppInit([NotNull] AppInitContext context)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// 异步执行应用程序预初始化
    /// </summary>
    /// <param name="context">应用程序初始化上下文</param>
    public Task OnPreAppInitAsync([NotNull] AppInitContext context)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// 同步执行服务后配置
    /// </summary>
    /// <param name="context">服务配置上下文</param>
    public void PostCfgSvcs(SvcCfgContext context)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// 异步执行服务后配置
    /// </summary>
    /// <param name="context">服务配置上下文</param>
    public Task PostCfgSvcsAsync(SvcCfgContext context)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// 同步执行服务预配置
    /// </summary>
    /// <param name="context">服务配置上下文</param>
    public void PreCfgSvc(SvcCfgContext context)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// 异步执行服务预配置
    /// </summary>
    /// <param name="context">服务配置上下文</param>
    public Task PreCfgSvcAsync(SvcCfgContext context)
    {
        throw new System.NotImplementedException();
    }
}