using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveHandler : MonoBehaviour, IUpdateSelectedHandler, IPointerDownHandler, IPointerUpHandler
{
    public bool isPressed;
    public bool isLeft;
    public PlayerController controller;

    public void OnUpdateSelected(BaseEventData data)
    {
        if (isPressed)
        {
            controller.isMoving = true;
            if (!isLeft)
            {
                controller.isLeft = false;
            }
            else
            {
                controller.isLeft = true;
            }
        }
        else
        {
            controller.isMoving = false;
        }
    }

    public void OnPointerDown(PointerEventData data)
    {
        isPressed = true;
    }
    public void OnPointerUp(PointerEventData data)
    {
        isPressed = false;
    }
}
