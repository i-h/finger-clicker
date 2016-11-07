using UnityEngine;
using System.Collections;
using UnityEngine.SocialPlatforms;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class GameManager : MonoBehaviour {
    public int logins;
    void Awake()
    {
        Social.localUser.Authenticate((bool success) => {
            Debug.Log("Login success: " + success + "\n" + Social.localUser.userName);
            if (success)
            {
                Debug.Log("Google username: " + Social.localUser.userName);


            }
        });
        // Google Play config 
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder()
        // enables saving game progress.
        .EnableSavedGames()
        .Build();

        Debug.Log("Google username: " + Social.localUser.userName);
        PlayGamesPlatform.InitializeInstance(config);
        // recommended for debugging:
        PlayGamesPlatform.DebugLogEnabled = true;
        // Activate the Google Play Games platform
        PlayGamesPlatform.Activate();

    }
    void Start()
    {
        Social.Active.ShowAchievementsUI();
    }
}
