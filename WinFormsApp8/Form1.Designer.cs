namespace WinFormsApp8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.listBox1 = new MaterialSkin.Controls.MaterialListBox();
            this.checkBox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkBox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkBox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkBox4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkBox5 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.PasswordLengthNumeric = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 64);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Длина";
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(6, 169);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(375, 48);
            this.materialTextBox21.TabIndex = 2;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.Color.DarkOrange;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(26, 441);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Generate";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderColor = System.Drawing.Color.LightGray;
            this.listBox1.Depth = 0;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listBox1.Location = new System.Drawing.Point(470, 85);
            this.listBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectedIndex = -1;
            this.listBox1.SelectedItem = null;
            this.listBox1.Size = new System.Drawing.Size(304, 413);
            this.listBox1.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Depth = 0;
            this.checkBox1.Location = new System.Drawing.Point(26, 239);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.ReadOnly = false;
            this.checkBox1.Ripple = true;
            this.checkBox1.Size = new System.Drawing.Size(89, 37);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Цифры";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Depth = 0;
            this.checkBox2.Location = new System.Drawing.Point(26, 276);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.ReadOnly = false;
            this.checkBox2.Ripple = true;
            this.checkBox2.Size = new System.Drawing.Size(170, 37);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Маленькие буквы";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Depth = 0;
            this.checkBox3.Location = new System.Drawing.Point(26, 313);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.ReadOnly = false;
            this.checkBox3.Ripple = true;
            this.checkBox3.Size = new System.Drawing.Size(168, 37);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Заглавные буквы";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Depth = 0;
            this.checkBox4.Location = new System.Drawing.Point(26, 350);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.ReadOnly = false;
            this.checkBox4.Ripple = true;
            this.checkBox4.Size = new System.Drawing.Size(211, 37);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "Спецыальные символы";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Depth = 0;
            this.checkBox5.Location = new System.Drawing.Point(26, 387);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox5.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.ReadOnly = false;
            this.checkBox5.Ripple = true;
            this.checkBox5.Size = new System.Drawing.Size(260, 37);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.Text = "Исключать похожие символы";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(27, 220);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Символы:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(6, 147);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(205, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Генерировать из символов";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(496, 64);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(225, 19);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.Text = "Нажмите, чтобы скопировать";
            // 
            // PasswordLengthNumeric
            // 
            this.PasswordLengthNumeric.AnimateReadOnly = false;
            this.PasswordLengthNumeric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PasswordLengthNumeric.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PasswordLengthNumeric.Depth = 0;
            this.PasswordLengthNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordLengthNumeric.HideSelection = true;
            this.PasswordLengthNumeric.LeadingIcon = null;
            this.PasswordLengthNumeric.Location = new System.Drawing.Point(6, 85);
            this.PasswordLengthNumeric.MaxLength = 32767;
            this.PasswordLengthNumeric.MouseState = MaterialSkin.MouseState.OUT;
            this.PasswordLengthNumeric.Name = "PasswordLengthNumeric";
            this.PasswordLengthNumeric.PasswordChar = '\0';
            this.PasswordLengthNumeric.PrefixSuffixText = null;
            this.PasswordLengthNumeric.ReadOnly = false;
            this.PasswordLengthNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordLengthNumeric.SelectedText = "";
            this.PasswordLengthNumeric.SelectionLength = 0;
            this.PasswordLengthNumeric.SelectionStart = 0;
            this.PasswordLengthNumeric.ShortcutsEnabled = true;
            this.PasswordLengthNumeric.Size = new System.Drawing.Size(375, 48);
            this.PasswordLengthNumeric.TabIndex = 15;
            this.PasswordLengthNumeric.TabStop = false;
            this.PasswordLengthNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordLengthNumeric.TrailingIcon = null;
            this.PasswordLengthNumeric.UseSystemPasswordChar = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.PasswordLengthNumeric);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialTextBox21);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Form1";
            this.Text = "PasswordMaker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialListBox listBox1;
        private MaterialSkin.Controls.MaterialCheckbox checkBox1;
        private MaterialSkin.Controls.MaterialCheckbox checkBox2;
        private MaterialSkin.Controls.MaterialCheckbox checkBox3;
        private MaterialSkin.Controls.MaterialCheckbox checkBox4;
        private MaterialSkin.Controls.MaterialCheckbox checkBox5;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 PasswordLengthNumeric;
    }
}