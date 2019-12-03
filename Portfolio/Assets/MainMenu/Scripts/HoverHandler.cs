using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class HoverHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private UnityEvent PointerEnterAction = null;
    [SerializeField]
    private UnityEvent PointerExitAction = null;

    public void OnPointerEnter(PointerEventData eventData)
    {
        PointerEnterAction.Invoke();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        PointerExitAction.Invoke();
    }
}
