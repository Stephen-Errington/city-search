﻿using CitySearch.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CitySearch.Services.Services
{
    public class CityResult : ICityResult
    {
        public CityResult(ICollection<string> nextCities, ICollection<string> nextLetters) {
            NextCities = nextCities;
            NextLetters = nextLetters;
        }

        public ICollection<string> NextCities { get; set; }
        public ICollection<string> NextLetters { get; set; }
    }
}