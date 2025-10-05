using UnityEngine;

public class AdjustScript : MonoBehaviour
{
    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 120, 100, 30), "Health up"))
        {
            GameControl.control.health += 10;
        }
        if (GUI.Button(new Rect(10, 160, 100, 30), "Health down"))
        {
            GameControl.control.health -= 10;
        }
        if (GUI.Button(new Rect(10, 200, 100, 30), "Experience up"))
        {
            GameControl.control.experience += 10;
        }
        if (GUI.Button(new Rect(10, 240, 100, 30), "Experience down"))
        {
            GameControl.control.experience -= 10;
        }
        if (GUI.Button(new Rect(10, 280, 100, 30), "Score up"))
        {
            GameControl.control.score += 10;
        }
        if (GUI.Button(new Rect(10, 320, 100, 30), "Score down"))
        {
            GameControl.control.score -= 10;
        }
        if (GUI.Button(new Rect(10, 360, 100, 30), "Level up"))
        {
            GameControl.control.level += 1;
        }
        if (GUI.Button(new Rect(10, 400, 100, 30), "Level down"))
        {
            GameControl.control.level -= 1;
        }
        if (GUI.Button(new Rect(10, 440, 100, 30), "Bond up"))
        {
            GameControl.control.bond += 10;
        }
        if (GUI.Button(new Rect(10, 480, 100, 30), "Bond down"))
        {
            GameControl.control.bond -= 10;
        }
        if (GUI.Button(new Rect(10, 520, 100, 30), "Currency up"))
        {
            GameControl.control.currency += 10;
        }
        if (GUI.Button(new Rect(10, 560, 100, 30), "Currency down"))
        {
            GameControl.control.currency -= 10;
        }


        if (GUI.Button(new Rect(10, 680, 100, 30), "Save"))
        {
            GameControl.control.Save();
        }
        if (GUI.Button(new Rect(10, 720, 100, 30), "Load"))
        {
            GameControl.control.Load();
        }
    }
}
