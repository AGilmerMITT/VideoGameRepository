using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            // Studios Creation
            Studio WildcardStudio = new("Wildcard Studio", 4_000_000);
            Studios.Add(WildcardStudio);
            Studio coffeeStainStudio = new("Coffee Stain Studios", 1_000_000);
            Studios.Add(coffeeStainStudio);
            Studio maddyMakesGamesStudio = new("Maddy Makes Games", 3_000_000);
            Studios.Add(maddyMakesGamesStudio);
            Studio monolithSoft = new("Monolith Soft", 1_000_000);
            Studios.Add(monolithSoft);
            Studio halLabs = new("HAL Laboratories", 1_000_000);
            Studios.Add(halLabs);
            Studio KeenSoftwareHouseStudio = new("Keen Software House Studios", 500_000);
            Studios.Add(KeenSoftwareHouseStudio);
            Studio hopooGames = new("Hopoo Games", 5_000_000);
            Studios.Add(hopooGames);
            Studio ninjaKiwi = new("Ninja Kiwi", 3_000_000);
            Studios.Add(ninjaKiwi);

            // Publishers Creation
            Publisher WildcardPublishing = new("Wildcard Publishing", 4_000_000);
            Publishers.Add(WildcardPublishing);
            Publisher coffeeStainPublishing = new("Coffee Stain Publishing", 1_000_000);
            Publishers.Add(coffeeStainPublishing);
            Publisher maddyMakesGamesPublishing = new("Maddy Makes Games", 36_000_000);
            Publishers.Add(maddyMakesGamesPublishing);
            Publisher nintendo = new("Nintendo", 100_000_000);
            Publishers.Add(nintendo);
            Publisher KeenSoftwareHousePublishing = new("Keen Software House Publishing", 500_000);
            Publishers.Add(KeenSoftwareHousePublishing);
            Publisher gearbox = new("Gearbox", 5);
            Publishers.Add(gearbox);
            Publisher ninjaKiwiPublishing = new("Ninja Kiwi Publishing", 1_000_000);
            Publishers.Add(ninjaKiwiPublishing);

            // Adding Studio to Publisher
            coffeeStainPublishing.AddStudio(coffeeStainStudio);
            WildcardPublishing.AddStudio(WildcardStudio);
            gearbox.AddStudio(hopooGames);
            ninjaKiwiPublishing.AddStudio(ninjaKiwi);
            maddyMakesGamesPublishing.AddStudio(maddyMakesGamesStudio);


            // Consoles Creation
            VideoGameConsole pc = new("PC", 1500, 20, true);
            Consoles.Add(pc);
            VideoGameConsole wiiU = new("Wii U", 400, 8, true);
            Consoles.Add(wiiU);
            VideoGameConsole nSwitch = new("Switch", 400, 8, true);
            Consoles.Add(nSwitch);

            /*
             * Video Games Creation
             *  order:
             *      Create new video game
             *      Add game to studio
             *      Add game to console
             *      Add game to VideoGames
             */

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
            coffeeStainStudio.AddGame(satisfactory);
            // gmae console here
            VideoGames.Add(satisfactory);

            VideoGame celeste = new(
                title: "Celeste",
                category: "Platformer",
                year: 2018,
                playerCount: 1,
                price: 20f,
                studio: maddyMakesGamesStudio,
                consoles: new() { pc },
                publisher: maddyMakesGamesPublishing,
                ageRating: 10
                );
            maddyMakesGamesStudio.AddGame(celeste);
            // gmae console here
            VideoGames.Add(celeste);

            VideoGame ARKSurvivalEvolved = new(
                title: "ARK: Survival Evolved",
                category: "Survival",
                year: 2017,
                playerCount: 100,
                price: 20f,
                studio: WildcardStudio,
                consoles: new() { pc },
                publisher: WildcardPublishing,
                ageRating: 13
                );
            WildcardStudio.AddGame(ARKSurvivalEvolved);
            pc.AddGame(ARKSurvivalEvolved);
            VideoGames.Add(ARKSurvivalEvolved);

            VideoGame SpaceEngineers = new(
                title: "Space Engineers",
                category: "Survival",
                year: 2019,
                playerCount: 20,
                price: 22f,
                studio: WildcardStudio,
                consoles: new() { pc },
                publisher: WildcardPublishing,
                ageRating: 13
                );
            coffeeStainStudio.AddGame(SpaceEngineers);
            pc.AddGame(SpaceEngineers);
            VideoGames.Add(SpaceEngineers);

            VideoGame riskOfRain = new(
                title: "Risk of Rain",
                category: "Roguelike",
                year: 2013,
                playerCount: 4,
                price: 11f,
                studio: hopooGames,
                consoles: new() { pc },
                publisher: gearbox,
                ageRating: 13
                );
            hopooGames.AddGame(riskOfRain);
            pc.AddGame(riskOfRain);
            VideoGames.Add(riskOfRain);

            VideoGame riskOfRain2 = new(
                title: "Risk of Rain 2",
                category: "Roguelike",
                year: 2018,
                playerCount: 4,
                price: 29f,
                studio: hopooGames,
                consoles: new() { pc },
                publisher: gearbox,
                ageRating: 13
                );
            hopooGames.AddGame(riskOfRain2);
            pc.AddGame(riskOfRain2);
            VideoGames.Add(riskOfRain2);
       
            VideoGame bloonsTD6 = new(
                title: "Bloons TD 6",
                category: "Tower Defense",
                year: 2018,
                playerCount: 4,
                price: 15.49f,
                studio: ninjaKiwi,
                consoles: new() { pc },
                publisher: ninjaKiwiPublishing,
                ageRating: 9
                );
            ninjaKiwi.AddGame(bloonsTD6);
            pc.AddGame(bloonsTD6);
            VideoGames.Add(bloonsTD6);

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
            VideoGames.Add(xenoblade);

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
            VideoGames.Add(xenoblade2);

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
            VideoGames.Add(xenoblade3);

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
            monolithSoft.AddGame(xenobladeX);
            VideoGames.Add(xenobladeX);

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
            halLabs.AddGame(forgottenLand);
            VideoGames.Add(forgottenLand);


            monolithSoft.AddGame(xenoblade);
            monolithSoft.AddGame(xenoblade2);
            monolithSoft.AddGame(xenoblade3);


            nSwitch.AddGame(xenoblade);
            nSwitch.AddGame(xenoblade2);
            nSwitch.AddGame(xenoblade3);
            nSwitch.AddGame(forgottenLand);

            wiiU.AddGame(xenobladeX);

            pc.AddGame(satisfactory);
        }
    }
}