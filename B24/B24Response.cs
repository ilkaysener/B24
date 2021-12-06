using RestSharp;
using System.Collections.Generic;

namespace B24
{
    /// <summary>
    /// B24 Core Response
    /// </summary>
    public class B24Response
    {
        public ProjectResult ProjectResult { get; set; }
        public List<ProjectResult> ProjectResults { get; set; }
        public TaskResult TaskResult { get; set; }
        public List<TaskResult> TaskResults { get; set; }
        public UserResult UserResult { get; set; }
        public List<UserResult> UserResults { get; set; }
        public IRestResponse RcResponse { get; set; }
        public System.Exception RcException { get; set; }
        public ResponseCode ResponseCode { get; set; }
        public string ResponseDescription { get; set; }
    }

    public enum ResponseCode
    {
        TryCatchException = 999,
        UserNotFound = 100,
        UserFound = 101,
        ProjectNotFound = 200,
        ProjectFound = 201,
        TaskNotFound = 300,
        TaskFound = 301,
        AddTaskSuccess = 302,
        AddTaskFail = 303,
    }
}
