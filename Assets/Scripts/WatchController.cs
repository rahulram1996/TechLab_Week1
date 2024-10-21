using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WatchController : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI time;
    [SerializeField] private Button scoreButton;

    [SerializeField] CanvasGroup scorePanel;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private float score;

    public static WatchController instance;

    private void Awake()
    {
        instance = this; 
    }

    private void Update()
    {
        time.text = System.DateTime.Now.ToString("hh:mm:ss");
    }

    public void ShowScore() 
    {
        StartCoroutine(Show());
    }

    public IEnumerator Show()
    {
        scorePanel.alpha = 1;
        yield return new WaitForSeconds(4);
        scorePanel.alpha = 0;
    }


    public void UpdateScore(float value)
    {
        score += value;
        scoreText.text = score.ToString();
    }

    public void ResetShootingExperience()
    {
        score = 0;
        scoreText.text = score.ToString();
    }
}
