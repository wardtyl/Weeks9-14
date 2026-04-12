using UnityEngine;
using UnityEngine.InputSystem;

public class ControlScript : MonoBehaviour
{
    public float speed;
    public Vector2 directionalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //allows plane to move at set speed
        transform.position += (Vector3)directionalInput * speed * Time.deltaTime;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        //player input and unity events allow movement
        directionalInput = context.ReadValue<Vector2>();
    }
}
