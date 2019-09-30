using System;
using System.Collections.Generic;
using System.Text;

namespace superliga_miniproject
{
    class Results
    {
        public string round;
        public string weekday;
        public string date;
        public string time;
        public string homeTeam;
        public string awayTeam;
        public int homeTeamGoals;
        public int awayTeamGoals;
        public int spectators;

        public Results(string round, string weekday, string date, string time, string homeTeam, 
                      string awayTeam, int homeTeamGoals, int awayTeamGoals, int spectators)
        {
            this.round = round;
            this.weekday = weekday;
            this.date = date;
            this.time = time;
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
            this.homeTeamGoals = homeTeamGoals;
            this.awayTeamGoals = awayTeamGoals;
            this.spectators = spectators;
        }
        public override string ToString()
        {
            return "Runde: " + round + " " + weekday + " " + date + " " + time + " " + homeTeam + " " + awayTeam
                + " " + homeTeamGoals + "-" + awayTeamGoals + " " + spectators;
        }
    }
}
