using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_PrepaidKartica
{
    public partial class PrepaidForm : Form
    {
        private PrepaidKartica _kartica;
        public PrepaidForm()
        {
            InitializeComponent();
        }

        private void PrepaidForm_Load(object sender, EventArgs e)
        {
            _kartica = new PrepaidKartica("HR12312414213");
            txtSerijskiBroj.Text = _kartica.SerijskiBroj;
        }

        private void btnAktiviraj_Click(object sender, EventArgs e)
        {
            _kartica.Aktiviraj();

            txtIznos.Text = _kartica.getCardMoney().ToString();
            txtStatus.Text = _kartica.getState().ToString();
        }

        private void btnUplati_Click(object sender, EventArgs e)
        {
            double iznosUplate = double.Parse(txtIznosUplate.Text);
            _kartica.Uplati(iznosUplate);
            txtIznosUplate.Clear();

            txtIznos.Text = _kartica.getCardMoney().ToString();
            txtStatus.Text = _kartica.getState().ToString();
        }

        private void btnIsplati_Click(object sender, EventArgs e)
        {
            double iznosIsplate = double.Parse(txtIznosIsplate.Text);
            _kartica.Isplati(iznosIsplate);
            
            txtIznos.Text = _kartica.getCardMoney().ToString();
            txtStatus.Text = _kartica.getState().ToString();

            txtIznosIsplate.Clear();
        }
    }
}
