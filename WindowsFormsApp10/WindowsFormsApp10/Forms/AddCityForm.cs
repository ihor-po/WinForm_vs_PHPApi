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
        private int id;
        private int countryId;
        private string country;
        private string responseJson;
        private City city;

        public AddCityForm(int _id, int _countryId, string _country)
        {
            InitializeComponent();
            this.Load += AddForm_Load;
            id = _id;
            countryId = _countryId;
            country = _country;

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            aсf_addButton.Click += Af_addButton_Click;

            if (id == -1)
            {
                this.Text = $"Добавление города в страну {country}";
                aсf_addButton.Text = "Добавить";
            }
            else
            {
                this.Text = $"Редактирование города в стране {country}";
                aсf_addButton.Text = "Изменить";
                getCountryById();
            }
        }

        private void Af_addButton_Click(object sender, EventArgs e)
        {
            switch (aсf_addButton.Text)
            {
                case "Изменить":
                    if (!String.IsNullOrEmpty(aсf_cityName.Text) && city != null)
                    {
                        UpdateCountry();
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

        private async void getCountryById()
        {
            string data = $"token=ps_rpo_2&param=getCountryById&countryId=" + id;

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

            city = JsonConvert.DeserializeObject<City>(responseJson);
            aсf_cityName.Text = city.cityName;
        }

        /// <summary>
        /// Add country to DB
        /// </summary>
        /// <param name="country"></param>
        private async void AddNewCity(string city)
        {
            City newCity = new City();
            newCity.cityName = city;
            newCity.countryId = countryId;
            //string data = $"token=ps_rpo_2&param=addCountry&country=" + aсf_cityName.Text;
            string data = JsonConvert.SerializeObject(newCity);

            //WebRequest request = Common.SendData("POST", data);

            //WebResponse response = await request.GetResponseAsync();

            //using (Stream stream = response.GetResponseStream())
            //{
            //using (StreamReader reader = new StreamReader(stream))
            //{
            //responseJson = reader.ReadToEnd();
            //}
            //}
            //response.Close();

            //if (responseJson == "200")
            //{
            //    Common.ShowSuccessMessage("Страна добавлена!");
            //    this.DialogResult = DialogResult.OK;
            //}
            //else
            //{
            //    Common.ShowErrorMessage("Ошибка добавления!");
            //}
        }

        /// <summary>
        /// Update country by id
        /// </summary>
        private async void UpdateCountry()
        {
            string data = $"token=ps_rpo_2&param=updateCountryById&country={aсf_cityName.Text}&countryId={city.id}";

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
                Common.ShowSuccessMessage("Страна изменена!");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                Common.ShowErrorMessage("Ошибка изменения!");
            }
        }
    }
}
