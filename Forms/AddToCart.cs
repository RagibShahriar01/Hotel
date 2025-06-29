using Hotel.Database;
using Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Hotel.Forms
{
    public partial class AddToCart : Form
    {

        private readonly Cart _cart;
        private readonly int newUserId;
        private readonly DatabaseHelper _db = new DatabaseHelper();
        public AddToCart(int userId, Cart cart)
        {
            InitializeComponent();
            _cart = cart ?? throw new ArgumentNullException(nameof(cart));
            newUserId = userId;

        }

        private void AddToCart_Load(object sender, EventArgs e)
        {
            // Populate UI from _cart
            lblProuct.Text = _cart.RoomType;
            lblKarat.Text = _cart.Food;
            Nightnum.Text = _cart.Nights.ToString("g");
            lblTotal.Text = _cart.Price.ToString("N0") + " Tk";
            CheckIndis.Text = _cart.CheckIn.ToString("g");
            label7.Text = _cart.CheckOut.ToString("g");

            // Wire up confirmation button

        }

        private void lblKarat_Click(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {

            this.Hide();
            Payment p1 = new Payment(newUserId, _cart);
            p1.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment p1 = new Payment(newUserId, _cart);


        }

        private void Nightnum_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
