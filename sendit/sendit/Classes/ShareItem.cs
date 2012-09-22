using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;
using Windows.ApplicationModel.DataTransfer.ShareTarget;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;


namespace sendit.Classes
{
    class ShareItem
    {
        [DataMember(Name = "Title")]
        public string text { get; set; }

        [DataMember(Name = "Uri")]
        public string Uri  { get; set; }

        [DataMember(Name = "Html")]
        public string html { get; set; }

        [DataMember(Name = "Bitmap")]
        public BitmapImage bitmap { get; set; }

        [DataMember(Name = "File")]
        public StorageFile file { get; set; }

    }
}
