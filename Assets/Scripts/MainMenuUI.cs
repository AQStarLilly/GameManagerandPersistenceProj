using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 150, 30), "Start New Game"))
        {
            GameControl.control.health = 100;
            GameControl.control.experience = 0;
            GameControl.control.score = 0;
            GameControl.control.level = 1;
            GameControl.control.bond = 0;
            GameControl.control.currency = 0;

            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }

        if (GUI.Button(new Rect(10, 50, 150, 30), "Load Saved Game"))
        {
            GameControl.control.Load();
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }

        if (GUI.Button(new Rect(10, 90, 150, 30), "Go to Level 1"))
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        if (GUI.Button(new Rect(10, 130, 150, 30), "Go to Level 2"))
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        if (GUI.Button(new Rect(10, 170, 150, 30), "Go to Level 3"))
            UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }
}
