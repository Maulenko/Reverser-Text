namespace Reverser_Text
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.labelUp = new System.Windows.Forms.Label();
            this.labelDown = new System.Windows.Forms.Label();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.VK = new System.Windows.Forms.Button();
            this.UpMenu = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCopyDown = new System.Windows.Forms.Button();
            this.buttonCopyUp = new System.Windows.Forms.Button();
            this.UpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxInput.Location = new System.Drawing.Point(0, 24);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(800, 165);
            this.richTextBoxInput.TabIndex = 0;
            this.richTextBoxInput.Text = "";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxOutput.Location = new System.Drawing.Point(0, 285);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(800, 165);
            this.richTextBoxOutput.TabIndex = 1;
            this.richTextBoxOutput.Text = "";
            // 
            // labelUp
            // 
            this.labelUp.AutoSize = true;
            this.labelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUp.Location = new System.Drawing.Point(0, 189);
            this.labelUp.Name = "labelUp";
            this.labelUp.Size = new System.Drawing.Size(49, 13);
            this.labelUp.TabIndex = 3;
            this.labelUp.Text = "Русский";
            // 
            // labelDown
            // 
            this.labelDown.AutoSize = true;
            this.labelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelDown.Location = new System.Drawing.Point(0, 272);
            this.labelDown.Name = "labelDown";
            this.labelDown.Size = new System.Drawing.Size(41, 13);
            this.labelDown.TabIndex = 4;
            this.labelDown.Text = "English";
            // 
            // buttonSwap
            // 
            this.buttonSwap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSwap.BackgroundImage")));
            this.buttonSwap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSwap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSwap.FlatAppearance.BorderSize = 0;
            this.buttonSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwap.Location = new System.Drawing.Point(12, 221);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(38, 35);
            this.buttonSwap.TabIndex = 5;
            this.buttonSwap.UseVisualStyleBackColor = true;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // buttonReverse
            // 
            this.buttonReverse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonReverse.BackgroundImage")));
            this.buttonReverse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReverse.FlatAppearance.BorderSize = 0;
            this.buttonReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReverse.Location = new System.Drawing.Point(56, 204);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(81, 68);
            this.buttonReverse.TabIndex = 6;
            this.buttonReverse.UseVisualStyleBackColor = true;
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCopyright.Location = new System.Drawing.Point(706, 252);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(82, 15);
            this.labelCopyright.TabIndex = 7;
            this.labelCopyright.Text = "© Maulenko";
            // 
            // VK
            // 
            this.VK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VK.BackgroundImage")));
            this.VK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VK.FlatAppearance.BorderSize = 0;
            this.VK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VK.Location = new System.Drawing.Point(741, 199);
            this.VK.Name = "VK";
            this.VK.Size = new System.Drawing.Size(45, 45);
            this.VK.TabIndex = 8;
            this.VK.UseVisualStyleBackColor = true;
            this.VK.Click += new System.EventHandler(this.VK_Click);
            // 
            // UpMenu
            // 
            this.UpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.UpMenu.Location = new System.Drawing.Point(0, 0);
            this.UpMenu.Name = "UpMenu";
            this.UpMenu.Size = new System.Drawing.Size(800, 24);
            this.UpMenu.TabIndex = 9;
            this.UpMenu.Text = "UpMenu";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.шрифтToolStripMenuItem.Text = "Текст";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // buttonCopyDown
            // 
            this.buttonCopyDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCopyDown.BackgroundImage")));
            this.buttonCopyDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCopyDown.FlatAppearance.BorderSize = 0;
            this.buttonCopyDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopyDown.Location = new System.Drawing.Point(760, 410);
            this.buttonCopyDown.Name = "buttonCopyDown";
            this.buttonCopyDown.Size = new System.Drawing.Size(40, 40);
            this.buttonCopyDown.TabIndex = 10;
            this.buttonCopyDown.UseVisualStyleBackColor = true;
            this.buttonCopyDown.Click += new System.EventHandler(this.buttonCopyDown_Click);
            // 
            // buttonCopyUp
            // 
            this.buttonCopyUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCopyUp.BackgroundImage")));
            this.buttonCopyUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCopyUp.FlatAppearance.BorderSize = 0;
            this.buttonCopyUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopyUp.Location = new System.Drawing.Point(760, 149);
            this.buttonCopyUp.Name = "buttonCopyUp";
            this.buttonCopyUp.Size = new System.Drawing.Size(40, 40);
            this.buttonCopyUp.TabIndex = 11;
            this.buttonCopyUp.UseVisualStyleBackColor = true;
            this.buttonCopyUp.Click += new System.EventHandler(this.buttonCopyUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCopyUp);
            this.Controls.Add(this.buttonCopyDown);
            this.Controls.Add(this.VK);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.buttonReverse);
            this.Controls.Add(this.buttonSwap);
            this.Controls.Add(this.labelDown);
            this.Controls.Add(this.labelUp);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.UpMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.UpMenu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reverser Text";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UpMenu.ResumeLayout(false);
            this.UpMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBoxInput;
        public System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Label labelUp;
        private System.Windows.Forms.Label labelDown;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Button VK;
        private System.Windows.Forms.MenuStrip UpMenu;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.Button buttonCopyDown;
        private System.Windows.Forms.Button buttonCopyUp;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

