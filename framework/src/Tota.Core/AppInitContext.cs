using System;
using System.Collections.Generic;
using System.Text;

using JetBrains.Annotations;

namespace Tota.Core;

/// <summary>
/// 应用程序初始化上下文
/// 用于在应用程序初始化过程中传递必要的上下文信息
/// </summary>
public class AppInitContext
{
    /// <summary>
    /// 获取或设置服务提供者实例
    /// 用于在初始化过程中访问已注册的服务
    /// </summary>
    public IServiceProvider ServiceProvider { get; set; }

    /// <summary>
    /// 初始化应用程序初始化上下文的新实例
    /// </summary>
    /// <param name="serviceProvider">服务提供者实例</param>
    public AppInitContext([NotNull] IServiceProvider serviceProvider)
    {
        ServiceProvider = serviceProvider;
    }
}
