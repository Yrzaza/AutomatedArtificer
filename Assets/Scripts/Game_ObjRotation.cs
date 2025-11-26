using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Game_ObjRotation : MonoBehaviour
{
    #region InputSystem
    //Cache action map
    [SerializeField] private InputActionAsset _action;

    public InputActionAsset action
    {
        get => _action;
        set => _action = value;

    }
    
    protected InputAction RightClickPressedInputAction { get; set; }

    protected InputAction MouseLookInputAction { get; set; }
    #endregion

    #region Variables
    //rotate only when right click is pressed
    private bool _rotateAllowed;
    private Camera _camera;
    //get rotation and if inverted
    [SerializeField] private float _speed;
    [SerializeField] private bool _inverted;
    #endregion


    //function to call on awake before start
    private void Awake()
    {
        InitializeInputSystem();
    }

    private void Update()
    {
        //check if rotate is allowed so you dont fucking blow up your pc
        if (!_rotateAllowed)
            return;

        //cache mouse because its important i guess
        Vector2 MouseDelta = GetMouseLookInput();

        MouseDelta *= _speed * Time.deltaTime;

        transform.Rotate(Vector3.up * (_inverted ? 1 : -1), MouseDelta.x, Space.World);
        transform.Rotate(Vector3.right * (_inverted ? -1 : 1), MouseDelta.y, Space.World);


    }





    private void InitializeInputSystem()
    {
        RightClickPressedInputAction = action.FindAction("Right Click");
        if (RightClickPressedInputAction != null)
        {
            //da things we wanna check for
            RightClickPressedInputAction.started += OnRightClickPressed;
            RightClickPressedInputAction.performed += OnRightClickPressed;
            RightClickPressedInputAction.canceled += OnRightClickPressed;
        }
        MouseLookInputAction = action.FindAction("Mouse Look");
        //enable input action
        action.Enable();
    }
    
    protected virtual void OnRightClickPressed(InputAction.CallbackContext context)
    {
        if (context.started || context.performed)
            //let the fuckin thing rotate if theyre pressed
            _rotateAllowed = true;
        else if (context.canceled)
            _rotateAllowed = false;
    }
    protected virtual Vector2 GetMouseLookInput()
    {
        //get the location of the mouse
        if (MouseLookInputAction != null)
            return MouseLookInputAction.ReadValue<Vector2>();
        
        return Vector2.zero;
    }
}
