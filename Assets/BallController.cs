using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最小値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    //スコアを表示するテキスト
    private GameObject scoreText;

    //スコアを保存する変数
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");

        //シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("衝突"+other.gameObject.tag);
        if (other.gameObject.tag=="SmallStarTag")
        {
            score += 10;
            this.scoreText.GetComponent<Text>().text = "スコア"+score.ToString()+"pt";
        }
        if (other.gameObject.tag == "LargeStarTag")
        {
            score += 20;
            this.scoreText.GetComponent<Text>().text = "スコア" + score.ToString() + "pt";
        }
        if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 30;
            this.scoreText.GetComponent<Text>().text = "スコア" + score.ToString() + "pt";
        }
        if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 40;
            this.scoreText.GetComponent<Text>().text = "スコア" + score.ToString() + "pt";
        }

        
    }
}