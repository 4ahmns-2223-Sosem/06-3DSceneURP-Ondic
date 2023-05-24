using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CrashHealth : MonoBehaviour
{
    public int Health;
    // Start is called before the first frame update
    void Start()
    {
        Health = 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Health == 0)
        {
            SceneManager.LoadScene("CarScene");
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Debug.Log("1 Health lost");
            Health -= 1;
        }
        
    }
}
