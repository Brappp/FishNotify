using Dalamud.Configuration;

namespace FishNotify;

internal sealed class Configuration : IPluginConfiguration
{
    public int Version { get; set; } = 0;
    public bool ChatAlerts { get; set; } = false;
}
