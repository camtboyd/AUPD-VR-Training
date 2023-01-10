using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] private GameObject playerObj;
    [SerializeField] private GameObject belt;


    public delegate void ChangeScene();
    public static event ChangeScene OnChange;


    public void LoadingScene()
    {
        SceneManager.LoadScene("LoadingScene");
    } 
    public void GameScene()
    {
        SceneManager.LoadScene("GameScene");
        DontDestroyOnLoad(belt);
        OnChange();
    }
}
