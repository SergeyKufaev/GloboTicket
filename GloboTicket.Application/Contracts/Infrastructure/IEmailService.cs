using System.Threading.Tasks;
using GloboTicket.Application.Models.Mail;

namespace GloboTicket.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmailAsync(Email email);
    }
}
