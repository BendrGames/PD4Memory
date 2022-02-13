using Memory.Models;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Memory.Views
{

    public class MemoryBoardView : ViewBaseClass<MemoryBoard>
    {
        public MemoryBoardView()
        {
        }

        protected override void Model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public void SetUpMemoryBoardView(MemoryBoard model, GameObject Tileprefab)
        {
            for (int i = 0; i < model.Tiles.Count; i++)
            {
                var tile = Instantiate(Tileprefab, new Vector3(model.Tiles[i].Row, 0, model.Tiles[i].Column), Tileprefab.transform.rotation, this.gameObject.transform);

                tile.GetComponent<TileView>().Model = model.Tiles[i];
            }

           
        }
    }
}
