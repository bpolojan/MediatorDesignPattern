using MediatR.Demo.Data;
using MediatR;

namespace MediatR.Demo.Commands
{
    public class CreateContactCommand : IRequest<Contact>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual string WebSite { get; set; }
    }
}
