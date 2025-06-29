using Hotel.Database;
using Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Forms
{
    public partial class AcRoom : Form
    {

        private readonly Cart _cart;
        private readonly int newUserId;
        private readonly DatabaseHelper _db = new DatabaseHelper();
        public AcRoom(int userId, Cart cart)
        {
            InitializeComponent();
            _cart = cart ?? throw new ArgumentNullException(nameof(cart));
            newUserId = userId;
            
            
            foreach (var pb in this.Controls.OfType<PictureBox>())
            {
                // assume each pb.Tag was set in Designer to the room‐type string
                pb.Click += RoomPicture_Click;
                pb.Cursor = Cursors.Hand;
            }
        }


        private void UpdateAvailability()
        {
            // for each PictureBox, read its Tag as the RoomType
            foreach (var pb in this.Controls.OfType<PictureBox>())
            {
                var roomType = pb.Tag?.ToString();
                var lblName = $"lblBooked{pb.Tag}";
                var lblBooked = this.Controls
                    .OfType<Label>()
                    .FirstOrDefault(l => l.Name.Equals(lblName, StringComparison.OrdinalIgnoreCase));

                if (roomType != null && lblBooked != null)
                    ToggleBooking(roomType, pb, lblBooked);
            }
        }






        private bool IsBooked(string roomType)
        {
            const string sql = @"
                SELECT COUNT(*) FROM dbo.RoomBuy
                 WHERE RoomType = @RoomType
                   AND @CheckIn  < CheckOutDate
                   AND @CheckOut > CheckInDate";

            var cnt = (int)_db.ExecuteScalar(sql, new[]{
                new SqlParameter("@RoomType",   roomType),
                new SqlParameter("@CheckIn",    _cart.CheckIn),
                new SqlParameter("@CheckOut",   _cart.CheckOut)
            });
            return cnt > 0;
        }





        private void ToggleBooking(string roomType, PictureBox pb, Label lblBooked)
        {
            bool booked = IsBooked(roomType);
            lblBooked.Visible = booked;

            if (booked)
            {
                pb.Cursor = Cursors.No;
                pb.Click -= RoomPicture_Click;
                pb.Click += (s, e) => MessageBox.Show(
                    "This room is already booked for your selected dates.\nPlease choose another.",
                    "Room Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lblBooked.Visible = false;
                pb.Cursor = Cursors.Hand;
                pb.Click -= RoomPicture_Click;
                pb.Click += RoomPicture_Click;
            }
        }





         private void RoomPicture_Click(object sender, EventArgs e)
        {


            var pb = (PictureBox)sender;
            var roomType = pb.Tag.ToString();

            var nextCart = new Cart
            {
                UserId = _cart.UserId,
                RoomType = roomType,
                CheckIn = _cart.CheckIn,
                CheckOut = _cart.CheckOut
            };

            var detailForm = new AcDouble(newUserId, nextCart);
            LoadFormInPanel(detailForm);
        }


        private void LoadFormInPanel(Form f)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panel1.Controls.Clear();    // assume you have a panel2 for the room detail
            panel1.Controls.Add(f);
            f.Show();
        }

        private void RuipictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.TopLevelControl.Hide();
            new AcSingle(newUserId, _cart).Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.TopLevelControl.Hide();
            new AcDouble(newUserId, _cart).Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.TopLevelControl.Hide();
            new AcTwoSingle(newUserId, _cart).Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.TopLevelControl.Hide();
            new AcTriple(newUserId, _cart).Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.TopLevelControl.Hide();
            new AcTwoDouble(newUserId, _cart).Show();
        }

        private void AcRoom_Load(object sender, EventArgs e)
        {
            UpdateAvailability();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBookedTriple_Click(object sender, EventArgs e)
        {

        }
    }
}
