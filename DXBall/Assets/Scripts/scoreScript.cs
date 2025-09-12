using UnityEngine;
using TMPro; // Use this if you’re using TextMeshPro
public class scoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;
    int score =0;
    public GameObject ball;

public void addScore(int input)
    { if (input == 1){
        score=score+input;
        scoreText.text = score.ToString()+" Points";
        if (score == 5){
            winText.text = "You Win!";
            ball.SetActive(false);
        }
    }

    else if (input == 0){
        winText.text = "Game Over!";
        }
    }
}
