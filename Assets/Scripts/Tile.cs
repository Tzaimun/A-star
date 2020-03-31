using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameManager;

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
    
    private void OnMouseDown()
    {
        Debug.Log(gameObject.transform.position);
        Debug.Log(gameObject);
        GameObject tile = gameManager.tile;
        Quaternion rotation = new Quaternion(0, 0, 0, 0);
        if (tile.name == "Begin")
        {
            GridTile tileInArray = FindTile(tile);
            Debug.Log(tileInArray);
            if (tileInArray != null)
            {
                GridTile newTile = gameManager.CreateTile(tile, tileInArray.arrayPosition);
                //Debug.Log(newTile);
                Destroy(gameObject);
            }
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
       
    }
    GridTile FindTile(GameObject tile)
    {
        for (int i = 0; i < gameManager.tileAmountX; i++)
        {
            for (int j = 0; j < gameManager.tileAmountY; j++)
            {
                if (tile.name == gridCreation.gridTiles[i, j].tile.name)
                {
                    Debug.Log("null because name equals");
                    return null;
                }
                Debug.Log(tile.transform.position + " " + gridCreation.gridTiles[i, j].position);
                Debug.Log(tile.transform.position.x.GetType());
                Debug.Log(gridCreation.gridTiles[i, j].position.x.GetType());
                if (tile.transform.position == gridCreation.gridTiles[i, j].position)
                {
                    Debug.Log("not null");
                    return gridCreation.gridTiles[i, j];
                }
            }
        }
        Debug.Log("null because end loops");
        return null;
        
    }
}
