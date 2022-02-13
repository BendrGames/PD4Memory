using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Memory.Models
{
    public class PlayerModel : ModelBaseClass
    {
        private int _score;

        public int Score
        {
            get { return _score; }
            set
            {
                if (_score == value) return;
                _score = value;
                OnPropertyChanged();
            }
        }
    }
}
