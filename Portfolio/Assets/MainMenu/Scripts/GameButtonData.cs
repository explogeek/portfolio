using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Game Button Data", menuName = "Main Menu/Game Button Data")]
public class GameButtonData : ScriptableObject
{
    public string SceneName = null;
    public string GameName;
    public Image GamePreviewImage;
}
