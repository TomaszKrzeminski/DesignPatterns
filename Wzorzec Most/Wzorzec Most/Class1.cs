using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec_Most
{
   


    public interface Device
    {
        VideoCall videoCall { get; set; }
        void ShowVideo();
        void StartVideo();
        void StopVideo();
        void Text(string messageText);
        void SelectPerson(string PersonName);


    }


    public interface VideoCall
    {
        void ShowVideo();
        void StartVideo();
        void StopVideo();
        void Text(string messageText);
        void SelectPerson(string PersonName);

    }





    public class CellPhone : Device
    {
        public VideoCall videoCall { get; set; }

        public CellPhone(VideoCall videoCall)
        {
            this.videoCall = videoCall;
        }


        public void SelectPerson(string PersonName)
        {
            Console.WriteLine("Cell Phone");
            videoCall.SelectPerson(PersonName);
        }

        public void ShowVideo()
        {
            Console.WriteLine("Cell Phone");
            videoCall.ShowVideo();
        }

        public void StartVideo()
        {
            Console.WriteLine("Cell Phone");
            videoCall.StartVideo();
        }

        public void StopVideo()
        {
            Console.WriteLine("Cell Phone");
            videoCall.StopVideo();
        }

        public void Text(string messageText)
        {
            Console.WriteLine("Cell Phone");
            videoCall.Text(messageText);
        }
    }

    public class Tablet : Device
    {
        public VideoCall videoCall { get; set; }

        public Tablet(VideoCall videoCall)
        {
            this.videoCall = videoCall;
        }


        public void SelectPerson(string PersonName)
        {
            Console.WriteLine("Tablet");
            videoCall.SelectPerson(PersonName);
        }

        public void ShowVideo()
        {
            Console.WriteLine("Tablet");
            videoCall.ShowVideo();
        }

        public void StartVideo()
        {
            Console.WriteLine("Tablet");
            videoCall.StartVideo();
        }

        public void StopVideo()
        {
            Console.WriteLine("Tablet");
            videoCall.StopVideo();
        }

        public void Text(string messageText)
        {
            Console.WriteLine("Tablet");
            videoCall.Text(messageText);
        }
    }

    public class FbMessanger : VideoCall
    {
        public void SelectPerson(string PersonName)
        {
            Console.WriteLine("FB Messenger selecting" +PersonName);
        }

        public void ShowVideo()
        {
            Console.WriteLine("FB Messenger showing video");
        }

        public void StartVideo()
        {
            Console.WriteLine("FB Messenger starting video");
        }

        public void StopVideo()
        {
            Console.WriteLine("FB Messenger stoping video");
        }

        public void Text(string messageText)
        {
            Console.WriteLine("FB Messenger writting message");
        }
    }

    public class WhatsUp : VideoCall
    {
        public void SelectPerson(string PersonName)
        {
            Console.WriteLine("WhatsUp selecting" + PersonName);
        }

        public void ShowVideo()
        {
            Console.WriteLine("WhatsUp showing video");
        }

        public void StartVideo()
        {
            Console.WriteLine("WhatsUp starting video");
        }

        public void StopVideo()
        {
            Console.WriteLine("WhatsUp stoping video");
        }

        public void Text(string messageText)
        {
            Console.WriteLine("WhatsUp writting message");
        }
    }


}
