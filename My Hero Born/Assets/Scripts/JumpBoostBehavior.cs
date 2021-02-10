using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoostBehavior : MonoBehaviour
{
    public float JumpForce = 500f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Rigidbody _rb = collision.gameObject.GetComponent<Rigidbody>();
            PickUpJump(_rb);
        }
    }

  
    void PickUpJump(Rigidbody _rb)
    {
        Debug.Log("Jump Boost!");
        Debug.Log(_rb.gameObject.name);
        _rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        Destroy(gameObject);
    }
}
