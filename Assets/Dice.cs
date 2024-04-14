using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    public Text score;
    public Text highScore;

    //Opening High Score saved from previous launches
    //Also saved "0" as default vakue is no records 
    public void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    //Command will simulate rolling dice and generate random number from range 1,2,3,4,5,6
    //And saving high score , when "HighScore" is a variable
    public void RollDice()
    { 
        int number = Random.Range(1, 7);
        score.text = number.ToString();


        if (number > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            highScore.text = number.ToString();
        }
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
        highScore.text = "0";
    }


}
