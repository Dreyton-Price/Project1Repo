using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevelTrigger : MonoBehaviour
{
    public string LevelToLoad = "Level1";

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("I have found a playa");
            SceneManager.LoadScene(LevelToLoad);
        }
    }
}
