using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerInput : MonoBehaviour
{
    public Vector2 MoveInput { get; private set; } = Vector2.zero;
    [SerializeField]
    public bool MoveIsPressed = false;

    public Vector2 LookInput { get; private set; } = Vector2.zero;

    InputAction _input = null;

    private void OnEnable()
    {
        _input = new InputAction();
        _input.PlayerController.Enable();

        _input.PlayerController.Move.perfomed += SetMove;
        _input.PlayerController.Move.canceled += SetMove;

        _input.PlayerController.Look.perfomed += SetLook;
        _input.PlayerController.Look.canceled += SetLook;
    }

    private void OnDisable()
    {
        _input.PlayerController.Move.perfomed -= SetMove;
        _input.PlayerController.Move.canceled -= SetMove;

        _input.PlayerController.Look.perfomed -= SetLook;
        _input.PlayerController.Look.canceled -= SetLook;

        _input.PlayerController.Disable();
    }

    private void SetMove(InputAction.CallbackContext ctx)
    {
        MoveInput = ctx.ReadValue<Vector2>();
        MoveIsPressed = true;
    }
    private void SetLook(InputAction.CallbackContext ctx)
    {
        LookInput = ctx.ReadValue<Vector2>();
        MoveIsPressed = false;
    }
}
