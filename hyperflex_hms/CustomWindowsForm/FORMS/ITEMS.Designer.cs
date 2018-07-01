namespace CustomWindowsForm.FORMS
{
    partial class ITEMS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new System.Windows.Forms.Panel();
            this._CloseButton = new CustomWindowsForm.ButtonZ();
            this.lbl_heder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CMB_CATEGORY = new CustomWindowsForm.hyflexComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV_ITEM = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHK_SEARCH_ITEMNAME = new System.Windows.Forms.CheckBox();
            this.BTN_NEW = new CustomWindowsForm.ShapedButton();
            this.BTN_SAVE = new CustomWindowsForm.ShapedButton();
            this.LBL_ITEM_ID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_BARCODE = new CustomWindowsForm.hyflexTextbox();
            this.TXT_ITEMNAME = new CustomWindowsForm.hyflexTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ITEM)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TopPanel.Controls.Add(this._CloseButton);
            this.TopPanel.Controls.Add(this.lbl_heder);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(588, 30);
            this.TopPanel.TabIndex = 5;
            // 
            // _CloseButton
            // 
            this._CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._CloseButton.DisplayText = "X";
            this._CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CloseButton.ForeColor = System.Drawing.Color.White;
            this._CloseButton.Location = new System.Drawing.Point(558, 3);
            this._CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this._CloseButton.MouseHoverColor = System.Drawing.Color.Red;
            this._CloseButton.Name = "_CloseButton";
            this._CloseButton.Size = new System.Drawing.Size(27, 29);
            this._CloseButton.TabIndex = 0;
            this._CloseButton.Text = "X";
            this._CloseButton.TextLocation_X = 6;
            this._CloseButton.TextLocation_Y = 1;
            this._CloseButton.UseVisualStyleBackColor = true;
            this._CloseButton.Click += new System.EventHandler(this._CloseButton_Click);
            // 
            // lbl_heder
            // 
            this.lbl_heder.AutoSize = true;
            this.lbl_heder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_heder.ForeColor = System.Drawing.Color.White;
            this.lbl_heder.Location = new System.Drawing.Point(3, 8);
            this.lbl_heder.Name = "lbl_heder";
            this.lbl_heder.Size = new System.Drawing.Size(58, 20);
            this.lbl_heder.TabIndex = 1;
            this.lbl_heder.Text = "ITEMS";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(586, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 518);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 518);
            this.label2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(2, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(584, 2);
            this.label3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(2, 531);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 15);
            this.panel2.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.CMB_CATEGORY);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.CHK_SEARCH_ITEMNAME);
            this.groupBox1.Controls.Add(this.BTN_NEW);
            this.groupBox1.Controls.Add(this.BTN_SAVE);
            this.groupBox1.Controls.Add(this.LBL_ITEM_ID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXT_BARCODE);
            this.groupBox1.Controls.Add(this.TXT_ITEMNAME);
            this.groupBox1.Location = new System.Drawing.Point(7, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 489);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NEW CATEGORY";
            // 
            // CMB_CATEGORY
            // 
            this.CMB_CATEGORY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMB_CATEGORY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMB_CATEGORY.F_color = System.Drawing.Color.LightGreen;
            this.CMB_CATEGORY.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CMB_CATEGORY.FormattingEnabled = true;
            this.CMB_CATEGORY.Location = new System.Drawing.Point(318, 73);
            this.CMB_CATEGORY.Name = "CMB_CATEGORY";
            this.CMB_CATEGORY.Size = new System.Drawing.Size(215, 25);
            this.CMB_CATEGORY.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV_ITEM);
            this.groupBox2.Location = new System.Drawing.Point(6, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 277);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Existing Items";
            // 
            // DGV_ITEM
            // 
            this.DGV_ITEM.AllowUserToAddRows = false;
            this.DGV_ITEM.AllowUserToDeleteRows = false;
            this.DGV_ITEM.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ITEM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_ITEM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_ITEM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column3,
            this.Column2,
            this.Column5});
            this.DGV_ITEM.GridColor = System.Drawing.Color.Silver;
            this.DGV_ITEM.Location = new System.Drawing.Point(4, 19);
            this.DGV_ITEM.Name = "DGV_ITEM";
            this.DGV_ITEM.RowHeadersWidth = 25;
            this.DGV_ITEM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ITEM.Size = new System.Drawing.Size(549, 252);
            this.DGV_ITEM.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "item_id";
            this.Column1.HeaderText = "ITEM ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "barcode";
            this.Column4.HeaderText = "BARCODE";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "caegory_name";
            this.Column3.HeaderText = "ITEM CATEGORY";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "item_name";
            this.Column2.HeaderText = "ITEM NAME";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "item_status";
            this.Column5.HeaderText = "STATUS";
            this.Column5.Name = "Column5";
            // 
            // CHK_SEARCH_ITEMNAME
            // 
            this.CHK_SEARCH_ITEMNAME.AutoSize = true;
            this.CHK_SEARCH_ITEMNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.CHK_SEARCH_ITEMNAME.Location = new System.Drawing.Point(71, 107);
            this.CHK_SEARCH_ITEMNAME.Name = "CHK_SEARCH_ITEMNAME";
            this.CHK_SEARCH_ITEMNAME.Size = new System.Drawing.Size(149, 16);
            this.CHK_SEARCH_ITEMNAME.TabIndex = 5;
            this.CHK_SEARCH_ITEMNAME.Text = "SEARCH ITEM WHEN I TYPE";
            this.CHK_SEARCH_ITEMNAME.UseVisualStyleBackColor = true;
            // 
            // BTN_NEW
            // 
            this.BTN_NEW.BackColor = System.Drawing.Color.Transparent;
            this.BTN_NEW.BorderColor = System.Drawing.Color.Transparent;
            this.BTN_NEW.BorderWidth = 2;
            this.BTN_NEW.ButtonShape = CustomWindowsForm.ShapedButton.ButtonsShapes.RoundRect;
            this.BTN_NEW.ButtonText = "";
            this.BTN_NEW.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BTN_NEW.FlatAppearance.BorderSize = 0;
            this.BTN_NEW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_NEW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTN_NEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEW.ForeColor = System.Drawing.Color.Black;
            this.BTN_NEW.GradientAngle = 90;
            this.BTN_NEW.Location = new System.Drawing.Point(246, 26);
            this.BTN_NEW.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.BTN_NEW.MouseClickColor2 = System.Drawing.Color.Red;
            this.BTN_NEW.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.BTN_NEW.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.BTN_NEW.Name = "BTN_NEW";
            this.BTN_NEW.ShowButtontext = true;
            this.BTN_NEW.Size = new System.Drawing.Size(62, 41);
            this.BTN_NEW.StartColor = System.Drawing.Color.Fuchsia;
            this.BTN_NEW.TabIndex = 4;
            this.BTN_NEW.Text = "NEW";
            this.BTN_NEW.TextLocation_X = 19;
            this.BTN_NEW.TextLocation_Y = 18;
            this.BTN_NEW.Transparent1 = 25;
            this.BTN_NEW.Transparent2 = 250;
            this.BTN_NEW.UseVisualStyleBackColor = false;
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.BackColor = System.Drawing.Color.Transparent;
            this.BTN_SAVE.BorderColor = System.Drawing.Color.Transparent;
            this.BTN_SAVE.BorderWidth = 2;
            this.BTN_SAVE.ButtonShape = CustomWindowsForm.ShapedButton.ButtonsShapes.RoundRect;
            this.BTN_SAVE.ButtonText = "";
            this.BTN_SAVE.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BTN_SAVE.FlatAppearance.BorderSize = 0;
            this.BTN_SAVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_SAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SAVE.ForeColor = System.Drawing.Color.Black;
            this.BTN_SAVE.GradientAngle = 90;
            this.BTN_SAVE.Location = new System.Drawing.Point(456, 160);
            this.BTN_SAVE.MouseClickColor1 = System.Drawing.Color.Yellow;
            this.BTN_SAVE.MouseClickColor2 = System.Drawing.Color.Red;
            this.BTN_SAVE.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.BTN_SAVE.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.ShowButtontext = true;
            this.BTN_SAVE.Size = new System.Drawing.Size(103, 40);
            this.BTN_SAVE.StartColor = System.Drawing.Color.Black;
            this.BTN_SAVE.TabIndex = 3;
            this.BTN_SAVE.Text = "SAVE";
            this.BTN_SAVE.TextLocation_X = 33;
            this.BTN_SAVE.TextLocation_Y = 18;
            this.BTN_SAVE.Transparent1 = 10;
            this.BTN_SAVE.Transparent2 = 250;
            this.BTN_SAVE.UseVisualStyleBackColor = false;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // LBL_ITEM_ID
            // 
            this.LBL_ITEM_ID.BackColor = System.Drawing.Color.Gainsboro;
            this.LBL_ITEM_ID.ForeColor = System.Drawing.Color.Black;
            this.LBL_ITEM_ID.Location = new System.Drawing.Point(71, 35);
            this.LBL_ITEM_ID.Name = "LBL_ITEM_ID";
            this.LBL_ITEM_ID.Size = new System.Drawing.Size(169, 23);
            this.LBL_ITEM_ID.TabIndex = 3;
            this.LBL_ITEM_ID.Text = "N/A";
            this.LBL_ITEM_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "BARCODE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "CATEGORY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "ITEM NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "ITEM ID";
            // 
            // TXT_BARCODE
            // 
            this.TXT_BARCODE.F_color = System.Drawing.Color.LightGreen;
            this.TXT_BARCODE.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TXT_BARCODE.Location = new System.Drawing.Point(71, 73);
            this.TXT_BARCODE.Name = "TXT_BARCODE";
            this.TXT_BARCODE.Size = new System.Drawing.Size(169, 25);
            this.TXT_BARCODE.TabIndex = 0;
            this.TXT_BARCODE.User_null_check = CustomWindowsForm.hyflexTextbox.Resust.False;
            this.TXT_BARCODE.User_selection = CustomWindowsForm.hyflexTextbox.String_Type.String;
            // 
            // TXT_ITEMNAME
            // 
            this.TXT_ITEMNAME.F_color = System.Drawing.Color.LightGreen;
            this.TXT_ITEMNAME.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TXT_ITEMNAME.Location = new System.Drawing.Point(71, 129);
            this.TXT_ITEMNAME.Name = "TXT_ITEMNAME";
            this.TXT_ITEMNAME.Size = new System.Drawing.Size(488, 25);
            this.TXT_ITEMNAME.TabIndex = 2;
            this.TXT_ITEMNAME.User_null_check = CustomWindowsForm.hyflexTextbox.Resust.False;
            this.TXT_ITEMNAME.User_selection = CustomWindowsForm.hyflexTextbox.String_Type.String;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "R";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ITEMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(588, 548);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ITEMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MsgBox";
            this.Load += new System.EventHandler(this.ITEMS_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ITEM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label lbl_heder;
        private ButtonZ _CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGV_ITEM;
        private System.Windows.Forms.CheckBox CHK_SEARCH_ITEMNAME;
        private ShapedButton BTN_NEW;
        private ShapedButton BTN_SAVE;
        private System.Windows.Forms.Label LBL_ITEM_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private hyflexTextbox TXT_ITEMNAME;
        private hyflexComboBox CMB_CATEGORY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private hyflexTextbox TXT_BARCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}