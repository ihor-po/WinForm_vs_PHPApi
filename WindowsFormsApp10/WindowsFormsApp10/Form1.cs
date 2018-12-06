using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp10
{
    public partial class main_form : Form
    {
        private string responseJson;
        public main_form()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            mf_addCountry.MouseHover += Mf_addCountry_MouseHover;
            mf_addCountry.MouseLeave += Mf_addCountry_MouseLeave;
            mf_addCountry.MouseDown += Mf_addCountry_MouseDown;
            mf_addCountry.MouseUp += Mf_addCountry_MouseLeave;
            mf_addCountry.Click += Mf_addCountry_Click;

            mf_countries.SelectedIndexChanged += Mf_countries_SelectedIndexChanged;

            await LoadComboboxCountriesAsync();

        }

        private void Mf_addCountry_Click(object sender, EventArgs e)
        {
            add_country ac = new add_country();

            ac.Show();

        }

        private void Mf_countries_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = (sender as ComboBox).SelectedValue.ToString();
        }

        #region styles
        /// <summary>
        /// Change button color when click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mf_addCountry_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Button).BackColor = Color.MidnightBlue;
        }

        /// <summary>
        /// Change to standart color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mf_addCountry_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.CornflowerBlue;
        }
        #endregion

        /// <summary>
        /// Change color when mouse over button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mf_addCountry_MouseHover(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.RoyalBlue;
        }

        //private async Task InsertCountriesAsync()
        //{
        //    //WebRequest request = WebRequest.Create("http://localhost:777/travel_agancy.loc/apiExem/api.php");       
        //    WebRequest request = WebRequest.Create("http://178.213.0.182:11080/apiExem/api.php");       
        //    //WebRequest request = WebRequest.Create("http://192.168.88.217/apiExem/api.php");
        //    request.Method = "POST"; // для отправки используется метод Post
        //                             // данные для отправки
        //    string data = $"token=ps_rpo_2&param=insCountries&object={JsonConvert.SerializeObject(new Country { countryName="Bolivia"})}";
        //    // преобразуем данные в массив байтов
        //    byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);
        //    // устанавливаем тип содержимого - параметр ContentType
        //    request.ContentType = "application/x-www-form-urlencoded";
        //    // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
        //    request.ContentLength = byteArray.Length;

        //    //записываем данные в поток запроса
        //    using (Stream dataStream = request.GetRequestStream())
        //    {
        //        dataStream.Write(byteArray, 0, byteArray.Length);
        //    }

        //    WebResponse response = await request.GetResponseAsync();
        //    using (Stream stream = response.GetResponseStream())
        //    {
        //        using (StreamReader reader = new StreamReader(stream))
        //        {
        //            responseJson = reader.ReadToEnd();
        //        }
        //    }
        //    response.Close();
        //    if (responseJson == "200") {
        //        MessageBox.Show("Страна добавлена!");
        //    }
        //}

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

            List < Country > countiries = JsonConvert.DeserializeObject<List<Country>>(responseJson).Select(c => c).ToList();
            mf_countries.DataSource = countiries;
            mf_countries.DisplayMember = "countryName";
            mf_countries.ValueMember = "id";
        }
    }
}
