using System;
using System.Collections.Generic;
using System.Reflection;

namespace Tota.Core.Modularity;

/// <summary>
/// Tota模块描述符接口
/// 用于描述模块的元数据信息，包括类型、程序集、依赖关系等
/// </summary>
public interface ITotaModuleDescriptor
{
    /// <summary>
    /// 获取模块的类型
    /// </summary>
    Type Type { get; }

    /// <summary>
    /// 获取模块所在的程序集
    /// </summary>
    Assembly Assembly { get; }
    
    /// <summary>
    /// 获取模块相关的所有程序集
    /// 包括模块自身及其依赖的程序集
    /// </summary>
    Assembly[] AllAssemblies { get; }

    /// <summary>
    /// 获取模块的实例
    /// </summary>
    ITotaModule Instance { get; }

    /// <summary>
    /// 获取模块是否作为插件加载
    /// </summary>
    bool IsLoadedAsPlugIn { get; }

    /// <summary>
    /// 获取模块的依赖项列表
    /// 返回该模块所依赖的其他模块描述符
    /// </summary>
    IReadOnlyList<ITotaModuleDescriptor> Dependencies { get; }
}