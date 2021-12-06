using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using RestSharp;
using System.Linq;

namespace B24
{
    public class B24Core
    {
        private static RestClient RC = new RestClient();
        private API B24Api = null;
        public B24Core(API B24Api)
        {
            this.B24Api = B24Api;
        }

        /// <summary>
        /// B24 Send Request
        /// </summary>
        /// <param name="MethodApi">Ex: tasks.task.add</param>
        /// <param name="Params">Ex: fields[TITLE]={TestTitle}&fields[DESCRIPTION]={TestDescription}"</param>
        /// <returns></returns>
        private IRestResponse SendRequest(string MethodApi, string Params)
        {
            var RC_URL = B24Api.API_URL + "/" + MethodApi + "?" + Params;
            var Request = new RestRequest(RC_URL);
            var Response = RC.Get(Request);
            return Response;
        }

        #region GetFunction

        /// <summary>
        /// Bitrix24 Check Api Key
        /// </summary>
        /// <returns></returns>
        public B24Response CheckApiKey()
        {
            B24Response b24Response = new B24Response();
            try
            {
                b24Response.RcResponse = SendRequest("user.get", "");
                return b24Response;
            }
            catch (Exception ex)
            {
                b24Response.RcException = ex;
                b24Response.ResponseCode = ResponseCode.TryCatchException;
                b24Response.ResponseDescription = ex.Message;
                return b24Response;
            }
        }

        /// <summary>
        /// Bitrix24 User Search With Bitrix24 ID
        /// </summary>
        /// <param name="UserId">Bitrix24 User ID</param>
        /// <returns></returns>
        public B24Response GetUserWithID(int ID)
        {
            B24Response b24Response = new B24Response();
            try
            {
                b24Response.RcResponse = SendRequest("user.get", "ID=" + ID + "");
                var BitrixUsers = JsonConvert.DeserializeObject<B24User>(b24Response.RcResponse.Content);
                if (BitrixUsers.result.Count == 0)
                {
                    b24Response.ResponseCode = ResponseCode.UserNotFound;
                    b24Response.ResponseDescription = "User not found.";
                }
                else
                {
                    b24Response.ResponseCode = ResponseCode.UserFound;
                    b24Response.ResponseDescription = "User found.";
                    b24Response.UserResult = BitrixUsers.result[0];
                }                
                return b24Response;
            }
            catch (Exception ex)
            {
                b24Response.RcException = ex;
                b24Response.ResponseCode = ResponseCode.TryCatchException;
                b24Response.ResponseDescription = ex.Message;
                return b24Response;
            }
        }

        /// <summary>
        /// Bitrix24 User Search With Email
        /// </summary>
        /// <param name="Email">Bitrix24 registered email</param>
        /// <returns></returns> 
        public B24Response GetUserWithEmail(string Email)
        {
            B24Response b24Response = new B24Response();
            try
            {
                b24Response.RcResponse = SendRequest("user.search", "EMAIL=" + Email + "&ADMIN_MODE=Y");
                var BitrixUsers = JsonConvert.DeserializeObject<B24User>(b24Response.RcResponse.Content);
                if (BitrixUsers.result.Count == 0)
                {
                    b24Response.ResponseCode = ResponseCode.UserNotFound;
                    b24Response.ResponseDescription = "User not found.";
                }
                else
                {
                    b24Response.ResponseCode = ResponseCode.UserFound;
                    b24Response.ResponseDescription = "User found.";
                    b24Response.UserResult = BitrixUsers.result[0];
                }                
                return b24Response;
            }
            catch (Exception ex)
            {
                b24Response.RcException = ex;
                b24Response.ResponseCode = ResponseCode.TryCatchException;
                b24Response.ResponseDescription = ex.Message;
                return b24Response;
            }
        }

        /// <summary>
        /// Bitrix24 Projects
        /// </summary>
        /// <returns></returns>
        public B24Response GetProjects(bool Is_Admin)
        {
            B24Response b24Response = new B24Response();
            try
            {
                b24Response.RcResponse = SendRequest("sonet_group.get", "IS_ADMIN=" + (Is_Admin == true ? "Y" : "N"));
                var BitrixProjects = JsonConvert.DeserializeObject<B24Project>(b24Response.RcResponse.Content);
                if (BitrixProjects.result.Count == 0)
                {
                    b24Response.ResponseCode = ResponseCode.ProjectNotFound;
                    b24Response.ResponseDescription = "Project not found.";
                }
                else
                {
                    b24Response.ResponseCode = ResponseCode.ProjectFound;
                    b24Response.ResponseDescription = "Project found.";
                    b24Response.ProjectResults = BitrixProjects.result;
                }               
                return b24Response;
            }
            catch (Exception ex)
            {
                b24Response.RcException = ex;
                b24Response.ResponseCode = ResponseCode.TryCatchException;
                b24Response.ResponseDescription = ex.Message;
                return b24Response;
            }
        }

