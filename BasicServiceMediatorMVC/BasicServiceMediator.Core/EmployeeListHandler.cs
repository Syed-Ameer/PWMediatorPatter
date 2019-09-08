using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BasicServiceMediator.Core
{
    public class EmployeeListHandler : IRequestHandler<EmployeeListRequest, List<EmployeeResponse>>
    {
        public Task<List<EmployeeResponse>> Handle(EmployeeListRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(EmployeeRepository.GetEmployeeList(request.FetchThisManyRecords));
        }
    }
}
