using Hotel.Database;
using Hotel.Forms;
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
    public partial class Payment : Form
    {
        private readonly int newUserId;
        private readonly Cart _cart;
        private readonly DatabaseHelper db = new DatabaseHelper();

        public Payment(int userId, Cart cart)
        {
            InitializeComponent();
            newUserId = userId;
            _cart = cart;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            lblAmount.Text = _cart.Price.ToString("N0") + " TK";
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string paymentMethod = radioBkash.Checked ? "Bkash"
               : radioNagad.Checked ? "Nagad"
               : radiocash.Checked ? "CashOnDelivery"
               : null;




            if (paymentMethod == null)
            {
                MessageBox.Show(
                    "Please select a payment method before placing your order.",
                    "Payment Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // stop here, don’t continue to booking
            }


            db.AddRoomBuy(
                newUserId,
                _cart.RoomType,
                _cart.Price,
                _cart.Food,
                _cart.Nights,
                 paymentMethod,
                _cart.CheckIn,
                _cart.CheckOut

            );

            MessageBox.Show("Your Room is Booked!", "Boking Confirmed",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            RoomList f4 = new RoomList(newUserId);
            f4.Show();
        }
    }
}
