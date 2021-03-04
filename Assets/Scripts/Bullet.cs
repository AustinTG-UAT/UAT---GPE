
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float fireSpeed;
    public float delayTime;
    [SerializeField, Tooltip("Damage to Enemies")] private float damageTaken;

    // Class Variables
    private Health damage;
    

    public void FireBullet()
    {
        
    }
    private void Start()
    {
        damage = GetComponent<Health>();
    }
    private void Update()
    {
        transform.position += transform.forward * (fireSpeed * Time.deltaTime);

        Destroy(gameObject, delayTime);
    }
    public void OnTriggerEnter(Collider other)
    {
        GameObject otherObj = other.gameObject;

        Health otherHealth = otherObj.GetComponent<Health>();
        if (otherHealth != null)
        {
            Debug.Log("Hit Target");
            otherHealth.DamageToHealth(damageTaken);
        }
    }
}
/* 
         if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("HITENEMY");
            damage.DamageToHealth(damageTaken);
        } 
 */