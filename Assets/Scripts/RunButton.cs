using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RunButton : MonoBehaviour
{
    private Button button;
    private Algorithm algorithm;
    private GameManager gameManager;

    void Start()
    {
        algorithm = GameObject.Find("GameManager").GetComponent<Algorithm>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(RunAlgorithm);
    }


    void RunAlgorithm()
    {
        gameManager.RunAlgorithm();
    }
}
