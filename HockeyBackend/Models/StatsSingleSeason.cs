namespace HockeyBackend.Models
{

    public class Stat
    {
        public Type type { get; set; }
        public Split[] splits { get; set; }
    }

    public class Type
    {
        public string displayName { get; set; }
        public Gametype gameType { get; set; }
    }

    public class Gametype
    {
        public string id { get; set; }
        public string description { get; set; }
        public bool postseason { get; set; }
    }

    public class Split
    {
        public string season { get; set; }
        public Stat1 stat { get; set; }
    }

    public class Stat1
    {
        public string timeOnIce { get; set; }
        public int assists { get; set; }
        public int goals { get; set; }
        public int pim { get; set; }
        public int shots { get; set; }
        public int games { get; set; }
        public int hits { get; set; }
        public int powerPlayGoals { get; set; }
        public int powerPlayPoints { get; set; }
        public string powerPlayTimeOnIce { get; set; }
        public string evenTimeOnIce { get; set; }
        public string penaltyMinutes { get; set; }
        public float faceOffPct { get; set; }
        public float shotPct { get; set; }
        public int gameWinningGoals { get; set; }
        public int overTimeGoals { get; set; }
        public int shortHandedGoals { get; set; }
        public int shortHandedPoints { get; set; }
        public string shortHandedTimeOnIce { get; set; }
        public int blocked { get; set; }
        public int plusMinus { get; set; }
        public int points { get; set; }
        public int shifts { get; set; }
        public string timeOnIcePerGame { get; set; }
        public string evenTimeOnIcePerGame { get; set; }
        public string shortHandedTimeOnIcePerGame { get; set; }
        public string powerPlayTimeOnIcePerGame { get; set; }
    }

}
