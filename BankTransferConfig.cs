using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Modul9_103022400003
{
    public class BankTransferConfig
    {
        

        //File json
        //{
        //  "lang": "CONFIG1",
        //  "transfer": {
        //    "threshold": "CONFIG2",
        //    "low_fee": "CONFIG3",
        //    "high_fee": "CONFIG4"
        //  },
        //  "methods": "CONFIG5",
        //  "confirmation": {
        //    "en": "CONFIG6",
        //    "id": "CONFIG7"
        //  }
        //}

        //1. bila jumlah yang yang di-transfer pada bagian sebelumnya(4-a) kurang dari
        //atau sama dengan nilai CONFIG2 atau “threshold”, maka biaya transfer adalah
        //CONFIG3 atau “low_fee”. Akan tetapi jika lebih dari “threshold”, maka biaya
        //transfer diambil dari nilai CONFIG4 atau “high_fee”.
        //2. Total biaya yang perlu dibayarkan adalah hasil penjumlahan dari jumlah uang
        //yang akan ditransfer dan biaya transfer.
        //3. Pesan output apabila CONFIG1 atau “lang” bernilai “en” adalah “Transfer fee =
        //< biaya_transfer >” dan “Total amount = < nominal_transfer + biaya_transfer >.
        //4. Pesan output apabila CONFIG1 atau “lang” bernilai “id” adalah “Biaya transfer =
        //< biaya_transfer >” dan “Total biaya = < nominal_transfer + biaya_transfer >.

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
