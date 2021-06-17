using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Boucles : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabsToSpawn;
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
        foreach (var prefab in prefabsToSpawn)
        {
            Instantiate(prefab);
        }
    }
    private void SecondIteration()
    {
        var i = 0;
        var position = Vector3.zero;
        while (i < prefabsToSpawn.Length)
        {
            position.x = i;
            Instantiate(prefabsToSpawn[i], position, Quaternion.identity);
            i++;
        }
    }
    private void ThirdIteration()
    {
        // Déplacer objet
        var position = Vector3.zero;

        // Pour chaque valeur de i = 0, tant que 1<taille du tableau, on ajoute 1
        for (var i = 0; i < prefabsToSpawn.Length; i++)
        {
            // On déplace l'objet de 1 m vers la droite
            position.x = i;
            Instantiate(prefabsToSpawn[i], position, Quaternion.identity);
        }
        for (var i = 0; i < 50; i++)
        {
            Debug.Log(position[i]);
        }
    }
    // Start is called before the first frame update
    void Start()
        {
        
        }

    // Update is called once per frame
    void Update()
    {
        
    }
    

}

