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
            // ������ �������
            text = text.Replace("...", "�");          
            // ������ �������
            text = text.Replace("+-", "�");
            // ������ �������
            text = Regex.Replace(text, @" ([?,:;!.])", "$1");
            text = Regex.Replace(text, @"([?,:;!.])", "$1 ");
            text = text.Replace("\" ", @"""");
            text = text.Replace(" \"", @"""");
            // ��������� �������
            text = Regex.Replace(text, "\"", newChar =>
            {
                if (first)
                {
                    first = false;
                    return "�";
                }
                else
                {
                    first = true;
                    return "�";
                }
            });
            // ����� �������
            text = Regex.Replace(text, @"\s{2,}", " ");
            text = Regex.Replace(text, @" ([?,:;!.])", "$1");
            // ������ �������
            text = text.Replace("������", "����� ������");
            //������� �������
            text = Char.ToUpper(text[0]) + text.Substring(1);
            //������� �������
            text = text.Replace("@", "������");
            return text.Trim();
        }
    }
}
