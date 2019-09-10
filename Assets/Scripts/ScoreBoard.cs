using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour{

  public static int PlayerScore = 0;
  public static int Greys = 80;
  public static int Reds = 40;
  GameObject Ball;

  public Text scoretext;
  private static bool playerWin = false;

  void Start () {
    Ball = GameObject.FindGameObjectWithTag("Ball");
    //scoreText = GameObject.Find ("TxtScoreTop").GetComponent<Text> ();
    //scoreText.text = "Score: " + PlayerScore;
  }

  public static void Score (string brickID) {
    if (brickID == "grey"){
      Greys--;
      PlayerScore++;
    } else {
      if (Greys >= (Reds*2)){
        PlayerScore = PlayerScore+2;
      } else {
        PlayerScore++;
      }
      Reds--;
    }
    if (Greys == 0 && Reds == 0){
      playerWin = true;
    }
  }

private void update(){
  scoretext.text = "Score: " + PlayerScore;
}
}
