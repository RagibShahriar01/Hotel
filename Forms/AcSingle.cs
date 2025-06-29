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
    public partial class AcSingle : Form
    {
        public readonly int newUserId;
        private readonly Cart _cart;
        private decimal _basePrice;
        public AcSingle(int userId, Cart cart)
        {
            InitializeComponent();
            newUserId = userId;

            _cart = cart ?? throw new ArgumentNullException(nameof(cart));
            newUserId = userId;

            // wire once:
            radioFoodIncluded.CheckedChanged += FoodOption_CheckedChanged;
            radioFoodNotIncluded.CheckedChanged += FoodOption_CheckedChanged;

        }



        private void AcSingle_Load(object sender, EventArgs e)
        {
            // display incoming dates
            lblCheckIn.Text = $"Check‑in:  {_cart.CheckIn:dd MMM yyyy}";
            lblCheckOut.Text = $"Check‑out: {_cart.CheckOut:dd MMM yyyy}";

            // default to food‐included
            radioFoodIncluded.Checked = true;

            lblCheckIn.Text = _cart.CheckIn.ToString("g");
            lblCheckOut.Text = _cart.CheckOut.ToString("g");
        }


        private void FoodOption_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFoodIncluded.Checked)
            {
                _basePrice = 1500m;
                _cart.Food = "Food Included";
            }
            else
            {
                _basePrice = 9000m;
                _cart.Food = "Food Not Included";
            }

            _cart.Price = _basePrice;
            label2.Text = _basePrice.ToString("N0") + " Tk";
        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            // fill in the room‐type now that we know it:
            _cart.RoomType = "Single Bed AC Room";

            var checkoutForm = new AddToCart(newUserId, _cart);
            Hide();
            checkoutForm.Show();
        }

        private void backlabel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomList lo = new RoomList(newUserId);
            lo.Show();
        }
    }
}
