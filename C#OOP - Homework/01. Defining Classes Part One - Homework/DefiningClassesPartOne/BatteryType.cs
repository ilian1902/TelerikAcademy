
namespace DefiningClassesPartOne
{
    using System.ComponentModel;

    // Problem 3. Enumeration
    // Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.

    public enum BatteryType
    {
        NiMH,
        NiCd,
        [Description("Li-Ion")] // it`s not allowed enumerators name to contain a hyphen
        LiIon
    }
}
