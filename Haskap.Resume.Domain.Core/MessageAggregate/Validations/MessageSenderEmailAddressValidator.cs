using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haskap.Resume.Domain.Core.MessageAggregate.Validations;

public class MessageSenderEmailAddressValidator : AbstractValidator<string>
{
    public MessageSenderEmailAddressValidator()
    {
        RuleFor(x => x).EmailAddress();
    }
}
