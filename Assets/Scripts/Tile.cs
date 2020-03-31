using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GridCreation;

public class Tile : MonoBehaviour
{
    private GameManager gameManager;
    private GridCreation gridCreation;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gridCreation = GameObject.Find("Grid").GetComponent<GridCreation>();

    }
    /*
    private void GetArrayPosition()
    {
        for (int i = 0; i < gridCreation.tileAmountX; i++)
        {
            for (int j = 0; j < gridCreation.tileAmountY; j++)
            {

            }
        }
    }
    */
    void Update()
    {
        
    }
    /*
    private void OnMouseDown()
    {
        Debug.Log(gameObject.transform.position);
        Debug.Log(gameObject)
        GameObject tile = gameManager.tile;
        Quaternion rotation = new Quaternion(0, 0, 0, 0);
        if (tile.name == "Begin")
        {
            //FindTile(tile);
           // if (FindTile(tile, tileSimilar.position) == null)
            //{
            //    Instantiate(tile, tileSimilar.position, rotation);
            //    Destroy(gameObject);
           //     
           // }
        }
        else if (tile.name == "End")
        {

        }
        else if (tile.name == "Wall")
        {

        }
        for (int i = 0; i < gridCreation.tileAmountX; i++)
        {
            for (int j = 0; j < gridCreation.tileAmountY; j++)
            {

            }
        }
       
    }*/
    /*GridTile FindTile(GameObject tile, Vector3 position)
    {
        for (int i = 0; i < gridCreation.tileAmountX; i++)
        {
            for (int j = 0; j < gridCreation.tileAmountY; j++)
            {
                if (tile == gridCreation.gridTiles[i, j].tile)
                {
                    
                }
            }
        }
        Quaternion rotation = new Quaternion(0, 0, 0, 0);

        Instantiate(tile, gameObject.transform.position, rotation);
        Destroy(gameObject); ;
    }*/
}
