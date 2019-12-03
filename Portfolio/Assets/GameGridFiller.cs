using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGridFiller : MonoBehaviour
{
    [SerializeField]
    private GameButtonData[] gameButtonDataArray = null;
    [SerializeField]
    private GameObject gameButtonPrefab = null;
    [SerializeField]
    private Transform gameGrid = null;

    private void Awake()
    {
        foreach (GameButtonData gameButtonData in gameButtonDataArray)
        {
            var gameButtonObj = Instantiate(gameButtonPrefab, gameGrid);
            gameButtonObj.GetComponent<GameButton>().GameButtonData = gameButtonData;
        }
    }
}
