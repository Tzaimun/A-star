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

    private GridTile validTile(GameObject tile, GridTile gameManagerTile, bool isBeginEnd = false)
    {
        GridTile tileInArray = FindTile(tile);
        //Debug.Log(gameManagerTile);
        if (gameManagerTile == null)
        {
            if (tileInArray != null)
            {
                GridTile newTile = gameManager.CreateTile(tile, tileInArray.arrayPosition);
                Instantiate(newTile.tile, newTile.position, new Quaternion(0, 0, 0, 0));
                gridCreation.gridTiles[newTile.arrayPosition.x, newTile.arrayPosition.y] = newTile;
                Debug.Log(gameObject.name);
                if (gameObject.name == "Begin(Clone)")
                {
                    gameManager.gridTiles.begin = null;
                }
                else if (gameObject.name == "End(Clone)")
                {
                    gameManager.gridTiles.end = null;
                }
                Destroy(gameObject);
                return newTile;
            }
        }
        return null;
    }

    
    
    private void OnMouseDown()
    {
        GameObject tile = gameManager.tile;

        if (tile.name == "Begin")
        {
            //Debug.Log(gameManager.gridTiles.begin);
            GridTile beginTile = validTile(tile, gameManager.gridTiles.begin, true);
            if (beginTile != null)
            {
                gameManager.gridTiles.begin = beginTile;
            }
        }
        else if (tile.name == "End")
        {
            GridTile endTile = validTile(tile, gameManager.gridTiles.end, true);
            if (endTile != null)
            {
                gameManager.gridTiles.end = endTile;
            }
        }
        else if (tile.name == "Wall")
        {
            validTile(tile, null);
        }
        else if (tile.name == "Background")
        {
            validTile(tile, null);
        }
       
    }
    GridTile FindTile(GameObject tile)
    {
        for (int i = 0; i < gameManager.tileAmountX; i++)
        {
            for (int j = 0; j < gameManager.tileAmountY; j++)
            {
                if (gameObject.transform.position == gridCreation.gridTiles[i, j].position)
                {
                    Debug.Log(gridCreation.gridTiles[i, j].arrayPosition);
                    return gridCreation.gridTiles[i, j];
                }
            }
        }
        return null;
        
    }
}
