using Steamworks;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        SteamUserStats.SetAchievement("welcomeAchievement");
    }

}
