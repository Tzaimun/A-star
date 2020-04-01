using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Algorithm : MonoBehaviour
{
    [SerializeField] private float g;   //Movement cost to move from the starting point to a given square on the grid.
    [SerializeField] private float h;   //Estimated movement cost to move from that given square on the grid to the final destination.
    [SerializeField] private float f;   //Sum of g and h

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




    */
}
