using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public TurnController turnController;
    public CanvasGroup canvasGroup;

    public void EnableAction(bool isEnable = true)
    {
        canvasGroup.interactable = isEnable;
    }
}
