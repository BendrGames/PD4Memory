using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory.Models.States
{
    class BoardTwoFoundState : BoardStateBaseClass
    {
        public BoardTwoFoundState(MemoryBoard board) : base(board)
        {
        }

        public override BoardStates State => BoardStates.TwoFound;

        public override void AddPreview(Tile tile)
        {

        }

        public override void TileAnimationEnd(Tile tile)
        {
            Board.PreviewingTiles.Remove(tile);

            if (Board.PreviewingTiles.Count == 0)
            {
                if (Board.Tiles.Where(t => t.State.State == TileStates.Hidden).Count() < 2)
                {
                    Board.State = new BoardFinishedState(Board);
                }
                else
                {
                    Board.State = new BoardNoPreviewState(Board);
                }
            }
        }
    }
}

