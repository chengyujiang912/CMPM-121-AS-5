using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    bool haveKey = false;
    public Text doorText;
    void GotKey()
    {
        haveKey = true;
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Player") && haveKey == false)
        {
            doorText.enabled = true;
            doorText.text = "The Door is Locked";
        }
        else if (other.gameObject.CompareTag ("Player") && haveKey == true)
        {
            gameObject.GetComponent<Animation>().Play("open");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag ("Player") && haveKey == false)
        {
            doorText.enabled = false;
        }
    }
}
