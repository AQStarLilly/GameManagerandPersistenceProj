using UnityEngine;
using UnityEngine.SceneManagement;

public class TraverseScreenScript : MonoBehaviour
{
    void OnGUI()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex == 0) ? 1 : 0;

        GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height - 80, 100, 30), "Current Scene: " + (currentSceneIndex + 1));
        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height - 50, 100, 40), "Load Scene " + (nextSceneIndex + 1)))
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}