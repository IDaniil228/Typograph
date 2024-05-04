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
            Assert.AreEqual("Привет, мир", testForm.EditText("Привет        ,мир"));
        }

        [TestMethod]
        public void TextWithСommas()
        {
            Assert.AreEqual("Привет, Маша", testForm.EditText("Привет,Маша"));
        }

        [TestMethod]
        public void TextWithQuotationMarks()
        {
            Assert.AreEqual("«Текст»", testForm.EditText("\"Текст\""));
        }

        [TestMethod]
        public void TextWithEllipsis()
        {
            Assert.AreEqual("Что-то…", testForm.EditText("Что-то..."));
        }

        [TestMethod]
        public void TextWithPlusMinus()
        {
            Assert.AreEqual("±миллион", testForm.EditText("+-миллион"));
        }

        [TestMethod]
        public void TextWithLaughter()
        {
            Assert.AreEqual("ОЧЕНЬ СМЕШНО", testForm.EditText("ХАХАХА"));
        }

        [TestMethod]
        public void TextWithUpperFirstChar()
        {
            Assert.AreEqual("Привет, мир", testForm.EditText("привет,мир"));
        }

        [TestMethod]
        public void TextWithMailChar()
        {
            Assert.AreEqual("Привет, СОБАКА", testForm.EditText("привет,@"));
        }

        [TestMethod]
        public void CheckText()
        {
            Assert.AreEqual("Привет, Дима. Ты мне должен ±миллион", testForm.EditText("привет,Дима.Ты мне должен +-миллион"));
        }

        [TestMethod]
        public void CheckText_2()
        {
            Assert.AreEqual("У меня появилась СОБАКА. С ней ОЧЕНЬ СМЕШНО играть!", testForm.EditText("у меня появилась @.С ней ХАХАХА играть!"));
        }
    }
}