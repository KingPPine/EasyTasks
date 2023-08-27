namespace EasyTasks.HTTP_Content_Objects
{
    internal class UserContent
    {
        public string username { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public int verified { get; set; }
    }
}
