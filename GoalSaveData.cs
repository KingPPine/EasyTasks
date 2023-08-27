namespace EasyTasks
{
    class GoalSaveData
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string title { get; set; }
        public GoalType goalType { get; set; }
        public int startNumericalValue { get; set; }
        public int endNumericalValue { get; set; }
        public int customProgressBarValue { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public bool completed { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}
