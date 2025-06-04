using UnityEngine;

public class Pin : MonoBehaviour
{
    public bool isFallen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.eulerAngles.x > 10 && transform.rotation.eulerAngles.x < 350)
        {
            isFallen = true;
        }
        else if (transform.rotation.eulerAngles.z > 10 && transform.rotation.eulerAngles.z < 350)
        {
            isFallen = true;
        }
        else
        {
            isFallen = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            Debug.Log(gameObject.name + " was hit by " + collision.collider.gameObject.name);
        }
    }
}
