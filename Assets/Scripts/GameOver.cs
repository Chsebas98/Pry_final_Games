using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameOver : MonoBehaviour
{
    public ScoreCollector sc;
    public GameObject stop;
    public GameObject car;
    public TextMeshProUGUI hs;

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        stop.SetActive(false);
    }
    public void StopGame()
    {
        stop.SetActive(true);
        if(sc.highScore==1)
            hs.text = sc.highScore.ToString()+ " Punto";
        else 
            hs.text = sc.highScore.ToString() + " Puntos";

        DestroyImmediate(car);
    }
}
