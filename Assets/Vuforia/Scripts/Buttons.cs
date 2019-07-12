using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    /*
    Scene 0: Loading scene
    Scene 1: Splash scene
    Scene 2: Vuforia AR scene
    Scene 3: About scene
     */

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(1);  //Loads scene 2, 'Main Menu' page
    }
    public void LoadARCamera()
    {
        SceneManager.LoadScene(2); //Loads scene 3, Vuforia AR
    }

    public void LoadAbout()
    {
        SceneManager.LoadScene(3);  //Loads scene 4, 'About' page
    }

    public void ExitApp()
    {
        Application.Quit(0);  // Exit the app
    }
}
