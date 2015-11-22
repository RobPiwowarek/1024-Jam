using UnityEngine;
using System.Collections;

public class PlayerStatistics: MonoBehaviour {
    int score = 0;
    int lives = 3;
    int horizontalSpeed = 1000;
    bool reversed = false;
    bool immune = false;
    public GameObject textScore;
    public GameObject livesScore;

    void Start()
    {
        UpdateScore(score);
        UpdateLives();
    }

    void UpdateLives()
    {
        if (lives < 0)
            lives = 0;

        livesScore.GetComponent<TextMesh>().text = "LIVES: " + lives;
    }

    public void UpdateScore(int points){
        score += points;
        textScore.GetComponent<TextMesh>().text = "SCORE: " + score;
    }

    public void Death()
    {
        //gameover etc.
        Debug.Log("GAME OVER MADAFAKA");
    }

    // returns true if player got killed
    public bool DealDamage(int amount = 1){
        if (!immune){
            lives -= amount;
            UpdateLives();
            if (lives <= 0){
                Death();
                return true;
            }
        }
        return false;
    }

    public int Lives { get; set; }
    public int HorizontalSpeed{
        get{
            if (reversed)
                return horizontalSpeed * (-1);
            else
                return horizontalSpeed;
        }
        set{lives = value;}
    }

    public bool Reversed{
        get { return reversed; }
        set { reversed = value; }
    }

    public bool Immune{
        get { return immune; }
        set { immune = value; }
    }
}
