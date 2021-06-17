using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleTab : MonoBehaviour
{
    // Tableau prefabs
    [SerializeField] GameObject[] prefabs;

    // Taille tableau
    [SerializeField] int lineX, lineY;

    private SecondCell[,] cellule;

    private bool gris;
    void Start()
    {
        // Tableau
        cellule = new SecondCell[lineX, lineY];
        var cell = cellule[1, 0];
        Apparition();
        Contamination();
        Instanciation();
        Couleur();
    }

    private void Apparition()
    {
        // Pour chaque ligne
        for(var i = 0; i < lineX; i++)
        {
            // Pour cahque colonne
            for(var ok = 0; ok < lineY; ok++)
            {
                // Générer sprites aléatoires
                cellule[i,ok] = new SecondCell(prefabs[Random.Range(0, prefabs.Length)]);
            }
        }
    }

    private void Contamination()
    {
        // Pour chaque cellule sauf la première et la dernière de chaque ligne
        for (var i = 1; i < lineX - 1; i++)
        {
            // Pour chaque colonne
            for (var ok = 0; ok < lineY; ok++)
            {
                // Si une deux cellules de même couleur entourent cellule de couleur différente
                if (cellule[i - 1, ok] == cellule[i + 1, ok])
                {
                    // Cellule prise en sandwich prend couleur voisines
                    cellule[i, ok].Prefab = cellule[i - 1, ok].Prefab;
                }
            }
        }
    }

    private void Instanciation()
    {
        // Variable position
        var position = Vector3.zero;

        for (var i = 0; i < lineX; i++)
        {
            for (var ok = 0; ok < lineY; ok++)
            {
                position.x = i;
                position.y = ok;
                Instantiate(cellule[i, ok].Prefab, position, Quaternion.identity);
            }
        }
    }

    private void Couleur()
    {
        for (var i = 0; i < lineX; i++)
        {
            for (var ok = 0; ok < lineY; ok++)
            {
                var element = Random.Range(0, 2);
                if (element == 0)
                {
                    gris = true;

                }
                else
                {
                    gris = false;
                }
            }
                
        }
        if (gris == true)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.grey;
        }
    }   

    void Update()
    {
        
    }
}
