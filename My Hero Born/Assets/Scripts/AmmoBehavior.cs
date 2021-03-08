using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBehavior : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            EnemyBehavior eb = FindObjectOfType<EnemyBehavior>();
            GameBehavior gb = FindObjectOfType<GameBehavior>();
            PickUpXAmmo(eb, gb);
        }
    }

    void PickUpXAmmo(EnemyBehavior eb, GameBehavior gb)
    {
        eb.damage += 4;
        gb.labelText = "Super Ammo! One shot destroy :)";
        Debug.Log("Super Ammo!");
        Debug.Log(eb.gameObject.name);
        Destroy(this.transform.parent.gameObject);
    }
}
