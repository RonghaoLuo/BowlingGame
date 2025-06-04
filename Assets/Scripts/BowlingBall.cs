using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    [SerializeField] private Rigidbody _myRigidbody;
    [SerializeField] private float _force;
    [SerializeField] private float _moveSpeed = 1f;
    [SerializeField] private GameObject _arrow;

    private float _horizontalInput;
    private bool _isThrown;

    public GameManager manager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_isThrown) return;

        // Else if not thrown
        MoveBall();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ThrowBall();
        }
    }

    void ThrowBall()
    {
        _myRigidbody.AddForce(_arrow.transform.forward * _force, ForceMode.Impulse);
        _isThrown = true;
        _arrow.SetActive(false);

        Invoke("ResetBall", 10);
    }

    void MoveBall()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        Debug.Log(_horizontalInput);

        //myRigidbody.AddForce(transform.right * horizontalInput);
        transform.position += transform.right * _horizontalInput * Time.deltaTime * _moveSpeed;
    }

    void ResetBall()
    {
        // spawn ball
        FindAnyObjectByType<GameManager>().SpawnBall();
        Destroy(gameObject);
    }
}
