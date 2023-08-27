
using AutoMapper;
using MediatR;
using School.Core.Features.Query.Models;
using School.Core.Features.Query.Resoponse;
using School.Core.ReponseBase;
using School.Data.Data;
using School.Service.Abstracts;

namespace School.Core.Features.Query.Handlers;

public class GetStudentListHandler :ResponseHandler, IRequestHandler<GetStudentListQuery,Response<List<GetStudentListResponse>>>
{
    #region Fields
    private readonly IStudentService _studentService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetStudentListHandler(IStudentService studentService,IMapper mapper)
    {
       _studentService = studentService;
        _mapper = mapper;
    }

    public async Task<Response<List<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
    {
         var studentList = await _studentService.GetStudensListAsync();
        var studentListResponse = _mapper.Map<List<GetStudentListResponse>>(studentList);
        return Success<List<GetStudentListResponse>>(studentListResponse);
    }


    #endregion

    #region Handler Method




    #endregion

}
