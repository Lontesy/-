using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {

        [Test]
        public void CheckEmptywordTest()
        {
            string word = "";
            string letter = "в";
            string replace = "ю";
            string actually = Лр___3__ТОПО_Кравцов_19_КБ_ПР1_.Lr_3.Sep(word, letter, replace);
            string expect = "";
            Assert.AreEqual(actually, expect);
        }
        [Test]
        public void CheckLetterTest()
        {
            string word = "Приветствую!";
            string letter = "в";
            string replace = "ю";
            string actually = Лр___3__ТОПО_Кравцов_19_КБ_ПР1_.Lr_3.Sep(word, letter, replace);
            string expect = "Приюетстюую!";
            Assert.AreEqual(actually, expect);
        }
        [Test]
        public void CheckSymbolTest()
        {
            string word = "Привет  ствую!";
            string letter = " ";
            string replace = "ю";
            string actually = Лр___3__ТОПО_Кравцов_19_КБ_ПР1_.Lr_3.Sep(word, letter, replace);
            string expect = "Приветююствую!";
            Assert.AreEqual(actually, expect);
        }
    } 
}