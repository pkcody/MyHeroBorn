using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoostBehavior : MonoBehaviour
{
    public float JumpForce = 5f;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            Rigidbody _rb = collider.gameObject.GetComponent<Rigidbody>();
            GameBehavior gb = FindObjectOfType<GameBehavior>();
            PickUpJump(_rb, gb);
        }
    }

  
    void PickUpJump(Rigidbody _rb, GameBehavior gb)
    {
        gb.labelText = "Jump Boosted!";
        Debug.Log("Jump Boost!");
        Debug.Log(_rb.gameObject.name);
        _rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        Destroy(this.transform.parent.gameObject);
    }
}
