using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckCollisionControl : MonoBehaviour
{
    [SerializeField] GameObject goalParticle;
    public int scoreValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      //if the puck collides with the goal then update the score according to the goals value
      // remove the number of available pucks
      
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Puck"))
        {
            var part = Instantiate<GameObject>(goalParticle,transform);
            GameManager.Instance.IncrementScore(scoreValue);
            GameManager.Instance.Pucks--;
            //part.transform.position = gameObject.transform.position;
            Destroy(part, 2.0f);

        }
    }
}
