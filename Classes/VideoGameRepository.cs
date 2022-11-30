using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameRepository.Classes
{
    internal class VideoGameRepository
    {
        public HashSet<VideoGame> VideoGames { get; set; } = new();
        public HashSet<VideoGameConsole> Consoles { get; set; } = new();
        public HashSet<Publisher> Publishers { get; set; } = new();
        public HashSet<Studio> Studios { get; set; } = new();

        public VideoGameRepository()
        {
            Studio coffeeStainStudio = new("Coffee Stain Studios", 1_000_000);
            Studio monolithSoft = new("Monolith Soft", 1_000_000);
            Studio halLabs = new("HAL Laboratories", 1_000_000);
            Studio TeamCherryStudio = new("Team Cherry",256_100);
            Studio MoonStudios = new("Moon Studios", 1_000_000);
            Studio Videocult = new("Videocult", 123_250);
            Studio SystemEraSoftworksStudio = new("System Era Softworks", 4_000_000);
            Studio CTOANStudio = new("CTOAN",0);


            Studios.Add(coffeeStainStudio);
            Studios.Add(monolithSoft);
            Studios.Add(halLabs);
            Studios.Add(TeamCherryStudio);
            Studios.Add(MoonStudios);
            Studios.Add(Videocult);
            Studios.Add(SystemEraSoftworksStudio);
            Studios.Add(CTOANStudio);
            
            Publisher coffeeStainPublishing = new("Coffee Stain Publishing", 1_000_000);
            Publisher nintendo = new("Nintendo", 100_000_000);
            Publisher TeamCherryPublisher = new("Team Cherry",256_100);
            Publisher MicrosoftStudios = new("Microsoft Studios", 4_793_600_000);
            Publisher AdultSwimGames = new("Adult Swim Games", 110_000);
            Publisher AkuparaGames = new("Akupara Games",110_000);
            Publisher SystemEraSoftworksPublisher = new("System Era Softworks", 4_000_000);
            Publisher CTOANPublisher = new("CTOAN",0);

            Publishers.Add(coffeeStainPublishing);
            Publishers.Add(nintendo);
            Publishers.Add(TeamCherryPublisher);
            Publishers.Add(MicrosoftStudios);
            Publishers.Add(AdultSwimGames);
            Publishers.Add(AkuparaGames);
            Publishers.Add(SystemEraSoftworksPublisher);
            Publishers.Add(CTOANPublisher);

            VideoGameConsole pc = new("PC", 1500, 20, true);
            VideoGameConsole wiiU = new("Wii U", 400, 8, true);
            VideoGameConsole nSwitch = new("Switch", 400, 8, true);
            VideoGameConsole xboxone = new("xbox one", 499.99, 8, true);
            VideoGameConsole ps4 = new("PlayStation 4",399,4,true);

            Consoles.Add(pc);
            Consoles.Add(wiiU);
            Consoles.Add(nSwitch);
            Consoles.Add(xboxone);
            Consoles.Add(ps4);

            VideoGame breadGame = new(
                title: "The Bread Game",
                category: "simulation",
                year: 2018,
                playerCount: 1,
                studio: CTOANStudio,
                publisher: CTOANPublisher,
                price: 0,
                ageRating: 3
                );
            VideoGames.Add(breadGame);

            CTOANStudio.AddGame(breadGame);
            CTOANPublisher.AddStudio(CTOANStudio);

            pc.AddGame(breadGame);

            VideoGame Astroneer = new(
              title: "Astroneer",
              category: "sandbox",
              year: 2019,
              playerCount: 4,
              studio: SystemEraSoftworksStudio,
              publisher: SystemEraSoftworksPublisher,
              price: 39,
              ageRating: 7
            );
            VideoGames.Add(Astroneer);

            SystemEraSoftworksStudio.AddGame(Astroneer);
            SystemEraSoftworksPublisher.AddStudio(SystemEraSoftworksStudio);
            pc.AddGame(Astroneer);
            nSwitch.AddGame(Astroneer);
            xboxone.AddGame(Astroneer);
            ps4.AddGame(Astroneer);


            VideoGame ori2 = new(
              title: "Ori and the Will of the Wisps",
              category: "metroidvania",
              year: 2020,
              playerCount: 1,
              studio: MoonStudios,
              publisher: MicrosoftStudios,
              ageRating: 7,
              price: 31.48
            );
            VideoGames.Add(ori2);

            MoonStudios.AddGame(ori2);
            pc.AddGame(ori2);
            nSwitch.AddGame(ori2);
            xboxone.AddGame(ori2);

            VideoGame rainworld = new(
              title: "Rain World",
              category: "survival",
              year: 2018,
              playerCount: 1,
              price: 24.88,
              publisher: AkuparaGames,
              studio: Videocult,
              ageRating: 10
            );
            VideoGames.Add(rainworld);

            Videocult.AddGame(rainworld);
            AkuparaGames.AddStudio(Videocult);
            AdultSwimGames.AddStudio(Videocult);
            pc.AddGame(rainworld);
            ps4.AddGame(rainworld);
            nSwitch.AddGame(rainworld);

            VideoGame ori1 = new(
             title: "Ori and the Blind Forest",
             category: "metroidvania",
             year: 2015,
             playerCount: 1,
             price: 4.99,
             studio: MoonStudios,
             publisher: MicrosoftStudios,
             ageRating: 7
            );
            VideoGames.Add(ori1);

            MoonStudios.AddGame(ori1);
            MicrosoftStudios.AddStudio(MoonStudios);
            pc.AddGame(ori1);
            xboxone.AddGame(ori1);
            nSwitch.AddGame(ori1);
            ps4.AddGame(ori1);

            VideoGame hollowKnight = new(
             title: "Hollow Knight",
             category: "metroidvania",
             year: 2017,
             playerCount: 1,
             price: 14.99,
             studio: TeamCherryStudio,
             publisher: TeamCherryPublisher,
             ageRating: 7
            );
            VideoGames.Add(hollowKnight);

            TeamCherryStudio.AddGame(hollowKnight);
            TeamCherryPublisher.AddStudio(TeamCherryStudio);
            pc.AddGame(hollowKnight);
            nSwitch.AddGame(hollowKnight);
            ps4.AddGame(hollowKnight);
            xboxone.AddGame(hollowKnight);

            VideoGame satisfactory = new(
                title: "Satisfactory",
                category: "Simulation",
                year: 2018,
                playerCount: 4,
                price: 40f,
                studio: coffeeStainStudio,
                consoles: new() { pc },
                publisher: coffeeStainPublishing,
                ageRating: 10
            );
            VideoGames.Add(satisfactory);

            coffeeStainStudio.AddGame(satisfactory);
            coffeeStainPublishing.AddStudio(coffeeStainStudio);
            pc.AddGame(satisfactory);

            VideoGame xenoblade = new(
                title: "Xenoblade Chronicles: Definitive Edition",
                category: "JRPG",
                year: 2020,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame xenoblade2 = new(
                title: "Xenoblade Chronicles 2",
                category: "JRPG",
                year: 2017,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame xenoblade3 = new(
                title: "Xenoblade Chronicles 3",
                category: "JRPG",
                year: 2022,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame xenobladeX = new(
                title: "Xenoblade Chronicles X",
                category: "JRPG",
                year: 2015,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { wiiU },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame forgottenLand = new(
                title: "Kirby and the Forgotten Land",
                category: "3D Platformer",
                year: 2022,
                playerCount: 1,
                price: 80f,
                studio: halLabs,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 7
            );

            VideoGames.Add(xenoblade);
            VideoGames.Add(xenoblade2);
            VideoGames.Add(xenoblade3);
            VideoGames.Add(xenobladeX);
            VideoGames.Add(forgottenLand);

            monolithSoft.AddGame(xenoblade);
            monolithSoft.AddGame(xenoblade2);
            monolithSoft.AddGame(xenoblade3);
            monolithSoft.AddGame(xenobladeX);

            halLabs.AddGame(forgottenLand);

            nSwitch.AddGame(xenoblade);
            nSwitch.AddGame(xenoblade2);
            nSwitch.AddGame(xenoblade3);
            nSwitch.AddGame(forgottenLand);

            wiiU.AddGame(xenobladeX);

        }
    }
}
