using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMove : MonoBehaviour
{
    public float speed;
    public Vector2 directionInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)directionInput * speed * Time.deltaTime;
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        directionInput = context.action.ReadValue<Vector2>();
    }
}
