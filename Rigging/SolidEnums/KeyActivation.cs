using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class KeyActivation : StaticEnumeration
{
    private KeyActivation(int index, string name) : base(index, name) { }

    public static readonly KeyActivation Q = new KeyActivation(1, "Q");
    public static readonly KeyActivation W = new KeyActivation(2, "W");
    public static readonly KeyActivation E = new KeyActivation(3, "E");
    public static readonly KeyActivation R = new KeyActivation(4, "R");
    public static readonly KeyActivation P = new KeyActivation(0, "P");

    public static readonly List<KeyActivation> byIndex = new List<KeyActivation>() { Q, W, E, R, P };

    public static int Count = byIndex.Count();
}

public enum KeyActivationIndexer
{
    Q = 0,
    W = 1,
    E = 2,
    R = 3,
    P = 4
}
