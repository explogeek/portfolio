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
    public GameButtonData GameButtonData { get => gameButtonData; set => SetupButton(value); }

    [SerializeField]
    private Button button;
    [SerializeField]
    private TextMeshProUGUI buttonText;

    private static Color darkColor = new Color(0.2f, 0.2f, 0.2f);
    private GameButtonData gameButtonData;

    private void OnEnable()
    {
        if (GameButtonData != null)
           SetupButton(GameButtonData);
    }

    private void SetupButton(GameButtonData gameButtonData)
    {
        this.gameButtonData = gameButtonData;
        if (GameButtonData.GamePreviewImage != null)
            button.image = GameButtonData.GamePreviewImage;
        buttonText.text = GameButtonData.GameName;
        button.onClick.AddListener(() => SceneManager.LoadScene(GameButtonData.SceneName));
        HideDetails();
    }

    public void ShowDetails()
    {
        button.image.color = darkColor;
        buttonText.gameObject.SetActive(true);
    }

    public void HideDetails()
    {
        button.image.color = Color.white;
        buttonText.gameObject.SetActive(false);
    }
}
