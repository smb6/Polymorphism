using System;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNoficationChannel(new MailNotificationChannel());
            encoder.RegisterNoficationChannel(new SmsNotificationChannel());
            encoder.Encode(new Video());
        }
    }
}
