using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace BilotApp
{
    public class ItemGrid
    {
        public int[] score;

        public ItemGrid(int player_nr)
        {
            score = new int[player_nr];
        }
    }
}
