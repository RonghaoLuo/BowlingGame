using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Pin[] pins;
    public GameObject ballPrefab;
    public int currentScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnBall()
    {
        Invoke("PrepareNewThrow", 2);
        Instantiate(ballPrefab, transform.position, transform.rotation);
    }

    void PrepareNewThrow()
    {
        foreach (Pin pin in pins)
        {
            if (pin.isFallen && pin.gameObject.activeInHierarchy)
            {
                currentScore++;
                pin.gameObject.SetActive(false);
            }
        }
    }
    public void ResetPin()
    {

    }
}
