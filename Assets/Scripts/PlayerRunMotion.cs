using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunMotion : MonoBehaviour
{
    // Allows User/Game Designer to change speed value in the inspector \\ Unity Program
    [SerializeField, Tooltip("The max speed of the player")]
    private float speed = 4f;

    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        input = Vector3.ClampMagnitude(input, 1f);
        input *= speed;
        anim.SetFloat("Horizontal", input.x);
        anim.SetFloat("Vertical", input.z);
    }
}
