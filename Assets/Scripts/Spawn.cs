using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject Spawn1;
    [SerializeField] private GameObject Spawn2;
    [SerializeField] private GameObject Spawn3;
    [SerializeField] private GameObject Spawn4;
    [SerializeField] private GameObject Spawn5;


    private Controls controls;

    private void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        controls.Main.Spawn.performed += OnSpawnPerformed;
    }

    private void OnSpawnPerformed(InputAction.CallbackContext obj)
    {
        FirstIteration();
    }

    private void FirstIteration()
    {
        var position = new Vector3(0, 0, 0);
        Instantiate(Spawn1, position, Quaternion.identity);
        position.x++;
        Instantiate(Spawn2, position, Quaternion.identity);
        position.x++;
        Instantiate(Spawn3, position, Quaternion.identity);
        position.x++;
        Instantiate(Spawn4, position, Quaternion.identity);
        position.x++;
        Instantiate(Spawn5, position, Quaternion.identity);
        position.x++;
    }


    void Update()
    {

    }
}