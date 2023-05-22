﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory.Models.States
{
    class BoardFinishedState : BoardStateBaseClass
    {
        public BoardFinishedState(MemoryBoard board) : base(board)
        {
        }

        public override BoardStates State => BoardStates.Finished;

        public override void AddPreview(Tile tile)
        {

        }

        public override void TileAnimationEnd(Tile tile)
        {
          
        }
    }
}

