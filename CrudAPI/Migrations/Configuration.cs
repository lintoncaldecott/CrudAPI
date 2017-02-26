using System.Data.Entity.Migrations;
using CrudAPI.DataLayer.DataAccess;
using CrudAPI.DataLayer.Models;
using System.Collections.Generic;

namespace CrudAPI.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<UserContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UserContext context)
        {
            var users = new List<User>
            {
                  new User { FirstName = "The", LastName = "Doctor", Status = true, ContactNumber = 0820000001, UserName = "DoctorWho@gmail.com" },
                  new User { FirstName = "Ellen", LastName = "Ripley", Status = true, ContactNumber = 0820000002, UserName = "Aliensaga@gmail.com" },
                  new User { FirstName = "Darth", LastName = "Vader", Status = true, ContactNumber = 0820000003, UserName = "StarWarssaga@gmail.com" },
                  new User { FirstName = "Kerr", LastName = "Avon", Status = true, ContactNumber = 0820000004, UserName = "Blakes7@gmail.com" },
                  new User { FirstName = "Malcolm", LastName = "Reynolds", Status = true, ContactNumber = 0820000005, UserName = "FireflySerenity@gmail.com" },
                  new User { FirstName = "GKar", LastName = "GKar", Status = true, ContactNumber = 0820000006, UserName = "Babylon5@gmail.com" },
                  new User { FirstName = "HAL-9000", LastName = "HAL-9000", Status = true, ContactNumber = 0820000007, UserName = "2001ASpaceOdyssey@gmail.com" },
                  new User { FirstName = "Rick", LastName = "Deckard", Status = true, ContactNumber = 0820000008, UserName = "BladeRunner@gmail.com" },
                  new User { FirstName = "Han", LastName = "Solo", Status = true, ContactNumber = 0820000009, UserName = "StarWarssaga@gmail.com" },
                  new User { FirstName = "Spock", LastName = "Spock", Status = true, ContactNumber = 0820000010, UserName = "StarTreksaga@gmail.com" },
                  new User { FirstName = "John", LastName = "Crichton", Status = true, ContactNumber = 0820000011, UserName = "Farscape@gmail.com" },
                  new User { FirstName = "Roy", LastName = "Batty", Status = true, ContactNumber = 0820000012, UserName = "BladeRunner@gmail.com" },
                  new User { FirstName = "Jack", LastName = "Harkness", Status = true, ContactNumber = 0820000013, UserName = "Torchwood@gmail.com" },
                  new User { FirstName = "James", LastName = "T Kirk", Status = true, ContactNumber = 0820000014, UserName = "StarTreksaga@gmail.com" },
                  new User { FirstName = "Jean-Luc", LastName = "Picard", Status = true, ContactNumber = 0820000015, UserName = "StarTrekTheNextGeneration@gmail.com" },
                  new User { FirstName = "Londo", LastName = "Mollari", Status = true, ContactNumber = 0820000016, UserName = "Babylon5@gmail.com" },
                  new User { FirstName = "The", LastName = "Alien", Status = true, ContactNumber = 0820000017, UserName = "Alien@gmail.com" },
                  new User { FirstName = "Dana", LastName = "Scully", Status = true, ContactNumber = 0820000018, UserName = "TheXFiles@gmail.com" },
                  new User { FirstName = "Ianto", LastName = "Jones", Status = true, ContactNumber = 0820000019, UserName = "Torchwood@gmail.com" },
                  new User { FirstName = "Yoda", LastName = "Yoda", Status = true, ContactNumber = 0820000020, UserName = "StarWarssaga@gmail.com" },
                  new User { FirstName = "Aeryn", LastName = "Sun", Status = true, ContactNumber = 0820000021, UserName = "Farscape@gmail.com" },
                  new User { FirstName = "Kara", LastName = "Thrace", Status = true, ContactNumber = 0820000022, UserName = "BattlestarGalactica@gmail.com" },
                  new User { FirstName = "Sarah", LastName = "Connor", Status = true, ContactNumber = 0820000023, UserName = "TheTerminatorsaga@gmail.com" },
                  new User { FirstName = "Doc", LastName = "Brown", Status = true, ContactNumber = 0820000024, UserName = "BacktotheFuturetrilogy@gmail.com" },
                  new User { FirstName = "Fox", LastName = "Mulder", Status = true, ContactNumber = 0820000025, UserName = "TheXFiles@gmail.com" },
                  new User { FirstName = "Bernard", LastName = "Quatermass", Status = true, ContactNumber = 0820000026, UserName = "QuatermassandthePit@gmail.com" },
                  new User { FirstName = "The", LastName = "Terminator", Status = true, ContactNumber = 0820000027, UserName = "TheTerminatorsaga@gmail.com" },
                  new User { FirstName = "Susan", LastName = "Ivanova", Status = true, ContactNumber = 0820000028, UserName = "Babylon5@gmail.com" },
                  new User { FirstName = "John", LastName = "Sheridan", Status = true, ContactNumber = 0820000029, UserName = "Babylon5@gmail.com" },
                  new User { FirstName = "Delenn", LastName = "Delenn", Status = true, ContactNumber = 0820000030, UserName = "Babylon5@gmail.com" },
                  new User { FirstName = "Jack", LastName = "ONeill", Status = true, ContactNumber = 0820000031, UserName = "StargateSG1@gmail.com" },
                  new User { FirstName = "Daleks", LastName = "Daleks", Status = true, ContactNumber = 0820000032, UserName = "DoctorWho@gmail.com" },
                  new User { FirstName = "Data", LastName = "Data", Status = true, ContactNumber = 0820000033, UserName = "StarTrekTheNextGeneration@gmail.com" },
                  new User { FirstName = "Luke", LastName = "Skywalker", Status = true, ContactNumber = 0820000034, UserName = "StarWarssaga@gmail.com" },
                  new User { FirstName = "Gort", LastName = "Klaatu", Status = true, ContactNumber = 0820000035, UserName = "TheDaytheEarthStoodStill@gmail.com" },
                  new User { FirstName = "Maria", LastName = "Robot", Status = true, ContactNumber = 0820000036, UserName = "Metropolis@gmail.com" },
                  new User { FirstName = "Judge", LastName = "Dredd", Status = true, ContactNumber = 0820000037, UserName = "JudgeDredd@gmail.com" },
                  new User { FirstName = "ET", LastName = "ET", Status = true, ContactNumber = 0820000038, UserName = "ETTheExtraTerrestrial@gmail.com" },
                  new User { FirstName = "Ben", LastName = "Kenobi", Status = true, ContactNumber = 0820000039, UserName = "StarWarssaga@gmail.com" },
                  new User { FirstName = "Neo", LastName = "Neo", Status = true, ContactNumber = 0820000040, UserName = "TheMatrixtrilogy@gmail.com" },
                  new User { FirstName = "Robbie", LastName = "Robot", Status = true, ContactNumber = 0820000041, UserName = "ForbiddenPlanet@gmail.com" },
                  new User { FirstName = "Marvin", LastName = "the Paranoid Android", Status = true, ContactNumber = 0820000042, UserName = "TheHitchhikersGuidetotheGalaxy@gmail.com" },
                  new User { FirstName = "Marty", LastName = "McFly", Status = true, ContactNumber = 0820000043, UserName = "BacktotheFuturetrilogy@gmail.com" },
                  new User { FirstName = "Rose", LastName = "Tyler", Status = true, ContactNumber = 0820000044, UserName = "DoctorWho@gmail.com" },
                  new User { FirstName = "Samantha", LastName = "Carter", Status = true, ContactNumber = 0820000045, UserName = "StargateSG1@gmail.com" },
                  new User { FirstName = "Donna", LastName = "Noble", Status = true, ContactNumber = 0820000046, UserName = "DoctorWho@gmail.com" },
                  new User { FirstName = "Walter", LastName = "Bishop", Status = true, ContactNumber = 0820000047, UserName = "Fringe@gmail.com" },
                  new User { FirstName = "William", LastName = "Adama", Status = true, ContactNumber = 0820000048, UserName = "BattlestarGalactica@gmail.com" },
                  new User { FirstName = "River", LastName = "Tam", Status = true, ContactNumber = 0820000049, UserName = "FireflySerenity@gmail.com" },
                  new User { FirstName = "Arthur", LastName = "Dent", Status = true, ContactNumber = 0820000050, UserName = "TheHitchhikersGuidetotheGalaxy@gmail.com" },
                  new User { FirstName = "Wall-E", LastName = "Wall-E", Status = true, ContactNumber = 0820000051, UserName = "WallE@gmail.com" },
                  new User { FirstName = "R2-D2", LastName = "R2-D2", Status = true, ContactNumber = 0820000052, UserName = "StarWars@gmail.com" },
                  new User { FirstName = "Boba", LastName = "Fett", Status = true, ContactNumber = 0820000053, UserName = "StarWars@gmail.com" },
                  new User { FirstName = "Arnold", LastName = "J Rimmer", Status = true, ContactNumber = 0820000054, UserName = "RedDwarf@gmail.com" },
                  new User { FirstName = "Sam", LastName = "Bell", Status = true, ContactNumber = 0820000055, UserName = "Moon@gmail.com" },
                  new User { FirstName = "Leeloo", LastName = "Leeloo", Status = true, ContactNumber = 0820000056, UserName = "TheFifthElement@gmail.com" },
                  new User { FirstName = "Roj", LastName = "Blake", Status = true, ContactNumber = 0820000057, UserName = "Blakes7@gmail.com" },
                  new User { FirstName = "Elim", LastName = "Garak", Status = true, ContactNumber = 0820000058, UserName = "StarTrekDeepSpaceNine@gmail.com" },
                  new User { FirstName = "Scorpius", LastName = "Scorpius", Status = true, ContactNumber = 0820000059, UserName = "Farscape@gmail.com" },
                  new User { FirstName = "Thomas", LastName = "Jerome Newton", Status = true, ContactNumber = 0820000060, UserName = "TheManWhoFelltoEarth@gmail.com" },
                  new User { FirstName = "Kathryn", LastName = "Janeway", Status = true, ContactNumber = 0820000061, UserName = "StarTrekVoyager@gmail.com" },
                  new User { FirstName = "Gaius", LastName = "Baltar", Status = true, ContactNumber = 0820000062, UserName = "BattlestarGalactica@gmail.com" },
                  new User { FirstName = "Chiana", LastName = "Chiana", Status = true, ContactNumber = 0820000063, UserName = "Farscape@gmail.com" },
                  new User { FirstName = "Kaylee", LastName = "Kaylee", Status = true, ContactNumber = 0820000064, UserName = "FireflySerenity@gmail.com" },
                  new User { FirstName = "Sarah-Jane", LastName = "Smith", Status = true, ContactNumber = 0820000065, UserName = "DoctorWho@gmail.com" },
                  new User { FirstName = "David", LastName = "David", Status = true, ContactNumber = 0820000066, UserName = "Prometheus@gmail.com" },
                  new User { FirstName = "Q", LastName = "Q", Status = true, ContactNumber = 0820000067, UserName = "StarTreksaga@gmail.com" },
                  new User { FirstName = "Dave", LastName = "Lister", Status = true, ContactNumber = 0820000068, UserName = "RedDwarf@gmail.com" },
                  new User { FirstName = "Amy", LastName = "Pond", Status = true, ContactNumber = 0820000069, UserName = "DoctorWho@gmail.com" },
                  new User { FirstName = "Flash", LastName = "Gordon", Status = true, ContactNumber = 0820000070, UserName = "FlashGordon@gmail.com" },
                  new User { FirstName = "Leia", LastName = "Organa", Status = true, ContactNumber = 0820000071, UserName = "StarWarssaga@gmail.com" },
                  new User { FirstName = "RoboCop", LastName = "RoboCop", Status = true, ContactNumber = 0820000072, UserName = "RoboCop@gmail.com" },
                  new User { FirstName = "River", LastName = "Song", Status = true, ContactNumber = 0820000073, UserName = "DoctorWho@gmail.com" },
                  new User { FirstName = "Snake", LastName = "Plissken", Status = true, ContactNumber = 0820000074, UserName = "EscapefromNewYork@gmail.com" },
                  new User { FirstName = "Alfred", LastName = "Bester", Status = true, ContactNumber = 0820000075, UserName = "Babylon5@gmail.com" },
                  new User { FirstName = "Barbarella", LastName = "Barbarella", Status = true, ContactNumber = 0820000076, UserName = "Barbarella@gmail.com" },
                  new User { FirstName = "John", LastName = "Sheppard", Status = true, ContactNumber = 0820000077, UserName = "StargateAtlantis@gmail.com" },
                  new User { FirstName = "Seven", LastName = "of Nine", Status = true, ContactNumber = 0820000078, UserName = "StarTrekVoyager@gmail.com" },
                  new User { FirstName = "Daniel", LastName = "Jackson", Status = true, ContactNumber = 0820000079, UserName = "StargateSG1@gmail.com" },
                  new User { FirstName = "RJ", LastName = "MacReady", Status = true, ContactNumber = 0820000080, UserName = "TheThing@gmail.com" },
                  new User { FirstName = "Dave", LastName = "Bowman", Status = true, ContactNumber = 0820000081, UserName = "2001ASpaceOdyssey@gmail.com" },
                  new User { FirstName = "Jeffrey", LastName = "Sinclair", Status = true, ContactNumber = 0820000082, UserName = "Babylon5@gmail.com" },
                  new User { FirstName = "Lyta", LastName = "Alexander", Status = true, ContactNumber = 0820000083, UserName = "Babylon5@gmail.com" },
                  new User { FirstName = "Tetsuo", LastName = "Shima", Status = true, ContactNumber = 0820000084, UserName = "Akira@gmail.com" },
                  new User { FirstName = "The", LastName = "Predator", Status = true, ContactNumber = 0820000085, UserName = "Predator@gmail.com" },
                  new User { FirstName = "Benjamin", LastName = "Sisko", Status = true, ContactNumber = 0820000086, UserName = "StarTrekDeepSpaceNine@gmail.com" },
                  new User { FirstName = "Gwen", LastName = "Cooper", Status = true, ContactNumber = 0820000087, UserName = "Torchwood@gmail.com" },
                  new User { FirstName = "Kryten", LastName = "Kryten", Status = true, ContactNumber = 0820000088, UserName = "RedDwarf@gmail.com" },
                  new User { FirstName = "Servalan", LastName = "Servalan", Status = true, ContactNumber = 0820000089, UserName = "Blakes7@gmail.com" },
                  new User { FirstName = "The", LastName = "Master", Status = true, ContactNumber = 0820000090, UserName = "DoctorWho@gmail.com" },
                  new User { FirstName = "Vala", LastName = "Mal Doran", Status = true, ContactNumber = 0820000091, UserName = "StargateSG1@gmail.com" },
                  new User { FirstName = "Bo", LastName = "Dennis", Status = true, ContactNumber = 0820000092, UserName = "LostGirl@gmail.com" },
                  new User { FirstName = "Michael", LastName = "Garibaldi", Status = true, ContactNumber = 0820000093, UserName = "Babylon5@gmail.com" },
                  new User { FirstName = "Number", LastName = "Six", Status = true, ContactNumber = 0820000094, UserName = "BattlestarGalactica@gmail.com" },
                  new User { FirstName = "Hoban", LastName = "Wash Washburn", Status = true, ContactNumber = 0820000095, UserName = "FireflySerenity@gmail.com" },
                  new User { FirstName = "C3PO", LastName = "C3PO", Status = true, ContactNumber = 0820000096, UserName = "StarWars@gmail.com" },
                  new User { FirstName = "Riddick", LastName = "Riddick", Status = true, ContactNumber = 0820000097, UserName = "TheChroniclesofRiddick@gmail.com" },
                  new User { FirstName = "Motoko", LastName = "Kusanagi", Status = true, ContactNumber = 0820000098, UserName = "GhostintheShell@gmail.com" },
                  new User { FirstName = "Laura", LastName = "Roslin", Status = true, ContactNumber = 0820000099, UserName = "BattlestarGalactica@gmail.com" },
                  new User { FirstName = "Doctor", LastName = "Ellie Arroway", Status = true, ContactNumber = 0820000100, UserName = "Contact@gmail.com" },
                  new User { FirstName = "Paul", LastName = "Atreides", Status = true, ContactNumber = 0825241234, UserName = "Paul@Atreides.com" },
                  new User { FirstName = "Duncan", LastName = "Idaho", Status = true, ContactNumber = 0825241234, UserName = "Duncan@Idaho.com" },
                  new User { FirstName = "Piter", LastName = "De Vries", Status = true, ContactNumber = 0825241234, UserName = "Piter@DeVries.com" }
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        }
    }
}
