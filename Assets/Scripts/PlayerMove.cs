using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float rotation;
    public Vector2 directionInput;
    public Vector2 setDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)directionInput * speed * Time.deltaTime;
        transform.right += (Vector3)setDirection * rotation * Time.deltaTime;
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        directionInput = context.action.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        setDirection = context.action.ReadValue<Vector2>();
    }
}
