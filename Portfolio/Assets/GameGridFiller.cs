using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGridFiller : MonoBehaviour
{
    [SerializeField]
    private GameButtonData[] gameButtonDataArray;
    [SerializeField]
    private GameObject gameButtonPrefab;

    private void Awake()
    {
        foreach (GameButtonData gameButtonData in gameButtonDataArray)
        {
            var gameButtonObj = Instantiate(gameButtonPrefab, this.gameObject.transform);
            gameButtonObj.GetComponent<GameButton>().GameButtonData = gameButtonData;
        }
    }

}
