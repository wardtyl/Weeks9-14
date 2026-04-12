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
        //using lerp to trigger bomb routes
        t += Time.deltaTime;

        if(t> 1)
        {
            t = 0;
        }

        transform.position = Vector2.Lerp(start.position, end.position, t);

        //if jet is in bomb don't trigger effect
        bool isInBomb = bombRenderer.bounds.Contains(player.transform.position);
        if (isInBomb
            && wasInBomb == false)
        {
            wasInBomb = true;
            OnEnter.Invoke();
        }
        //if jet is in bomb trigger effect
        else if (!isInBomb && wasInBomb)
        {
            wasInBomb = false;
            OnLeave.Invoke();
        }

    }
}
