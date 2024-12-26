﻿using System.ComponentModel.DataAnnotations;

namespace KartingSystemSimulationDraft.Models
{
    public class RaceHistoryLeaderboard
{
        [Key]
        public int RaceHistoryId { get; set; }
    public int LeaderboardId { get; set; }

    public RaceHistory RaceHistory { get; set; }
    public Leaderboard Leaderboard { get; set; }
}

}
