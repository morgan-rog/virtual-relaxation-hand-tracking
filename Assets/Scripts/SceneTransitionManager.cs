using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    // public string scene;

    public void GoToScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}
