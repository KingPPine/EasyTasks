﻿namespace EasyTasks
{
    class SaveData
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public UserSaveData userSaveData { get; set; }
        public TaskSaveData[] tasks { get; set; }
        public GoalSaveData[] goals { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}
