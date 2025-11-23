using UnityEngine;

public class touchRotate : MonoBehaviour
{
    void OnMouseDown()
    {
        if (!GameControl.youWin)
            transform.Rotate(0, 0, 90);
    }
}
