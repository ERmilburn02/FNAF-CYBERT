[System.Serializable]
public class PlayerData
{
    public int CurrentNight;
    public bool Night6Unlocked;
    public bool CustomNightUnlocked;
    public bool Beaten420;

    public PlayerData()
    {
        CurrentNight = Player.SAVE_CurrentNight;
        Night6Unlocked = Player.SAVE_Night6Unlocked;
        CustomNightUnlocked = Player.SAVE_CustomNightUnlocked;
        Beaten420 = Player.SAVE_Beaten420;
    }
}
