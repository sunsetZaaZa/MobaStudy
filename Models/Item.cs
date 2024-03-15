using MobaGains.Rigging.Enum;

namespace MobaGains.Models;

public class Item
{
    public int id { get; set; }
    public int name { get; set; }
    public int description { get; set; }
    public ItemType type { get; set; }
}
