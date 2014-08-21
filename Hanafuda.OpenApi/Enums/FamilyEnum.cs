using Hanafuda.OpenApi.Attributes;
using System;

namespace Hanafuda.OpenApi.Enums
{
    /// <summary>
    /// Families
    /// </summary>
    [Flags]
    public enum FamilyEnum
    {
        [Score(1)]
        Normal = 0,

        [Score(10)]
        Animal = 1,

        [Score(5)]
        Ribbon = 2,

        [Score(20)]
        Special = 4
    }
}
