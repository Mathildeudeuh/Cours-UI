using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciceCoroutine : MonoBehaviour
{
    //On déclare une variable numérique nommée "myInt"
    private int myInt;
    void Start()
    {
        //On appelle la fonction StartCoroutine, elle permet d'utiliser IEnumerator
        StartCoroutine(Test());

    }
    //IEnumerator permet d'utiliser un timer
    private IEnumerator Test()
    {
        while (myInt < 10)
        {
            Debug.Log(myInt += 1);
            yield return new WaitForSeconds(1);
            
        }
     

    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
