using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Destroy : MonoBehaviour
{
    // Variable pour les contrôles
    private Controls controls;


    // Contrôles
    private void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        controls.Main.Destruction.performed += OnDestructionPerformed;
    }

    // Qaund on appuie sur la flèche de gauche, ça disparait
    private void OnDestructionPerformed(InputAction.CallbackContext obj)
    {
        // Aller à la fonction FirstInteration
        FirstIteration();
    }

    private void FirstIteration()
    {
        // Variable "myObject" (tableau de game objects) --> se réfère au tag "ToDetroy", créé dans Unity, on identifie les prefabs portant ce tag
        var prefabsToDestroy = GameObject.FindGameObjectsWithTag("ToDestroy");

        // Dans le tableau "myObject" qui contient les prefabs
        foreach (GameObject myObject in prefabsToDestroy)
            {
                // Destruction des objets portant le tag "ToDestroy"
                Destroy(myObject);
            }

    }
    void Start()
    {
    }
}