using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreUI : MonoBehaviour
{
    public string LevelToLoad = "Level1";
    private int Score = 0;
    [SerializeField]
    private TextMeshProUGUI text;

    public void IncreaseScore()
    {
        Score++;

        text.text = "Stars: " + Score + "/5";

        if (Score > 4)
        {
            Debug.Log("ALL STARS FOUND");
            SceneManager.LoadScene(LevelToLoad);
        }
    }
}
