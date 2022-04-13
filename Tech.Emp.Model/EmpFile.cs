using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Emp.Model
{

    public class Rootobject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string about { get; set; }
        public string token { get; set; }
        public object country { get; set; }
        public string location { get; set; }
        public float lng { get; set; }
        public float lat { get; set; }
        public DateTime? dob { get; set; }
        public int gender { get; set; }
        public int userType { get; set; }
        public int userStatus { get; set; }
        public string profilePicture { get; set; }
        public string coverPicture { get; set; }
        public bool enablefollowme { get; set; }
        public bool sendmenotifications { get; set; }
        public bool sendTextmessages { get; set; }
        public bool enabletagging { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public float livelng { get; set; }
        public float livelat { get; set; }
        public string liveLocation { get; set; }
        public int creditBalance { get; set; }
        public int myCash { get; set; }
    }

}
