using System;
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
    public partial class SAMPLE : Form
    {
        public SAMPLE()
        {
            InitializeComponent();
          
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
