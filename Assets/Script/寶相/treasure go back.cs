using UnityEngine;
using UnityEngine.SceneManagement;

public class treasuregoback : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            SceneManager.LoadScene(0);
    }
}
