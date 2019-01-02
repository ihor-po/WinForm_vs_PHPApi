using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class add_country : Form
    {
        private string responseJson;

        public add_country()
        {
            InitializeComponent();
            this.Load += Add_country_Load;
            this.FormClosed += Add_country_FormClosed;
        }

        private void Add_country_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Add_country_Load(object sender, EventArgs e)
        {
            df_addCountry.Click += Df_addCountry_Click;
            ac_countries.DoubleClick += Ac_countries_DoubleClick;
            df_deleteCountry.Click += Df_deleteCountry_Click;

            GetAllCountries();
        }

        /// <summary>
        /// Delete selected country
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Df_deleteCountry_Click(object sender, EventArgs e)
        {
            string data = $"token=ps_rpo_2&param=deleteCountryById&countryId={ac_countries.SelectedItems[0].Text}";

            WebRequest request = Common.SendData("POST", data);

            WebResponse response = await request.GetResponseAsync();

            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    responseJson = reader.ReadToEnd();
                }
            }
            response.Close();

            if (responseJson == "200")
            {
                Common.ShowSuccessMessage("Страна удалена!");
                GetAllCountries();
               
            }
            else
            {
                Common.ShowErrorMessage("Ошибка удаления!");
            }
        }

        /// <summary>
        /// Show form for add country
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Df_addCountry_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm(-1);
            if (af.ShowDialog() == DialogResult.OK)
            {
                GetAllCountries();
            }
        }

        /// <summary>
        /// Edit coutry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ac_countries_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ac_countries.SelectedItems[0].Text);
            AddForm af = new AddForm(id);
            if (af.ShowDialog() == DialogResult.OK)
            {
                GetAllCountries();
            }
        }

        /// <summary>
        /// Get all city from server
        /// </summary>
        private async void GetAllCountries()
        {
            string data = "token=ps_rpo_2&param=getCountries";

            WebRequest request = Common.SendData("POST", data);

            WebResponse response = await request.GetResponseAsync();

            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    responseJson = reader.ReadToEnd();
                }
            }

            response.Close();

            List<Country> countiries = JsonConvert.DeserializeObject<List<Country>>(responseJson).Select(c => c).ToList();
            ac_countries.Items.Clear();

            foreach (var item in countiries)
            {
                ListViewItem lvi = new ListViewItem(item.id.ToString());
                lvi.SubItems.Add(item.countryName);
                ac_countries.Items.Add(lvi);
                
            }
        }
    }
}
