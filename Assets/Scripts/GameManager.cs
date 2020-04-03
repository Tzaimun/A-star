using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GridCreation;


public class GameManager : MonoBehaviour
{
    public GameObject tile;
    public Vector2 viewSize;
    public int tileAmountX;
    internal int tileAmountY;
    public float pixelsPerUnit = 100.0f;
    public GridTiles gridTiles;
    private GridCreation gridCreation;
    internal float tileSize;
    private Algorithm algorithm;

    void Start()
    {
        gridCreation = GameObject.Find("Grid").GetComponent<GridCreation>();
        algorithm = gameObject.GetComponent<Algorithm>();
        tileSize = viewSize.x / tileAmountX;
        tileAmountY = (int)System.Math.Ceiling(viewSize.y / tileSize);
        gridCreation.InitializeGrid(tile, tileSize);
        
    }

    public class GridTile
    {
        internal GameObject tile;
        internal Vector3 position;
        internal Vector2Int arrayPosition;
        internal float f;
        internal float g;
        internal float h;
        public GridTile(GameObject tile, Vector3 position, Vector2Int arrayPosition)
        {
            this.tile = tile;
            this.position = position;
            this.arrayPosition = arrayPosition;
        }
        internal float F
        {
            get { return f; }
            set { f = value; }
        }
        internal float G
        {
            get { return g; }
            set { g = value; }
        }
        internal float H
        {
            get { return h; }
            set { h = value; }
        }
    }

    public class GridTiles
    {
        internal GridTile[,] tiles;
        internal GridTile begin;
        internal GridTile end;
        public GridTiles(GridTile[,] tiles)
        {
            this.tiles = tiles;
        }
        internal GridTile Begin
        {
            get { return begin; }
            set { begin = value;  }
        }
        internal GridTile End
        {
            get { return end; }
            set { end = value; }
        }
    }

    public GridTile CreateTile(GameObject tile, Vector2Int arrayPosition)
    {
        //Offsets to bottom left
        float translateTransform = tileSize / pixelsPerUnit;
        Vector2 offset = new Vector2(-0.5f * viewSize.x / pixelsPerUnit, -0.5f * viewSize.y / pixelsPerUnit);
        Vector3 position = new Vector3(offset.y + translateTransform * arrayPosition.y, offset.x + translateTransform * arrayPosition.x, 0);
        GridTile gridTile = new GridTile(tile, position, arrayPosition);

      
        return gridTile;
    }

    public void SelectTile(GameObject tileSelected)
    {
        tile = tileSelected;
        //Debug.Log(tile);
    }
    
    public void RunAlgorithm()
    {
        algorithm.AStar(gridTiles);
    }
 
}
