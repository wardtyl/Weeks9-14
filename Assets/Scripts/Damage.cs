using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class Damage : MonoBehaviour
{
    public Slider healthBar;
    public SpriteRenderer topDownJet;
    public SpriteRenderer pixelBomb;
    public int health = 5;
    public UnityEvent<float> UpdateHealthbar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthBar.maxValue = health;
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void takeDamage(float damage)
    {
        //if (topDownJet.bounds.Contains(pixelBomb) == true)
        //{
        //    health -= -1;
        //}

        healthBar.value = health;

        health -= 1;
        UpdateHealthbar.Invoke(health);


    }
}
