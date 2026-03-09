using UnityEngine;

public class Pickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Pickup trigger entered");

            FindFirstObjectByType<ScoreUI>().IncreaseScore();

            Destroy(gameObject);
        }
    }
}
