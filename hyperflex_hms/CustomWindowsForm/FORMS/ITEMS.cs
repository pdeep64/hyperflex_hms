using CustomWindowsForm.CLASS;
using MySql.Data.MySqlClient;
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
    public partial class ITEMS : Form
    {
        public ITEMS()
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
        private String GETMAXID()
        {
            try
            {
                CONNECTION.open_connection();
                using (MySqlDataAdapter DA = new MySqlDataAdapter("SELECT MAX(item_id) FROM item", CONNECTION.CON))
                {
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    if (DT.Rows.Count > 0)
                    {
                        return DT.Rows[0].Field<int>(0).ToString();
                    }
                    else
                    {
                        return "0";
                    }

                }

            }
            catch (Exception EX)
            {

                return EX.ToString();
            }
        }
        private void SAVE_ITEMS()
        {
            //try
            //{
                CONNECTION.open_connection();
                using (MySqlCommand da = new MySqlCommand("INSERT INTO item (barcode,item_category,item_name,item_status) VALUES(@barcode,@item_category,@item_name,@item_status)", CONNECTION.CON))
                {
                    da.Parameters.Clear();
                    da.Parameters.AddWithValue("@barcode", "N/A");
                    da.Parameters.AddWithValue("@item_category", CMB_CATEGORY.SelectedValue);
                    da.Parameters.AddWithValue("@item_name", TXT_ITEMNAME.Text);
                    da.Parameters.AddWithValue("@item_status", "ENABLE");
                    if (da.ExecuteNonQuery() > 0)
                    {
                        LBL_ITEM_ID.Text = GETMAXID();
                        if (TXT_BARCODE.Text==String.Empty)
                        {
                            using (MySqlCommand CM = new MySqlCommand("UPDATE item SET barcode=@barcode WHERE item_id=@item_id", CONNECTION.CON))
                            {
                                CM.Parameters.Clear();
                                CM.Parameters.AddWithValue("@item_id", LBL_ITEM_ID.Text);
                                CM.Parameters.AddWithValue("@barcode", LBL_ITEM_ID.Text);
                                CM.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            using (MySqlCommand C = new MySqlCommand("UPDATE item SET barcode=@barcode WHERE item_id=@item_id", CONNECTION.CON))
                            {
                                C.Parameters.Clear();
                                C.Parameters.AddWithValue("@item_id", LBL_ITEM_ID.Text);
                                C.Parameters.AddWithValue("@barcode", TXT_BARCODE.Text);
                                C.ExecuteNonQuery();
                            }
                        }
                       
                        MSGBOX mdg = new MSGBOX(MessageAlertHeder.Success(), "ITEM ADDED SUCCESFULLY!", MessageAlertImage.Success());
                        mdg.ShowDialog();

                    }
                    else
                    {
                        MSGBOX mdg = new MSGBOX(MessageAlertHeder.Alert(), "ITEM ADDED FAILED!", MessageAlertImage.Alert());
                        mdg.ShowDialog();
                    }

                }
            //}
            //catch (Exception ex)
            //{
            //    MSGBOX mdg = new MSGBOX(MessageAlertHeder.Error(), ex.Message, MessageAlertImage.Error());
            //    mdg.ShowDialog();
            //}
            //finally
            //{
            //    CONNECTION.close_connection();
            //}
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            if(CMB_CATEGORY.SelectedIndex==-1)
            {
                CMB_CATEGORY.Focus();
                MSGBOX mdg = new MSGBOX(MessageAlertHeder.Warning(),"PLEASE SELECT CATEGORY", MessageAlertImage.Warning());
                mdg.ShowDialog();
            }
            else if(TXT_ITEMNAME.Text==String.Empty)
            {
                TXT_ITEMNAME.Focus();
                MSGBOX mdg = new MSGBOX(MessageAlertHeder.Warning(), "PLEASE ENTER ITEM NAME", MessageAlertImage.Warning());
                mdg.ShowDialog();
            }
            else if(BTN_SAVE.Text=="SAVE")
            {
                SAVE_ITEMS();
                LOAD_ITEM_lIST();
            }
            else if(BTN_SAVE.Text == "UPDATE")
            {

            }
        }
        private void LOAD_ITEM_lIST()
        {
            try
            {
                CONNECTION.open_connection();
                using (MySqlDataAdapter DA = new MySqlDataAdapter("SELECT item.item_id , item.barcode , category.caegory_name , item.item_name , item.item_status FROM hyperfle_hms.item INNER JOIN hyperfle_hms.category ON (item.item_category = category.categry_id)", CONNECTION.CON))
                {
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    if (DT.Rows.Count > 0)
                    {
                        DGV_ITEM.DataSource = DT;
                        DGV_ITEM.AutoGenerateColumns = false;
                    }
                    else
                    {
                        DGV_ITEM.DataSource = null;
                    }
                }

            }
            catch (Exception EX)
            {

                MSGBOX mdg = new MSGBOX(MessageAlertHeder.Error(), EX.Message, MessageAlertImage.Error());
                mdg.ShowDialog();
            }
        }
        private void ITEMS_Load(object sender, EventArgs e)
        {
            CLS_ITEM.LOAD_CATEGORY(CMB_CATEGORY);
            LOAD_ITEM_lIST();
        }
    }
}
