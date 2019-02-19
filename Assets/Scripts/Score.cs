using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text countText;
    public Text winText;
    public int count;

    void Start ()
    {
        count = 5;
        SetCountText ();
        winText.text = "";
    }

    public void SetCountText ()
    {
        countText.text = "Remaining: " + count.ToString ();
        if (count == 0)
        {
            winText.text = "You Win!";
            SceneManager.LoadScene("Menu");
        }
    }

}
