using System;
using System.Threading;
using System.Threading.Tasks;

public interface IEmailService
{
    void SendEmail(Message message);
}
