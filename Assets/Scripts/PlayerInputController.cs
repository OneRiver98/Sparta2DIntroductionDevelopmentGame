using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{
    public void OnMove(InputValue value)
    {
        Vector2 moveInputValue = value.Get<Vector2>();
        CallMoveEvent(moveInputValue);
    }
}
