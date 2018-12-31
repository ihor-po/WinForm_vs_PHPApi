namespace WindowsFormsApp10
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.mf_countries = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mf_addCountry = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mf_btn_cityDictionary = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mf_cb_city = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mf_btn_hotelDictionary = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mf_cb_hotel = new System.Windows.Forms.ComboBox();
            this.mf_gb_stars = new System.Windows.Forms.GroupBox();
            this.mf_gb_price = new System.Windows.Forms.GroupBox();
            this.mf_lbl_cost = new System.Windows.Forms.Label();
            this.mf_tb_hotelInfo = new System.Windows.Forms.TextBox();
            this.mf_pb_s1 = new System.Windows.Forms.PictureBox();
            this.mf_pb_s2 = new System.Windows.Forms.PictureBox();
            this.mf_pb_s3 = new System.Windows.Forms.PictureBox();
            this.mf_pb_s4 = new System.Windows.Forms.PictureBox();
            this.mf_pb_s5 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.mf_gb_stars.SuspendLayout();
            this.mf_gb_price.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mf_pb_s1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mf_pb_s2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mf_pb_s3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mf_pb_s4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mf_pb_s5)).BeginInit();
            this.SuspendLayout();
            // 
            // mf_countries
            // 
            this.mf_countries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mf_countries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mf_countries.FormattingEnabled = true;
            this.mf_countries.Location = new System.Drawing.Point(104, 31);
            this.mf_countries.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mf_countries.Name = "mf_countries";
            this.mf_countries.Size = new System.Drawing.Size(278, 28);
            this.mf_countries.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Страна";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mf_addCountry);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mf_countries);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(614, 78);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор страны";
            // 
            // mf_addCountry
            // 
            this.mf_addCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mf_addCountry.Location = new System.Drawing.Point(409, 26);
            this.mf_addCountry.Name = "mf_addCountry";
            this.mf_addCountry.Size = new System.Drawing.Size(187, 36);
            this.mf_addCountry.TabIndex = 2;
            this.mf_addCountry.Text = "Открыть справочник";
            this.mf_addCountry.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mf_btn_cityDictionary);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mf_cb_city);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(14, 101);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(614, 78);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор города";
            // 
            // mf_btn_cityDictionary
            // 
            this.mf_btn_cityDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mf_btn_cityDictionary.Location = new System.Drawing.Point(409, 26);
            this.mf_btn_cityDictionary.Name = "mf_btn_cityDictionary";
            this.mf_btn_cityDictionary.Size = new System.Drawing.Size(187, 36);
            this.mf_btn_cityDictionary.TabIndex = 2;
            this.mf_btn_cityDictionary.Text = "Открыть справочник";
            this.mf_btn_cityDictionary.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Город";
            // 
            // mf_cb_city
            // 
            this.mf_cb_city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mf_cb_city.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mf_cb_city.FormattingEnabled = true;
            this.mf_cb_city.Location = new System.Drawing.Point(104, 31);
            this.mf_cb_city.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mf_cb_city.Name = "mf_cb_city";
            this.mf_cb_city.Size = new System.Drawing.Size(278, 28);
            this.mf_cb_city.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mf_tb_hotelInfo);
            this.groupBox3.Controls.Add(this.mf_gb_price);
            this.groupBox3.Controls.Add(this.mf_gb_stars);
            this.groupBox3.Controls.Add(this.mf_btn_hotelDictionary);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.mf_cb_hotel);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(14, 187);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(614, 263);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбор отеля";
            // 
            // mf_btn_hotelDictionary
            // 
            this.mf_btn_hotelDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mf_btn_hotelDictionary.Location = new System.Drawing.Point(409, 26);
            this.mf_btn_hotelDictionary.Name = "mf_btn_hotelDictionary";
            this.mf_btn_hotelDictionary.Size = new System.Drawing.Size(187, 36);
            this.mf_btn_hotelDictionary.TabIndex = 2;
            this.mf_btn_hotelDictionary.Text = "Открыть справочник";
            this.mf_btn_hotelDictionary.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Отель";
            // 
            // mf_cb_hotel
            // 
            this.mf_cb_hotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mf_cb_hotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mf_cb_hotel.FormattingEnabled = true;
            this.mf_cb_hotel.Location = new System.Drawing.Point(104, 31);
            this.mf_cb_hotel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mf_cb_hotel.Name = "mf_cb_hotel";
            this.mf_cb_hotel.Size = new System.Drawing.Size(278, 28);
            this.mf_cb_hotel.TabIndex = 0;
            // 
            // mf_gb_stars
            // 
            this.mf_gb_stars.Controls.Add(this.mf_pb_s5);
            this.mf_gb_stars.Controls.Add(this.mf_pb_s4);
            this.mf_gb_stars.Controls.Add(this.mf_pb_s3);
            this.mf_gb_stars.Controls.Add(this.mf_pb_s2);
            this.mf_gb_stars.Controls.Add(this.mf_pb_s1);
            this.mf_gb_stars.Location = new System.Drawing.Point(104, 67);
            this.mf_gb_stars.Name = "mf_gb_stars";
            this.mf_gb_stars.Size = new System.Drawing.Size(278, 69);
            this.mf_gb_stars.TabIndex = 3;
            this.mf_gb_stars.TabStop = false;
            this.mf_gb_stars.Text = "Звезды";
            // 
            // mf_gb_price
            // 
            this.mf_gb_price.Controls.Add(this.mf_lbl_cost);
            this.mf_gb_price.Location = new System.Drawing.Point(409, 67);
            this.mf_gb_price.Name = "mf_gb_price";
            this.mf_gb_price.Size = new System.Drawing.Size(187, 69);
            this.mf_gb_price.TabIndex = 4;
            this.mf_gb_price.TabStop = false;
            this.mf_gb_price.Text = "Стоимость";
            // 
            // mf_lbl_cost
            // 
            this.mf_lbl_cost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mf_lbl_cost.AutoSize = true;
            this.mf_lbl_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mf_lbl_cost.Location = new System.Drawing.Point(66, 25);
            this.mf_lbl_cost.Name = "mf_lbl_cost";
            this.mf_lbl_cost.Size = new System.Drawing.Size(62, 29);
            this.mf_lbl_cost.TabIndex = 0;
            this.mf_lbl_cost.Text = "0.00";
            // 
            // mf_tb_hotelInfo
            // 
            this.mf_tb_hotelInfo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.mf_tb_hotelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mf_tb_hotelInfo.Location = new System.Drawing.Point(104, 143);
            this.mf_tb_hotelInfo.Multiline = true;
            this.mf_tb_hotelInfo.Name = "mf_tb_hotelInfo";
            this.mf_tb_hotelInfo.ReadOnly = true;
            this.mf_tb_hotelInfo.Size = new System.Drawing.Size(492, 109);
            this.mf_tb_hotelInfo.TabIndex = 5;
            // 
            // mf_pb_s1
            // 
            this.mf_pb_s1.Image = global::WindowsFormsApp10.Properties.Resources.Star_32;
            this.mf_pb_s1.Location = new System.Drawing.Point(15, 24);
            this.mf_pb_s1.Name = "mf_pb_s1";
            this.mf_pb_s1.Size = new System.Drawing.Size(33, 33);
            this.mf_pb_s1.TabIndex = 0;
            this.mf_pb_s1.TabStop = false;
            // 
            // mf_pb_s2
            // 
            this.mf_pb_s2.Image = global::WindowsFormsApp10.Properties.Resources.Star_32;
            this.mf_pb_s2.Location = new System.Drawing.Point(68, 24);
            this.mf_pb_s2.Name = "mf_pb_s2";
            this.mf_pb_s2.Size = new System.Drawing.Size(33, 33);
            this.mf_pb_s2.TabIndex = 1;
            this.mf_pb_s2.TabStop = false;
            // 
            // mf_pb_s3
            // 
            this.mf_pb_s3.Image = global::WindowsFormsApp10.Properties.Resources.Star_32;
            this.mf_pb_s3.Location = new System.Drawing.Point(122, 24);
            this.mf_pb_s3.Name = "mf_pb_s3";
            this.mf_pb_s3.Size = new System.Drawing.Size(33, 33);
            this.mf_pb_s3.TabIndex = 2;
            this.mf_pb_s3.TabStop = false;
            // 
            // mf_pb_s4
            // 
            this.mf_pb_s4.Image = global::WindowsFormsApp10.Properties.Resources.Star_32;
            this.mf_pb_s4.Location = new System.Drawing.Point(176, 24);
            this.mf_pb_s4.Name = "mf_pb_s4";
            this.mf_pb_s4.Size = new System.Drawing.Size(33, 33);
            this.mf_pb_s4.TabIndex = 3;
            this.mf_pb_s4.TabStop = false;
            // 
            // mf_pb_s5
            // 
            this.mf_pb_s5.Image = global::WindowsFormsApp10.Properties.Resources.Star_32;
            this.mf_pb_s5.Location = new System.Drawing.Point(231, 24);
            this.mf_pb_s5.Name = "mf_pb_s5";
            this.mf_pb_s5.Size = new System.Drawing.Size(33, 33);
            this.mf_pb_s5.TabIndex = 4;
            this.mf_pb_s5.TabStop = false;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(640, 463);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Туристеческое агенство \"Туда-сюда\"";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.mf_gb_stars.ResumeLayout(false);
            this.mf_gb_price.ResumeLayout(false);
            this.mf_gb_price.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mf_pb_s1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mf_pb_s2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mf_pb_s3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mf_pb_s4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mf_pb_s5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox mf_countries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button mf_addCountry;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button mf_btn_cityDictionary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox mf_cb_city;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox mf_gb_stars;
        private System.Windows.Forms.Button mf_btn_hotelDictionary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox mf_cb_hotel;
        private System.Windows.Forms.TextBox mf_tb_hotelInfo;
        private System.Windows.Forms.GroupBox mf_gb_price;
        private System.Windows.Forms.Label mf_lbl_cost;
        private System.Windows.Forms.PictureBox mf_pb_s5;
        private System.Windows.Forms.PictureBox mf_pb_s4;
        private System.Windows.Forms.PictureBox mf_pb_s3;
        private System.Windows.Forms.PictureBox mf_pb_s2;
        private System.Windows.Forms.PictureBox mf_pb_s1;
    }
}

