using System;

namespace Haskap.Resume.Domain.Core.MessageAggregate;

public class Message : AggregateRoot
{
    public MessageSubject Subject { get; private set; }
    public MessageBody Body { get; private set; }
    public MessageSenderName SenderName { get; private set; }
    public MessageSenderEmailAddress SenderEmailAddress { get; private set; }
    public DateTime MessageDate { get; private set; }
    public bool IsRead { get; private set; }

    public void MarkAsRead()
    {
        IsRead = true;
    }

    private Message()
    {
        
    }
    
    public Message(
        MessageSenderName messageSenderName, 
        MessageSenderEmailAddress messageSenderEmailAddress, 
        MessageSubject messageSubject, 
        MessageBody messageBody)
    {
        SenderName = messageSenderName;
        SenderEmailAddress = messageSenderEmailAddress;
        Subject = messageSubject;
        Body = messageBody;
        MessageDate = DateTime.UtcNow;
        IsRead = false;
    }
}
