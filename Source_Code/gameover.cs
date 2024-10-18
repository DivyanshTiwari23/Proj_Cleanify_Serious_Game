using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class gameover : MonoBehaviour
{   
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI coinstext;
    public TextMeshProUGUI totalcoins;
    public TextMeshProUGUI high_score;


    int coins_multiplier = 13;

    void Start()
    {   
        
        int score = FindObjectOfType<gamemanager>().score;
        int high = FindObjectOfType<metadata>().high_score;
        high = high > score ? high : score;
        FindObjectOfType<metadata>().high_score = high;
        // int tcoins, high;
        int tcoins = FindObjectOfType<metadata>().coins;
        
        scoretext.text = "Your Score : " + score.ToString();

        int coins = score*coins_multiplier;
        tcoins = tcoins + coins;
        FindObjectOfType<metadata>().coins = tcoins;
        coinstext.text = "Coins Earned : " + coins.ToString();
        // high = score;
        // tcoins = coins;
        totalcoins.text = "Total Coins : " + tcoins.ToString();
        high_score.text = "High Score : " + high.ToString();

        FindObjectOfType<metadata>().saveplayer();        
    }

    public void restart_level()
    {           
        // SceneManager.LoadScene(1);
        FindObjectOfType<gamemanager>().start_game();
    }

    public void main_menu()
    {
        SceneManager.LoadScene(0);
    }

}
