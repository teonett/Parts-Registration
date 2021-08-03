using System.Collections.Generic;
using Flunt.Notifications;
using NetHacksPack.Core;

namespace Parts.Registration.Domain.Commands
{
    public abstract class BaseCommand : Command
    {
        public bool Valid { get { return this.contract.Valid; } }
        public IReadOnlyCollection<Notification> Notifications { get { return this.contract.Notifications; } }
        public bool Invalid { get { return this.contract.Invalid; } }

        private Flunt.Validations.Contract contract;

        protected void Validate(Flunt.Validations.Contract contract)
        {
            this.contract = contract;
        }

    }
}
