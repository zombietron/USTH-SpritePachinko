using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Instance
    {
        private set
        {
            if (instance != null)
            {
                Debug.LogWarning("Cannot create duplicate of: " + GameManager.instance.GetInstanceID());
                Destroy(value.gameObject);
            } 
            else
                instance = value; 
        }

        get { return instance; }
    }

    private  int score = 0;

    public  int Score
    {
        private set { score = value; }
        get { return score; }
    }

    public void IncrementScore(int amt)
    {
        score += amt;
        uiUpdate.SetScore(score);
    }

    [SerializeField] ScoreUIUpdate uiUpdate;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        GameOverUI.SetActive(false);
        SpawnPuck();
    }

    [SerializeField] Transform puckStart;
    [SerializeField] GameObject puck;

    public int Pucks
    {
        set 
        { 
            pucks = value;
            uiUpdate.UpdatePuckCount(pucks);
        }
        get { return pucks; }
    }
    private int pucks = 5;
    public void SpawnPuck()
    {
        var go = Instantiate<GameObject>(puck);
        go.transform.position = puckStart.position;
        uiUpdate.UpdatePuckCount(pucks);
    }


    public GameObject GameOverUI;
    public TMP_Text gameOverText;
    public void GameOver()
    {
        GameOverUI.SetActive(true);
        gameOverText.text = "Your Score is: " + score.ToString() + " push RESTART to try again!";
    }

    // Update is called once per frame
    void Update()
    {
        if(pucks <=0)
        {
            GameOver();
        }
    }
}
