using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reverser_Text
{
    public partial class TextControl : Form
    {
        Form1 parent;
        TextControl control;
        public TextControl(Form1 form)
        {
            InitializeComponent();
            parent = form;
            System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
            foreach (FontFamily font in fonts.Families)
            {
                comboBox1.Items.Add(font.Name);
            }
        }

        private void TextControl_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBoxStyle.SelectedIndex = 0;
        }
        public void TextFont()
        {
            int TextFontSize = int.Parse(numericSize.Value.ToString());
            string FontFamily = comboBox1.SelectedItem as string;
            var fs = (FontStyle)Enum.Parse(typeof(FontStyle), (string)comboBoxStyle.SelectedItem);
            parent.richTextBoxInput.Font = new Font(FontFamily, (float)TextFontSize, fs);
            parent.richTextBoxOutput.Font = new Font(FontFamily, (float)TextFontSize, fs);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            TextFont();
            if (MessageBox.Show("Вы хотите применить настройки?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
            parent.Activate();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
