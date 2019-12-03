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
    private TextMeshProUGUI buttonText;

    private static Color darkColor = new Color(0.2f, 0.2f, 0.2f);

    private void Awake()
    {
        button = GetComponent<Button>();
        buttonText = button.GetComponentInChildren<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        if (gameButtonData != null)
           SetupButton();
    }

    private void SetupButton()
    {
        if (gameButtonData.GamePreviewImage != null)
            button.image = gameButtonData.GamePreviewImage;
        buttonText.text = gameButtonData.GameName;
        button.onClick.AddListener(() => SceneManager.LoadScene(gameButtonData.SceneName));
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
