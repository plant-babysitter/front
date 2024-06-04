using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plant_sitter
{
    public partial class InfoChangeForm : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button buttonSave;

        public InfoChangeForm(Label lbl1, Label lbl2, Label lbl3, Label lbl4, Label lbl5)
        {
            InitializeComponent();
            label1 = lbl1;
            label2 = lbl2;
            label3 = lbl3;
            label4 = lbl4;
            label5 = lbl5;
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // TextBoxes 설정
            textBox1 = new TextBox { Location = new System.Drawing.Point(20, 20), Width = 200 };
            textBox2 = new TextBox { Location = new System.Drawing.Point(20, 60), Width = 200 };
            textBox3 = new TextBox { Location = new System.Drawing.Point(20, 100), Width = 200 };
            textBox4 = new TextBox { Location = new System.Drawing.Point(20, 140), Width = 200 };
            textBox5 = new TextBox { Location = new System.Drawing.Point(20, 180), Width = 200 };

            textBox1.Text = label1.Text;
            textBox2.Text = label2.Text;
            textBox3.Text = label3.Text;
            textBox4.Text = label4.Text;
            textBox5.Text = label5.Text;

            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(textBox3);
            this.Controls.Add(textBox4);
            this.Controls.Add(textBox5);

            // Save Button 설정
            buttonSave = new Button
            {
                Text = "저장",
                Location = new System.Drawing.Point(20, 220)
            };
            buttonSave.Click += ButtonSave_Click;
            this.Controls.Add(buttonSave);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = textBox2.Text;
            label3.Text = textBox3.Text;
            label4.Text = textBox4.Text;
            label5.Text = textBox5.Text;
            this.Close();
        }
    }
}
