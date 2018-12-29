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
    public partial class Dictionary_city : Form
    {
        private string responseJson;
        private int countryId;
        private string country;

        public Dictionary_city(int _countryId, string _country)
        {
            InitializeComponent();
            countryId = _countryId;
            country = _country;
            this.Text += country;
            this.Load += Dictionary_city_Load;
        }

        private void Dictionary_city_Load(object sender, EventArgs e)
        {
            dc_addCity.Click += Df_addCity_Click;
            dc_lv_cities.DoubleClick += Ac_countries_DoubleClick;
            df_deleteCountry.Click += Df_deleteCountry_Click;

            GetCountryCities(countryId);
        }

        /// <summary>
        /// Delete selected country
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Df_deleteCountry_Click(object sender, EventArgs e)
        {
            string data = $"token=ps_rpo_2&param=deleteCountryById&countryId={dc_lv_cities.SelectedItems[0].Text}";

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
                GetCountryCities(countryId);
               
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
        private void Df_addCity_Click(object sender, EventArgs e)
        {
            AddCityForm acf = new AddCityForm(-1, countryId, country);
            if (acf.ShowDialog() == DialogResult.OK)
            {
                GetCountryCities(countryId);
            }
        }

        /// <summary>
        /// Edit coutry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ac_countries_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dc_lv_cities.SelectedItems[0].Text);
            AddForm af = new AddForm(id);
            if (af.ShowDialog() == DialogResult.OK)
            {
                GetCountryCities(countryId);
            }
        }


        /// <summary>
        /// Get list of celected country cities
        /// </summary>
        /// <param name="countryId"></param>
        /// <returns></returns>
        private async void GetCountryCities(int countryId)
        {
            string data = $"token=ps_rpo_2&param=getCities&countryId={countryId}";

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

            List<City> cities = JsonConvert.DeserializeObject<List<City>>(responseJson).Select(c => c).ToList();

            dc_lv_cities.Items.Clear();

            foreach (var item in cities)
            {
                ListViewItem lvi = new ListViewItem(item.id.ToString());
                lvi.SubItems.Add(item.cityName);
                dc_lv_cities.Items.Add(lvi);
            }
        }
    }
}
