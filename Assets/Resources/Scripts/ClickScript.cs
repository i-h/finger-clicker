using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class ClickScript : MonoBehaviour {
    public static int Score = 0;
    public Text ScoreDisplay;
    void OnMouseDown()
    {
        Score++;
        if (ScoreDisplay)
        {
            ScoreDisplay.text = Score.ToString();
        }
        if(Score == 1)
        {
            Social.Active.ReportProgress(FingerClicker.GPGSIds.achievement_first_click, 100.0f, (bool success) => {
                Debug.Log("ACHIEVEMENT POST SUCCESS: " + success);
            });
        }
    }
}
