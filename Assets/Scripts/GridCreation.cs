using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Math;
using static GameManager;
using static GameManager.GridTile;

public class GridCreation : MonoBehaviour

{
    public List<GameObject> Prefabs; //Background, Begin, End, Path, Wall
    private GameManager gameManager;
    private float pixelsPerUnit;
    internal GridTile[,] gridTiles;
   

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        pixelsPerUnit = gameManager.pixelsPerUnit;
        Debug.Log("hey");
    }


    void Update()
    {
        
    }

    public void InitializeGrid(GameObject tile, int tileAmountY, float tileSize)
    {
        //Calculate tileSize to be able to scale the tile correctly.
        //translateTransform makes it possible to get the distance in units between two points.
        ;
        //Scale transform makes it possible to get the resized scale in units.
        float scaleTransform = tileSize / (tile.GetComponent<BoxCollider2D>().size.x * 100);
        tile.transform.localScale = new Vector3(scaleTransform, scaleTransform, scaleTransform);
        //Get the amount of tiles on the y. Math.Ceiling rounds an float to the next integer.

        //Initialize the GameObject array and make it the size of the amount of tiles.
        gridTiles = new GridTile[gameManager.tileAmountX, tileAmountY];
        for (int i = 0; i < gameManager.tileAmountX; i++)
        {
            for (int j = 0; j < tileAmountY; j++)
            {
                //Get a new gridTile, add it to the gridTiles array.
                Vector2 arrayPosition = new Vector2(i, j);
                GridTile gridTile = gameManager.CreateTile(tile, arrayPosition);
                Instantiate(gridTile.tile, gridTile.position, new Quaternion(0, 0, 0, 0));
                gridTiles[i, j] = gridTile;
            }
        }
    }
    
}

