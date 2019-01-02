namespace WindowsFormsApp10
{
    partial class Dictionary_city
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dictionary_city));
            this.dc_lv_cities = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cityName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dc_addCity = new System.Windows.Forms.Button();
            this.df_deleteCity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dc_lv_cities
            // 
            this.dc_lv_cities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dc_lv_cities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.cityName});
            this.dc_lv_cities.FullRowSelect = true;
            this.dc_lv_cities.GridLines = true;
            this.dc_lv_cities.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.dc_lv_cities.Location = new System.Drawing.Point(12, 12);
            this.dc_lv_cities.MultiSelect = false;
            this.dc_lv_cities.Name = "dc_lv_cities";
            this.dc_lv_cities.Size = new System.Drawing.Size(427, 151);
            this.dc_lv_cities.TabIndex = 0;
            this.dc_lv_cities.UseCompatibleStateImageBehavior = false;
            this.dc_lv_cities.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // cityName
            // 
            this.cityName.Text = "Города";
            this.cityName.Width = 360;
            // 
            // dc_addCity
            // 
            this.dc_addCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dc_addCity.ForeColor = System.Drawing.Color.White;
            this.dc_addCity.Location = new System.Drawing.Point(454, 12);
            this.dc_addCity.Name = "dc_addCity";
            this.dc_addCity.Size = new System.Drawing.Size(161, 68);
            this.dc_addCity.TabIndex = 1;
            this.dc_addCity.Text = "Добавить";
            this.dc_addCity.UseVisualStyleBackColor = true;
            // 
            // df_deleteCity
            // 
            this.df_deleteCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.df_deleteCity.ForeColor = System.Drawing.Color.White;
            this.df_deleteCity.Location = new System.Drawing.Point(454, 95);
            this.df_deleteCity.Name = "df_deleteCity";
            this.df_deleteCity.Size = new System.Drawing.Size(161, 68);
            this.df_deleteCity.TabIndex = 2;
            this.df_deleteCity.Text = "Удалить";
            this.df_deleteCity.UseVisualStyleBackColor = true;
            // 
            // Dictionary_city
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(627, 172);
            this.Controls.Add(this.df_deleteCity);
            this.Controls.Add(this.dc_addCity);
            this.Controls.Add(this.dc_lv_cities);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dictionary_city";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник Города в стране: ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dc_lv_cities;
        private System.Windows.Forms.Button dc_addCity;
        private System.Windows.Forms.Button df_deleteCity;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader cityName;
    }
}