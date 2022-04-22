using Haskap.Resume.Application.UseCaseServices.Dtos;

namespace Haskap.Resume.Application.UseCaseServices.Contracts;

public interface IContactService
{
    Task SendMessageAsync(SendMessageInputDto sendMessageInputDto);
}
