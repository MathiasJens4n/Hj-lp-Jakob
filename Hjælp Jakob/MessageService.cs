using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjælp_Jakob
{
    public enum MessageCarrier { Smtp, VMessage }
    //This class sends a message to either one or many persons using SMTP or VMessage
    internal class MessageService
    {
        Converter converter;

        string to, from, body, subject, cc;

        public string To { get => to; set => to = value; }
        public string From { get => from; set => from = value; }
        public string Body { get => body; set => body = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Cc { get => cc; set => cc = value; }

        public MessageService(string to, string from, string body, string subject, string cc)
        {
            this.to = to;
            this.from = from;
            this.body = body;
            this.subject = subject;
            this.cc = cc;
        }

        public void SendMessage(MessageCarrier type, MessageService m, bool isHTML)
        {
            //herinde sendes der en email ud til modtageren
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = converter.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = converter.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }

        public void SendMessageToAll(MessageCarrier type, string[] to, MessageService m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = converter.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = converter.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }
    }
}
