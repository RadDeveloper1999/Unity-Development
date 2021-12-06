using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public GameObject gameOverUI;
//   private bool isDead = false;


    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){
            restart();
        }    
    }

/*
    public void func(){
        isDead = true;
    }
*/
    public void restart(){

        SceneManager.LoadScene("SampleScene");
    }
}
