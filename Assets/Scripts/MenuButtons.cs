using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public string LevelToLoad = "Level1";
    public void StartGame()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
