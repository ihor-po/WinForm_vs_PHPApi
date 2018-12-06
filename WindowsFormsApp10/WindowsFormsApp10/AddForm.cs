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
    public partial class AddForm : Form
    {
        private int id;
        private string responseJson;
        private Country country;

        public AddForm(int _id)
        {
            InitializeComponent();
            this.Load += AddForm_Load;
            id = _id;

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            af_addButton.Click += Af_addButton_Click;

            if (id == -1)
            {
                this.Text = "Добавление страны";
                af_addButton.Text = "Добавить";
            }
            else
            {
                this.Text = "Редактирование страны";
                af_addButton.Text = "Изменить";
                getCountryById();
            }
        }

        private void Af_addButton_Click(object sender, EventArgs e)
        {
            switch (af_addButton.Text)
            {
                case "Изменить":
                    if (!String.IsNullOrEmpty(af_countryName.Text) && country != null)
                    {
                        UpdateCountry();
                    }
                    else
                    {
                        Common.ShowErrorMessage("Введите название страны!");
                    }
                    break;
                   
                case "Добавить":

                    if (!String.IsNullOrEmpty(af_countryName.Text))
                    {
                        AddNewCountry(af_countryName.Text);
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

            country = JsonConvert.DeserializeObject<Country>(responseJson);
            af_countryName.Text = country.countryName;
        }

        /// <summary>
        /// Add country to DB
        /// </summary>
        /// <param name="country"></param>
        private async void AddNewCountry(string country)
        {
            string data = $"token=ps_rpo_2&param=addCountry&country=" + af_countryName.Text;

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
                Common.ShowSuccessMessage("Страна добавлена!");
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
        private async void UpdateCountry()
        {
            string data = $"token=ps_rpo_2&param=updateCountryById&country={af_countryName.Text}&countryId={country.id}";

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
