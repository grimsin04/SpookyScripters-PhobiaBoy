using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCheck : MonoBehaviour
{
    public GameObject ChestOpen;

    void Start()
    {
        ChestOpen.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ChestOpen.SetActive(true);
            Debug.Log("We Just Collided");
        }
        
    }
}
