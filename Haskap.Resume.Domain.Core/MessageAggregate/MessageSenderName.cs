using Ardalis.GuardClauses;
using Haskap.DddBase.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haskap.Resume.Domain.Core.MessageAggregate;

public class MessageSenderName : ValueObject
{
    public string Value { get; private set; }

    private MessageSenderName()
    {

    }

    public MessageSenderName(string value)
    {
        Guard.Against.NullOrWhiteSpace(value, nameof(value));

        Value = value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
