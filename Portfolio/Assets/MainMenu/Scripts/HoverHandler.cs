using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class HoverHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private UnityEvent PointerEnterAction;
    [SerializeField]
    private UnityEvent PointerExitAction;

    public void OnPointerEnter(PointerEventData eventData)
    {
        PointerEnterAction.Invoke();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        PointerExitAction.Invoke();
    }
}
