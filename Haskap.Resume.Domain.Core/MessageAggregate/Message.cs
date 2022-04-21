using System;

namespace Haskap.Resume.Domain.Core.MessageAggregate;

public class Message : AggregateRoot
{
    public MessageSubject Subject { get; set; }
    public MessageBody Body { get; set; }
    public MessageSenderName SenderName { get; set; }
    public MessageSenderEmailAddress SenderEmailAddress { get; set; }
    public DateTime MessageDate { get; set; }
    public bool IsRead { get; set; }

    public void MarkAsRead()
    {
        IsRead = true;
    }
}
