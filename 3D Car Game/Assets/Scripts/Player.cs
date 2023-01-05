using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float ms;
    public float moveInput;

    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        transform.Translate(transform.right * Time.fixedDeltaTime * ms * moveInput);
        transform.Translate(transform.forward * Time.fixedDeltaTime * ms);
    }
}
