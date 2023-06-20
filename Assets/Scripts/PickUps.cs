using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUps : MonoBehaviour
{

    public GameObject trash1;
    public GameObject trash2;
    public GameObject trash3;
    public int scorePickUp = 0;
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
        Debug.Log("hit");
        if (other.CompareTag("Trash1"))
        {
            Debug.Log("picked trash1");
            Destroy(trash1);
            scorePickUp += 1;

        }
        else if(other.CompareTag("Trash2"))
        {
            Debug.Log("picked trash2");
            Destroy(trash2);
            scorePickUp += 2;

        }
        else if(other.CompareTag("Trash3"))
        {
            Debug.Log("picked trash3");
            Destroy(trash3);
            scorePickUp += 3;

        }

    }


}
