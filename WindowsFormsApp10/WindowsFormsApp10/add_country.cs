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
        }

        private void Add_country_Load(object sender, EventArgs e)
        {
            ac_countries.DoubleClick += Ac_countries_DoubleClick;

            GetAllCities();
        }

        private void Ac_countries_DoubleClick(object sender, EventArgs e)
        {
            this.Text = ac_countries.SelectedItems[0].Text;
        }

        /// <summary>
        /// Get all city from server
        /// </summary>
        private async void GetAllCities()
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

            foreach (var item in countiries)
            {
                ListViewItem lvi = new ListViewItem(item.id.ToString());
                lvi.SubItems.Add(item.countryName);
                ac_countries.Items.Add(lvi);
                
            }
        }
    }
}
