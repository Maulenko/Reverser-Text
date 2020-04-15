using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Reverser_Text
{
    public partial class Form1 : Form
    {
        Translit translit = new Translit();
        TextControl control;
        public Form1()
        {
            InitializeComponent();
        }

        public void buttonSwap_Click(object sender, EventArgs e)
        {
            (labelUp.Text, labelDown.Text) = (labelDown.Text, labelUp.Text);
            (richTextBoxInput.Text, richTextBoxOutput.Text) = (richTextBoxOutput.Text, richTextBoxInput.Text);

        }
        

        public void buttonReverse_Click(object sender, EventArgs e)
        {
            if (labelUp.Text == "Русский")
            {
                richTextBoxOutput.Text = translit.TranslitRus(richTextBoxInput.Text);
            }
            if (labelUp.Text == "English")
            {
                richTextBoxOutput.Text = translit.TranslitEng(richTextBoxInput.Text);
            }
        }

        public void VK_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://vk.com/maulenko");
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(VK, "По всем вопросам обращаться в ВК.");
            t.SetToolTip(richTextBoxInput, "Введите текст, который хотите преобразовать.");
            t.SetToolTip(richTextBoxOutput, "Преобразованный текст.");
            t.SetToolTip(buttonReverse, "Преобразовать текст.");
            t.SetToolTip(buttonSwap, "Изменить язык преобразования.");
        }

        public void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            control = new TextControl(this);
            control.Visible = true;
            
        }

        private void buttonCopyUp_Click(object sender, EventArgs e)
        {
            var data = new DataObject();
            data.SetData(DataFormats.UnicodeText, true, richTextBoxInput.Text);
            var thread = new Thread(() => Clipboard.SetDataObject(data, true));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }

        private void buttonCopyDown_Click(object sender, EventArgs e)
        {
            var data = new DataObject();
            data.SetData(DataFormats.UnicodeText, true, richTextBoxOutput.Text);
            var thread = new Thread(() => Clipboard.SetDataObject(data, true));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = "Сохранить";
                sfd.Filter = "txt files (*.txt)|*.txt";
                sfd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

                if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter SW = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write));
                        if (richTextBoxInput.Text != null && richTextBoxOutput.Text != null)
                        {
                            if (labelUp.Text == "Русский")
                            {
                                SW.Write($"[Русский]\n{richTextBoxInput.Text}\n\n[English]\n{richTextBoxOutput.Text}");
                                SW.Flush();
                            }
                            if (labelUp.Text == "English")
                            {
                                SW.Write($"[Русский]\n{richTextBoxOutput.Text}\n\n[English]\n{richTextBoxInput.Text}");
                                SW.Flush();
                            }
                                SW.Close();
                                SW.Dispose();
                                MessageBox.Show("Файл сохранен.");

                            
                        }
                        else
                            MessageBox.Show("Поле не может быть пустым.");
                    }
                }
            }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
            else
                return;
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("По всем вопросам обращаться в ВК по кнопке.");
        }
    }
    
}
