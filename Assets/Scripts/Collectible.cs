using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public ParticleSystem boom;
    private Score score;
    // Update is called once per frame
    void Start ()
    {
        score = GameObject.FindObjectOfType<Score> ();
    }
    void Update () 
    {
        transform.Rotate (new Vector3 (0, 0, 90) * Time.deltaTime);
    }
    
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ( "Player"))
        {
            Instantiate(boom, transform.position, Quaternion.identity);
            score.count = score.count - 1;
            score.SetCountText ();
            gameObject.SetActive (false);
        }
    }
}
