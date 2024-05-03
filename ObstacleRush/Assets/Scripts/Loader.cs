using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    public string sceneToLoad; // Name of the scene to load

    void Start()
    {
        // Invoke the LoadScene method after 3 seconds
        Invoke("LoadScene", 1f);
    }

    void LoadScene()
    {
        Debug.Log("test");
        // Load the specified scene
        SceneManager.LoadScene(sceneToLoad);
    }
}
