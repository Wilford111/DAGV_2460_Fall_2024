using UnityEngine;
using UnityEngine.Events;

public class MouseDownBehavior : MonoBehaviour
{
    public UnityEvent mouseDownEvent;

    public Renderer rend;
    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }

    private void OnMouseEnter()
    {
        rend.material.color = Color.yellow;
    }

    private void OnMouseExit()
    {
        rend.material.color = Color.white;
    }
}
