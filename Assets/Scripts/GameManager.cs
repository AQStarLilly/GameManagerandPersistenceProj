using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static int instanceCount = 0;

    [Header("Testing")]
    [Tooltip("If true, Singleton is disabled and multiple GameManagers can exist.")]
    [SerializeField] private bool disableSingletonInspector = false;
    public static bool disableSingleton = false;


    void Awake()
    {
        if(instanceCount == 0)
        {
            disableSingleton = disableSingletonInspector;
        }

        if (disableSingleton)
        {
            //Test mode
            instanceCount++;
            DontDestroyOnLoad(gameObject);
            Debug.Log("[GameManager] Created new instance (Singleton disabled). Count = " + instanceCount);
        }
        else
        {
            //Normal Singleton
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
                instanceCount++;
                Debug.Log("[GameManager] Singleton instance created. Count = " + instanceCount);
            }
            else if (Instance != this)
            {
                Destroy(gameObject);
                Debug.Log("[GameManager] Duplicate destroyed (Singleton enabled).");
            }
        }      
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) SceneManager.LoadScene(0); // Main Menu
        if (Input.GetKeyDown(KeyCode.Alpha2)) SceneManager.LoadScene(1); // Level 1
        if (Input.GetKeyDown(KeyCode.Alpha3)) SceneManager.LoadScene(2); // Level 2
        if (Input.GetKeyDown(KeyCode.Alpha4)) SceneManager.LoadScene(3); // Level 3
    }

    void OnGUI()
    {
        GUI.Label(new Rect(200, 10, 200, 30), "GameManagers: " + instanceCount);
        GUI.Label(new Rect(200, 25, 200, 30), "Singleton Disabled: " + disableSingleton);
        GUI.Label(new Rect(200, 40, 200, 30), "Current Scene: " + SceneManager.GetActiveScene().name);
    }
}
