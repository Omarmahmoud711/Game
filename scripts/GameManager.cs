using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
public bool GameEnded=false;
public GameObject levelcompletescreen;


public void LevelComplete(){


levelcompletescreen.SetActive(true);

}

  public void EndGame(){
    if(GameEnded==false){
    GameEnded=true;
    Debug.Log("GameOver");
    Invoke("Restart",2f);
  }}

  void Restart(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

  }
}
