namespace DotaSite.Models
{
    public class Clan
    {
        public string team_id { get; set; }
        public string name { get; set; }
        public string tag { get; set; }
        public string time_created { get; set; }
        public string rating { get; set; }
        public string logo { get; set; }
        public string logo_sponsor { get; set; }
        public string country_code { get; set; }
        public string url { get; set; }
        public string games_played_with_current_roster { get; set; }
        public string admin_account_id { get; set; }
        public string players { get; set; }
    }
}