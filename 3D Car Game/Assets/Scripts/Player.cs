using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;

    public float ms;
    public float moveInput;

    public int hp;

    private void Start()
    {
        hp = 2;
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        transform.Translate(transform.right * Time.fixedDeltaTime * ms * moveInput);
        transform.Translate(transform.forward * Time.fixedDeltaTime * ms);

    }
    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("obstacle"))
        {
            hp--;
            Destroy(other.gameObject);
            if(hp < 1)
            {
                Destroy(gameObject);
            }
        }
    }*/
}
