using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public float speed = 1.0f;
    public float scoreRaw;
    public float score ;

    private void Start()
    {
        scoreText.text = "SCORE : " + score.ToString() ;
    }
    private void Update()
    {
        scoreRaw -= Time.deltaTime * 10;
        score = Mathf.Floor(scoreRaw);
        scoreText.text = "SCORE : " + score.ToString();
    }
}

