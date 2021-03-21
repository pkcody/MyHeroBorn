using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    public GameBehavior gameManager;
  //  public AudioSource audioSource;
 //   public float volume = 0.5f;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);
          //  audioSource.PlayOneShot(audioSource.clip, volume);
            Debug.Log("Item collected!");

            gameManager.Items += 1;
            gameManager.PrintLootReport();
        }
    }
}
