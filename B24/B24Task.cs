using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace B24
{
    public class TaskGroup
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class TaskAction
    {
        [JsonProperty("accept")]
        public bool Accept { get; set; }

        [JsonProperty("decline")]
        public bool Decline { get; set; }

        [JsonProperty("complete")]
        public bool Complete { get; set; }

        [JsonProperty("approve")]
        public bool Approve { get; set; }

        [JsonProperty("disapprove")]
        public bool Disapprove { get; set; }

        [JsonProperty("start")]
        public bool Start { get; set; }

        [JsonProperty("pause")]
        public bool Pause { get; set; }

        [JsonProperty("delegate")]
        public bool Delegate { get; set; }

        [JsonProperty("remove")]
        public bool Remove { get; set; }

        [JsonProperty("edit")]
        public bool Edit { get; set; }

        [JsonProperty("defer")]
        public bool Defer { get; set; }

        [JsonProperty("renew")]
        public bool Renew { get; set; }

        [JsonProperty("create")]
        public bool Create { get; set; }

        [JsonProperty("changeDeadline")]
        public bool ChangeDeadline { get; set; }

        [JsonProperty("checklistAddItems")]
        public bool ChecklistAddItems { get; set; }

        [JsonProperty("addFavorite")]
        public bool AddFavorite { get; set; }

        [JsonProperty("deleteFavorite")]
        public bool DeleteFavorite { get; set; }

        [JsonProperty("rate")]
        public bool Rate { get; set; }

        [JsonProperty("edit.originator")]
        public bool EditOriginator { get; set; }

        [JsonProperty("checklist.reorder")]
        public bool ChecklistReorder { get; set; }

        [JsonProperty("elapsedtime.add")]
        public bool ElapsedtimeAdd { get; set; }

        [JsonProperty("dayplan.timer.toggle")]
        public bool DayplanTimerToggle { get; set; }

        [JsonProperty("edit.plan")]
        public bool EditPlan { get; set; }

        [JsonProperty("checklist.add")]
        public bool ChecklistAdd { get; set; }

        [JsonProperty("favorite.add")]
        public bool FavoriteAdd { get; set; }

        [JsonProperty("favorite.delete")]
        public bool FavoriteDelete { get; set; }
    }

    public class Task
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parentId")]
        public object ParentId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("mark")]
        public object Mark { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("multitask")]
        public string Multitask { get; set; }

        [JsonProperty("notViewed")]
        public string NotViewed { get; set; }

        [JsonProperty("replicate")]
        public string Replicate { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("stageId")]
        public string StageId { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdDate")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("responsibleId")]
        public string ResponsibleId { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("changedDate")]
        public DateTime ChangedDate { get; set; }

        [JsonProperty("statusChangedBy")]
        public string StatusChangedBy { get; set; }

        [JsonProperty("statusChangedDate")]
        public DateTime StatusChangedDate { get; set; }

        [JsonProperty("closedBy")]
        public object ClosedBy { get; set; }

        [JsonProperty("closedDate")]
        public object ClosedDate { get; set; }

        [JsonProperty("activityDate")]
        public DateTime ActivityDate { get; set; }

        [JsonProperty("dateStart")]
        public object DateStart { get; set; }

        [JsonProperty("deadline")]
        public DateTime Deadline { get; set; }

        [JsonProperty("startDatePlan")]
        public object StartDatePlan { get; set; }

        [JsonProperty("endDatePlan")]
        public object EndDatePlan { get; set; }

        [JsonProperty("guid")]
        public string Guid { get; set; }

        [JsonProperty("xmlId")]
        public object XmlId { get; set; }

        [JsonProperty("commentsCount")]
        public string CommentsCount { get; set; }

        [JsonProperty("allowChangeDeadline")]
        public string AllowChangeDeadline { get; set; }

        [JsonProperty("taskControl")]
        public string TaskControl { get; set; }

        [JsonProperty("addInReport")]
        public string AddInReport { get; set; }

        [JsonProperty("forkedByTemplateId")]
        public object ForkedByTemplateId { get; set; }

        [JsonProperty("timeEstimate")]
        public string TimeEstimate { get; set; }

        [JsonProperty("timeSpentInLogs")]
        public object TimeSpentInLogs { get; set; }

        [JsonProperty("matchWorkTime")]
        public string MatchWorkTime { get; set; }

        [JsonProperty("forumTopicId")]
        public string ForumTopicId { get; set; }

        [JsonProperty("forumId")]
        public string ForumId { get; set; }

        [JsonProperty("siteId")]
        public string SiteId { get; set; }

        [JsonProperty("subordinate")]
        public string Subordinate { get; set; }

        [JsonProperty("favorite")]
        public string Favorite { get; set; }

        [JsonProperty("exchangeModified")]
        public object ExchangeModified { get; set; }

        [JsonProperty("exchangeId")]
        public object ExchangeId { get; set; }

        [JsonProperty("outlookVersion")]
        public string OutlookVersion { get; set; }

        [JsonProperty("viewedDate")]
        public object ViewedDate { get; set; }

        [JsonProperty("sorting")]
        public object Sorting { get; set; }

        [JsonProperty("durationPlan")]
        public object DurationPlan { get; set; }

        [JsonProperty("durationFact")]
        public object DurationFact { get; set; }

        [JsonProperty("durationType")]
        public string DurationType { get; set; }

        [JsonProperty("isMuted")]
        public string IsMuted { get; set; }

        [JsonProperty("isPinned")]
        public string IsPinned { get; set; }

        [JsonProperty("descriptionInBbcode")]
        public string DescriptionInBbcode { get; set; }

        [JsonProperty("ufCrmTask")]
        public bool UfCrmTask { get; set; }

        //[JsonProperty("ufTaskWebdavFiles")]
        //public IList<object> UfTaskWebdavFiles { get; set; }

        [JsonProperty("ufMailMessage")]
        public object UfMailMessage { get; set; }

        [JsonProperty("auditors")]
        public IList<string> Auditors { get; set; }

        [JsonProperty("accomplices")]
        public IList<object> Accomplices { get; set; }

        [JsonProperty("checklist")]
        public IList<object> Checklist { get; set; }

        //[JsonProperty("group")]
        //public IList<object> Group { get; set; }

        [JsonProperty("creator")]
        public UserResult Creator { get; set; }

        [JsonProperty("responsible")]
        public UserResult Responsible { get; set; }

        [JsonProperty("newCommentsCount")]
        public int NewCommentsCount { get; set; }

        [JsonProperty("action")]
        public TaskAction Action { get; set; }
    }

    public class TaskResult
    {
        [JsonProperty("task")]
        public Task Task { get; set; }
    }

    public class TaskTime
    {
        [JsonProperty("start")]
        public double Start { get; set; }

        [JsonProperty("finish")]
        public double Finish { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("processing")]
        public double Processing { get; set; }

        [JsonProperty("date_start")]
        public DateTime DateStart { get; set; }

        [JsonProperty("date_finish")]
        public DateTime DateFinish { get; set; }
    }

    public class B24Task
    {
        public List<TaskResult> Results { get; set; }
        [JsonProperty("result")]
        public TaskResult Result { get; set; }

        [JsonProperty("time")]
        public TaskTime Time { get; set; }
    }
}
