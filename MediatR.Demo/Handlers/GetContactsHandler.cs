using MediatR.Demo.Data;
using MediatR.Demo.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MediatR.Demo.Handlers
{
    public class GetContactsHandler : IRequestHandler<GetContactsQuery, List<Contact>>
    {     
        private ContactsContext _db;

        public GetContactsHandler(IMediator mediator, ContactsContext db)
        {          
            _db = db;
        }

        public async Task<List<Contact>> Handle(GetContactsQuery request, CancellationToken cancellationToken)
        {  
            return await _db.Contacts.ToListAsync();
        }
    }
}
