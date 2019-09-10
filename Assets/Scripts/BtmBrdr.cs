using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtmBrdr : MonoBehaviour{

  public GameObject GameOver;
    private void OnTriggerEnter2D(Collider2D collision){
            GameOver.SetActive(true);
    }


}
