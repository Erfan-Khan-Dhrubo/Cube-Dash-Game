using TMPro;
using UnityEngine;

public class newScore : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text playerScoreTextFinal;
    public bool playerDead = false;

    private float _temp = 0;
    

    // Update is called once per frame
    void Update()
    {
        if (!playerDead)
        {
            _temp += 10 * Time.deltaTime;
            scoreText.text = _temp.ToString("0");
            playerScoreTextFinal.text = "Your Score:" + _temp.ToString("0");
        }
    }
}
