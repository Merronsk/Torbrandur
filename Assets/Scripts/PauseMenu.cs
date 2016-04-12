using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public bool isPaused;
    public Transform pauseMenu, mainMenu;

    void Update()
    {
        if (isPaused)
        {
            pauseMenu.gameObject.SetActive(true);
        }
        else
        {
            pauseMenu.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;
        }

    }

    public void Resume()
    {
        isPaused = false;
    }
    public void GraphicSettings()
    {

    }
    public void ControlSettings()
    {

    }
    public void QuitMenu()
    {
        SceneManager.LoadScene("Scene");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
