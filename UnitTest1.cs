using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LabWork10;

namespace LabWork10Tests
{
    public class PasswordValidatorTests
    {
        [Theory]
        [InlineData("Password1")]
        [InlineData("asddads1")]
        [InlineData("1234567a")]
        [InlineData("A1!?@&^%#2%")]
        [InlineData("Пароль123abc")]
        [InlineData("LongPassword123124124312312")]
        public void IsValid_COrrectPassword_ReturnsTrue(string password)
        {
            Assert.True(PasswordValidator.IsValid(password));
        }

        [Fact]
        public void IsValid_Null_ReturnsFalse()
        {
            Assert.False(PasswordValidator.IsValid(null));
        }

        [Fact]
        public void IsValid_EmptyString_ReturnsFalse()
        {
            Assert.False(PasswordValidator.IsValid(""));
        }

        [Theory]
        [InlineData("Pass1")]
        [InlineData("asdfgh7")]
        public void IsValid_TooShort_ReturnsFalse(string password)
        {
            Assert.False(PasswordValidator.IsValid(password));
        }

        [Theory]
        [InlineData("BezCiferok")]
        [InlineData("asdfqweqw")]
        public void IsValid_NoDigit_ReturnsFalse(string password)
        {
            Assert.False(PasswordValidator.IsValid(password));
        }

        [Theory]
        [InlineData("123423425")]
        [InlineData("12412343$")]
        public void IsValid_NoLatinLetter_ReturnsFalse(string password)
        {
            Assert.False(PasswordValidator.IsValid(password));
        }

        [Theory]
        [InlineData("ПарольКлассныйНоХЗ2")]
        [InlineData("ПарольГовно1")]
        public void IsValid_CirilicAndDigit_ReturnsFalse(string password)
        {
            Assert.False(PasswordValidator.IsValid(password));
        }

        [Theory]
        [InlineData("           ")]
        [InlineData("!!!№$#$;!;??")]
        public void IsValid_OnlySpacesOrSymbols_ReturnsFalse(string password)
        {
            Assert.False(PasswordValidator.IsValid(password));
        }
    }
}