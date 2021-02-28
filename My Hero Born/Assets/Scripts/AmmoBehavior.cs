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
            PickUpXAmmo(eb);
        }
    }

    void PickUpXAmmo(EnemyBehavior eb)
    {
        eb.damage += 4;
        Debug.Log("Super Ammo!");
        Debug.Log(eb.gameObject.name);
        Destroy(this.transform.parent.gameObject);
    }
}
