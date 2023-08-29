using Neptunee.BaseCleanArchitecture.OResponse;
using Neptunee.BaseCleanArchitecture.Requests;

namespace StayHome.Application.Dashboard.Drivers;

public class DeleteDriverCommand
{
    public class Request : IRequest<OperationResponse>
    {
        public Request(Guid? id, List<Guid> ids)
        {
            if (id.HasValue)
                Ids.Add(id.Value);

            Ids.AddRange(ids);
        }
        public List<Guid> Ids { get; set; } = new();
    }
}