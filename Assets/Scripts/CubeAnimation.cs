using UnityEngine;

public class CubeAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("IsCubeFlipping", Input.GetKeyDown(KeyCode.UpArrow));
        animator.SetBool("IsCubeCircling", Input.GetKeyDown(KeyCode.RightArrow));
    }
}
