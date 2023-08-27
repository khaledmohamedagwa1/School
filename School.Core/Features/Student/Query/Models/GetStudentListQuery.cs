

using MediatR;
using School.Core.Features.Query.Resoponse;
using School.Core.ReponseBase;

namespace School.Core.Features.Query.Models;

public class GetStudentListQuery :IRequest<Response<List<GetStudentListResponse>>>
{
}
