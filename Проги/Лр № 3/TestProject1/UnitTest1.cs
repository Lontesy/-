using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringHandlerTest
{

   
        class UnitTest2
        {
            static object[] CheckSymbols = {
            new object[] { "Привет  ствую!", " ", "ю", "Приветююствую!" },
            new object[] { "Привет!!!", "!", ".", "Привет..." },
            new object[] { "Project.", ".", "/", "Project/" }
        };

            [TestCase("", "в", "ю", "")]
            [TestCase("", "ю", "в", "")]
            [TestCase("", "o", "r", "")]
            public void CheckEmptywordTest(string word, string letter, string replace, string expect)
            {
                string actually = Лр___3__ТОПО_Кравцов_19_КБ_ПР1_.Lr_3.Sep(word, letter, replace);
                Assert.AreEqual(actually, expect);
            }

            [TestCase("Приветствую!", "в", "ю", "Приюетстюую!")]
            [TestCase("Привет!", "в", "ю", "Приюет!")]
            [TestCase("Project", "o", "r", "Prrject")]
            public void CheckLetterTest(string word, string letter, string replace, string expect)
            {
                string actually = Лр___3__ТОПО_Кравцов_19_КБ_ПР1_.Lr_3.Sep(word, letter, replace);
                Assert.AreEqual(actually, expect);
            }

            [TestCaseSource("CheckSymbols")]
            public void CheckSymbolTest(string word, string letter, string replace, string expect)
            {
                string actually = Лр___3__ТОПО_Кравцов_19_КБ_ПР1_.Lr_3.Sep(word, letter, replace);
                Assert.AreEqual(actually, expect);
            }

        }
  }   



