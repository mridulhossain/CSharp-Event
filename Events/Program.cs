using System;

namespace Events
{
    class Program
    {
        // create delegate for signiture
        public delegate void Noti(string msg);

        // create event type of delegates
        public static event Noti MsgSender;

        static void Main(string[] args)
        {
            //create connetion
            MsgSender += SmsSend;
            MsgSender += EmailSend;


            // invoke with data
            MsgSender.Invoke("Hello,thank you for subscribe.");
        }




        //method
        public static void SmsSend(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void EmailSend(string msg)
        {
            Console.WriteLine(msg);
        }

    }
}
