using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AzureTranslator;

namespace BingTranslatorAPI
{
    public partial class Form1 : Form
    {
        private readonly AzureAuthentication _authentication;
        private readonly AzureAccessToken _token;

        public Form1()
        {
            InitializeComponent();
            _authentication = new AzureAuthentication(
                AzureClientCredentials.clientId, 
                AzureClientCredentials.clientSecret);

             _token = _authentication.GetAccessToken();
        }

        private void btnTraducir_Click(object sender, EventArgs e)
        {            
            var bing = new BingTranslator();

            try
            {
                txtTraducido.Text = bing.Translate(_token,txtOriginal.Text,"es","en");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
