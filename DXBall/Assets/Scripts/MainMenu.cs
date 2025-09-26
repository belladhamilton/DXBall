using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        // Check if the player presses the space bar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadLevel1();
        }
    }

    void OnGUI()
    {
        // Display simple instructions on screen
        GUIStyle style = new GUIStyle();
        style.fontSize = 40;
        style.alignment = TextAnchor.MiddleCenter;
        style.normal.textColor = Color.white;

        Rect rect = new Rect(0, Screen.height / 2 - 50, Screen.width, 100);
        GUI.Label(rect, "Press SPACE to Start DXBall", style);
    }

    void LoadLevel1()
    {
        // Make sure Level1 is added to Build Settings (File > Build Settings)
        SceneManager.LoadScene("Level1");
    }
}
