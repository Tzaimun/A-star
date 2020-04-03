using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameManager;

public class Algorithm : MonoBehaviour
{

    private bool endReached;
    private List<GridTile> open = new List<GridTile>();
    private List<GridTile> closed = new List<GridTile>();
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    
    public void AStar(GridTiles gridTiles)
    {
        Debug.Log(gridTiles.begin);
        if (gridTiles.begin != null)
        {
            Debug.Log(gridTiles.begin);
            open.Add(gridTiles.begin);
        }
        
        while (!endReached)
        {
            GridTile lowestF = open[0];
            if (lowestF == gridTiles.end)
            {
                return;
            }
            else
            {
                List<GridTile> neighbours = FindNeighbours(lowestF.arrayPosition, gridTiles);
                foreach (GridTile i in neighbours)
                {
                    Debug.Log(i.arrayPosition);
                }
                
            }
            break;
        }
    }

    private List<GridTile> FindNeighbours(Vector2Int baseArrayPosition, GridTiles gridTiles)
    {
        List<GridTile> neighbourTiles = new List<GridTile>();
        neighbourTiles.Add(gridTiles.tiles[baseArrayPosition.x--, baseArrayPosition.y]);
        neighbourTiles.Add(gridTiles.tiles[baseArrayPosition.x, baseArrayPosition.y++]);
        neighbourTiles.Add(gridTiles.tiles[baseArrayPosition.x++, baseArrayPosition.y]);
        neighbourTiles.Add(gridTiles.tiles[baseArrayPosition.x, baseArrayPosition.y--]);
        return neighbourTiles;
    }
    //On a square grid that allows 8 directions of movement, use Diagonal distance (L∞).
    /*
     * Diagonal distance
     * function heuristic(node) =
        dx = abs(node.x - goal.x)
        dy = abs(node.y - goal.y)
     return D * (dx + dy) + (D2 - 2 * D) * min(dx, dy)
     * When D = 1 and D2 = 1, this is called the Chebyshev distance.
     * Break ties Heuristic:
     * heuristic *= (1.0 + p)
     * P = (minimum cost of taking one step)/(expected maximum path length). Max path length = ((2*tileX-2)+2*tileY)
     * Andere manier van breaking the ties
     * Astar itself: f(n)=g(n)+h(n)
    */
    /*
     * Manhatten heuristic:
     * h=∣xstart​−xdestination​∣+∣ystart​−ydestination​∣
     */

}
