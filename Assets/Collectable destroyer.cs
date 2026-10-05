using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class collectableDestroyer : MonoBehaviour
{
    public TMP_Text scoreText;
    DeathZone D;


    public float score = 100;

    public void Start()
    {
       // D = GetComponent<DeathZone>();
        scoreText.text = "SCORE : " + score.ToString();
    }

    public GameObject player;
    //much like the start() and update() methods, ontriggerenter2d is a special unity method that is called
    //by unity automatically at a specific point - in this case, when something enters the trigger attached
    //to this gameobject
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if the gameobject that has collided with our trigger is tagged with cleanup...
        if (collision.gameObject.tag == "collectable")
        {
            //then we use this method to destroy it
            Destroy(collision.gameObject);
            score += 50;
        }

        
    }
    private void Update()
    {
        score += Time.deltaTime * -10;
        scoreText.text = "SCORE : " + score.ToString();

        if (score < -5) ;
        D.deathManager.ShowDeathScreen();
    }

}