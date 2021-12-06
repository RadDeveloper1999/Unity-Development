using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public float scoreMultiplier;
    private float score;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        score += scoreMultiplier * Time.deltaTime;
        scoreText.text = score.ToString("0.00");
    }
}
