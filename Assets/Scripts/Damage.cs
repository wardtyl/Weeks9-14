using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class Damage : MonoBehaviour
{
    public Slider healthBar;
    public int health = 5;
    public UnityEvent<float> UpdateHealthbar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //establisahes starting health value
        healthBar.maxValue = health;
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void takeDamage(float damage)
    {
        //when event invoked trigger negative health
        healthBar.value = health;

        health -= 1;
        UpdateHealthbar.Invoke(health);
    }
}
