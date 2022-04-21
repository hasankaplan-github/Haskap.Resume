using Ardalis.GuardClauses;
using Haskap.Resume.Domain.Core.MessageAggregate.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haskap.Resume.Domain.Core.MessageAggregate.GuardClauses;

public static class MessageSenderEmailAddressGuardClauses
{
    public static string InvalidEmailAddressFormat(this IGuardClause guardClause, string input, string parameterName, string? message = null)
    {
        var userEmailValidator = new MessageSenderEmailAddressValidator();
        var valiationResult = userEmailValidator.Validate(input);

        if (valiationResult.IsValid == false)
            throw new ArgumentException(message, parameterName);

        return input;
    }
}
