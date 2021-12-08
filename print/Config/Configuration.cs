using System;
using System.IO;
using Newtonsoft.Json;

namespace print.Config
{
    public class Configuration : IConfig<ConfigModel>
    {
        // public static void Main(string[] args)
        // {
        //     // var configuration = new Configuration();
        //     // configuration.Initial();
        //     ConfigModel configModel = new ConfigModel();
        //     configModel.ConnectionSTring1 =
        //         "Data Source=192.168.1.10;Initial Catalog=V_PMA2122;user Id=wats;Password=997755;";
        //     configModel.ConnectionSTring2 =
        //         "Data Source=192.168.1.10;Initial Catalog=PMA2122;user Id=wats;Password=997755;";
        //     configModel.Dbname1 =
        //         "V_PMA2122";
        //     configModel.Dbname1 =
        //         "PMA2122";
        //     string json = JsonConvert.SerializeObject(configModel);
        //     Console.WriteLine(json);
        // }
        private const string DEFAULT_FILENAME = "settings.json";

        public string Create(ConfigModel data)
        {
            if (!File.Exists(DEFAULT_FILENAME))
            {
                File.WriteAllText(DEFAULT_FILENAME, "");
            }

            string json = JsonConvert.SerializeObject(data);

            File.WriteAllText(DEFAULT_FILENAME, json);


            return Get();
        }

        public string Get()
        {
            var json = File.ReadAllText(DEFAULT_FILENAME);
            return json;
        }

        public ConfigModel Initial()
        {
            ConfigModel configModel = new ConfigModel();
            configModel.ConnectionSTring1 =
                "Data Source=192.168.1.10;Initial Catalog=V_PMA2122;user Id=wats;Password=997755;";
            configModel.ConnectionSTring2 =
                "Data Source=192.168.1.10;Initial Catalog=PMA2021;user Id=wats;Password=997755;";
            configModel.Dbname1 =
                "V_PMA2122";
            configModel.Dbname2 =
                "PMA2021";
            configModel.Apikey =
                "EKTH6T5CQHDN14BSIT60";
            configModel.selfNumber =
                "919895271345";
            string json = JsonConvert.SerializeObject(configModel);
            if (!File.Exists(DEFAULT_FILENAME))
            {
                File.WriteAllText(DEFAULT_FILENAME, json);
            }


            return GetConfig();
        }

        public ConfigModel Reset()
        {
            ConfigModel configModel = new ConfigModel();
            configModel.ConnectionSTring1 =
                "Data Source=192.168.1.10;Initial Catalog=V_PMA2122;user Id=wats;Password=997755;";
            configModel.ConnectionSTring2 =
                "Data Source=192.168.1.10;Initial Catalog=PMA2021;user Id=wats;Password=997755;";
            configModel.Dbname1 =
                "V_PMA2122";
            configModel.Dbname2 =
                "PMA2021";
            configModel.Apikey =
                "EKTH6T5CQHDN14BSIT60";
            configModel.selfNumber =
                "919895271345";
            string json = JsonConvert.SerializeObject(configModel);

            File.WriteAllText(DEFAULT_FILENAME, json);


            return GetConfig();
        }

        public ConfigModel GetConfig()
        {
            var json = File.ReadAllText(DEFAULT_FILENAME);
            ConfigModel m = JsonConvert.DeserializeObject<ConfigModel>(json);
            return m;
        }
    }

    public class ConfigModel
    {
        public String ConnectionSTring1 { get; set; }
        public String ConnectionSTring2 { get; set; }
        public String Dbname1 { get; set; }
        public String Dbname2 { get; set; }
        public String Apikey { get; set; }
        public String selfNumber { get; set; }
    }
}