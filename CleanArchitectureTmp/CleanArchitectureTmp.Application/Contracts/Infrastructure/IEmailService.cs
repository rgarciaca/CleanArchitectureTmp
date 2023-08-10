using CleanArchitectureTmp.Application.Models;

namespace CleanArchitectureTmp.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
