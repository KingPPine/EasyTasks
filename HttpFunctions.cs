using EasyTasks.HTTP_Content_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EasyTasks
{
    public static class HttpFunctions
    {
        private static readonly HttpClient httpClient = new HttpClient(); //the http client to interact with the API


        public static async void AddTaskDatabase(TaskControl task, string userID)
        {
            // POST to Tasks endpoint
            TaskContent taskContent = new TaskContent();
            taskContent.title = task.getTitle();
            taskContent.completed = 0; //false, since it would only be completed if we were in the action of removing the task from the UI.
            taskContent.userID = userID;

            var json = JsonSerializer.Serialize(taskContent);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "https://a0vq91llc2.execute-api.us-west-2.amazonaws.com/easytasks/tasks";

            var response = await httpClient.PostAsync(url, data);
            var responseString = response.Content.ReadAsStringAsync().Result;

            var responseContent = JsonSerializer.Deserialize<TaskContent>(responseString);

            if (responseContent != null)
                task.setDatabaseID(responseContent.id);
        }

        public static async void UpdateTaskDatabase(TaskControl task, string userID)
        {
            //PUT to Tasks endpoint
            TaskContent taskContent = new TaskContent();
            taskContent.id = task.getDatabaseID();
            taskContent.title = task.getTitle();
            taskContent.completed = 0; //false, since it would only be completed if we were in the action of removing the task from the UI.
            taskContent.userID = userID;

            var json = JsonSerializer.Serialize(taskContent);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "https://a0vq91llc2.execute-api.us-west-2.amazonaws.com/easytasks/tasks/" + taskContent.id;

            var response = await httpClient.PutAsync(url, data);
            var responseString = response.Content.ReadAsStringAsync().Result;
        }

        public static async void CompleteTaskDatabase(TaskControl task, string userID)
        {
            //PUT to Tasks endpoint
            TaskContent taskContent = new TaskContent();
            taskContent.id = task.getDatabaseID();
            taskContent.title = task.getTitle();
            taskContent.completed = 1; //true, since it would only be completed if we were in the action of removing the task from the UI.
            taskContent.userID = userID;

            var json = JsonSerializer.Serialize(taskContent);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "https://a0vq91llc2.execute-api.us-west-2.amazonaws.com/easytasks/tasks/" + taskContent.id;

            var response = await httpClient.PutAsync(url, data);
            var responseString = response.Content.ReadAsStringAsync().Result;
        }

        public static async void Register(string username, string localPassword)
        {
            // POST to User endpoint
            var userContent = new UserContent();
            userContent.username = username;
            userContent.salt = GetRandomString(20);
            userContent.password = GetHashedPassword(localPassword + userContent.salt);
            userContent.verified = 0;

            var json = JsonSerializer.Serialize(userContent);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "https://a0vq91llc2.execute-api.us-west-2.amazonaws.com/easytasks/users";

            var response = await httpClient.PostAsync(url, data);
            var responseString = response.Content.ReadAsStringAsync().Result;
        }

        public static async Task<bool> Authenticate(string username, string localPassword)
        {
            // GET to User endpoint
            var response = await httpClient.GetAsync("https://a0vq91llc2.execute-api.us-west-2.amazonaws.com/easytasks/users/" + username);
            var responseString = await response.Content.ReadAsStringAsync();
            var userContent = JsonSerializer.Deserialize<UserContent[]>(responseString)[0];

            string password = userContent.password;
            string salt = userContent.salt;
            int verified = userContent.verified;

            string hashedInput = GetHashedPassword(localPassword + salt);
            bool result = (hashedInput == password);

            return result;
        }

        public static async void ChangePassword(string username, string currentLocalPassword, string newLocalPassword)
        {
            //PUT to User endpoint
            var userContent = new UserContent();
            userContent.username = username;
            userContent.salt = GetRandomString(20);
            userContent.password = GetHashedPassword(newLocalPassword + userContent.salt);

            var json = JsonSerializer.Serialize(userContent);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "https://a0vq91llc2.execute-api.us-west-2.amazonaws.com/easytasks/users/" + username;

            var response = await httpClient.PutAsync(url, data);
        }

        private static string GetHashedPassword(string input)
        {
            //create cryptography class instance
            SHA256 sHA256 = SHA256.Create();
            //compute bytes of input string
            byte[] bytes = sHA256.ComputeHash(Encoding.Unicode.GetBytes(input));

            //compute string from bytes
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            //return hashed string
            return builder.ToString();
        }

        private static string GetRandomString(int length)
        {
            Random random = new Random();
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string str = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)])
                .ToArray());

            return str;
        }

    }
}
