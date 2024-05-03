using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float time = 0;
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        GetComponent<Text>().text = "TIME TAKEN: " + ((int)time) + " seconds";
    }
}
