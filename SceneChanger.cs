using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public string sceneName = "";
    // Start is called before the first frame update\
    void OnTriggerEnter(Collider other)

    {

        EditorSceneManager.LoadScene(sceneName);

    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    
    {
        
    }
}
