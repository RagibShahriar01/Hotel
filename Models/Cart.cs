using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Cart
    {

        public int UserId { get; set; }
        public string RoomType { get; set; }

        public string Food { get; set; }

        public int Nights { get; set; }
        public decimal Price { get; set; }

        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
