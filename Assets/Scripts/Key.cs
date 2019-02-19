using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject Door;
    
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Player"))
        {
            Door.SendMessage("GotKey");
            
            gameObject.SetActive(false);
        }
    }
}
