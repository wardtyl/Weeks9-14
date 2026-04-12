using UnityEngine;
using UnityEngine.UI;
public class Damage : MonoBehaviour
{
    public Slider healthBar;
    public SpriteRenderer topDownJet;
    public SpriteRenderer pixelBomb;
    public int health = 5;
    private Vector3 bomb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthBar.maxValue = health;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 bomb = pixelBomb;
        if(topDownJet.bounds.Contains("pixelBomb") == true)
        {
            health -= -1;
        }

        healthBar.value = health;
    }
}
