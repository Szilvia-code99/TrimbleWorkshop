using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Files
{
   /// <summary>
   /// class for representing a fotball team's scores
   /// </summary>
    public class FootballTeam
   {
      private int wins = 0;
      private int draws= 0;
      private int losses = 0;
      private int points = 0;
      private int numberOfPoints = 0;
      private string teamName;

      public void AddTeamName()
      {
         UserInputValidator.UserInputValidation.ValidateUserInput(ref teamName, "Add your teams name");
      }
      /// <summary>
      /// Filling a txt with user input of scores
      /// </summary>
      public void AddScores()
      {
         string path= Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Resources", "football.txt");
         using (System.IO.StreamWriter file =
           new System.IO.StreamWriter(@path, true)) {
            string exit = string.Empty;
            string score = string.Empty;
            do {
               UserInputValidator.UserInputValidation.ValidateUserInput(ref score, "Type the score like (team1 x:y team2)");
               file.WriteLine(score);
               do {
                  UserInputValidator.UserInputValidation.ValidateUserInput(ref exit, "Do you want to add more scores?Y/N");
               } while (exit != "Y" && exit != "N");
            } while (exit == "Y");
         }
      }


      /// <summary>
      /// Printing statistics of football team from file(wins/draws/losses/points/numberOfPoints(count with 3p for W, 1p for D, 0p for L)
      /// </summary>
      public void CalculateStatisticsOfFootballTeam()
      {
        
         string path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Resources", "football.txt");
         using (System.IO.StreamReader fileRw =
          new System.IO.StreamReader(@path, true)) {
            string line;
            while ((line = fileRw.ReadLine()) != null) {
               string[] scores = line.Split(':');

               string[] firstTeam = scores[0].Split(' ');
               string[] secondTeam = scores[1].Split(' ');

               if (firstTeam[0] == teamName) {
                  if (Int32.Parse(firstTeam[1]) > Int32.Parse(secondTeam[0])) {
                     wins++;
                     points += Int32.Parse(firstTeam[1]);
                  } else if (Int32.Parse(firstTeam[1]) < Int32.Parse(secondTeam[0])) {
                     losses++;
                     points += Int32.Parse(firstTeam[1]);
                  } else if (Int32.Parse(firstTeam[1]) == Int32.Parse(secondTeam[0])) {
                     draws++;
                     points += Int32.Parse(firstTeam[1]);
                  }
               } else {
                  if (Int32.Parse(firstTeam[1]) < Int32.Parse(secondTeam[0])) {
                     wins++;
                     points += Int32.Parse(secondTeam[0]);
                  } else if (Int32.Parse(firstTeam[1]) > Int32.Parse(secondTeam[0])) {
                     losses++;
                     points += Int32.Parse(secondTeam[0]);
                  } else if (Int32.Parse(firstTeam[1]) == Int32.Parse(secondTeam[0])) {
                     draws++;
                     points += Int32.Parse(secondTeam[0]);
                  }
               }
            }
         }
         numberOfPoints = wins * 3 + draws;
      }

      public void PrintStatistics()
      {
         Console.WriteLine($"Team: {teamName}, Wins: {wins}, Draws: {draws}, Losses: {losses}, Points: {points}, NumberOfPoints: {numberOfPoints}");
      }
   }
}
