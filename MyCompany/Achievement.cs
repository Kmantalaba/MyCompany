namespace MyCompany
{
    public class Achievement
    {
        public Achievement(int id, string achievementGet)
        {
            Id = id;
            AchievementGet = achievementGet;
        }

        public int Id { get; set; }
        public string AchievementGet { get; set; } = null!;
    }
}