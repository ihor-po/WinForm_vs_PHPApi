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
    public partial class AddCityForm : Form
    {
        private string country;
        private string responseJson;
        private City city;

        public AddCityForm(City _city, string _country)
        {
            InitializeComponent();
            this.Load += AddForm_Load;
            city = _city;
            country = _country;

        }

        private async void AddForm_Load(object sender, EventArgs e)
        {
            aсf_addButton.Click += Af_addButton_Click;

            if (city.id == -1)
            {
                this.Text = $"Добавление города в страну {country}";
                aсf_addButton.Text = "Добавить";
            }
            else
            {
                this.Text = $"Редактирование города в стране {country}";
                aсf_addButton.Text = "Изменить";
                aсf_cityName.Text = city.cityName;
            }

            await LoadComboboxCountriesAsync();
            SelectCountry();
        }

        private void Af_addButton_Click(object sender, EventArgs e)
        {
            switch (aсf_addButton.Text)
            {
                case "Изменить":
                    if (!String.IsNullOrEmpty(aсf_cityName.Text) && city != null)
                    {
                        UpdateCity();
                    }
                    else
                    {
                        Common.ShowErrorMessage("Введите название страны!");
                    }
                    break;
                   
                case "Добавить":

                    if (!String.IsNullOrEmpty(aсf_cityName.Text))
                    {
                        AddNewCity(aсf_cityName.Text);
                    }
                    else
                    {
                        Common.ShowErrorMessage("Введите название страны!");
                    }
                    break;
            }
        }

        /// <summary>
        /// Add country to DB
        /// </summary>
        /// <param name="country"></param>
        private async void AddNewCity(string cityName)
        {
            city.cityName = cityName;
            city.countryId = Convert.ToInt32(acf_cb_countries.SelectedValue.ToString());
            
            string data = $"token=ps_rpo_2&param=createCity&city=" + JsonConvert.SerializeObject(city);

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
                Common.ShowSuccessMessage("Город добавлен!");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                Common.ShowErrorMessage("Ошибка добавления!");
            }
        }

        /// <summary>
        /// Update country by id
        /// </summary>
        private async void UpdateCity()
        {
            city.cityName = aсf_cityName.Text;
            city.countryId = Convert.ToInt32(acf_cb_countries.SelectedValue.ToString());

            string data = $"token=ps_rpo_2&param=updateCity&city=" + JsonConvert.SerializeObject(city);
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
                Common.ShowSuccessMessage("Город изменен!");
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
            acf_cb_countries.DataSource = countiries;
            acf_cb_countries.DisplayMember = "countryName";
            acf_cb_countries.ValueMember = "id";
        }

        /// <summary>
        /// Select city country
        /// </summary>
        private void SelectCountry()
        {
            int i = 0;
            foreach (Country val in acf_cb_countries.Items)
            {
                if (val.id == city.countryId)
                {
                    acf_cb_countries.SelectedIndex = i;
                    break;
                }
                i++;
            }
        }
    }
}
