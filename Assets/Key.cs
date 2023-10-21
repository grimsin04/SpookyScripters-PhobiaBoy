using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject key;
    public GameObject invisibleWall;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            key.SetActive(false);
            invisibleWall.SetActive(false);
            Debug.Log("Entered Key");
        }
    }
}
