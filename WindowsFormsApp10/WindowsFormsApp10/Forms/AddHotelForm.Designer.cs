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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCityForm));
            this.label1 = new System.Windows.Forms.Label();
            this.aсf_cityName = new System.Windows.Forms.TextBox();
            this.aсf_addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.acf_cb_countries = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Город";
            // 
            // aсf_cityName
            // 
            this.aсf_cityName.Location = new System.Drawing.Point(98, 20);
            this.aсf_cityName.Name = "aсf_cityName";
            this.aсf_cityName.Size = new System.Drawing.Size(255, 26);
            this.aсf_cityName.TabIndex = 1;
            // 
            // aсf_addButton
            // 
            this.aсf_addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aсf_addButton.Location = new System.Drawing.Point(385, 52);
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
            // acf_cb_countries
            // 
            this.acf_cb_countries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acf_cb_countries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acf_cb_countries.FormattingEnabled = true;
            this.acf_cb_countries.Location = new System.Drawing.Point(98, 57);
            this.acf_cb_countries.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acf_cb_countries.Name = "acf_cb_countries";
            this.acf_cb_countries.Size = new System.Drawing.Size(255, 28);
            this.acf_cb_countries.TabIndex = 4;
            // 
            // AddCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(505, 108);
            this.Controls.Add(this.acf_cb_countries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aсf_addButton);
            this.Controls.Add(this.aсf_cityName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление города в страну ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aсf_cityName;
        private System.Windows.Forms.Button aсf_addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox acf_cb_countries;
    }
}