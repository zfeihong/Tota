using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using JetBrains.Annotations;

using Tota.Core;

namespace Modularity.Contracts;

/// <summary>
/// 应用程序预初始化接口
/// 在应用程序初始化之前执行
/// </summary>
public interface IOnPreAppInit
{
    /// <summary>
    /// 异步执行应用程序预初始化
    /// </summary>
    /// <param name="context">应用程序初始化上下文</param>
    Task OnPreAppInitAsync([NotNull] AppInitContext context);

    /// <summary>
    /// 同步执行应用程序预初始化
    /// </summary>
    /// <param name="context">应用程序初始化上下文</param>
    void OnPreAppInit([NotNull] AppInitContext context);
}

/// <summary>
/// 应用程序初始化接口
/// 在应用程序初始化时执行
/// </summary>
public interface IOnAppInit
{
    /// <summary>
    /// 异步执行应用程序初始化
    /// </summary>
    /// <param name="context">应用程序初始化上下文</param>
    Task OnAppInitAsync([NotNull] AppInitContext context);

    /// <summary>
    /// 同步执行应用程序初始化
    /// </summary>
    /// <param name="context">应用程序初始化上下文</param>
    void OnAppInit([NotNull] AppInitContext context);
}

/// <summary>
/// 应用程序后初始化接口
/// 在应用程序初始化之后执行
/// </summary>
public interface IOnPostAppInit
{
    /// <summary>
    /// 异步执行应用程序后初始化
    /// </summary>
    /// <param name="context">应用程序初始化上下文</param>
    Task OnPostAppInitAsync([NotNull] AppInitContext context);

    /// <summary>
    /// 同步执行应用程序后初始化
    /// </summary>
    /// <param name="context">应用程序初始化上下文</param>
    void OnPostAppInit([NotNull] AppInitContext context);
}

/// <summary>
/// 应用程序关闭接口
/// 在应用程序关闭时执行
/// </summary>
public interface IOnAppShutdown
{
    /// <summary>
    /// 异步执行应用程序关闭
    /// </summary>
    /// <param name="context">应用程序关闭上下文</param>
    Task OnAppShutdownAsync([NotNull] AppShutdownContext context);

    /// <summary>
    /// 同步执行应用程序关闭
    /// </summary>
    /// <param name="context">应用程序关闭上下文</param>
    void OnAppShutdown([NotNull] AppShutdownContext context);
}
