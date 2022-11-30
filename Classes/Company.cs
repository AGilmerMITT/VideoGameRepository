﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame_Repository.Classes
{
    abstract public class Company
    {
        private static int _nextId { get; set; } = 1;
        public int Id { get; } = _nextId++;
        public string Name { get; }
        public double Income { get; private set; }

        public Company(string name, double income)
        {
            Name = name;
            Income = income;
        }
        public override string ToString()
        {
            return Name;
        }
    }

    public class Studio : Company
    {
        private HashSet<VideoGame> _videoGames { get; set; } = new();
        public HashSet<VideoGame> VideoGames { get { return _videoGames.ToHashSet(); } }

        public Studio(string name, double income) : base(name, income) { }

        public void AddGame(VideoGame game)
        {
            _videoGames.Add(game);
        }
    }

    public class Publisher : Company
    {
        private HashSet<Studio> _studios { get; set; } = new();
        public HashSet<Studio> Studios { get { return _studios.ToHashSet(); } }

        public Publisher(string name, double income) : base(name, income) { }

        public void AddStudio(Studio studio)
        {
            _studios.Add(studio);
        }
    }
}
