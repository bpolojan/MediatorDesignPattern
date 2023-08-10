using MediatR.Demo.Data;
using MediatR.Demo.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MediatR.Demo.Handlers
{
    public class GetContactByIdHandler : IRequestHandler<GetContactByIdQuery, Contact>
    { 
        private ContactsContext _db;
        public GetContactByIdHandler(ContactsContext db)
        {
            _db = db;
        }

        // This is where the Bussiness Logic Takes Place -> you can Inject here _Mapper/Repo/Logging
        public async Task<Contact> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
        {
            var order = await _db.Contacts.Where(c => c.Id == request.Id).SingleOrDefaultAsync();
            return order == null ? null: order;
          
        }
    }
}
