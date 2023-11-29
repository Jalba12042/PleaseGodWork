using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryScript : MonoBehaviour
{
    [SerializeField] PauseScreen pauseScreen;

    public Transform container;
    public GameObject memFab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("mem"))
        {
            Destroy(other.gameObject);
            pauseScreen.incrementMem();
            Instantiate(memFab, container);
        }
    }
}
