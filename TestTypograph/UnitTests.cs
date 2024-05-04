using Typograph;

namespace TestTypograph
{
    [TestClass]
    public class UnitTests
    {
        MainForm testForm = new MainForm();

        [TestMethod]
        public void TextWithLotsOfSpaces()
        {
            Assert.AreEqual("������, ���", testForm.EditText("������        ,���"));
        }

        [TestMethod]
        public void TextWith�ommas()
        {
            Assert.AreEqual("������, ����", testForm.EditText("������,����"));
        }

        [TestMethod]
        public void TextWithQuotationMarks()
        {
            Assert.AreEqual("������", testForm.EditText("\"�����\""));
        }

        [TestMethod]
        public void TextWithEllipsis()
        {
            Assert.AreEqual("���-��", testForm.EditText("���-��..."));
        }

        [TestMethod]
        public void TextWithPlusMinus()
        {
            Assert.AreEqual("��������", testForm.EditText("+-�������"));
        }

        [TestMethod]
        public void TextWithLaughter()
        {
            Assert.AreEqual("����� ������", testForm.EditText("������"));
        }

        [TestMethod]
        public void TextWithUpperFirstChar()
        {
            Assert.AreEqual("������, ���", testForm.EditText("������,���"));
        }

        [TestMethod]
        public void TextWithMailChar()
        {
            Assert.AreEqual("������, ������", testForm.EditText("������,@"));
        }

        [TestMethod]
        public void CheckText()
        {
            Assert.AreEqual("������, ����. �� ��� ������ ��������", testForm.EditText("������,����.�� ��� ������ +-�������"));
        }

        [TestMethod]
        public void CheckText_2()
        {
            Assert.AreEqual("� ���� ��������� ������. � ��� ����� ������ ������!", testForm.EditText("� ���� ��������� @.� ��� ������ ������!"));
        }
    }
}