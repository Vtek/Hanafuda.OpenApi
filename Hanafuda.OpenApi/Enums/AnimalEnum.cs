using System;

namespace Hanafuda.OpenApi.Enums
{
    /// <summary>
    /// Animals
    /// </summary>
    [Flags]
    public enum AnimalEnum
    {
        BushWarbler = 0,
        Cuckoo = 1,
        Iris = 2,
        Butterflies = 4,
        Boar = 8,
        Geese = 16,
        SakeCup = 32,
        Deer = 64,
        Swallow = 128
    }
}
