using Ardalis.GuardClauses;
using Haskap.DddBase.Domain.Core;
using Haskap.Resume.Domain.Core.MessageAggregate.GuardClauses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haskap.Resume.Domain.Core.MessageAggregate;

public class MessageSenderEmailAddress : ValueObject
{
    public string Value { get; private set; }

    private MessageSenderEmailAddress()
    {

    }

    public MessageSenderEmailAddress(string value)
    {
        Guard.Against.NullOrWhiteSpace(value, nameof(value));
        Guard.Against.InvalidEmailAddressFormat(value, nameof(value));

        Value = value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
