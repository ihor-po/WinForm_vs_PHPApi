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
    public partial class Dictionary_hotel : Form
    {
        private string responseJson;
        private int countryId;
        private int cityId;
        private string city;

        public Dictionary_hotel(int _countryId, int _cityId, string _city)
        {
            InitializeComponent();
            countryId = _countryId;
            cityId = _cityId;
            city = _city;
            this.Text += city;
            this.Load += Dictionary_hotel_Load;
        }

        private void Dictionary_hotel_Load(object sender, EventArgs e)
        {
            dc_addCity.Click += Df_addCity_Click;
            dc_lv_hotels.DoubleClick += Dc_cities_DoubleClick;
            df_deleteCountry.Click += Df_deleteCity_Click;

            GetCityHotels(countryId, cityId);
        }

        /// <summary>
        /// Delete selected city
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Df_deleteCity_Click(object sender, EventArgs e)
        {
            if (dc_lv_hotels.SelectedItems.Count > 0)
            {
                string data = $"token=ps_rpo_2&param=deleteCity&city={dc_lv_hotels.SelectedItems[0].Text}";

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
                    GetCityHotels(countryId, cityId);

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

            AddCityForm acf = new AddCityForm(city, null);
            if (acf.ShowDialog() == DialogResult.OK)
            {
                GetCityHotels(countryId, cityId);
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
            city.id = Convert.ToInt32(dc_lv_hotels.SelectedItems[0].Text);
            city.cityName = dc_lv_hotels.SelectedItems[0].SubItems[1].Text;
            city.countryId = countryId;

            AddCityForm acf = new AddCityForm(city, null);
            if (acf.ShowDialog() == DialogResult.OK)
            {
                GetCityHotels(countryId, cityId);
            }
        }

        /// <summary>
        /// Get list of celected country cities
        /// </summary>
        /// <param name="countryId"></param>
        /// <returns></returns>
        private async void GetCityHotels(int countryId, int cityId)
        {
            string data = $"token=ps_rpo_2&param=getHotels&countryId={countryId}&cityId={cityId}";

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

            List<Hotel> cities = JsonConvert.DeserializeObject<List<Hotel>>(responseJson).Select(h => h).ToList();

            dc_lv_hotels.Items.Clear();

            foreach (var item in cities)
            {
                ListViewItem lvi = new ListViewItem(item.id.ToString());
                lvi.SubItems.Add(item.hotelName);
                lvi.SubItems.Add(item.stars.ToString());
                lvi.SubItems.Add(item.cost.ToString());
                dc_lv_hotels.Items.Add(lvi);
            }
        }
    }
}
