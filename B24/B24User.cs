using System;
using System.Collections.Generic;
using System.Text;

namespace B24
{
    public class UserResult
    {
        public string ID { get; set; }
        public bool ACTIVE { get; set; }
        public string EMAIL { get; set; }
        public string NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string SECOND_NAME { get; set; }
        public string PERSONAL_GENDER { get; set; }
        public string PERSONAL_PROFESSION { get; set; }
        public string PERSONAL_WWW { get; set; }
        public string PERSONAL_BIRTHDAY { get; set; }
        public object PERSONAL_PHOTO { get; set; }
        public string PERSONAL_ICQ { get; set; }
        public string PERSONAL_PHONE { get; set; }
        public string PERSONAL_FAX { get; set; }
        public string PERSONAL_MOBILE { get; set; }
        public string PERSONAL_PAGER { get; set; }
        public string PERSONAL_STREET { get; set; }
        public string PERSONAL_CITY { get; set; }
        public string PERSONAL_STATE { get; set; }
        public string PERSONAL_ZIP { get; set; }
        public string PERSONAL_COUNTRY { get; set; }
        public string WORK_COMPANY { get; set; }
        public string WORK_POSITION { get; set; }
        public string WORK_PHONE { get; set; }
        public object UF_DEPARTMENT { get; set; }
        public object UF_INTERESTS { get; set; }
        public object UF_SKILLS { get; set; }
        public object UF_WEB_SITES { get; set; }
        public object UF_XING { get; set; }
        public object UF_LINKEDIN { get; set; }
        public object UF_FACEBOOK { get; set; }
        public object UF_TWITTER { get; set; }
        public object UF_SKYPE { get; set; }
        public object UF_DISTRICT { get; set; }
        public string UF_PHONE_INNER { get; set; }
        public string USER_TYPE { get; set; }
    }

    public class UserTime
    {
        public double start { get; set; }
        public double finish { get; set; }
        public double duration { get; set; }
        public double processing { get; set; }
        public DateTime date_start { get; set; }
        public DateTime date_finish { get; set; }
    }

    public class B24User
    {
        public List<UserResult> result { get; set; }
        public int total { get; set; }
        public UserTime time { get; set; }
    }
}
