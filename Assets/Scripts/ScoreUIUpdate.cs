using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreUIUpdate : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text puckCounter;
    // Start is called before the first frame update
    void Awake()
    {
        scoreText = GetComponent<TMP_Text>();
        
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetScore(int val)
    {
        scoreText.text = "Score: " + GameManager.Instance.Score.ToString();
    }

    public void UpdatePuckCount(int val)
    {
        puckCounter.text = "Pucks: " + GameManager.Instance.Pucks.ToString();
    }
      

}
