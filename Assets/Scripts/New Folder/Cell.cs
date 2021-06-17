using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell
{
    // Variable type bool (true/false)
    // public bool isTaken;
    
    // Variable GameObject
    public GameObject nombre;


    // Constructeur classe Cell
    public Cell()
    {
        // Variable "element" assoiciée à un nombre aléatoire entre 1 et 5 (inclus)
        var element = Random.Range(0, 5);
        // ou
        // var element = Random.Range(0, Prefabs.Lenght) --> entre 0 et le dernier élément du tableau
        // --> à mettre dans le script principal
        


        //Associer numéro à prefabs
        if (element == 0)
        {
            nombre = GameObject.FindGameObjectWithTag("Sprite1");
        }
        else if (element == 1)
        {
            nombre = GameObject.FindGameObjectWithTag("Sprite2");
        }
        else if (element == 2)
        {
            nombre = GameObject.FindGameObjectWithTag("Sprite3");
        }
        else if (element == 3)
        {
            nombre = GameObject.FindGameObjectWithTag("Sprite4");
        }
        else
        {
            nombre = GameObject.FindGameObjectWithTag("Sprite5");
        }
        // ou
        // var prefab = prebabs[element]

        // Associer variable "coin" à la comparaison entre 1 et isTaken
        // var coin = isTaken = true;
    }
    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
