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

        int randomtile = Random.Range(0, _board.Tiles.Count);
        _board.Tiles[randomtile].PropertyChanged += (s,e) =>
        {
            Debug.Log(_board.Tiles[randomtile].ToString());
            Debug.Log(e.PropertyName);
        };

        InvokeRepeating("IncreasteTileID", 2, 2);

        
        _memoryBoard.SetUpMemoryBoardView(_board, _tilePrefab);
    }


    private void IncreasteTileID()
    {
        foreach (var tile in _board.Tiles)
        {
            tile.MemoryCardId++;
        }
    }
}
