﻿using Hotel.Models;
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
    public partial class NonTwoDouble : Form
    {
        public readonly int newUserId;
        private readonly Cart _cart;
        private decimal _basePrice;
        private int _nights;
        public NonTwoDouble(int userId, Cart cart)
        {
            InitializeComponent();
            newUserId = userId;

            _cart = cart ?? throw new ArgumentNullException(nameof(cart));
            newUserId = userId;

            // wire once:
            radioFoodIncluded.CheckedChanged += FoodOption_CheckedChanged;
            radioFoodNotIncluded.CheckedChanged += FoodOption_CheckedChanged;
        }

     
        private void NonTwoDouble_Load(object sender, EventArgs e)
        {
            _nights = _cart.Nights;

            // display incoming dates
            lblCheckIn.Text = $"Check‑in:  {_cart.CheckIn:dd MMM yyyy}";
            lblCheckOut.Text = $"Check‑out: {_cart.CheckOut:dd MMM yyyy}";

            // default to food‐included
            radioFoodIncluded.Checked = true;

            lblCheckIn.Text = _cart.CheckIn.ToString("g");
            lblCheckOut.Text = _cart.CheckOut.ToString("g");

            UpdateSummary();
        }


        private void FoodOption_CheckedChanged(object sender, EventArgs e)
        {

            //pick base rate
            _basePrice = radioFoodIncluded.Checked ? 1500m : 1000m;
            _cart.Food = radioFoodIncluded.Checked
                           ? "Food Included"
                           : "Food Not Included";

            // now update the one‐label summary
            UpdateSummary();
        }




        private void UpdateSummary()
        {
            // total cost
            decimal total = _basePrice * _nights;

            // store in cart for later
            _cart.Price = total;

            // single label:
            label2.Text = total.ToString("N0") + " TK";
            lblSummary.Text = "Will Stay For " + $"{_nights} Night";
        }



        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            // fill in the room‐type now that we know it:
            _cart.RoomType = "Two Double Bed Non AC Room";

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
