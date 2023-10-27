using UnityEngine;
using UnityEngine.UI;

public class PinballGame : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    private void Start()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // ボールが何かにぶつかったらポイントを加算
        if (collision.gameObject.CompareTag("Obstacle")) // Obstacleにぶつかった場合
        {
            score += 10; // ぶつかったら10ポイントを加算
            UpdateScoreText();
        }
    }

    private void UpdateScoreText()
    {
        // スコアをUIテキストに表示
        scoreText.text = "Score: " + score.ToString();
    }
}
