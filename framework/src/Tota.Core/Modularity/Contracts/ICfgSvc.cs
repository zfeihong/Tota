using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Tota.Core.Modularity;

namespace Modularity.Contracts;

/// <summary>
/// 服务预配置接口
/// </summary>
public interface IPreCfgSvcs
{
    /// <summary>
    /// 异步执行服务预配置
    /// </summary>
    /// <param name="context">服务配置上下文</param>
    Task PreCfgSvcAsync(SvcCfgContext context);

    /// <summary>
    /// 同步执行服务预配置
    /// </summary>
    /// <param name="context">服务配置上下文</param>
    void PreCfgSvc(SvcCfgContext context);
}

/// <summary>
/// 服务后配置接口
/// </summary>
public interface IPostCfgSvcs
{
    /// <summary>
    /// 异步执行服务后配置
    /// </summary>
    /// <param name="context">服务配置上下文</param>
    Task PostCfgSvcsAsync(SvcCfgContext context);

    /// <summary>
    /// 同步执行服务后配置
    /// </summary>
    /// <param name="context">服务配置上下文</param>
    void PostCfgSvcs(SvcCfgContext context);
}
