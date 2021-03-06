﻿using FastFoodServerAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodServerAPI.Data
{
    public class GamePowerup
    {
        public string PackageName { get; private set; }
        public GamePowerupType Type { get; private set; }
        public int Amount { get; private set; }
        public int Cost { get; private set; }

        public GamePowerup(string packageName, GamePowerupType type, int amount, int cost)
        {
            this.PackageName = packageName;
            this.Type = type;
            this.Amount = amount;
            this.Cost = cost;
        }
    }
}
