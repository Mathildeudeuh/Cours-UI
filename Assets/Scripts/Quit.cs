using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Quit : MonoBehaviour
{
    public void quitter()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
/*    void Update()
    {
        if (Input.GetButton("QUIT"))
        {
            Application.Quit();
        }
    }*/
}
