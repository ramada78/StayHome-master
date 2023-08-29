using Neptunee.BaseCleanArchitecture.OResponse;
using Neptunee.BaseCleanArchitecture.Requests;

namespace StayHome.Application.Dashboard.Orders;

public class HandelOrderCommand
{
    public class Request : IRequest<OperationResponse>
    {  
        public Guid Id { get; set; }
        public Guid DriverId { get; set; }
    }
}