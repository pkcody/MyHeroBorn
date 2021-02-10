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
            GameBehavior gb = FindObjectOfType<GameBehavior>();
            PickUpHealth(gb);
        }

    void PickUpHealth(GameBehavior gb)
        {
            gb.HP += 5;
            Debug.Log("picked up health");
            Destroy(gameObject);
        }
    }
}
