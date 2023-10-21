using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject ChestOpen;
    public GameObject Monster;


    // Start is called before the first frame update
    void Start()
    {
        ChestOpen.SetActive(false);
        Monster.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ChestOpen.SetActive(true);
            Monster.SetActive(true);
            Debug.Log("Entered Key");
        }
    }
}
