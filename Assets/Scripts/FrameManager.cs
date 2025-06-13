using UnityEngine;

public class FrameManager : MonoBehaviour
{
    public int maxAmountOfFrames;
    public int currentFrame = 1;
    public bool isGameOver = false;

    public UIFrame[] listOfFrames;
    public GameManager gameManager;
    public GameObject strikeMessage, SpareMessage;

    private void Start()
    {
        currentFrame = 1;
    }

    public void NextFrame()
    {
        listOfFrames[currentFrame - 1].frameTotalScore.text = gameManager.totalScore.ToString();

        currentFrame++;
        if (currentFrame > maxAmountOfFrames)
        {
            isGameOver = true;
        }
    }

    public void UpdateFirstThrowText()
    {
        if (gameManager.firstThrowScore == 10) // Strike!
        {
            listOfFrames[currentFrame - 1].secondThrowText.text = "X";
            strikeMessage.SetActive(true);
            Invoke("ResetMessages", 3f);
        }
        else
        {
            listOfFrames[currentFrame - 1].firstThrowText.text = gameManager.firstThrowScore.ToString();
        }
    }

    public void UpdateSecondThrowText()
    {
        if (gameManager.secondThrowScore + gameManager.firstThrowScore == 10) // Spare!
        {
            listOfFrames[currentFrame - 1].secondThrowText.text = "/";
            SpareMessage.SetActive(true);
            Invoke("ResetMessages", 3f);
        }
        else
        {
            listOfFrames[currentFrame - 1].secondThrowText.text = gameManager.secondThrowScore.ToString();
        }
    }

    void ResetMessages()
    {
        strikeMessage.SetActive (false);
        SpareMessage.SetActive (false);
    }
}
