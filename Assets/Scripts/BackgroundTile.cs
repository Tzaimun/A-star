using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTile : MonoBehaviour
{
    private Color baseColor;
    private Color mouseOverColor;


    void Start()
    {
        baseColor = GetComponent<SpriteRenderer>().material.color;
        mouseOverColor = new Color(1, 1, 1, 0.5f);
    }


    void Update()
    {

    }

    private void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().material.color = mouseOverColor;
    }
    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().material.color = baseColor;
    }

}
