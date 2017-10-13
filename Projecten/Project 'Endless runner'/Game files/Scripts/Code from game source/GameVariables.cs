using UnityEngine;
using UnityEngine.SceneManagement;

public class GameVariables : MonoBehaviour {

    public DifficultyManager difficultyManager;
    public ManageOptions manageOptions;
    public AudioClip[] resourceClips;
    public int difficultyValue;
    public int selectedMusic;

    void Awake()
    {
        resourceClips = Resources.LoadAll<AudioClip>("Songs");
    }

    void Update()
    {   
        if(SceneManager.GetActiveScene().name == "Chooser")
        {
            difficultyValue = difficultyManager.difficultyValue;
            selectedMusic = manageOptions.musicDropDown.value;
        }
        if(SceneManager.GetActiveScene().name == "Menu")
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
