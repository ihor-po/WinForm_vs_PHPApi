﻿namespace WindowsFormsApp10
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
            this.groupBox1.SuspendLayout();
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
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(640, 367);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox mf_countries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button mf_addCountry;
    }
}
