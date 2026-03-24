using UnityEditor.Build;
using UnityEngine;
using UnityEngine.InputSystem;

public class StrategyBuilder : MonoBehaviour
{
    private float Progress = 0f;
    private float destroyProgress = 0f;

    public float Duration;
    public float destroyDuration;

    public GameObject houseBuilder;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        Progress += Time.deltaTime;
       
            GameObject spawnedObject = Instantiate(houseBuilder, transform.position, Quaternion.identity);

            Destroy(spawnedObject, destroyDuration);

            Progress = 0f;
        
    }
}
