using Haskap.DddBase.Utilities.Guids;
using Haskap.Resume.Application.UseCaseServices.Contracts;
using Haskap.Resume.Application.UseCaseServices.Dtos;
using Haskap.Resume.Domain.Core.MessageAggregate;
using Haskap.Resume.Infrastructure.Data.NpgsqlDbContext;

namespace Haskap.Resume.Application.UseCaseServices;

public class ContactService : IContactService
{
    private readonly ResumeDbContext _resumeDbContext;

    public ContactService(ResumeDbContext resumeDbContext)
    {
        _resumeDbContext=resumeDbContext;
    }

    public async Task SendMessageAsync(SendMessageInputDto sendMessageInputDto)
    {
        var messageSenderName = new MessageSenderName(sendMessageInputDto.SenderName);
        var messageSenderEmailAddress = new MessageSenderEmailAddress(sendMessageInputDto.SenderEmailAddress);
        var messageSubject = new MessageSubject(sendMessageInputDto.Subject);
        var messageBody = new MessageBody(sendMessageInputDto.Body);
        var message = new Message(GuidGenerator.CreateSimpleGuid(), messageSenderName, messageSenderEmailAddress, messageSubject, messageBody);

        await _resumeDbContext.Message.AddAsync(message);
        await _resumeDbContext.SaveChangesAsync();
    }
}