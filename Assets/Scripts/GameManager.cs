using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Pin[] pins;
    public GameObject ballPrefab;
    public int currentScore;
    public int firstThrowScore, secondThrowScore;
    public int currentThrow;
    public int totalScore;

    private FrameManager frameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        frameManager = FindAnyObjectByType<FrameManager>();
        frameManager.gameManager = this;
        currentThrow = 1;
        SpawnBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnBall()
    {
        // here could be a new throw

        if (frameManager.isGameOver == false)
        {
            Instantiate(ballPrefab, transform.position, transform.rotation);
        }
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
        if (currentThrow == 1)
        {
            firstThrowScore = currentScore;
            frameManager.UpdateFirstThrowText();
        }
        else if (currentThrow == 2)
        {
            secondThrowScore = currentScore - firstThrowScore;
            frameManager.UpdateSecondThrowText();
        }
            currentThrow++;
        if (currentThrow > 2 || currentScore == 10)
        {
            totalScore += currentScore;
            ResetFrame();
        }

        // set a new throw
    }

    public void FinishThrow()
    {
        // here could be a new throw

        Invoke("PrepareNewThrow", 3);
        Invoke("SpawnBall", 3.01f);
    }

    void ResetFrame()
    {
        currentThrow = 1;
        currentScore = 0;
        frameManager.NextFrame();

        firstThrowScore = 0;
        secondThrowScore = 0;

        foreach (Pin pin in pins)
        {
            pin.ResetPin();
        }
    }
}
