using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectHit : MonoBehaviour
{
    public GameObject gameplayUIPanel; // Reference to the Gameplay UI panel
    public GameObject gameWinPanel; // Reference to the Game Win panel

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (gameObject.tag == "EndCheckpoint")
            {
                // Stop time
                Time.timeScale = 0f;

                Spinner[] spinners = FindObjectsOfType<Spinner>();

                foreach (Spinner spinner in spinners)
                {
                    spinner.yAngle = 0;
                }

                // Unlock the cursor
                Cursor.lockState = CursorLockMode.None;
                // Make the cursor visible
                Cursor.visible = true;

                // Disable movement controlled by the "Mover" script
                Mover moverScript = other.gameObject.GetComponent<Mover>();

                if (moverScript != null)
                {
                    moverScript.enabled = false;
                }

                // Disable the Gameplay UI panel
                gameplayUIPanel.SetActive(false);

                // Enable the Game Win Panel
                gameWinPanel.SetActive(true);
            }
            else
            {
                GetComponent<MeshRenderer>().material.color = Color.red;

                if (gameObject.tag != "Hit")
                {
                    GameObject.Find("Cubey").GetComponent<Score>().score++;

                    GameObject.Find("Obstacles Hit").GetComponent<Text>().text = "OBSTACLES HIT: " + GameObject.Find("Cubey").GetComponent<Score>().score;
                }

                gameObject.tag = "Hit";
            }
        }
    }
}
