using UnityEngine;

public class Collectable : MonoBehaviour
{
    public float scoreAdd = 100f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           // GameObject.FindWithTag("Score").GetComponent<ScoreManager>().scoreRaw += scoreAdd;
         //   Destroy(gameObject);
        }
    }
}