using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class CloseupTrigger : MonoBehaviour
{
    [SerializeField] GameObject _closeupCam;
    [SerializeField] GameObject _mainCam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _closeupCam.SetActive(true);
            _mainCam.SetActive(false);
            Invoke(nameof(DisableCloseupCam), 3);
        }
    }

    private void DisableCloseupCam()
    {
        _closeupCam.SetActive(false);
        _mainCam.SetActive(true);
    }
}
