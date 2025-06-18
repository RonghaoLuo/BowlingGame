using TMPro;
using UnityEngine;

public class UIGameOver : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // this executes when the game ends, since the GameOverCanvas starts at the end of the game
        scoreText.text = FindAnyObjectByType<GameManager>().totalScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
