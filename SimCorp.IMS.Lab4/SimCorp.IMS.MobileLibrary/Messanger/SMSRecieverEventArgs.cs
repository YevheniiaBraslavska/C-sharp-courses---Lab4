using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobileLibrary {
    public class SMSRecieverEventArgs : EventArgs {
        public UserMessage Message { get; set; }
        public Mobile Mobile { get; set; }

        public SMSRecieverEventArgs(UserMessage message,Mobile mobile) {
            Message = message;
            Mobile = mobile;
        }
    }
}
