using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public int score = 0;

    private void OnCollisionEnter(Collision other)
    {
        GameObject.Find("Obstacles Hit").GetComponent<Text>().text = "OBSTACLES HIT: " + score;
    }

    void Start()
    {
        GameObject.Find("Obstacles Hit").GetComponent<Text>().text = "OBSTACLES HIT: " + 0;
    }
}
