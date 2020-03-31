using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileSelect : MonoBehaviour
{
    public GameObject tile;
    private Button button;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetTile);
    }


    void Update()
    {

    }
    void SetTile()
    {
        gameManager.SelectTile(tile);
    }
}

