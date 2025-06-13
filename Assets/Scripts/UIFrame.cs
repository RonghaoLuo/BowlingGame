using UnityEngine;
using TMPro;

public class UIFrame : MonoBehaviour
{
    public TextMeshProUGUI frameNumber;
    public TextMeshProUGUI firstThrowText;
    public TextMeshProUGUI secondThrowText;
    public TextMeshProUGUI frameTotalScore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        frameNumber.text = (transform.GetSiblingIndex() + 1).ToString();
        firstThrowText.text = "";
        secondThrowText.text = "";
        frameTotalScore.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
