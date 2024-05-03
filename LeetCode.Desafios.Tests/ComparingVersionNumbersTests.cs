using LeetCode.Desafios.Facil;

namespace LeetCode.Desafios.Tests
{
    public class ComparingVersionNumbersTests
    {
        [Theory]
        [InlineData("1.0", "2.0")]
        [InlineData("0.1", "1.0")]
        [InlineData("1", "1.1")]
        public void PrimeiraVersaoDeveRetornarMenor(string v1, string v2)
        {
            var version = new VersionComparer();
            var result = version.Comparer(v1, v2);

            Assert.Equal(-1, result);
        }

        [Theory]
        [InlineData("2.0", "1.0")]
        [InlineData("1.1", "1.0")]
        [InlineData("1.0.1", "1")]
        public void PrimeiraVersaoDeveRetornarMaior(string v1, string v2)
        {
            var version = new VersionComparer();
            var result = version.Comparer(v1, v2);

            Assert.Equal(1, result);
        }

        [Theory]
        [InlineData("1.0", "1.0")]
        [InlineData("1.000001", "1.01")]
        [InlineData("1.0.0", "1.0")]
        [InlineData("1.0", "1")]
        public void DeveRetornarIgual(string v1, string v2)
        {
            var version = new VersionComparer();
            var result = version.Comparer(v2, v1);

            Assert.Equal(0, result);

        }
    }
}