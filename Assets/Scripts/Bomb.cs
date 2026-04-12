using UnityEngine;
using UnityEngine.Events;

public class Bomb : MonoBehaviour
{
    private SpriteRenderer bombRenderer;
    private bool wasInBomb = false;
    public UnityEvent OnEnter;
    public UnityEvent OnLeave;
    public Transform player;

    public Transform start;
    public Transform end;
    public float t = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bombRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if(t> 1)
        {
            t = 0;
        }

        transform.position = Vector2.Lerp(start.position, end.position, t);

        bool isInBomb = bombRenderer.bounds.Contains(player.transform.position);
        if (isInBomb
            && wasInBomb == false)
        {
            wasInBomb = true;
            //WHAT WE WANT TO HAVE HAPPEN WHEN THE PLAYER ENTERS THE SENSOR
            OnEnter.Invoke();
        }
        else if (!isInBomb && wasInBomb)
        {
            wasInBomb = false;
            //WHAT WE WANT TO HAVE HAPPEN WHEN THE PLAYER EXITS THE SENSOR
            OnLeave.Invoke();
        }

    }
}
