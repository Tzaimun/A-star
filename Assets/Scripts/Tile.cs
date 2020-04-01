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

    private void beginEndTile(GameObject tile, bool gameManagerTile)
    {
        GridTile tileInArray = FindTile(tile);
        
        if (gameManagerTile == false)
        {
            if (tileInArray != null)
            {
                GridTile newTile = gameManager.CreateTile(tile, tileInArray.arrayPosition);
                Instantiate(newTile.tile, newTile.position, new Quaternion(0, 0, 0, 0));
                gridCreation.gridTiles[newTile.arrayPosition.x, newTile.arrayPosition.y] = newTile;
                Destroy(gameObject);
            }
        }
    }
    
    private void OnMouseDown()
    {
        GameObject tile = gameManager.tile;

        if (tile.name == "Begin")
        {
            beginEndTile(tile, gameManager.beginTile);
            gameManager.beginTile = true;
        }
        else if (tile.name == "End")
        {
            beginEndTile(tile, gameManager.endTile);
            gameManager.endTile = true;
        }
        else if (tile.name == "Wall")
        {
            beginEndTile(tile, gameManager.wallTile);
            gameManager.amtWallTiles++;
            if (gameManager.amtWallTiles >= gameManager.tileAmountX * gameManager.tileAmountY)
            {
                gameManager.wallTile = true;
            }
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
                    //Debug.Log(tile.name + " " + gridCreation.gridTiles[i, j].tile.name);
                    return gridCreation.gridTiles[i, j];
                }
            }
        }
        return null;
        
    }
}
