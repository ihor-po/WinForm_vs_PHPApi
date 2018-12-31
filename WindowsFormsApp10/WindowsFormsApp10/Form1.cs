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
        private List<Hotel> hotels;
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

            mf_btn_cityDictionary.MouseHover += Mf_addCountry_MouseHover;
            mf_btn_cityDictionary.MouseLeave += Mf_addCountry_MouseLeave;
            mf_btn_cityDictionary.MouseDown += Mf_addCountry_MouseDown;
            mf_btn_cityDictionary.MouseUp += Mf_addCountry_MouseLeave;

            mf_btn_hotelDictionary.MouseHover += Mf_addCountry_MouseHover;
            mf_btn_hotelDictionary.MouseLeave += Mf_addCountry_MouseLeave;
            mf_btn_hotelDictionary.MouseDown += Mf_addCountry_MouseDown;
            mf_btn_hotelDictionary.MouseUp += Mf_addCountry_MouseLeave;

            mf_addCountry.Click += Mf_addCountry_Click;
            mf_btn_cityDictionary.Click += Mf_btn_cityDictionary_Click;
            mf_btn_hotelDictionary.Click += Mf_btn_hotelDictionary_Click;

            mf_countries.SelectedIndexChanged += Mf_countries_SelectedIndexChanged;
            mf_cb_city.SelectedIndexChanged += Mf_cb_city_SelectedIndexChanged;
            mf_cb_hotel.SelectedIndexChanged += Mf_cb_hotel_SelectedIndexChanged;

            await LoadComboboxCountriesAsync();

            int countryId = Convert.ToInt32(mf_countries.SelectedValue.ToString());

            await LoadComboboxCitiesAsync(countryId);

            int cityId = Convert.ToInt32(mf_cb_city.SelectedValue.ToString());

            await LoadComboboxHotelsAsync(countryId, cityId);

            int hotelId = Convert.ToInt32(mf_cb_hotel.SelectedValue.ToString());
            FillHotelInfo(hotelId);

        }

        private void Mf_btn_hotelDictionary_Click(object sender, EventArgs e)
        {
            int countryId = Convert.ToInt32(mf_countries.SelectedValue.ToString());
            int cityId = Convert.ToInt32(mf_cb_city.SelectedValue.ToString());
            string city = mf_cb_city.Text;

            Dictionary_hotel dh = new Dictionary_hotel(countryId, cityId, city);
            dh.ShowDialog();
        }

        /// <summary>
        /// Event when selected city changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Mf_cb_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int countryId = Convert.ToInt32(mf_countries.SelectedValue.ToString());
                int cityId = Convert.ToInt32(mf_cb_city.SelectedValue.ToString());

                await LoadComboboxHotelsAsync(countryId, cityId);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// When selected hotel was changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mf_cb_hotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int hotelId = Convert.ToInt32(mf_cb_hotel.SelectedValue.ToString());
                ClearStars();
                FillHotelInfo(hotelId);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Show form for working with Cities dictionary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mf_btn_cityDictionary_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(mf_countries.SelectedValue.ToString());
            string country = mf_countries.Text;
            Dictionary_city dc = new Dictionary_city(id, country);
            dc.ShowDialog();
        }

        /// <summary>
        /// Show form for working with Country dictionary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mf_addCountry_Click(object sender, EventArgs e)
        {
            add_country ac = new add_country();

            ac.ShowDialog();
        }

        /// <summary>
        /// Country change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Mf_countries_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = mf_countries.SelectedValue.ToString();

            if (! String.IsNullOrEmpty(val))
            {
                try
                {
                    int id = Convert.ToInt32(val);
                    await LoadComboboxCitiesAsync(id);
                }
                catch (Exception)
                {

                }
               
            }
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

        /// <summary>
        /// Get list of celected country cities
        /// </summary>
        /// <param name="countryId"></param>
        /// <returns></returns>
        private async Task LoadComboboxCitiesAsync(int countryId)
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

            if (cities.Count() == 0)
            {
                EnabDisabCitiesControls(false);
                EnabDisabHotelsControls(false);
            }
            else
            {
                EnabDisabCitiesControls(true);

                mf_cb_city.DataSource = cities;
                mf_cb_city.DisplayMember = "cityName";
                mf_cb_city.ValueMember = "id";
            }
        }

        /// <summary>
        /// Get list of hotels
        /// </summary>
        /// <param name="countryId"></param>
        /// <param name="cityId"></param>
        /// <returns></returns>
        private async Task LoadComboboxHotelsAsync(int countryId, int cityId)
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

            hotels = JsonConvert.DeserializeObject<List<Hotel>>(responseJson).Select(c => c).ToList();

            if (hotels.Count() == 0)
            {
                EnabDisabHotelsControls(false);
            }
            else
            {
                EnabDisabHotelsControls(true);

                mf_cb_hotel.DataSource = hotels;
                mf_cb_hotel.DisplayMember = "hotelName";
                mf_cb_hotel.ValueMember = "id";
            }
        }

        /// <summary>
        /// Enable / disable cities controls
        /// </summary>
        /// <param name="status"></param>
        private void EnabDisabCitiesControls(bool status)
        {
            mf_cb_city.Enabled = status;
            if (!status)
            {
                mf_cb_city.DataSource = null;
            }
        }

        /// <summary>
        /// Enable / disable cities controls
        /// </summary>
        /// <param name="status"></param>
        private void EnabDisabHotelsControls(bool status)
        {
            mf_cb_hotel.Enabled = status;
            if (!status)
            {
                mf_lbl_cost.Text = "0.00";
                mf_tb_hotelInfo.Text = "";
                mf_cb_hotel.DataSource = null;
                ClearStars();
            }
        }

        /// <summary>
        /// Fill hotel info
        /// </summary>
        /// <param name="hotelId"></param>
        private void FillHotelInfo(int hotelId)
        {
            Hotel hotel = hotels.First(h => h.id == hotelId);

            if (hotel != null)
            {
                mf_lbl_cost.Text = hotel.cost.ToString();
                mf_tb_hotelInfo.Text = hotel.info;
                FillStars(hotel.stars);
            }
            
        }


        /// <summary>
        /// Fill hotels stars
        /// </summary>
        /// <param name="count"></param>
        private void FillStars(int count)
        {
            if (count > 0 )
            {
                for (int i = 4; i > 4 - count; i--)
                {
                    if (mf_gb_stars.Controls[i] is PictureBox)
                    {
                        (mf_gb_stars.Controls[i] as PictureBox).Visible = true;
                    }
                    
                }
            }
        }

        /// <summary>
        /// Hide all stars
        /// </summary>
        private void ClearStars()
        {
            foreach(var item in mf_gb_stars.Controls)
            {
                if (item is PictureBox)
                {
                    (item as PictureBox).Visible = false;
                }
            }
        }

    }
}
