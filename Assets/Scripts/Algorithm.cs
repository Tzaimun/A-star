using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Algorithm : MonoBehaviour
{
    [SerializeField] private float g;   //Movement cost to move from the starting point to a given square on the grid.
    [SerializeField] private float h;   //Estimated movement cost to move from that given square on the grid to the final destination.
    [SerializeField] private float f;   //Sum of g and h


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
