namespace WindowsFormsApp10
{
    partial class add_country
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_country));
            this.ac_countries = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.countriesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.df_addCountry = new System.Windows.Forms.Button();
            this.df_deleteCountry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ac_countries
            // 
            this.ac_countries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ac_countries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.countriesName});
            this.ac_countries.FullRowSelect = true;
            this.ac_countries.GridLines = true;
            this.ac_countries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ac_countries.Location = new System.Drawing.Point(12, 12);
            this.ac_countries.MultiSelect = false;
            this.ac_countries.Name = "ac_countries";
            this.ac_countries.Size = new System.Drawing.Size(427, 151);
            this.ac_countries.TabIndex = 0;
            this.ac_countries.UseCompatibleStateImageBehavior = false;
            this.ac_countries.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // countriesName
            // 
            this.countriesName.Text = "Страны";
            this.countriesName.Width = 360;
            // 
            // df_addCountry
            // 
            this.df_addCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.df_addCountry.ForeColor = System.Drawing.Color.White;
            this.df_addCountry.Location = new System.Drawing.Point(454, 12);
            this.df_addCountry.Name = "df_addCountry";
            this.df_addCountry.Size = new System.Drawing.Size(161, 68);
            this.df_addCountry.TabIndex = 1;
            this.df_addCountry.Text = "Добавить";
            this.df_addCountry.UseVisualStyleBackColor = true;
            // 
            // df_deleteCountry
            // 
            this.df_deleteCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.df_deleteCountry.ForeColor = System.Drawing.Color.White;
            this.df_deleteCountry.Location = new System.Drawing.Point(454, 95);
            this.df_deleteCountry.Name = "df_deleteCountry";
            this.df_deleteCountry.Size = new System.Drawing.Size(161, 68);
            this.df_deleteCountry.TabIndex = 2;
            this.df_deleteCountry.Text = "Удалить";
            this.df_deleteCountry.UseVisualStyleBackColor = true;
            // 
            // add_country
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(627, 172);
            this.Controls.Add(this.df_deleteCountry);
            this.Controls.Add(this.df_addCountry);
            this.Controls.Add(this.ac_countries);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_country";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник Страны";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ac_countries;
        private System.Windows.Forms.Button df_addCountry;
        private System.Windows.Forms.Button df_deleteCountry;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader countriesName;
    }
}