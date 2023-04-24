using ConsiderTheSourceCode.Application.DTOs.Email;

namespace ConsiderTheSourceCode.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequestDto request);
    }
}
