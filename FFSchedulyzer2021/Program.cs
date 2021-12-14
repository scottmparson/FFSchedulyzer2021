using System;
using System.Collections.Generic;
using ConsoleTables;
using System.Linq;
using System.Text;

namespace FFSchedulyzer2021
{
    class Program
    {

        private static Team? Beth, Brandon, Bryan, Daniel, Eric, Evan, Julie, Kevin, Kim, Kyle, Nate, Scott;

        static void Main(string[] args)
        {
            Beth = new Team("Better than 2020", new double[]
            {
                131.3, 100.96, 75.47, 89.57, 87.17, 71.15, 72.14, 91.52, 61.81, 62.92, 88.67, 31.51, 87.41, 90.07
            });

            //Brandon
            Brandon = new Team("Isaiah's Mugger", new double[]
            {
                117.32, 123.72, 139.73, 68.33, 153.61, 101.08, 141.65, 100.51, 106.52, 103.61, 108.08, 98.39, 150.79, 114.78
            });

            //Bryan
            Bryan = new Team("Bus Wankers", new double[] {
               125.47, 160.4, 102.38, 132.69, 92.68, 77.59, 120.11, 83.88, 79.08, 83.05, 125.22, 72.71, 114.8, 130.49
            });

            //Daniel
            Daniel = new Team("I'M PICKLE RICK", new double[]
            {
                84.43, 86.13, 117.35, 107.01, 121.74, 147.01, 97.69, 98.26, 78.04, 87.72, 106.69, 117.64, 60.32, 126.84
            });

            //Eric
            Eric = new Team("The Midnight Society", new double[]
            {
                101.86, 83.85, 56.67, 123.42, 97.66, 112.29, 103.08, 122.17, 110.29, 98.09, 101.66, 77.51, 126.86, 114.29
            });

            //Evan
            Evan = new Team("Lot Lizard King", new double[]
            {
                89.64, 108.59, 122.38, 92.65, 178.02, 77.73, 97.28, 101.53, 127.97, 98.24, 148.33, 105.28, 127.39, 130.39
            });

            //Julie
            Julie = new Team("DontDraft BlackedOut", new double[]
            {
                65.39, 133.63, 91.42, 104.23, 168.97, 127.52, 116.97, 91.08, 64.61, 101.38, 118.88, 108.79, 114.67, 150.95
            });

            //Kevin
            Kevin = new Team("Deep Loggins", new double[]
            {
                116.93, 110.76, 92.77, 115.64, 133.24, 142.66, 54.12, 100.09, 105.37, 113.83, 83.39, 108.6, 96.4, 45.53
            });

            //Kim
            Kim = new Team("The Blue Bandaids", new double[]
            {
                129.48, 93.94, 108.9, 121.05, 97.35, 134.69, 93.34, 104.24, 57.01, 95.25, 130.6, 129.0, 74.49, 106.8
            });

            //Kyle
            Kyle = new Team("Morehead Felaters", new double[]
            {
               101.31, 100.66, 110.28, 80.2, 100.99, 131.0, 120.34, 106.35, 96.51, 102.3, 96.11, 118.4, 122.6, 125.77
            });

            //Nate
            Nate = new Team("Nilbog Dance Academy", new double[]
            {
                107.75, 90.65, 120.68, 130.79, 155.74, 94.74, 116.93, 118.4, 108.0, 51.53, 92.62, 94.17, 115.5, 123.15
            });

            //Scott
            Scott = new Team("Salsa Sharks", new double[]
            {
                115.55, 130.19, 131.86, 106.35, 137.31, 114.61, 117.49, 92.84, 72.56, 98.09, 92.27, 63.87, 91.11, 104.8
            });

            Beth.SetSchedule(new Team[]
            {
                Evan, Julie, Kim, Scott, Bryan, Nate, Brandon, Daniel, Kyle, Kevin, Eric, Evan, Julie, Kim
            });
            Brandon.SetSchedule(new Team[]
            {
                Scott, Bryan, Nate, Kevin, Daniel, Kyle, Beth, Eric, Evan, Julie, Kim, Scott, Bryan, Nate
            });
            Bryan.SetSchedule(new Team[]
            {
                Nate, Brandon, Daniel, Kyle, Beth, Eric, Evan, Julie, Kim, Scott, Kevin, Nate, Brandon, Daniel
            });
            Daniel.SetSchedule(new Team[]
            {
                Kim, Scott, Bryan, Nate, Brandon, Kevin, Kyle, Beth, Eric, Evan, Julie, Kim, Scott, Bryan
            });
            Eric.SetSchedule(new Team[]
            {
                Kevin, Evan, Julie, Kim, Scott, Bryan, Nate, Brandon, Daniel, Kyle, Beth, Kevin, Evan, Julie   
            });
            Evan.SetSchedule(new Team[]
            {
                Beth, Eric, Kevin, Julie, Kim, Scott, Bryan, Nate, Brandon, Daniel, Kyle, Beth, Eric, Kevin
            });
            Julie.SetSchedule(new Team[]
            {
                Kyle, Beth, Eric, Evan, Kevin, Kim, Scott, Bryan, Nate, Brandon, Daniel, Kyle, Beth, Eric
            });
            Kevin.SetSchedule(new Team[]
            {
                Eric, Nate, Evan, Brandon, Julie, Daniel, Kim, Kyle, Scott, Beth, Bryan, Eric, Nate, Evan
            });
            Kim.SetSchedule(new Team[]
            {
                Daniel, Kyle, Beth, Eric, Evan, Julie, Kevin, Scott, Bryan, Nate, Brandon, Daniel, Kyle, Beth
            });
            Kyle.SetSchedule(new Team[]
            {
                Julie, Kim, Scott, Bryan, Nate, Brandon, Daniel, Kevin, Beth, Eric, Evan, Julie, Kim, Scott
            });
            Nate.SetSchedule(new Team[]
            {
                Bryan, Kevin, Brandon, Daniel, Kyle, Beth, Eric, Evan, Julie, Kim, Scott, Bryan, Kevin, Brandon
            });
            Scott.SetSchedule(new Team[]
            {
                Brandon, Daniel, Kyle, Beth, Eric, Evan, Julie, Kim, Kevin, Bryan, Nate, Brandon, Daniel, Kyle
            });

            List<Team> league = new List<Team>();
            league.Add(Beth);
            league.Add(Brandon);
            league.Add(Bryan);
            league.Add(Daniel);
            league.Add(Eric);
            league.Add(Evan);
            league.Add(Julie);
            league.Add(Kevin);
            league.Add(Kim);
            league.Add(Kyle);
            league.Add(Nate);
            league.Add(Scott);

            AnalyzeSchedule(Beth);
            AnalyzeSchedule(Beth, Brandon);
            AnalyzeSchedule(Beth, Bryan);
            AnalyzeSchedule(Beth, Daniel);
            AnalyzeSchedule(Beth, Eric);
            AnalyzeSchedule(Beth, Evan);
            AnalyzeSchedule(Beth, Julie);
            AnalyzeSchedule(Beth, Kevin);
            AnalyzeSchedule(Beth, Kim);
            AnalyzeSchedule(Beth, Kyle);
            AnalyzeSchedule(Beth, Nate);
            AnalyzeSchedule(Beth, Scott);
            Console.WriteLine("Total Wins: " + Beth.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Brandon);
            AnalyzeSchedule(Brandon, Beth);
            AnalyzeSchedule(Brandon, Bryan);
            AnalyzeSchedule(Brandon, Daniel);
            AnalyzeSchedule(Brandon, Eric);
            AnalyzeSchedule(Brandon, Evan);
            AnalyzeSchedule(Brandon, Julie);
            AnalyzeSchedule(Brandon, Kevin);
            AnalyzeSchedule(Brandon, Kim);
            AnalyzeSchedule(Brandon, Kyle);
            AnalyzeSchedule(Brandon, Nate);
            AnalyzeSchedule(Brandon, Scott);
            Console.WriteLine("Total Wins: " + Brandon.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Bryan);
            AnalyzeSchedule(Bryan, Beth);
            AnalyzeSchedule(Bryan, Brandon);
            AnalyzeSchedule(Bryan, Daniel);
            AnalyzeSchedule(Bryan, Eric);
            AnalyzeSchedule(Bryan, Evan);
            AnalyzeSchedule(Bryan, Julie);
            AnalyzeSchedule(Bryan, Kevin);
            AnalyzeSchedule(Bryan, Kim);
            AnalyzeSchedule(Bryan, Kyle);
            AnalyzeSchedule(Bryan, Nate);
            AnalyzeSchedule(Bryan, Scott);
            Console.WriteLine("Total Wins: " + Bryan.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Daniel);
            AnalyzeSchedule(Daniel, Beth);
            AnalyzeSchedule(Daniel, Brandon);
            AnalyzeSchedule(Daniel, Bryan);
            AnalyzeSchedule(Daniel, Eric);
            AnalyzeSchedule(Daniel, Evan);
            AnalyzeSchedule(Daniel, Julie);
            AnalyzeSchedule(Daniel, Kevin);
            AnalyzeSchedule(Daniel, Kim);
            AnalyzeSchedule(Daniel, Kyle);
            AnalyzeSchedule(Daniel, Nate);
            AnalyzeSchedule(Daniel, Scott);
            Console.WriteLine("Total Wins: " + Daniel.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Eric);
            AnalyzeSchedule(Eric, Beth);
            AnalyzeSchedule(Eric, Brandon);
            AnalyzeSchedule(Eric, Bryan);
            AnalyzeSchedule(Eric, Daniel);
            AnalyzeSchedule(Eric, Evan);
            AnalyzeSchedule(Eric, Julie);
            AnalyzeSchedule(Eric, Kevin);
            AnalyzeSchedule(Eric, Kim);
            AnalyzeSchedule(Eric, Kyle);
            AnalyzeSchedule(Eric, Nate);
            AnalyzeSchedule(Eric, Scott);
            Console.WriteLine("Total Wins: " + Eric.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Evan);
            AnalyzeSchedule(Evan, Beth);
            AnalyzeSchedule(Evan, Brandon);
            AnalyzeSchedule(Evan, Bryan);
            AnalyzeSchedule(Evan, Daniel);
            AnalyzeSchedule(Evan, Eric);
            AnalyzeSchedule(Evan, Julie);
            AnalyzeSchedule(Evan, Kevin);
            AnalyzeSchedule(Evan, Kim);
            AnalyzeSchedule(Evan, Kyle);
            AnalyzeSchedule(Evan, Nate);
            AnalyzeSchedule(Evan, Scott);
            Console.WriteLine("Total Wins: " + Evan.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Julie);
            AnalyzeSchedule(Julie, Beth);
            AnalyzeSchedule(Julie, Brandon);
            AnalyzeSchedule(Julie, Bryan);
            AnalyzeSchedule(Julie, Daniel);
            AnalyzeSchedule(Julie, Evan);
            AnalyzeSchedule(Julie, Eric);
            AnalyzeSchedule(Julie, Kevin);
            AnalyzeSchedule(Julie, Kim);
            AnalyzeSchedule(Julie, Kyle);
            AnalyzeSchedule(Julie, Nate);
            AnalyzeSchedule(Julie, Scott);
            Console.WriteLine("Total Wins: " + Julie.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Kevin);
            AnalyzeSchedule(Kevin, Beth);
            AnalyzeSchedule(Kevin, Brandon);
            AnalyzeSchedule(Kevin, Bryan);
            AnalyzeSchedule(Kevin, Daniel);
            AnalyzeSchedule(Kevin, Evan);
            AnalyzeSchedule(Kevin, Eric);
            AnalyzeSchedule(Kevin, Julie);
            AnalyzeSchedule(Kevin, Kim);
            AnalyzeSchedule(Kevin, Kyle);
            AnalyzeSchedule(Kevin, Nate);
            AnalyzeSchedule(Kevin, Scott);
            Console.WriteLine("Total Wins: " + Kevin.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Kim);
            AnalyzeSchedule(Kim, Beth);
            AnalyzeSchedule(Kim, Brandon);
            AnalyzeSchedule(Kim, Bryan);
            AnalyzeSchedule(Kim, Daniel);
            AnalyzeSchedule(Kim, Evan);
            AnalyzeSchedule(Kim, Eric);
            AnalyzeSchedule(Kim, Julie);
            AnalyzeSchedule(Kim, Kevin);
            AnalyzeSchedule(Kim, Kyle);
            AnalyzeSchedule(Kim, Nate);
            AnalyzeSchedule(Kim, Scott);
            Console.WriteLine("Total Wins: " + Kim.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Kyle);
            AnalyzeSchedule(Kyle, Beth);
            AnalyzeSchedule(Kyle, Brandon);
            AnalyzeSchedule(Kyle, Bryan);
            AnalyzeSchedule(Kyle, Daniel);
            AnalyzeSchedule(Kyle, Evan);
            AnalyzeSchedule(Kyle, Eric);
            AnalyzeSchedule(Kyle, Julie);
            AnalyzeSchedule(Kyle, Kevin);
            AnalyzeSchedule(Kyle, Kim);
            AnalyzeSchedule(Kyle, Nate);
            AnalyzeSchedule(Kyle, Scott);
            Console.WriteLine("Total Wins: " + Kyle.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Nate);
            AnalyzeSchedule(Nate, Beth);
            AnalyzeSchedule(Nate, Brandon);
            AnalyzeSchedule(Nate, Bryan);
            AnalyzeSchedule(Nate, Daniel);
            AnalyzeSchedule(Nate, Evan);
            AnalyzeSchedule(Nate, Eric);
            AnalyzeSchedule(Nate, Julie);
            AnalyzeSchedule(Nate, Kevin);
            AnalyzeSchedule(Nate, Kim);
            AnalyzeSchedule(Nate, Kyle);
            AnalyzeSchedule(Nate, Scott);
            Console.WriteLine("Total Wins: " + Nate.totalWins);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            AnalyzeSchedule(Scott);
            AnalyzeSchedule(Scott, Beth);
            AnalyzeSchedule(Scott, Brandon);
            AnalyzeSchedule(Scott, Bryan);
            AnalyzeSchedule(Scott, Daniel);
            AnalyzeSchedule(Scott, Eric);
            AnalyzeSchedule(Scott, Evan);
            AnalyzeSchedule(Scott, Julie);
            AnalyzeSchedule(Scott, Kevin);
            AnalyzeSchedule(Scott, Kim);
            AnalyzeSchedule(Scott, Kyle);
            AnalyzeSchedule(Scott, Nate);
            Console.WriteLine("Total Wins: " + Scott.totalWins);
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

                //var table = new ConsoleTables
            }
        }
    }
}
