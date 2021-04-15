using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneGame : MonoBehaviour
{
    public void ChangeSceneGame()
	{
		SceneManager.LoadScene("Game");
	}
	public void ChangeSceneRulles()
    {
		SceneManager.LoadScene("Rulles");
	}
    public void ChangeSceneStart()
    {
        SceneManager.LoadScene("Start");
    }
    

    
}