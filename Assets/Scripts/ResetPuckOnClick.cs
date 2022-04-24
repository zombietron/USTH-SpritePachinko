using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResetPuckOnClick : MonoBehaviour
{


    public void ResetPuck()
    {
        var puck = GameObject.FindGameObjectWithTag("Puck");
        Destroy(puck);
        GameManager.Instance.SpawnPuck();
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
