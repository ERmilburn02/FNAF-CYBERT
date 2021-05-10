public static class Player
{
    public static int Night { get; set; }
    public static int CurrentTime { get; set; }
    public static int Power { get; set; }
    public static bool LeftDoorClosed { get; set; }
    public static bool RightDoorClosed { get; set; }
    public static bool CameraUp { get; set; }
    public static Room CurrentCamera { get; set; }

    public static bool RevEnabled { get; set; }
    public static bool RevInOffice { get; set; }
    public static bool MidnaEnabled { get; set; }
    public static bool MidnaInOffice { get; set; }
    public static bool TuckerEnabled { get; set; }
    public static bool TuckerInOffice { get; set; }

    public static int DanDifficulty { get; set; }
    public static bool DanInOffice { get; set; }
    public static int JerikaDifficulty { get; set; }
    public static bool JerikaInOffice { get; set; }
    public static int AlyssaDifficulty { get; set; }
    public static bool AlyssaInOffice { get; set; }
    public static int BrigetteDifficulty { get; set; }
    public static bool BrigetteInOffice { get; set; }

    public static int SAVE_CurrentNight { get; set; }
    public static bool SAVE_Night6Unlocked { get; set; }
    public static bool SAVE_CustomNightUnlocked { get; set; }
    public static bool SAVE_Beaten420 { get; set; }
}