using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {

        [Test]
        public void CheckEmptywordTest()
        {
            string word = "";
            string letter = "�";
            string replace = "�";
            string actually = ��___3__����_�������_19_��_��1_.Lr_3.Sep(word, letter, replace);
            string expect = "";
            Assert.AreEqual(actually, expect);
        }
        [Test]
        public void CheckLetterTest()
        {
            string word = "�����������!";
            string letter = "�";
            string replace = "�";
            string actually = ��___3__����_�������_19_��_��1_.Lr_3.Sep(word, letter, replace);
            string expect = "�����������!";
            Assert.AreEqual(actually, expect);
        }
        [Test]
        public void CheckSymbolTest()
        {
            string word = "������  �����!";
            string letter = " ";
            string replace = "�";
            string actually = ��___3__����_�������_19_��_��1_.Lr_3.Sep(word, letter, replace);
            string expect = "�������������!";
            Assert.AreEqual(actually, expect);
        }
    } 
}