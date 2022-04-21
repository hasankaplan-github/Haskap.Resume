using Ardalis.GuardClauses;
using Haskap.DddBase.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haskap.Resume.Domain.Core.MessageAggregate;

public class MessageBody : ValueObject
{
    public string Value { get; private set; }

    private MessageBody()
    {

    }

    public MessageBody(string value)
    {
        Guard.Against.NullOrWhiteSpace(value, nameof(value));
        Guard.Against.InvalidInput(value, nameof(value), x => x.Length > 2000);

        Value = value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
