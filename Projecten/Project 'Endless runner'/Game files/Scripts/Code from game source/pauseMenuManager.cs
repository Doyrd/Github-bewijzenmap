using UnityEngine.SceneManagement;
using UnityEngine;

public class pauseMenuManager : MonoBehaviour
{

    public AudioSource buttonSound;

    public GameObject pauseMenu;
    public GameObject optionsMenu;

    public GameObject thePauseButton;
    public GameVariables gameVariables;

    public void PauseGame()
    {
        buttonSound.Play();
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        thePauseButton.SetActive(false);
    }

    public void ResumeGame()
    {
        buttonSound.Play();
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        thePauseButton.SetActive(true);
    }

    public void ChangeSceneTo()
    {
        buttonSound.Play();
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        thePauseButton.SetActive(true);
        SceneManager.LoadScene("Menu");
    }

    public void RestartGame()
    {
        buttonSound.Play();
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        thePauseButton.SetActive(true);
//        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Main");
    }

    public void OptionsMenu()
    {
        buttonSound.Play();
        Time.timeScale = 0f;
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(true);
        thePauseButton.SetActive(false);
    }

    public void BackToMenu()
    {
        buttonSound.Play();
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        optionsMenu.SetActive(false);
        thePauseButton.SetActive(false);

    }
}
