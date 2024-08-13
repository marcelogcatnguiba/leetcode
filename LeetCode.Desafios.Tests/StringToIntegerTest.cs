using System.ComponentModel;
using LeetCode.Desafios.Facil;

namespace LeetCode.Desafios.Tests
{
    public class StringToIntegerTest
    {
        [Theory]
        [InlineData("42")]
        [DisplayName("StringToInt")]
        public void DeveRetornarUmNumero(string s)
        {
            var converter = new StringToInteger();

            Assert.Equal(42, converter.Converter(s));
        }

        [Theory]
        [InlineData("-42")]
        [DisplayName("StringToInt")]
        public void DeveRetornarUmNumeroNegativo(string s)
        {
            var converter = new StringToInteger();

            Assert.Equal(-42, converter.Converter(s));
        }

        [Theory]
        [InlineData("      42")]
        [DisplayName("StringToInt")]
        public void DeveRetornarUmNumeroEliminandoOsEspacos(string s)
        {
            var converter = new StringToInteger();

            Assert.Equal(42, converter.Converter(s));
        }
    }
}