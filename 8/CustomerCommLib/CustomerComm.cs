using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCommLib
{
    public class CustomerComm
    {
        IMailSender _mailSender;
        public CustomerComm(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }
        public virtual bool SendMailToCustomer()
        {
            _mailSender.SendMail("sourishjana99@gmail.com", "Some message");
            return true;
        }
    }
}
