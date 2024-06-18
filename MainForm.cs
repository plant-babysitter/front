using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
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
            LoadSettings();
        }


            private void LoadSettings()
            {
                label1.Text = Properties.Settings.Default.Label1Text;
                label2.Text = Properties.Settings.Default.Label2Text;
                label3.Text = Properties.Settings.Default.Label3Text;
                label4.Text = Properties.Settings.Default.Label4Text;
                label5.Text = Properties.Settings.Default.Label5Text;

            string imagePath = Properties.Settings.Default.PlantImagePath;
            if (!string.IsNullOrEmpty(imagePath))
            {
                // 디버깅 코드
               

                if (File.Exists(imagePath))
                {
                    pictureBoxQ.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Image file does not exist: " + imagePath);
                }
            }
        }

            private void InitializeCustomComponents()
            {
            }
            private void Form1_Load(object sender, EventArgs e)
            {

            }


        private void Button_set_image1(object sender, EventArgs e)
        {
            ImageChangeForm imageChangeForm = new ImageChangeForm(pictureBoxQ);
            imageChangeForm.ShowDialog();
        }

        private void Button_set_info_Click(object sender, EventArgs e)
        {
            InfoChangeForm infoChangeForm = new InfoChangeForm(label1, label2, label3, label4, label5);
            infoChangeForm.ShowDialog();
        }
    }

    } 
