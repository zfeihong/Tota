using System.Collections.Generic;

using JetBrains.Annotations;

using Microsoft.Extensions.DependencyInjection;

namespace Tota.Core.Modularity;

/// <summary>
/// 服务配置上下文
/// 用于在模块服务配置过程中传递必要的上下文信息
/// 包括服务集合和模块间共享的数据项
/// </summary>
public class SvcCfgContext
{
    /// <summary>
    /// 获取服务集合
    /// 用于注册和配置模块的服务
    /// </summary>
    public IServiceCollection Services { get; }

    /// <summary>
    /// 获取模块间共享的数据项字典
    /// 用于在服务配置阶段存储和共享模块间的数据
    /// </summary>
    public IDictionary<string, object?> Items { get; }

    /// <summary>
    /// 获取或设置在服务注册阶段可以存储并在模块之间共享的任意命名对象
    /// 这是对 <see cref="Items"/> 字典的简化用法
    /// 如果指定的键在 <see cref="Items"/> 字典中未找到，则返回 null
    /// </summary>
    /// <param name="key">数据项的键名</param>
    /// <returns>存储的数据项值，如果未找到则返回 null</returns>
    public object? this[string key] {
        get => Items.TryGetValue(key, out var obj);
        set => Items[key] = value;
    }

    /// <summary>
    /// 初始化服务配置上下文的新实例
    /// </summary>
    /// <param name="services">服务集合实例</param>
    public SvcCfgContext([NotNull] IServiceCollection services)
    {
        Services = services;
        Items = new Dictionary<string, object?>();
    }
}