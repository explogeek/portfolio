using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

[RequireComponent(typeof(Button))]
[ExecuteInEditMode]
public class GameButton : MonoBehaviour
{
    [SerializeField]
    private GameButtonData gameButtonData = null;

    private Button button;

    private void OnEnable()
    {
        if (gameButtonData != null)
           SetupButton();
    }

    private void SetupButton()
    {
        button = GetComponent<Button>();
        if (gameButtonData.GamePreviewImage != null)
            button.image = gameButtonData.GamePreviewImage;
        var buttonText = button.GetComponentInChildren<TextMeshProUGUI>();
        buttonText.text = gameButtonData.GameName;
        button.onClick.AddListener(() => SceneManager.LoadScene(gameButtonData.SceneName));
    }
}
