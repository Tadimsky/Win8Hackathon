using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace sendit.Classes
{
    public class Devices
    {
        [DataMember(Name = "deviceID")]
        public int Id { get; set; }

        [DataMember(Name = "fname")]
        public string Text { get; set; }

        [DataMember(Name = "owner")]
        public string Complete { get; set; }
        
    }
}
