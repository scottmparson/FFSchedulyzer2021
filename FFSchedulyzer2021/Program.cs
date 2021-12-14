using System;
using System.Collections.Generic;
using ConsoleTables;
using System.Linq;
using System.Text;

namespace FFSchedulyzer2021
{
    class Program
    {

        private static Team? Team1, Team2, Team3, Team4, Team5, Team6, Team7, Team8, Team9, Team10, Team11, Team12;

        static void Main(string[] args)
        {
            //Beth
            Team1 = new Team("Better than 2020", new double[]
            {
                131.3, 100.96, 75.47, 89.57, 87.17, 71.15, 72.14, 91.52, 61.81, 62.92, 88.67, 31.51, 87.41, 90.07
            });

            //Brandon
            Team2 = new Team("Isaiah's Mugger", new double[]
            {
                117.32, 123.72, 139.73, 68.33, 153.61, 101.08, 141.65, 100.51, 106.52, 103.61, 108.08, 98.39, 150.79, 114.78
            });

            //Bryan
            Team3 = new Team("Bus Wankers", new double[] {
               125.47, 160.4, 102.38, 132.69, 92.68, 77.59, 120.11, 83.88, 79.08, 83.05, 125.22, 72.71, 114.8, 130.49
            });

            //Daniel
            Team4 = new Team("I'M PICKLE RICK", new double[]
            {
                84.43, 86.13, 117.35, 107.01, 121.74, 147.01, 97.69, 98.26, 78.04, 87.72, 106.69, 117.64, 60.32, 126.84
            });

            //Eric
            Team5 = new Team("The Midnight Society", new double[]
            {
                101.86, 83.85, 56.67, 123.42, 97.66, 112.29, 103.08, 122.17, 110.29, 98.09, 101.66, 77.51, 126.86, 114.29
            });

            //Evan
            Team6 = new Team("Lot Lizard King", new double[]
            {
                89.64, 108.59, 122.38, 92.65, 178.02, 77.73, 97.28, 101.53, 127.97, 98.24, 148.33, 105.28, 127.39, 130.39
            });

            //Julie
            Team7 = new Team("DontDraft BlackedOut", new double[]
            {
                65.39, 133.63, 91.42, 104.23, 168.97, 127.52, 116.97, 91.08, 64.61, 101.38, 118.88, 108.79, 114.67, 150.95
            });

            //Kevin
            Team8 = new Team("Deep Loggins", new double[]
            {
                116.93, 110.76, 92.77, 115.64, 133.24, 142.66, 54.12, 100.09, 105.37, 113.83, 83.39, 108.6, 96.4, 45.53
            });

            //Kim
            Team9 = new Team("The Blue Bandaids", new double[]
            {
                129.48, 93.94, 108.9, 121.05, 97.35, 134.69, 93.34, 104.24, 57.01, 95.25, 130.6, 129.0, 74.49, 106.8
            });

            //Kyle
            Team10 = new Team("Morehead Felaters", new double[]
            {
               101.31, 100.66, 110.28, 80.2, 100.99, 131.0, 120.34, 106.35, 96.51, 102.3, 96.11, 118.4, 122.6, 125.77
            });

            //Nate
            Team11 = new Team("Nilbog Dance Academy", new double[]
            {
                107.75, 90.65, 120.68, 130.79, 155.74, 94.74, 116.93, 118.4, 108.0, 51.53, 92.62, 94.17, 115.5, 123.15
            });

            //Scott
            Team12 = new Team("Salsa Sharks", new double[]
            {
                115.55, 130.19, 131.86, 106.35, 137.31, 114.61, 117.49, 92.84, 72.56, 98.09, 92.27, 63.87, 91.11, 104.8
            });

            Team1.SetSchedule(new Team[]
            {
                Team6, Team7, Team9, Team12, Team3, Team11, Team2, Team4, Team10, Team8, Team5, Team6, Team7, Team9
            });
            Team2.SetSchedule(new Team[]
            {
                Team12, Team3, Team11, Team8, Team4, Team10, Team1, Team5, Team6, Team7, Team9, Team12, Team3, Team11
            });
            Team3.SetSchedule(new Team[]
            {
                Team11, Team2, Team4, Team10, Team1, Team5, Team6, Team7, Team9, Team12, Team8, Team11, Team2, Team4
            });
            Team4.SetSchedule(new Team[]
            {
                Team9, Team12, Team3, Team11, Team2, Team8, Team10, Team1, Team5, Team6, Team7, Team9, Team12, Team3
            });
            Team5.SetSchedule(new Team[]
            {
                Team8, Team6, Team7, Team9, Team12, Team3, Team11, Team2, Team4, Team10, Team1, Team8, Team6, Team7   
            });
            Team6.SetSchedule(new Team[]
            {
                Team1, Team5, Team8, Team7, Team9, Team12, Team3, Team11, Team2, Team4, Team10, Team1, Team5, Team8
            });
            Team7.SetSchedule(new Team[]
            {
                Team10, Team1, Team5, Team6, Team8, Team9, Team12, Team3, Team11, Team2, Team4, Team10, Team1, Team5
            });
            Team8.SetSchedule(new Team[]
            {
                Team5, Team11, Team6, Team2, Team7, Team4, Team9, Team10, Team12, Team1, Team3, Team5, Team11, Team6
            });
            Team9.SetSchedule(new Team[]
            {
                Team4, Team10, Team1, Team5, Team6, Team7, Team8, Team12, Team3, Team11, Team2, Team4, Team10, Team1
            });
            Team10.SetSchedule(new Team[]
            {
                Team7, Team9, Team12, Team3, Team11, Team2, Team4, Team8, Team1, Team5, Team6, Team7, Team9, Team12
            });
            Team11.SetSchedule(new Team[]
            {
                Team3, Team8, Team2, Team4, Team10, Team1, Team5, Team6, Team7, Team9, Team12, Team3, Team8, Team2
            });
            Team12.SetSchedule(new Team[]
            {
                Team2, Team4, Team10, Team1, Team5, Team6, Team7, Team9, Team8, Team3, Team11, Team2, Team4, Team10
            });

            List<Team> league = new List<Team>();
            league.Add(Team1);
            league.Add(Team2);
            league.Add(Team3);
            league.Add(Team4);
            league.Add(Team5);
            league.Add(Team6);
            league.Add(Team7);
            league.Add(Team8);
            league.Add(Team9);
            league.Add(Team10);
            league.Add(Team11);
            league.Add(Team12);

            AnalyzeSchedule(Team1);
            AnalyzeSchedule(Team1, Team2);
            AnalyzeSchedule(Team1, Team3);
            AnalyzeSchedule(Team1, Team4);
            AnalyzeSchedule(Team1, Team5);
            AnalyzeSchedule(Team1, Team6);
            AnalyzeSchedule(Team1, Team7);
            AnalyzeSchedule(Team1, Team8);
            AnalyzeSchedule(Team1, Team9);
            AnalyzeSchedule(Team1, Team10);
            AnalyzeSchedule(Team1, Team11);
            AnalyzeSchedule(Team1, Team12);
            Console.WriteLine("Total Wins: " + Team1.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Team2);
            AnalyzeSchedule(Team2, Team1);
            AnalyzeSchedule(Team2, Team3);
            AnalyzeSchedule(Team2, Team4);
            AnalyzeSchedule(Team2, Team5);
            AnalyzeSchedule(Team2, Team6);
            AnalyzeSchedule(Team2, Team7);
            AnalyzeSchedule(Team2, Team8);
            AnalyzeSchedule(Team2, Team9);
            AnalyzeSchedule(Team2, Team10);
            AnalyzeSchedule(Team2, Team11);
            AnalyzeSchedule(Team2, Team12);
            Console.WriteLine("Total Wins: " + Team2.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Team3);
            AnalyzeSchedule(Team3, Team1);
            AnalyzeSchedule(Team3, Team2);
            AnalyzeSchedule(Team3, Team4);
            AnalyzeSchedule(Team3, Team5);
            AnalyzeSchedule(Team3, Team6);
            AnalyzeSchedule(Team3, Team7);
            AnalyzeSchedule(Team3, Team8);
            AnalyzeSchedule(Team3, Team9);
            AnalyzeSchedule(Team3, Team10);
            AnalyzeSchedule(Team3, Team11);
            AnalyzeSchedule(Team3, Team12);
            Console.WriteLine("Total Wins: " + Team3.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Team4);
            AnalyzeSchedule(Team4, Team1);
            AnalyzeSchedule(Team4, Team2);
            AnalyzeSchedule(Team4, Team3);
            AnalyzeSchedule(Team4, Team5);
            AnalyzeSchedule(Team4, Team6);
            AnalyzeSchedule(Team4, Team7);
            AnalyzeSchedule(Team4, Team8);
            AnalyzeSchedule(Team4, Team9);
            AnalyzeSchedule(Team4, Team10);
            AnalyzeSchedule(Team4, Team11);
            AnalyzeSchedule(Team4, Team12);
            Console.WriteLine("Total Wins: " + Team4.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Team5);
            AnalyzeSchedule(Team5, Team1);
            AnalyzeSchedule(Team5, Team2);
            AnalyzeSchedule(Team5, Team3);
            AnalyzeSchedule(Team5, Team4);
            AnalyzeSchedule(Team5, Team6);
            AnalyzeSchedule(Team5, Team7);
            AnalyzeSchedule(Team5, Team8);
            AnalyzeSchedule(Team5, Team9);
            AnalyzeSchedule(Team5, Team10);
            AnalyzeSchedule(Team5, Team11);
            AnalyzeSchedule(Team5, Team12);
            Console.WriteLine("Total Wins: " + Team5.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Team6);
            AnalyzeSchedule(Team6, Team1);
            AnalyzeSchedule(Team6, Team2);
            AnalyzeSchedule(Team6, Team3);
            AnalyzeSchedule(Team6, Team4);
            AnalyzeSchedule(Team6, Team5);
            AnalyzeSchedule(Team6, Team7);
            AnalyzeSchedule(Team6, Team8);
            AnalyzeSchedule(Team6, Team9);
            AnalyzeSchedule(Team6, Team10);
            AnalyzeSchedule(Team6, Team11);
            AnalyzeSchedule(Team6, Team12);
            Console.WriteLine("Total Wins: " + Team6.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Team7);
            AnalyzeSchedule(Team7, Team1);
            AnalyzeSchedule(Team7, Team2);
            AnalyzeSchedule(Team7, Team3);
            AnalyzeSchedule(Team7, Team4);
            AnalyzeSchedule(Team7, Team6);
            AnalyzeSchedule(Team7, Team5);
            AnalyzeSchedule(Team7, Team8);
            AnalyzeSchedule(Team7, Team9);
            AnalyzeSchedule(Team7, Team10);
            AnalyzeSchedule(Team7, Team11);
            AnalyzeSchedule(Team7, Team12);
            Console.WriteLine("Total Wins: " + Team7.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Team8);
            AnalyzeSchedule(Team8, Team1);
            AnalyzeSchedule(Team8, Team2);
            AnalyzeSchedule(Team8, Team3);
            AnalyzeSchedule(Team8, Team4);
            AnalyzeSchedule(Team8, Team6);
            AnalyzeSchedule(Team8, Team5);
            AnalyzeSchedule(Team8, Team7);
            AnalyzeSchedule(Team8, Team9);
            AnalyzeSchedule(Team8, Team10);
            AnalyzeSchedule(Team8, Team11);
            AnalyzeSchedule(Team8, Team12);
            Console.WriteLine("Total Wins: " + Team8.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Team9);
            AnalyzeSchedule(Team9, Team1);
            AnalyzeSchedule(Team9, Team2);
            AnalyzeSchedule(Team9, Team3);
            AnalyzeSchedule(Team9, Team4);
            AnalyzeSchedule(Team9, Team6);
            AnalyzeSchedule(Team9, Team5);
            AnalyzeSchedule(Team9, Team7);
            AnalyzeSchedule(Team9, Team8);
            AnalyzeSchedule(Team9, Team10);
            AnalyzeSchedule(Team9, Team11);
            AnalyzeSchedule(Team9, Team12);
            Console.WriteLine("Total Wins: " + Team9.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Team10);
            AnalyzeSchedule(Team10, Team1);
            AnalyzeSchedule(Team10, Team2);
            AnalyzeSchedule(Team10, Team3);
            AnalyzeSchedule(Team10, Team4);
            AnalyzeSchedule(Team10, Team6);
            AnalyzeSchedule(Team10, Team5);
            AnalyzeSchedule(Team10, Team7);
            AnalyzeSchedule(Team10, Team8);
            AnalyzeSchedule(Team10, Team9);
            AnalyzeSchedule(Team10, Team11);
            AnalyzeSchedule(Team10, Team12);
            Console.WriteLine("Total Wins: " + Team10.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Team11);
            AnalyzeSchedule(Team11, Team1);
            AnalyzeSchedule(Team11, Team2);
            AnalyzeSchedule(Team11, Team3);
            AnalyzeSchedule(Team11, Team4);
            AnalyzeSchedule(Team11, Team6);
            AnalyzeSchedule(Team11, Team5);
            AnalyzeSchedule(Team11, Team7);
            AnalyzeSchedule(Team11, Team8);
            AnalyzeSchedule(Team11, Team9);
            AnalyzeSchedule(Team11, Team10);
            AnalyzeSchedule(Team11, Team12);
            Console.WriteLine("Total Wins: " + Team11.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Team12);
            AnalyzeSchedule(Team12, Team1);
            AnalyzeSchedule(Team12, Team2);
            AnalyzeSchedule(Team12, Team3);
            AnalyzeSchedule(Team12, Team4);
            AnalyzeSchedule(Team12, Team5);
            AnalyzeSchedule(Team12, Team6);
            AnalyzeSchedule(Team12, Team7);
            AnalyzeSchedule(Team12, Team8);
            AnalyzeSchedule(Team12, Team9);
            AnalyzeSchedule(Team12, Team10);
            AnalyzeSchedule(Team12, Team11);
            Console.WriteLine("Total Wins: " + Team12.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();


            foreach (Team team in league)
            {
                team.averageWins = (double)team.totalWins / league.Count;
            }
            league.Sort((x, y) => y.averageWins.CompareTo(x.averageWins));

            var table = new ConsoleTable("~~~~", "Average Wins", "~~~~");
            int rank = 1;
            foreach (Team team in league)
            {
                table.AddRow(rank, team.name, Math.Round(team.averageWins, 2));
                rank++;
            }
            table.Options.EnableCount = false;
            table.Write(Format.Minimal);
           
            Console.ReadKey();
        }

        //Actual Record
        public static void AnalyzeSchedule(Team team)
        {
            if (team.scores.Length != team.schedule.Length)
            {
                Console.WriteLine("Error: Array Lengths invalid for TEAM: " + team.name);
                Console.ReadKey();
            }
            else
            {
                for (int i = 0; i < team.scores.Length; i++)
                {
                    if (team.scores[i] > team.schedule[i].scores[i])
                    {
                        team.wins++;
                    }
                    else if (team.scores[i] < team.schedule[i].scores[i])
                    {
                        team.losses++;
                    }
                    else
                    {
                        team.ties++;
                    }

                    team.pointsFor += team.scores[i];
                    team.pointsAgainst += team.schedule[i].scores[i];
                }
                if (team.ties == 0)
                {
                    //Console.WriteLine(team.name + "'s actual record is: " + team.wins + "-" + team.losses + " | PF: " + team.pointsFor);
                    Console.WriteLine(string.Format("{0}'s actual record is: {1}-{2} | PF: {3}", team.name, team.wins, team.losses, team.pointsFor));
                }
                else
                {
                    Console.WriteLine(team.name + "'s actual record is: " + team.wins + "-" + team.losses + "-" + team.ties + " | PF: " + team.pointsFor);
                }
                team.actualWins = team.wins;
                team.totalWins += team.wins;
                team.ResetRecord();
            }
        }

        //Compare schedules with another team
        public static void AnalyzeSchedule(Team team, Team compTeam)
        {
            if (team.scores.Length != team.schedule.Length)
            {
                Console.WriteLine("Error: Array lengths invalid for TEAM: " + team.name);
            }
            else
            {
                var table = new ConsoleTable("Schedule", "Record", "Better/Worse");
                for (int i = 0; i < team.scores.Length; i++)
                {
                    //Preserve H2H records
                    if (team.name.Equals(compTeam.schedule[i].name))
                    {
                        if (team.scores[i] > team.schedule[i].scores[i])
                        {
                            team.wins++;
                        }
                        else if (team.scores[i] < team.schedule[i].scores[i])
                        {
                            team.losses++;
                        }
                        else
                        {
                            team.ties++;
                        }
                    }
                    else
                    {
                        if (team.scores[i] > compTeam.schedule[i].scores[i])
                        {
                            team.wins++;
                        }
                        else if (team.scores[i] < compTeam.schedule[i].scores[i])
                        {
                            team.losses++;
                        }
                        else
                        {
                            team.ties++;
                        }
                    }
                }
                char indicator;
                if (team.wins > team.actualWins)
                {
                    indicator = '^';
                }
                else if (team.wins < team.actualWins)
                {
                    indicator = 'v';
                }
                else
                {
                    indicator = '=';
                }

                //Display results
                if (team.ties == 0)
                {
                    Console.WriteLine("If " + team.name + " had played " + compTeam.name + "'s schedule, record is " + team.wins + "-" + team.losses + " | " + indicator);
                }
                else
                {
                    Console.WriteLine("If " + team.name + " had played " + compTeam.name + "'s schedule, record is " + team.wins + "-" + team.losses + "-" + team.ties + " | " + indicator);
                }
                team.totalWins += team.wins;
                team.ResetRecord();
            }
        }
    }
}
