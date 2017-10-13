using UnityEngine.SceneManagement;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    public GameObject theDeathMenu;
    public GameObject thePauseButton;
    public GameObject thePlayer;

    public void OnDeath()
    {
        thePlayer.SetActive(false);
        thePauseButton.SetActive(false);
        theDeathMenu.SetActive(true);
    }

        public void RestartGame()
    {
        thePlayer.SetActive(true);
        Time.timeScale = 1f;
        theDeathMenu.SetActive(false);
        thePauseButton.SetActive(true);
        SceneManager.LoadScene("Main");
    }

    public void ChangeSceneTo(int changeToSceneTo)
    {
        thePlayer.SetActive(true);
        Time.timeScale = 1f;
        theDeathMenu.SetActive(false);
        SceneManager.LoadScene(changeToSceneTo);
        thePauseButton.SetActive(true);
    }
}
