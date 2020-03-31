using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GridCreation;

public class GameManager : MonoBehaviour
{
    public GameObject tile;
    public Vector2 viewSize;
    public int tileAmountX;
    private int tileAmountY;
    public float pixelsPerUnit = 100.0f;
    private GridCreation gridCreation;
    private GridTile[,] gridTiles;
    private float tileSize;
    

    void Start()
    {
        gridCreation = GameObject.Find("Grid").GetComponent<GridCreation>();
        tileSize = viewSize.x / tileAmountX;
        tileAmountY = (int)System.Math.Ceiling(viewSize.y / tileSize);
        gridCreation.InitializeGrid(tile, tileAmountY, tileSize);
    }

    public class GridTile
    {
        internal GameObject tile;
        internal Vector3 position;
        internal Vector2 arrayPosition;
        internal string name;
        public GridTile(GameObject tileObject, Vector3 positionVec, Vector2 arrayPositionVec)
        {
            tile = tileObject;
            position = positionVec;
            arrayPosition = arrayPositionVec;
            name = arrayPositionVec.ToString();
        }
    }

    public GridTile CreateTile(GameObject tile, float translateTransform, Vector2 arrayPosition)
    {
        //Offsets to bottom left
        Vector2 offset = new Vector2(-0.5f * viewSize.x / pixelsPerUnit, -0.5f * viewSize.y / pixelsPerUnit);
        Vector3 position = new Vector3(offset.y + translateTransform * arrayPosition.y, offset.x + translateTransform * arrayPosition.x, 0);
        GridTile gridTile = new GridTile(tile, position, arrayPosition);
        return gridTile;
    }

    public void InstantiateFullGrid()
    {
       
    }

    public void SelectTile(GameObject tileSelected)
    {
        tile = tileSelected;
        
    }
 
}
