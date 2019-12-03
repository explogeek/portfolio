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
    private Button button = null;
    [SerializeField]
    private TextMeshProUGUI buttonText = null;
    [SerializeField]
    private GameButtonData gameButtonData = null;
    [SerializeField]
    private Image workInProgressImage = null;

    private static Color darkColor = new Color(0.2f, 0.2f, 0.2f);

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
        button.interactable = gameButtonData.isPlayable;
        workInProgressImage.enabled = !button.interactable;
    }

    public void ShowDetails()
    {
        button.image.color = darkColor;
        buttonText.gameObject.SetActive(true);
        if (workInProgressImage.enabled)
            workInProgressImage.color = darkColor;
    }

    public void HideDetails()
    {
        button.image.color = Color.white;
        buttonText.gameObject.SetActive(false);
        if (workInProgressImage.enabled)
            workInProgressImage.color = Color.white;
    }
}
