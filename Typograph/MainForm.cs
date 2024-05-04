using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Typograph
{
    public partial class MainForm : Form
    {
        bool first = true;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Output.Text = EditText(Input.Text);
        }
        public string EditText(string text)
        {
            // Первое правило
            text = text.Replace("...", "…");          
            // Второе правило
            text = text.Replace("+-", "±");
            // Третье правило
            text = Regex.Replace(text, @" ([?,:;!.])", "$1");
            text = Regex.Replace(text, @"([?,:;!.])", "$1 ");
            text = text.Replace("\" ", @"""");
            text = text.Replace(" \"", @"""");
            // Четвертое правило
            text = Regex.Replace(text, "\"", newChar =>
            {
                if (first)
                {
                    first = false;
                    return "«";
                }
                else
                {
                    first = true;
                    return "»";
                }
            });
            // Пятое правило
            text = Regex.Replace(text, @"\s{2,}", " ");
            text = Regex.Replace(text, @" ([?,:;!.])", "$1");
            // Шестое правило
            text = text.Replace("ХАХАХА", "ОЧЕНЬ СМЕШНО");
            //Седьмое правило
            text = Char.ToUpper(text[0]) + text.Substring(1);
            //Восьмое правило
            text = text.Replace("@", "СОБАКА");
            return text.Trim();
        }
    }
}
