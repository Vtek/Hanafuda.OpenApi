using Hanafuda.OpenApi.Attributes;

namespace Hanafuda.OpenApi.Test.Extensions.Data
{
    public enum TestEnum
    {
        [Kanji("Name", "Symbol")]
        WithKanji,
        WithoutKanji,
        [Score(1)]
        WithScore,
        WithoutScore
    }
}
