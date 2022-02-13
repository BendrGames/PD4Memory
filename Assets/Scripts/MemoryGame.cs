using Memory.Models;
using Memory.Views;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryGame : MonoBehaviour
{
    MemoryBoard _board;

    [SerializeField] private GameObject _tilePrefab;
    [SerializeField] private MemoryBoardView _memoryBoard;

    private void Start()
    {
        _board = new MemoryBoard(3, 3);

        //foreach (var item in _board.Tiles)
        //{
        //    item.PropertyChanged += (s, e) =>
        //    {
        //        item.OnPropertyChanged();
        //    };
        //}
      

        //InvokeRepeating("IncreasteTileID", 2, 2);

        
        _memoryBoard.SetUpMemoryBoardView(_board, _tilePrefab);
    }


    //private void IncreasteTileID()
    //{
    //    foreach (var tile in _board.Tiles)
    //    {
    //        tile.MemoryCardId++;
    //    }
    //}
}
