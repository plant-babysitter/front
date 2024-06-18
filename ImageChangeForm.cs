using System;
using System.IO;
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
    public partial class ImageChangeForm : Form
    {
        private PictureBox pictureBoxQ;
        private ListBox listBoxImages;
        private Button buttonA;
        private Button buttonB;
        private Label labelFileName;

        public ImageChangeForm(PictureBox mainPictureBox)
        {
            InitializeComponent();
            pictureBoxQ = mainPictureBox;
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            listBoxImages = new ListBox { Location = new System.Drawing.Point(20, 20), Width = 200, Height = 150 };

            // 리소스에 있는 이미지 파일 이름 추가
            listBoxImages.Items.Add("나팔꽃");
            listBoxImages.Items.Add("강낭콩");
            listBoxImages.Items.Add("방울토마토");
            listBoxImages.Items.Add("basic");

            listBoxImages.DoubleClick += ListBoxImages_DoubleClick;
            this.Controls.Add(listBoxImages);

            buttonA = new Button
            {
                Text = "선택",
                Location = new System.Drawing.Point(230, 20)
            };
            buttonA.Click += ButtonA_Click;
            this.Controls.Add(buttonA);

            buttonB = new Button
            {
                Text = "확인",
                Location = new System.Drawing.Point(230, 60)
            };
            buttonB.Click += ButtonB_Click;
            this.Controls.Add(buttonB);

            labelFileName = new Label { Location = new System.Drawing.Point(20, 180), Width = 200 };
            this.Controls.Add(labelFileName);
        }

        private void ListBoxImages_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxImages.SelectedItem != null)
            {
                var selectedImage = listBoxImages.SelectedItem.ToString();
                pictureBoxQ.Image = (Image)Properties.Resources.ResourceManager.GetObject(selectedImage);
                labelFileName.Text = selectedImage;
            }
        }

        private void ButtonA_Click(object sender, EventArgs e)
        {
            if (listBoxImages.SelectedItem != null)
            {
                var selectedImage = listBoxImages.SelectedItem.ToString();
                pictureBoxQ.Image = (Image)Properties.Resources.ResourceManager.GetObject(selectedImage);
                labelFileName.Text = selectedImage;
            }
        }

        private void ButtonB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(labelFileName.Text))
            {
                string imagePath = Path.Combine(Application.StartupPath, $"{labelFileName.Text}.jpg");
                Properties.Settings.Default.PlantImagePath = imagePath;
                Properties.Settings.Default.Save();
          
            }

            this.Close();
        }
    }


}


