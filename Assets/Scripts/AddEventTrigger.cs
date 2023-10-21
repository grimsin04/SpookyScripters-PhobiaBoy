using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AddEventTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<EventTrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
