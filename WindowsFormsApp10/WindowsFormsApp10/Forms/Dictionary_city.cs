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
            this.FormClosed += Dictionary_city_FormClosed;
        }

        private void Dictionary_city_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Dictionary_city_Load(object sender, EventArgs e)
        {
            dc_addCity.Click += Df_addCity_Click;
            dc_lv_cities.DoubleClick += Dc_cities_DoubleClick;
            df_deleteCity.Click += Df_deleteCity_Click;

            GetCountryCities(countryId);
        }

        /// <summary>
        /// Delete selected city
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Df_deleteCity_Click(object sender, EventArgs e)
        {
            if (dc_lv_cities.SelectedItems.Count > 0)
            {
                string data = $"token=ps_rpo_2&param=deleteCity&city={dc_lv_cities.SelectedItems[0].Text}";

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
                    Common.ShowSuccessMessage("Город удален!");
                    GetCountryCities(countryId);

                }
                else
                {
                    Common.ShowErrorMessage("Ошибка удаления!");
                }
            }
            else
            {
                Common.ShowErrorMessage("Город не выбран!");
            }
            
        }

        /// <summary>
        /// Show form for add country
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Df_addCity_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.id = -1;
            city.countryId = countryId;

            AddCityForm acf = new AddCityForm(city, country);
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
        private void Dc_cities_DoubleClick(object sender, EventArgs e)
        {
            City city = new City();
            city.id = Convert.ToInt32(dc_lv_cities.SelectedItems[0].Text);
            city.cityName = dc_lv_cities.SelectedItems[0].SubItems[1].Text;
            city.countryId = countryId;

            AddCityForm acf = new AddCityForm(city, country);
            if (acf.ShowDialog() == DialogResult.OK)
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
