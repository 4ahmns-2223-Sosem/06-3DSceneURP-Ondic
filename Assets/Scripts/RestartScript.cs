using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Level Restart
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        //Lobby zurücksetzten
        if(Input.GetKeyDown("l"))
        {
            //SceneManager.LoadScene();
            SceneManager.LoadScene(3);
        }
        
    }
}
