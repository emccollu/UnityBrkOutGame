using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadGame : MonoBehaviour {

  public void LoadScene(string sceneName){
    SceneManager.LoadScene(sceneName);
  }
  public void RestartGame() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
	public void quitButton () {
		Application.Quit ();
	}
}

/*
Unity 2d 2019 Breakout Game
  - Bricks scarlet & grey spelling unlv
  - When scarlett is hit and there remains 2* as many greys, 2pts
  - Game has :
      - Student Name
      - Start Button
      - Finish Button
      - Score
      - Win or lose decision
      - How many Greys & Scarletts left


*/
