using System.Collections.Generic;

namespace FishNotify;

public class OpcodeRegion
{
    public string? Version { get; set; }
    public string? Region { get; set; }
    public Dictionary<string, List<OpcodeList>>? Lists { get; set; }
}
