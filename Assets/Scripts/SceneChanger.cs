using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGameScene()
    {
        Debug.Log("Loading game...");
        SceneManager.LoadScene("Bowling"); // also can use numbers of the scene
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
