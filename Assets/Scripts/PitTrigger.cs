using UnityEngine;

public class PitTrigger : MonoBehaviour
{
    public GameManager manager;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " entered the pit"); 
        if (other.gameObject.CompareTag("Player"))
        {
            // where ball needs respawn
            manager = FindAnyObjectByType<GameManager>();
            if (manager != null)
            {
                manager.SpawnBall();
            }

            Destroy(other.gameObject);
            Debug.Log(other.gameObject.name + " is destroyed");
        }
    }
}
