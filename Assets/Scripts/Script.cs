using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    [SerializeField] public GameObject toSpawn;
    [SerializeField] public int arraySize;

    private MyClass[] myClassInstances;
    // private MyClass myClassInstance;

    void Start()
    {
        var array = new GameObject[arraySize];
        var pos = Vector3.zero;

        /* myClassInstance = new MyClass();
         Debug.Log(myClassInstance.myText);

         for(var i = 0; i < array.Length; i++);
         {
             pos.x = i;
             array[i] = Instantiate(toSpawn, pos, Quaternion.identity);
             Debug.Log(array[0].name);
         }

         var secondArray = new Vector3[arraySize];
         for(int i = 0; i < secondArray.Length; i++); }*/
        for (int i = 0; i < myClassInstances.Length; i++)
        {
            // secondArray[i] = new Vector3(i, 0, 0);
            myClassInstances[i] = new MyClass();

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
