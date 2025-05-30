using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WWHDHacker.Properties;

namespace WWHDHacker
{
    public class ConfigObject
    {
        public static ConfigObject config;

        static string defaultWiiuIP = "192.168.";
        static bool defaultWarningBeforeRuns = true;
        static bool defaultDisplayMacros = true;
        static Dictionary<string, JsonInput> defaultMacros = new Dictionary<string, JsonInput>(){
               { "levitate", new JsonInput((int)InputEnum.L, value:64f)},
               { "doorCancel", new JsonInput((int)InputEnum.DpadLeft)},
               { "superswim", new JsonInput((int)InputEnum.DpadRight, value:500f)},
               { "storage", new JsonInput((int)InputEnum.DpadDown)},
               { "masterkey", new JsonInput((int)InputEnum.ZR)},
               { "storePosition", new JsonInput((int)InputEnum.DpadRight, masterkey:true)},
               { "restorePosition", new JsonInput((int)InputEnum.DpadLeft, masterkey:true)},
               { "reloadRoom", new JsonInput((int)InputEnum.DpadDown, masterkey:true)},
               { "refillMagic", new JsonInput((int)InputEnum.R, masterkey:true)},
               { "refillHealth", new JsonInput((int)InputEnum.L, masterkey:true)},
               { "refillAmmo", new JsonInput((int)InputEnum.DpadUp, masterkey:true)},
               { "windDirection", new JsonInput((int)InputEnum.L3)},
        };
        static Dictionary<string, Stage> defaultFavorites = new Dictionary<string, Stage>();

        public string wiiuIP;
        public bool warningBeforeRuns;
        public bool displayMacros;
        public Dictionary<string, JsonInput> macros;
        public Dictionary<string, Stage> favorites;

        public ConfigObject(string wiiuIP = "", bool warningBeforeRuns = true, bool displayMacros = true, Dictionary<string, JsonInput> macros = null, Dictionary<string, Stage> favorites = null)
        {
            this.wiiuIP = wiiuIP;
            this.warningBeforeRuns = warningBeforeRuns;
            this.displayMacros = displayMacros;
            this.macros = macros;
            this.favorites = favorites;
        }

        public static ConfigObject Default()
        {
            return new ConfigObject(defaultWiiuIP, defaultWarningBeforeRuns, defaultDisplayMacros, defaultMacros, defaultFavorites);
        }

        public void FillConfig()
        {
            if (wiiuIP == null)
            {
                wiiuIP = Settings.Default.wiiuIP == "192.168." ? defaultWiiuIP : Settings.Default.wiiuIP;
            }
            if (macros == null)
            {
                macros = defaultMacros;
            }
            if (favorites == null)
            {
                Console.WriteLine("test");

                if (Settings.Default.favorites.Count == 0)
                {
                    favorites = defaultFavorites;
                }
                else
                {
                    favorites = new Dictionary<string, Stage>();
                    foreach (string fav in Settings.Default.favorites)
                    {
                        favorites.Add(fav, new Stage("", Form1.yamlMap[fav], 0, false, 0, 0, 0xFF));
                    }
                }
            }
        }


    }

    public class JsonInput
    {
        public bool enabled;
        public int input;
        public bool masterkey;
        public float value;
        public bool alternative;

        public JsonInput(int input, bool enabled = true, bool masterkey = false, float value = 0f, bool alternative = false)
        {
            this.enabled = enabled;
            this.input = input;
            this.masterkey = masterkey;
            this.value = value;
            this.alternative = alternative;
        }
    }
}
