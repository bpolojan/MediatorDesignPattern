using MediatR.Demo.Data;
using MediatR;

namespace MediatR.Demo.Queries
{
    public class GetContactByIdQuery:IRequest<Contact>
    {
        public int Id { get; set; }
        public GetContactByIdQuery(int id)
        {
            Id = id;
        }
    }
}
