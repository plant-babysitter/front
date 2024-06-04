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
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            InitializeCustomComponents();

        }

        private void InitializeCustomComponents()
        {
            }
            private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_set_info1(object sender, EventArgs e)
        {
            InfoChangeForm infoChangeForm = new InfoChangeForm(label1, label2, label3, label4, label5);
            infoChangeForm.ShowDialog();
        }

   
        private void Button_set_image1(object sender, EventArgs e)
        {
            ImageChangeForm imageChangeForm = new ImageChangeForm(pictureBoxQ);
            imageChangeForm.ShowDialog();
        }

    }

}
