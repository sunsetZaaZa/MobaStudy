using System.Reflection;

namespace MobaGains.Rigging.Utilities;

public abstract class StaticEnumeration
{
    private readonly int index;
    private readonly string? displayName;

    protected StaticEnumeration(int index, string? displayName)
    {
        this.index = index;
        this.displayName = displayName;
    }

    public int Index
    {
        get { return index; }
    }

    public string? DisplayName
    {
        get { return displayName; }
    }

    public override bool Equals(object obj)
    {
        var otherValue = obj as StaticEnumeration;

        if (otherValue == null)
        {
            return false;
        }

        var typeMatches = GetType().Equals(obj.GetType());
        var valueMatches = index.Equals(otherValue.Index);

        return typeMatches && valueMatches;
    }

    public override int GetHashCode()
    {
        return index.GetHashCode();
    }
}
