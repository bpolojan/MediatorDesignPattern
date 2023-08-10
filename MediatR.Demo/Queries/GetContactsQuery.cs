using MediatR.Demo.Data;

namespace MediatR.Demo.Queries
{
    public class GetContactsQuery:IRequest<List<Contact>>
    {
        
    }
}
