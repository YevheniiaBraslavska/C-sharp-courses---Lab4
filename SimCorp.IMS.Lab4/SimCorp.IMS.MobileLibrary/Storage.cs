﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobileLibrary {
    public class Storage {
        public List<UserMessage> Messages = new List<UserMessage>();

        public void Write(object sender, SMSRecieverEventArgs args) {
            Messages.Add(args.Message);
            args.Mobile.SmsProvider.RaiseSmsRecievedEvent(sender, args);
        }

        public void Delete(UserMessage message) {
            Messages.Remove(message);
        }

        public void Delete(List<UserMessage> messages) {
            foreach (var message in messages) {
                Delete(message);
            }
        }
    }
}
