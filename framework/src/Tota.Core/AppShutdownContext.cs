using System;
using System.Collections.Generic;
using System.Text;

using JetBrains.Annotations;

namespace Tota.Core;

/// <summary>
/// 应用程序关闭上下文
/// 用于在应用程序关闭过程中传递必要的上下文信息
/// </summary>
public class AppShutdownContext
{
    /// <summary>
    /// 获取服务提供者实例
    /// 用于在关闭过程中访问已注册的服务
    /// </summary>
    public IServiceProvider ServiceProvider { get; }

    /// <summary>
    /// 初始化应用程序关闭上下文的新实例
    /// </summary>
    /// <param name="serviceProvider">服务提供者实例</param>
    public AppShutdownContext([NotNull] IServiceProvider serviceProvider)
    {
        ServiceProvider = serviceProvider;
    }
}
