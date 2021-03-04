using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{   
    // player health
    [SerializeField, Tooltip("Max Health Pawn can have.")] private float maxHealth;
    [SerializeField, Tooltip("Initial, Starting Health Pawn has.")] private float initialHealth;
    private float currentHealth;
    private float deciHealth;
    // player damage
    private float damage;
    private float damageTaken;
    // Pickup healing 
    private float healHealth;



    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if(initialHealth > maxHealth)
        {
            initialHealth = maxHealth;
        }
        if(initialHealth <= 0)
        {
            OnDeath();
        }
    }
    public float HealthPercent()
    {
        deciHealth = initialHealth / maxHealth;
        return deciHealth;
    }
    public void AddHealth(float healing)
    {
        initialHealth = initialHealth + healing;
        Debug.Log(initialHealth);
    }
    public void DamageToHealth(float damage)
    {
        initialHealth = initialHealth - damage;
        Debug.Log("HealthTaken" + initialHealth);
    }
    public void OnDeath()
    {
        Destroy(gameObject);
    }
}
