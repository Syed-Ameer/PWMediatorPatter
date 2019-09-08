using MediatR;

namespace BasicServiceMediator.Core
{
    public class EmployeeDetailRequest: IRequest<EmployeeResponse>
    {
        public int EmployeeId { get; set; }
    }
}
