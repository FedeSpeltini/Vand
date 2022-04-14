using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoPago.Client.Payment;
using MercadoPago.Client.Preference;
using MercadoPago.Config;
using MercadoPago.Resource.Payment;
using MercadoPago.Resource.Preference;

namespace Views
{
    public partial class FrmTestMercadoPago : Form
    {
        public FrmTestMercadoPago()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            MercadoPagoConfig.AccessToken = "TEST-3139802888276081-102617-55828606cc0a33e415ebb4658b655e59-350441853";
            var request = new PreferenceRequest
            {
                Items = new List<PreferenceItemRequest>
                {
                    new PreferenceItemRequest
                    {
                        Title = "Mi producto",
                        Quantity = 1,
                        CurrencyId = "ARS",
                        UnitPrice = 75.56m,
                    },
                },
            };

            // Crea la preferencia usando el client
            var client = new PreferenceClient();
            Preference preference = await client.CreateAsync(request);


            label1.Text = ($"Payment ID: {preference.Payer}");
        }
    }
}
