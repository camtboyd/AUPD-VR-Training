using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] private GameObject playerObj;

    public void LoadingScene()
    {
        SceneManager.LoadScene("LoadingScene");
    } 
    public void GameScene()
    {
        SceneManager.LoadScene("GameScene");
        //SceneManager.MoveGameObjectToScene(playerObj, SceneManager.GetSceneByName("GameScene"));
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("GameScene"));
        //playerObj.transform.position; 
    }
}
