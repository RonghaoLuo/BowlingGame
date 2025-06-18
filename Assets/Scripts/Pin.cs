using UnityEngine;

public class Pin : MonoBehaviour
{
    public bool isFallen;
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    public Rigidbody myRigidbody;
    public AudioSource pinHitSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
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

            pinHitSound.pitch = Random.Range(0.7f, 1.3f);
            pinHitSound.time = 0.45f;
            pinHitSound.Play();
        }
    }

    public void ResetPin()
    {
        transform.position = originalPosition;
        transform.rotation = originalRotation;
        myRigidbody.linearVelocity = Vector3.zero;
        myRigidbody.angularVelocity = Vector3.zero;
        gameObject.SetActive(true);
    }
}
