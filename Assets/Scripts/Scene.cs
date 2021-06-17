using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    [SerializeField] private string SceneName;
    public void jouer()
    {
        SceneManager.LoadScene("Game");
    }
    

    void Start()
    {
       
    }

    void Update()
    {
        
    }
}
