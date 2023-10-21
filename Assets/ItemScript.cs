using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ItemScript : MonoBehaviour
{
    public GameObject ChestOpen;

    // Start is called before the first frame update
    void Start()
    {
        ChestOpen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            ChestOpen.SetActive(true);
            Debug.Log("Entered Key");
        }
    }
}
