namespace WindowsFormsApp10
{
    partial class Dictionary_hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dictionary_hotel));
            this.dc_lv_hotels = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hotelName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stars = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dc_addHotel = new System.Windows.Forms.Button();
            this.df_deleteHotel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dc_lv_hotels
            // 
            this.dc_lv_hotels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dc_lv_hotels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.hotelName,
            this.Stars,
            this.Cost});
            this.dc_lv_hotels.FullRowSelect = true;
            this.dc_lv_hotels.GridLines = true;
            this.dc_lv_hotels.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.dc_lv_hotels.Location = new System.Drawing.Point(12, 12);
            this.dc_lv_hotels.MultiSelect = false;
            this.dc_lv_hotels.Name = "dc_lv_hotels";
            this.dc_lv_hotels.Size = new System.Drawing.Size(621, 323);
            this.dc_lv_hotels.TabIndex = 0;
            this.dc_lv_hotels.UseCompatibleStateImageBehavior = false;
            this.dc_lv_hotels.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // hotelName
            // 
            this.hotelName.Text = "Отели";
            this.hotelName.Width = 360;
            // 
            // Stars
            // 
            this.Stars.Text = "Звезды";
            this.Stars.Width = 75;
            // 
            // Cost
            // 
            this.Cost.Text = "Стоимость";
            this.Cost.Width = 120;
            // 
            // dc_addHotel
            // 
            this.dc_addHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dc_addHotel.ForeColor = System.Drawing.Color.White;
            this.dc_addHotel.Location = new System.Drawing.Point(645, 181);
            this.dc_addHotel.Name = "dc_addHotel";
            this.dc_addHotel.Size = new System.Drawing.Size(161, 68);
            this.dc_addHotel.TabIndex = 1;
            this.dc_addHotel.Text = "Добавить";
            this.dc_addHotel.UseVisualStyleBackColor = true;
            // 
            // df_deleteHotel
            // 
            this.df_deleteHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.df_deleteHotel.ForeColor = System.Drawing.Color.White;
            this.df_deleteHotel.Location = new System.Drawing.Point(645, 264);
            this.df_deleteHotel.Name = "df_deleteHotel";
            this.df_deleteHotel.Size = new System.Drawing.Size(161, 68);
            this.df_deleteHotel.TabIndex = 2;
            this.df_deleteHotel.Text = "Удалить";
            this.df_deleteHotel.UseVisualStyleBackColor = true;
            // 
            // Dictionary_hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(818, 346);
            this.Controls.Add(this.df_deleteHotel);
            this.Controls.Add(this.dc_addHotel);
            this.Controls.Add(this.dc_lv_hotels);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dictionary_hotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник Отели в городе: ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dc_lv_hotels;
        private System.Windows.Forms.Button dc_addHotel;
        private System.Windows.Forms.Button df_deleteHotel;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader hotelName;
        private System.Windows.Forms.ColumnHeader Stars;
        private System.Windows.Forms.ColumnHeader Cost;
    }
}