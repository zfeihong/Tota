using System.Threading.Tasks;

namespace Tota.Core.Modularity;

/// <summary>
/// Tota模块接口
/// 定义模块的基本行为，包括服务配置等
/// </summary>
public interface ITotaModule
{
    /// <summary>
    /// 异步配置模块服务
    /// </summary>
    /// <param name="context">服务配置上下文</param>
    Task CfgSvcsAsync(SvcCfgContext context);

    /// <summary>
    /// 同步配置模块服务
    /// </summary>
    /// <param name="context">服务配置上下文</param>
    void CfgSvcs(SvcCfgContext context);
}