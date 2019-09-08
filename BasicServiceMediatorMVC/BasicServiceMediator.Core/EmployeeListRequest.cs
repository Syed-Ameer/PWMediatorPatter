using MediatR;
using System.Collections.Generic;

namespace BasicServiceMediator.Core
{
    public class EmployeeListRequest : IRequest<List<EmployeeResponse>>
    {
        public int FetchThisManyRecords { get; set; }
    }
}
