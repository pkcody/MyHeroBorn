using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehavior : MonoBehaviour
{
    public float addHealth = 5;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {

            PickUpHealth();
        }

    void PickUpHealth()
        {
            Debug.Log("picked up health");
        }
    }
}
