using UnityEngine;
using UnityEngine.EventSystems;

public class touchRotate : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        if (!GameControl.youWin)
            transform.Rotate(0, 0, 90);
    }
}

