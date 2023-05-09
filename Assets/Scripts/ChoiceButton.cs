using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChoiceButton : MonoBehaviour
{
    public bool isBicycle;
    public bool isCar;
    public GameObject bicycleZone;
    public GameObject carZone;
    // Start is called before the first frame update
    void Start()
    {
        isBicycle = false;
        isCar = false;

    }

     void Update()
    {

        if (isBicycle) 
        {
            if (Input.GetKeyDown("q"))
            {
                Debug.Log("Scene loaded 1");
                TeleportBicycle();
            }

        }

        if (isCar)
        {
            if (Input.GetKeyDown("e"))
            {
                Debug.Log("Scene loaded 2");
                TeleportCar();
            }

        }

    }
    // teleport
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGERED");

        if (other.CompareTag("Bicycle"))
        {
            Debug.Log("in Bicycle zone");
            isBicycle = true;

        }
        else if (other.CompareTag("Car"))
        {
            Debug.Log("in Car zone");
            isCar = true;
        }
    }
   void TeleportBicycle()
    {
        SceneManager.LoadScene(1);

    }
    void TeleportCar()
    {
        SceneManager.LoadScene(2);

    }

 

}
