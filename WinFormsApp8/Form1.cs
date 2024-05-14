using MaterialSkin;
using MaterialSkin.Controls;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool[] Modifiers() => new bool[5]
            {
                checkBox1.Checked,
                checkBox2.Checked,
                checkBox3.Checked,
                checkBox4.Checked,
                checkBox5.Checked
            };
        bool IsChekedNoRepetitions()
        {
            if (checkBox5.Checked)
            {
                bool[] options = Modifiers();
                int number = 0;
                if (options[0]) number += 10;
                if (options[1]) number += 26;
                if (options[2]) number += 26;
                if (options[3]) number += 15;
                int length = Convert.ToInt32(PasswordLengthNumeric.Text);
                return length > number ? false : true;
            }
            else
            {
                return true;
            }
        }
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(PasswordLengthNumeric.Text);
            if (length > 0)
            {
                if (!Array.TrueForAll(Modifiers(), e => e == false))
                {
                    if (IsChekedNoRepetitions())
                    {
                        listBox1.Items.Clear();
                        Generator generator = new Generator(length, Modifiers());
                        for (int i = 0; i < 20; i++)
                        {
                            listBox1.Items.Add(new MaterialListBoxItem(generator.Generate()));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невозможно сгенерировать пароль из уникальных символов.\n(Символов недостаточно).");
                    }
                }
                else
                {
                    MessageBox.Show("Заполните минимум 1 чекбокс!");
                }
            }
            else
            {
                MessageBox.Show("Длина пароля не может быть меньше 0!");
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                string s = listBox1.SelectedItem.ToString();
                Clipboard.SetData(DataFormats.StringFormat, s);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
