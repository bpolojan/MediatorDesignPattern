using MediatR.Demo.Commands;
using MediatR.Demo.Data;
using MediatR;

namespace MediatR.Demo.Handlers
{
    public class CreateContactHandler : IRequestHandler<CreateContactCommand, Contact>
    {
        private readonly ContactsContext _db;
        public CreateContactHandler(ContactsContext db)
        {
            _db = db;
        }
        public async Task<Contact> Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            Contact contact = new Contact() { FirstName = request.FirstName, LastName = request.LastName, WebSite = request.WebSite };
            _db.Add(contact);
            await _db.SaveChangesAsync(cancellationToken);
            return contact;
        }
    }
}
