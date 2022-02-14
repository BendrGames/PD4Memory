using Memory.Models.States;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Memory.Models
{
    public class MemoryBoard : ModelBaseClass
    {

        private int _rows;
        public int Rows
        {
            get { return _rows; }
            set
            {
                if (_rows == value) return;
                _rows = value;
                //OnPropertyChanged();
            }
        }

        private int _columns;
        public int Columns
        {
            get { return _columns; }
            set
            {
                if (_columns == value) return;
                _columns = value;
                //OnPropertyChanged();
            }
        }

        private List<Tile> _tiles;
        public List<Tile> Tiles
        {
            get { return _tiles; }
            set
            {
                if (_tiles == value) return;
                _tiles = value;
                //OnPropertyChanged();
            }
        }

        private List<Tile> _previewingTiles;
        public List<Tile> PreviewingTiles
        {
            get { return _previewingTiles; }
            set
            {
                if (_previewingTiles == value) return;
                _previewingTiles = value;
                //OnPropertyChanged();
            }
        }

        private bool _isCombinationFound;

        public bool IsCombinationFound
        {
            get
            {
                return _isCombinationFound;
                //if 2 tiles with same image found return true;
            }

        }

        private IBoardState _state;

        public IBoardState State
        {
            get { return _state; }
            set
            {
                if (_state == value) return;
                _state = value;
                OnPropertyChanged();
            }
        }


        private PlayerModel _playermodel1;
        public PlayerModel Playermodel1
        {
            get { return _playermodel1; }
            set
            {
                if (_playermodel1 == value) return;
                _playermodel1 = value;
                OnPropertyChanged();
            }
        }

        private PlayerModel _playermodel2;
        public PlayerModel Playermodel2
        {
            get { return _playermodel2; }
            set
            {
                if (_playermodel2 == value) return;
                _playermodel2 = value;
                OnPropertyChanged();
            }
        }

        public MemoryBoard(int rows, int columns, PlayerModel player1, PlayerModel player2)
        {
            Rows = rows;
            Columns = columns;
            Playermodel1 = player1;
            Playermodel2 = player2;

            Tiles = new List<Tile>();
            PreviewingTiles = new List<Tile>();

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Tiles.Add(new Tile(i, j, this));
                }
            }

            AssignMemoryCards();

            State = new BoardNoPreviewState(this);
        }


        private void AssignMemoryCards()
        {
            for (int i = 0; i < Tiles.Count - 1; i++)
            {
                Tiles[i].MemoryCardId = i / 2;
                
            }
        }

        public override string ToString()
        {
            return $"MemoryBoard({Rows},{Columns})";
        }
    }
}


