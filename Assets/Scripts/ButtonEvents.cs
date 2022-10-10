using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class ButtonEvents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame()
    {
        EditorSceneManager.LoadScene(1);
    }

   public void ToMenu()
    {
        EditorSceneManager.LoadScene(0);
    }
}
