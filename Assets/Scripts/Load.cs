using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    // Image pour le chargement
    [SerializeField] GameObject loadingScreenPrefab;

    public void LoadSceneAsync()
    {
        StartCoroutine(LoadingScreenCoroutine());
    }

    IEnumerator LoadingScreenCoroutine()
    {
        // Associer à une variable l'instance du Game Object
        var prefab = Instantiate (loadingScreenPrefab);

        // Ne pas la détruire pendant le chargement
        DontDestroyOnLoad(prefab);


        var sceneloading = SceneManager.LoadSceneAsync("Game");
        sceneloading.allowSceneActivation = false;
        while (sceneloading.isDone == false)
        {
            if(sceneloading.progress >= 0.9f)
            {
                sceneloading.allowSceneActivation = true;
                prefab.GetComponent<Animator>().SetTrigger("Disparition");
            }
            
            yield return new WaitForSeconds(2);
            //yield return null;
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
