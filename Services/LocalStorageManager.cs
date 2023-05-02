using Newtonsoft.Json;
using PNGTuber.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGTuber.Services
{
    public class LocalStorageManager
    {
        public static void SaveConfig()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PNGTuberSettings.json");
            string value = JsonConvert.SerializeObject(Singleton.Instance.settings);
            using (FileStream fileStream = File.Open(path, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.Write(value);
                    streamWriter.Close();
                }
            }
        }
        public static bool LoadConfig()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PNGTuberSettings.json");
            if (File.Exists(path))
            {
                Singleton.Instance.settings = JsonConvert.DeserializeObject<ConfigurationModel>(File.ReadAllText(path));
                if (!CheckIntegrity(Singleton.Instance.settings))
                    return false;
                return true;
            }
            return false;
        }
        private static bool CheckIntegrity(ConfigurationModel settings)
        {
            if (settings.Volume == 0)
                return false;
            if (settings.Amplifier == 0)
                return false;
            if (string.IsNullOrEmpty(settings.IdleImagePath))
                return false;
            if (string.IsNullOrEmpty(settings.TalkingImagePath))
                return false;

            return true;
        }
    }
}
