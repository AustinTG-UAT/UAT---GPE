using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [Header("IK Points")]
    public Transform rightHandPoint;
    public Transform leftHandPoint;

    public GameObject bulletPF;
    public Transform bulletStart;

    // Start is called before the first frame update
    public virtual void Start()
    {
        
    }

    // Update is called once per frame
    public virtual void Update()
    {
        
    }
    public void FireBullet()
    {
        GameObject bullet = Instantiate(bulletPF, bulletStart.position, bulletStart.rotation) as GameObject;
        Debug.Log("FIRED");
    }
}
