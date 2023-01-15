using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retailer_App.Models
{
    public class UserRule
    {
        public string Uid { get; set; }
        public User User { get; set; } = new User(); 
        public string Menu { get; set; }
        public string Access { get; set; }
    }
}
