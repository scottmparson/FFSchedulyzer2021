using System;
using System.Collections.Generic;
using System.Text;

namespace FFSchedulyzer2021
{
    class Team
    {
        public double[] scores;
        public string name;
        public Team[] schedule;
        public int wins = 0;
        public int losses = 0;
        public int ties = 0;
        public double pointsFor = 0;
        public double pointsAgainst = 0;
        public int actualWins = 0;
        public int actualLosses = 0;
        public int actualTies = 0;
        public int totalWins = 0;
        public double averageWins = 0;

        public Team(String teamName, double[] teamScores)
        {
            name = teamName;
            scores = teamScores;
        }

        public void SetSchedule(Team[] teamSchedule)
        {
            schedule = teamSchedule;
        }
        public void ResetRecord()
        {
            wins = 0;
            losses = 0;
            ties = 0;
            pointsFor = 0;
            pointsAgainst = 0;
        }
    }
}
