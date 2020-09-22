using OOP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace Files
{
   /// <summary>
   ///1. Build a method that accepts a list of professors or students and serializes that list as XML locally.(xml file creation)
   ///The file should be overwritten if it already exists when the method is called.
   ///2. Build another method that deserializes the xml file and binds the result to a List type variable(s) : students, teachers(read from xml students and teachers)
   ///3. Create a program that prompts the user for the name of a text file.the program will check that the file exists, displaying a message and quitting if it does not.
   ///the file will be opened and copied to another file (prompt the user for the file name), but with every character converted to uppercase.
   ///4.Create a program that fills in a document with the results of a sports team by your choice(football/basketball/ handball etc.) and print the following statistics : 
   ///number of Wins/Draws/Losses Goals/Points Scored;goals/Points Conceded number of points(count with 3p for W, 1p for D, 0p for L)
   /// </summary>
   
   class File
   {
         static void Main(string[] args)
         {
         Serialization demo = new Serialization();
         demo.SerializeListOfStudentsToXml();
         demo.DeserializeListOfStudentsFromXml();
         demo.SerializeListOfTeachersToXml();
         demo.DeserializeListOfTeachersFromXml();
         demo.SerializeListOfTeachersToJson();
         demo.SerializeListOfStudentsToJson();

         FileInputOutput.ConvertFileToUppercase();

         FootballTeam team = new FootballTeam();
         team.AddTeamName();
         team.AddScores();
         team.CalculateStatisticsOfFootballTeam();
         team.PrintStatistics();
         }
      }
   }