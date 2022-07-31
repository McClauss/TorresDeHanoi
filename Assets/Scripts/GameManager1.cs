using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;//Publico y Estatico para que todo el mundo la pueda acceder. Se suele llamar Instance
    public int score;

    private void Awake()
    {
        if(Instance==null){
            Instance=this;
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);
        }
    }

    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1)){
            SceneManager.LoadScene("1");
        }else if(Input.GetKeyDown(KeyCode.F2)){
            SceneManager.LoadScene("2");
        }
    }

    public int GetScore(){
        return score++;
    }
}
