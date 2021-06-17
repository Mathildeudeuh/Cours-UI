// Générer une ligne aléatoires composée de 5 préfabs différents et de 50 éléments.
// Si un prefabs se retrouve entre deux prefabs identiques, il se transfome et prend
// l'apparence de ceux qui l'ont contaminé


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contamination : MonoBehaviour
{
    // Variable sérialisée (tableau) pour le choix des prefabs
    [SerializeField] GameObject[] Prefabs;

    // Variable sérialisée pour le nombre de prefabs sur une ligne
    [SerializeField] int lineSize;

    // Variable pour les cellules
    private Cell[] cells;

    // Variable type bool
    private bool isContaminate;

    void Start()
    {
        // Assoicier var "cells" à l'instance du tableau "Cell" --> Générer le tableau
        var cells = new Cell[lineSize];

        // Appeler les fonctions "FillArray", "ContaminateArray", "IntantiateArray"
        FillArray();
        ContaminateArray();
        InstantiateArray();
    }


    // Fonction pour remplir
    private void FillArray()
    {
        // Pour chaque variable de i = 0, tant que i est inférieur à la taille du tableau, on ajoute une cellule
        for(var i = 0; i < lineSize; i++)
        {
            // Associer cells[i] et l'instance de Cell
            cells[i] = new Cell();

            // ou
            // var element = Random.Range(0, prefabs;Length)
            // var prefab = Prefabs[element]
            // cells[i] = new Cell(prefab)


            // Dans l'instance -->
            // public GameObject Prefab;
            
            // public Cell(GameObject obj)
            //{image = obj;}
        }
    }

    // Fonction pour contaminer
    private void ContaminateArray()
    {
        // Pour chaque variable de i = 1 et tant que la pénultième cellule n'est pas atteinte, ça continue
        for (var i = 1; i < lineSize - 1; i++)
        {
            // Si la cellule précédente et la suivante continennet les mêmes prefabs
            if (cells[i - 1].nombre == cells[i + 1].nombre)
            {
                // La cellule copie le prefab de ses voisines
                isContaminate = true;
            }
        }
    }
    
    // Fonction pour transformer
    private void InstantiateArray()
    {
        // La position se trouve aux coordonnées (0,0,0)
        var pos = new Vector3(0, 0, 0);

        // Pour chaque valeur de i = 0 et tant que la taille du tableau n'est pas atteinte, ça continue
        for (var i = 0; i > lineSize; i ++)
        {
            // Associer la position du prefab à i --> Quand le numéro de la cellule augmente, la position en x aussi
            pos.x = i;

            // Si la condition "est contaminée" est respectée
            if (isContaminate == true)
            {
                // La cellule copie le prefab de la case précédente
                cells[i - 1].nombre = cells[i].nombre;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
