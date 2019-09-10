using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

  public string BrickType;

    void OnCollisionEnter2D(Collision2D collisionInfo) {
        Destroy(gameObject);
        ScoreBoard.Score(BrickType);
    }


}
