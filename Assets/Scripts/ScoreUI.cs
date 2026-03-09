using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
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
        }
    }
}
