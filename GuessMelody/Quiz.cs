using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace GuessMelody
{
    static class Quiz
    {
        public static List<string> musicList = new List<string>();

        public static int gameDuration = 60;
        public static int musicDuration = 10;
        public static bool randomStart = false;
        public static string lastFolder = "";
        public static bool subFolders = false;

        public static string songName = "";

        private static string regKeyName = @"Software\Colorado\GuessMelody";

        public static void ReadMusic()
        {
            string[] inputMusicList = Directory.GetFiles(lastFolder, "*.mp3", subFolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            musicList.Clear();
            musicList.AddRange(inputMusicList);
        }

        public static void WriteParam()
        {
            RegistryKey rk = null;

            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);

                if (rk == null) 
                    return;

                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("SubFolders", subFolders);
                rk.SetValue("GameDuration", gameDuration);
                rk.SetValue("MusicDuration", musicDuration);
                rk.SetValue("RandomStart", randomStart);
            }
            finally
            {
                if (rk != null) 
                    rk.Close();
            }
        }

        public static void ReadParam()
        {
            RegistryKey rk = null;

            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);

                if (rk == null)
                    return;

                lastFolder = (string)rk.GetValue("LastFolder");
                subFolders = Convert.ToBoolean(rk.GetValue("SubFolders"));
                gameDuration = (int)rk.GetValue("GameDuration");
                musicDuration = (int)rk.GetValue("MusicDuration");
                randomStart = Convert.ToBoolean(rk.GetValue("RandomStart"));
            }
            finally
            {
                if (rk != null)
                    rk.Close();
            }
        }
    }
}
