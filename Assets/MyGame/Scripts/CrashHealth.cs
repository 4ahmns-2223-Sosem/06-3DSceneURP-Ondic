using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CrashHealth : MonoBehaviour
{
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health == 0)
        {
            SceneManager.LoadScene("CarScene");
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Debug.Log("1 Health lost");
            health -= 1;
        }
        
    }
}
