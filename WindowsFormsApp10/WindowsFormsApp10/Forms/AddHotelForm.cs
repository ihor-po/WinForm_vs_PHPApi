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
    public partial class AddHotelForm : Form
    {
        private string city;
        private string responseJson;
        private Hotel hotel;

        public AddHotelForm(Hotel _hotel, string _city)
        {
            InitializeComponent();
            this.Load += AddForm_Load;
            hotel = _hotel;
            city = _city;

        }

        private async void AddForm_Load(object sender, EventArgs e)
        {
            aсf_addButton.Click += Af_addButton_Click;

            if (hotel.id == -1)
            {
                this.Text = $"Добавление отеля в город {city}";
                aсf_addButton.Text = "Добавить";
            }
            else
            {
                this.Text = $"Редактирование отеля в городе {city}";
                aсf_addButton.Text = "Изменить";
                ahf_hotelName.Text = hotel.hotelName;
                ahf_cb_cost.Value = hotel.cost;
                ahf_tb_about.Text = hotel.info;
                FillStars();
            }

            await LoadComboboxCountriesAsync();
            await LoadComboboxCitiesAsync();
            SelectCountry();
            SelectCity();
        }

        private void Af_addButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ahf_hotelName.Text))
            {
                hotel.hotelName = ahf_hotelName.Text;
                if (ahf_cb_countries.SelectedIndex != -1)
                {
                    hotel.countryId = Convert.ToInt32(ahf_cb_countries.SelectedValue);
                    if (ahf_cb_cities.SelectedIndex != -1)
                    {
                        hotel.cityId = Convert.ToInt32(ahf_cb_countries.SelectedValue);
                        if (ahf_cb_stars.SelectedIndex != -1)
                        {
                            hotel.stars = Convert.ToInt32(ahf_cb_stars.SelectedItem);
                            hotel.cost = Convert.ToInt32(ahf_cb_cost.Value);
                            if (!String.IsNullOrEmpty(ahf_tb_about.Text))
                            {
                                hotel.info = ahf_tb_about.Text;
                               
                            }
                            else
                            {
                                Common.ShowErrorMessage("Вы не ввели описание отеля!");
                                return;
                            }
                        }
                        else
                        {
                            Common.ShowErrorMessage("Вы не выбрали количество звезд!");
                            return;
                        }
                    }
                    else
                    {
                        Common.ShowErrorMessage("Вы не выбрали город!");
                        return;
                    }
                }
                else
                {
                    Common.ShowErrorMessage("Вы не выбрали страну!");
                    return;
                }
            }
            else
            {
                Common.ShowErrorMessage("Введите название отеля!");
                return;
            }

            switch (aсf_addButton.Text)
            {
                case "Изменить":
                        UpdateHotel();
                    break;
                   
                case "Добавить":
                    AddNewHotel();
                    break;
            }
        }

        /// <summary>
        /// Add hotel to DB
        /// </summary>
        /// <param name="country"></param>
        private async void AddNewHotel()
        {
            hotel.countryId = Convert.ToInt32(ahf_cb_countries.SelectedValue.ToString());
            hotel.cityId = Convert.ToInt32(ahf_cb_cities.SelectedValue.ToString());

            string data = $"token=ps_rpo_2&param=createHotel&hotel=" + JsonConvert.SerializeObject(hotel);

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
                Common.ShowSuccessMessage("Отель добавлен!");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                Common.ShowErrorMessage("Ошибка добавления!");
            }
        }

        /// <summary>
        /// Update hotel by id
        /// </summary>
        private async void UpdateHotel()
        {
            string data = $"token=ps_rpo_2&param=updateHotel&hotel=" + JsonConvert.SerializeObject(hotel);
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
                Common.ShowSuccessMessage("Отель изменен!");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                Common.ShowErrorMessage("Ошибка изменения!");
            }
        }

        /// <summary>
        /// Get list of countries
        /// </summary>
        /// <returns></returns>
        private async Task LoadComboboxCountriesAsync()
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
            ahf_cb_countries.DataSource = countiries;
            ahf_cb_countries.DisplayMember = "countryName";
            ahf_cb_countries.ValueMember = "id";
        }

        /// <summary>
        /// Get list of celected country cities
        /// </summary>
        /// <param name="countryId"></param>
        /// <returns></returns>
        private async Task LoadComboboxCitiesAsync()
        {
            string data = $"token=ps_rpo_2&param=getCities&countryId={hotel.countryId}";

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

            ahf_cb_cities.DataSource = cities;
            ahf_cb_cities.DisplayMember = "cityName";
            ahf_cb_cities.ValueMember = "id";
        }

        /// <summary>
        /// Select hotel country
        /// </summary>
        private void SelectCountry()
        {
            int i = 0;
            foreach (Country val in ahf_cb_countries.Items)
            {
                if (val.id == hotel.countryId)
                {
                    ahf_cb_countries.SelectedIndex = i;
                    break;
                }
                i++;
            }
        }

        /// <summary>
        /// Select hotel city
        /// </summary>
        private void SelectCity()
        {
            int i = 0;
            foreach (City val in ahf_cb_cities.Items)
            {
                if (val.id == hotel.cityId)
                {
                    ahf_cb_cities.SelectedIndex = i;
                    break;
                }
                i++;
            }
        }

        private void FillStars()
        {
            int i = 0;
            foreach (string val in ahf_cb_stars.Items)
            {
                if (Convert.ToInt32(val) == hotel.stars)
                {
                    ahf_cb_stars.SelectedIndex = i;
                    break;
                }
                i++;
            }
        }
    }
}
