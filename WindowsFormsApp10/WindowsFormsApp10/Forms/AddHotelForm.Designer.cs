namespace WindowsFormsApp10
{
    partial class AddHotelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHotelForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ahf_hotelName = new System.Windows.Forms.TextBox();
            this.aсf_addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ahf_cb_countries = new System.Windows.Forms.ComboBox();
            this.ahf_cb_cities = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ahf_cb_stars = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ahf_cb_cost = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ahf_tb_about = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ahf_cb_cost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // ahf_hotelName
            // 
            this.ahf_hotelName.Location = new System.Drawing.Point(116, 20);
            this.ahf_hotelName.Name = "ahf_hotelName";
            this.ahf_hotelName.Size = new System.Drawing.Size(255, 26);
            this.ahf_hotelName.TabIndex = 1;
            // 
            // aсf_addButton
            // 
            this.aсf_addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aсf_addButton.Location = new System.Drawing.Point(193, 338);
            this.aсf_addButton.Name = "aсf_addButton";
            this.aсf_addButton.Size = new System.Drawing.Size(96, 36);
            this.aсf_addButton.TabIndex = 2;
            this.aсf_addButton.Text = "Добавить";
            this.aсf_addButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Страна";
            // 
            // ahf_cb_countries
            // 
            this.ahf_cb_countries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ahf_cb_countries.Enabled = false;
            this.ahf_cb_countries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ahf_cb_countries.FormattingEnabled = true;
            this.ahf_cb_countries.Location = new System.Drawing.Point(116, 57);
            this.ahf_cb_countries.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ahf_cb_countries.Name = "ahf_cb_countries";
            this.ahf_cb_countries.Size = new System.Drawing.Size(255, 28);
            this.ahf_cb_countries.TabIndex = 4;
            // 
            // ahf_cb_cities
            // 
            this.ahf_cb_cities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ahf_cb_cities.Enabled = false;
            this.ahf_cb_cities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ahf_cb_cities.FormattingEnabled = true;
            this.ahf_cb_cities.Location = new System.Drawing.Point(116, 95);
            this.ahf_cb_cities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ahf_cb_cities.Name = "ahf_cb_cities";
            this.ahf_cb_cities.Size = new System.Drawing.Size(255, 28);
            this.ahf_cb_cities.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Город";
            // 
            // ahf_cb_stars
            // 
            this.ahf_cb_stars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ahf_cb_stars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ahf_cb_stars.FormattingEnabled = true;
            this.ahf_cb_stars.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ahf_cb_stars.Location = new System.Drawing.Point(116, 133);
            this.ahf_cb_stars.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ahf_cb_stars.Name = "ahf_cb_stars";
            this.ahf_cb_stars.Size = new System.Drawing.Size(255, 28);
            this.ahf_cb_stars.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Звезды";
            // 
            // ahf_cb_cost
            // 
            this.ahf_cb_cost.Location = new System.Drawing.Point(116, 170);
            this.ahf_cb_cost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ahf_cb_cost.Name = "ahf_cb_cost";
            this.ahf_cb_cost.Size = new System.Drawing.Size(255, 26);
            this.ahf_cb_cost.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Стоимость";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Описание";
            // 
            // ahf_tb_about
            // 
            this.ahf_tb_about.Location = new System.Drawing.Point(116, 206);
            this.ahf_tb_about.Multiline = true;
            this.ahf_tb_about.Name = "ahf_tb_about";
            this.ahf_tb_about.Size = new System.Drawing.Size(255, 122);
            this.ahf_tb_about.TabIndex = 12;
            // 
            // AddHotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(391, 382);
            this.Controls.Add(this.ahf_tb_about);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ahf_cb_cost);
            this.Controls.Add(this.ahf_cb_stars);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ahf_cb_cities);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ahf_cb_countries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aсf_addButton);
            this.Controls.Add(this.ahf_hotelName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddHotelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление отеля в страну ";
            ((System.ComponentModel.ISupportInitialize)(this.ahf_cb_cost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ahf_hotelName;
        private System.Windows.Forms.Button aсf_addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ahf_cb_countries;
        private System.Windows.Forms.ComboBox ahf_cb_cities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ahf_cb_stars;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ahf_cb_cost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ahf_tb_about;
    }
}