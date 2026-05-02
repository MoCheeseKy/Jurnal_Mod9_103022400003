using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Modul9_103022400003
{
    public class BankTransferConfig
    {
        public Config config { get; set; }
        private string filepath = "bank_transfer_config.json";

        public BankTransferConfig() {
            try
            {
                ReadConfigFile();
                Console.WriteLine("Sukses Bro!");
            }
            catch
            {
                SetDefault();
                WriteConfigFile();
            }
        }
        public void ReadConfigFile()
        {
            string jsonString = System.IO.File.ReadAllText(filepath);
            config = System.Text.Json.JsonSerializer.Deserialize<Config>(jsonString);
        }

        public void WriteConfigFile()
        {
            string jsonString = System.Text.Json.JsonSerializer.Serialize(config);
            System.IO.File.WriteAllText(filepath, jsonString);
        }

        public void SetDefault()
        {
           config = new Config
            {
                lang = "en",
                transfer = new Transfer
                {
                    treshold = 25000000,
                    low_fee = 6500,
                    high_fee = 15000
                },
                methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" },
                confirmation = new Confirmation
                {
                    en = "yes",
                    id = "ya"
                }
            };
        }
    }
}
