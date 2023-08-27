namespace EasyTasks
{
    class UserSaveData
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string username { get; set; }
        public string password { get; set; }
        public int verified { get; set; }
        public DateTime lastActivity { get; set; }
        public bool locallyAuthenticated { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


    }
}
