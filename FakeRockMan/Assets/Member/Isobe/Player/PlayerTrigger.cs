using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    [SerializeField]
    public bool st = false;
    public Vector3 vector = Vector3.zero;
    [SerializeField]
    public bool jumpTrigger = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            jumpTrigger = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            jumpTrigger = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (st)
        {
            vector = collision.contacts[0].normal;
            jumpTrigger = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (st)
        {
            vector = Vector3.zero;
            jumpTrigger = false;
        }
    }
}
