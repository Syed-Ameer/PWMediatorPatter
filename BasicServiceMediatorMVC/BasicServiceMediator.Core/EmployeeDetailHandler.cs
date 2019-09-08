using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BasicServiceMediator.Core
{
    public class EmployeeDetailHandler : IRequestHandler<EmployeeDetailRequest, EmployeeResponse>
    {
        public Task<EmployeeResponse> Handle(EmployeeDetailRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(EmployeeRepository.GetEmployeeById(request.EmployeeId));
        }
    }
}
