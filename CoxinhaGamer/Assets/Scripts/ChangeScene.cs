using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] float timer = 25.0f;
    [SerializeField] string sceneToLoad = "Scene 01";
    void Start()
    {
        StartCoroutine("changeScene");
    }

    IEnumerator changeScene()
    {
        yield return new WaitForSeconds(timer);
        SceneManager.LoadScene(sceneToLoad);
    }

}
