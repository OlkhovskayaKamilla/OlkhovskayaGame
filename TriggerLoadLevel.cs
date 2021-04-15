using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerLoadLevel : MonoBehaviour
{
    public GameObject FinishPage;
    public GameObject StartPage;
    public GameObject Camera;
    public GameObject Camera2;
    public GameObject FinishCamera;
    public int score = 0;
    public static int bestscore = 451;
    public Text txt;

    private void Start()
    {
        FinishPage.SetActive(false);
        StartPage.SetActive(true);
        Camera.SetActive(true);
        Camera2.SetActive(true);
        FinishCamera.SetActive(false);

    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            FinishPage.SetActive(true);
            StartPage.SetActive(false);
            Camera.SetActive(false);
            Camera2.SetActive(false);
            FinishCamera.SetActive(true);

            score = GameObject.Find("SHONDi").GetComponent<PlayerMovement>().score;
            if (bestscore > score)
            {
                bestscore = score;
            }

        }
    }

    private void Update()
    {
        txt.text = "Best score: " + bestscore;
    }
}
