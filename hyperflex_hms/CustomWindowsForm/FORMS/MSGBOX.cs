﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomWindowsForm.FORMS
{
    public partial class MSGBOX : Form
    {
        public MSGBOX(string lbl_headr,string lbl_message,string Image)
        {
            InitializeComponent();
            lbl_heder.Text = lbl_headr;
            txt_message.Text = lbl_message;
            Bitmap IMG;
            if (Image == "Warning")
            {
                pb_image.Image = Properties.Resources.warning;
                IMG= Properties.Resources.warning;
            } 
            else if (Image == "Alert")
            {
                pb_image.Image = Properties.Resources.alert;
                IMG = Properties.Resources.alert;
            }
            else if (Image == "Success")
            {
                pb_image.Image = Properties.Resources.success;
                IMG = Properties.Resources.success;
            }
            else if (Image == "Error")
            {
                pb_image.Image = Properties.Resources.error;
                IMG = Properties.Resources.error;
            }
            else if (Image == "Notification")
            {
                pb_image.Image = Properties.Resources.notification;
                IMG = Properties.Resources.notification;
            }
            else
            {
                pb_image.Image = Properties.Resources.warning;
                IMG = Properties.Resources.warning;
            }
               

            CenterPictureBox(pb_image,IMG);
        }
        private void CenterPictureBox(PictureBox picBox, Bitmap picImage)
        {
            picBox.Image = picImage;
            picBox.Location = new Point((picBox.Parent.ClientSize.Width / 2) - (picImage.Width / 2), 35);
            picBox.Refresh();
        }
        private void CenterButton(Button btn_ok)
        {
            btn_ok.Location = new Point((btn_ok.Parent.ClientSize.Width / 2) - 35);
            btn_ok.Refresh();
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MSGBOX_Load(object sender, EventArgs e)
        {

        }
    }
}