        /// <summary>
        /// Bitrix24 User Projects
        /// </summary>
        /// <returns></returns>
        public B24Response GetProjectsWithUserId(int UserId)
        {
            List<ProjectResult> b24ResponseProjectResultList = new List<ProjectResult>();
            B24Response b24Response = new B24Response();

            try
            {
                B24User b24User = JsonConvert.DeserializeObject<B24User>(GetUserWithID(UserId).RcResponse.Content);
                B24Project b24Projects = JsonConvert.DeserializeObject<B24Project>(GetProjects(true).RcResponse.Content);
                
                b24ResponseProjectResultList.AddRange(from ProjectResult b24PR in b24Projects.result
                                                      let b24SonetGroupUsers = JsonConvert.DeserializeObject<B24SonetGroupUser>(SendRequest("sonet_group.user.get", "ID=" + b24PR.ID).Content)
                                                      from SonetGroupUserResult b24SonetGroupUserResult in b24SonetGroupUsers.result
                                                      where b24SonetGroupUserResult.USER_ID == b24User.result[0].ID
                                                      select b24PR);

                if (b24ResponseProjectResultList.Count == 0)
                {
                    b24Response.ResponseCode = ResponseCode.ProjectNotFound;
                    b24Response.ResponseDescription = "Project not found.";
                }
                else
                {
                    b24Response.ResponseCode = ResponseCode.ProjectFound;
                    b24Response.ResponseDescription = "Project found.";
                    b24Response.ProjectResults = b24ResponseProjectResultList;
                }
                return b24Response;
            }
            catch (Exception ex)
            {
                b24Response.RcException = ex;
                b24Response.ResponseCode = ResponseCode.TryCatchException;
                b24Response.ResponseDescription = ex.Message;
                return b24Response;
            }
        }

        /// <summary>
        /// Bitrix24 Task
        /// </summary>
        /// <param name="TaskId">Bitrix24 Task ID</param>
        /// <returns></returns>
        public B24Response GetTask(int TaskId)
        {
            B24Response b24Response = new B24Response();
            try
            {
                b24Response.RcResponse = SendRequest("tasks.task.get", "taskId=" + TaskId.ToString() + "");
                var BitrixTasks = JsonConvert.DeserializeObject<B24Task>(b24Response.RcResponse.Content);
                if (BitrixTasks.Result == null)
                {
                    b24Response.ResponseCode = ResponseCode.TaskNotFound;
                    b24Response.ResponseDescription = "Task not found.";
                }
                else
                {
                    b24Response.ResponseCode = ResponseCode.TaskFound;
                    b24Response.ResponseDescription = "Task found.";
                    b24Response.TaskResult = BitrixTasks.Result;
                }
                return b24Response;
            }
            catch (Exception ex)
            {
                b24Response.RcException = ex;
                b24Response.ResponseCode = ResponseCode.TryCatchException;
                b24Response.ResponseDescription = ex.Message;
                return b24Response;
            }
        }

        /// <summary>
        /// Bitrix24 Task Control
        /// </summary>
        /// <param name="TaskIds">Ex: 1456,1254,4475</param>
        /// <returns></returns>
        public bool ControlTask(string TaskIds)
        {
            try
            {
                foreach (string TaskId in TaskIds.Split(','))
                {
                    var Response = SendRequest("tasks.task.get", "taskId=" + TaskId + "");
                    var BitrixTasks = JsonConvert.DeserializeObject<B24Task>(Response.Content);
                    if (BitrixTasks.Result == null)
                    {
                        throw new Exception("No task on Bitrix24.\nResponse :" + Response);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region SetFunction
        /// <summary>
        /// Bitrix24 Add Task
        /// </summary>
        /// <param name="TaskItem">B24Task Object</param>
        /// <returns></returns>
        public B24Response AddTasks(B24Task TaskItem)
        {
            B24Response b24Response = new B24Response();
            try
            {
                var param = "fields[TITLE]=" + TaskItem.Result.Task.Title + "";
                param += "&fields[DESCRIPTION]=" + TaskItem.Result.Task.Description + "";
                param += "&fields[START_DATE_PLAN]=" + TaskItem.Result.Task.StartDatePlan + "";
                param += "&fields[DEADLINE]=" + TaskItem.Result.Task.Deadline + "";
                param += "&fields[PRIORITY]=" + TaskItem.Result.Task.Priority + "";
                param += "&fields[GROUP_ID]=" + TaskItem.Result.Task.GroupId + "";
                param += "&fields[CREATED_BY]=" + TaskItem.Result.Task.CreatedBy + "";
                param += "&fields[RESPONSIBLE_ID]=" + TaskItem.Result.Task.ResponsibleId + "";
                if (TaskItem.Result.Task.Auditors != null)
                {
                    for (int i = 0; i < TaskItem.Result.Task.Auditors.Count; i++)
                    {
                        param += "&fields[AUDITORS][" + i + "]=" + TaskItem.Result.Task.Auditors[i] + "";
                    }
                }
                if (TaskItem.Result.Task.Accomplices != null)
                {
                    for (int i = 0; i < TaskItem.Result.Task.Accomplices.Count; i++)
                    {
                        param += "&fields[ACCOMPLICES][" + i + "]=" + TaskItem.Result.Task.Accomplices[i] + "";
                    }
                }
                b24Response.RcResponse = SendRequest("tasks.task.add", param);

                if (b24Response.RcResponse.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    b24Response.ResponseCode = ResponseCode.AddTaskFail;
                    b24Response.ResponseDescription = "Add Task Error.";
                }
                else
                {
                    b24Response.ResponseCode = ResponseCode.AddTaskSuccess;
                    b24Response.ResponseDescription = "Add Task Success";
                }
                return b24Response;
            }
            catch (Exception ex)
            {
                b24Response.RcException = ex;
                b24Response.ResponseCode = ResponseCode.TryCatchException;
                b24Response.ResponseDescription = ex.Message;
                return b24Response;
            }
        }
        #endregion
    }
}
