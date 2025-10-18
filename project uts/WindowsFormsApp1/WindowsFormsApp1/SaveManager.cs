using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SaveManager
    {
        private static string savePath = "gamesave.txt";

        // savegame data ke file
        public static void SaveGame()
        {
            try
            {
                List<string> lines = new List<string>();

                lines.Add("RESOURCES");
                lines.Add(GameData.res_clay.ToString());
                lines.Add(GameData.res_iron.ToString());
                lines.Add(GameData.res_wood.ToString());
                lines.Add(GameData.res_crop.ToString());

                lines.Add("MULTIPLIERS");
                lines.Add(GameData.clayProductionMultiplier.ToString());
                lines.Add(GameData.ironProductionMultiplier.ToString());
                lines.Add(GameData.woodProductionMultiplier.ToString());
                lines.Add(GameData.cropProductionMultiplier.ToString());

                lines.Add("CLAY");
                lines.Add(SaveGenerator(GameData.clay1));
                lines.Add(SaveGenerator(GameData.clay2));
                lines.Add(SaveGenerator(GameData.clay3));
                lines.Add(SaveGenerator(GameData.clay4));

                lines.Add("IRON");
                lines.Add(SaveGenerator(GameData.iron1));
                lines.Add(SaveGenerator(GameData.iron2));
                lines.Add(SaveGenerator(GameData.iron3));
                lines.Add(SaveGenerator(GameData.iron4));

                lines.Add("WOOD");
                lines.Add(SaveGenerator(GameData.wood1));
                lines.Add(SaveGenerator(GameData.wood2));
                lines.Add(SaveGenerator(GameData.wood3));
                lines.Add(SaveGenerator(GameData.wood4));

                lines.Add("CROP");
                lines.Add(SaveGenerator(GameData.crop1));
                lines.Add(SaveGenerator(GameData.crop2));
                lines.Add(SaveGenerator(GameData.crop3));
                lines.Add(SaveGenerator(GameData.crop4));
                lines.Add(SaveGenerator(GameData.crop5));
                lines.Add(SaveGenerator(GameData.crop6));

                // map nya yang di hunt
                lines.Add("HUNTMAP");
                foreach (System.Data.DataRow row in GlobalData.upg.Hunt.Rows)
                {
                    string x = row[0].ToString();
                    string y = row[1].ToString();
                    string type = row[2].ToString();
                    lines.Add(x + "|" + y + "|" + type);
                }

                File.WriteAllLines(savePath, lines);
                System.Windows.Forms.MessageBox.Show("berhasil ngesave 🗣️");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("gagal ngesave 🗣️: " + e.Message);
            }
        }

        private static string SaveGenerator(Generator gen)
        {
            return gen.level + "|" + gen.production_rate + "|" + gen.active + "|" + gen.uptime;
        }

        // load game data dari file ini
        public static void LoadGame()
        {
            try
            {
                if (!SaveFileExists())
                {
                    System.Windows.Forms.MessageBox.Show("No save file found.");
                    return;
                }

                if (IsSaveFileEmpty())
                {
                    System.Windows.Forms.MessageBox.Show("Save file is empty.");
                    return;
                }

                string[] lines = File.ReadAllLines(savePath);
                int index = 0;

                while (index < lines.Length && lines[index] != "RESOURCES") index++;
                index++;
                GameData.res_clay = double.Parse(lines[index++]);
                GameData.res_iron = double.Parse(lines[index++]);
                GameData.res_wood = double.Parse(lines[index++]);
                GameData.res_crop = double.Parse(lines[index++]);

                while (index < lines.Length && lines[index] != "MULTIPLIERS") index++;
                index++;
                GameData.clayProductionMultiplier = double.Parse(lines[index++]);
                GameData.ironProductionMultiplier = double.Parse(lines[index++]);
                GameData.woodProductionMultiplier = double.Parse(lines[index++]);
                GameData.cropProductionMultiplier = double.Parse(lines[index++]);

                while (index < lines.Length && lines[index] != "CLAY") index++;
                index++;
                LoadGenerator(GameData.clay1, lines[index++]);
                LoadGenerator(GameData.clay2, lines[index++]);
                LoadGenerator(GameData.clay3, lines[index++]);
                LoadGenerator(GameData.clay4, lines[index++]);

                while (index < lines.Length && lines[index] != "IRON") index++;
                index++;
                LoadGenerator(GameData.iron1, lines[index++]);
                LoadGenerator(GameData.iron2, lines[index++]);
                LoadGenerator(GameData.iron3, lines[index++]);
                LoadGenerator(GameData.iron4, lines[index++]);

                while (index < lines.Length && lines[index] != "WOOD") index++;
                index++;
                LoadGenerator(GameData.wood1, lines[index++]);
                LoadGenerator(GameData.wood2, lines[index++]);
                LoadGenerator(GameData.wood3, lines[index++]);
                LoadGenerator(GameData.wood4, lines[index++]);

                while (index < lines.Length && lines[index] != "CROP") index++;
                index++;
                LoadGenerator(GameData.crop1, lines[index++]);
                LoadGenerator(GameData.crop2, lines[index++]);
                LoadGenerator(GameData.crop3, lines[index++]);
                LoadGenerator(GameData.crop4, lines[index++]);
                LoadGenerator(GameData.crop5, lines[index++]);
                LoadGenerator(GameData.crop6, lines[index++]);

                // load hunt map
                while (index < lines.Length && lines[index] != "HUNTMAP") index++;
                index++;
                GlobalData.upg.Hunt.Rows.Clear();
                while (index < lines.Length)
                {
                    string[] parts = lines[index].Split('|');
                    if (parts.Length >= 3)
                    {
                        int x = int.Parse(parts[0]);
                        int y = int.Parse(parts[1]);
                        int type = int.Parse(parts[2]);
                        GlobalData.upg.Hunt.AddHuntRow(x, y, type);
                    }
                    index++;
                }

                System.Windows.Forms.MessageBox.Show("Game loaded successfully!");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Failed to load: " + e.Message);
            }
        }

        // load generator dari string (| jadi pemisah)
        private static void LoadGenerator(Generator gen, string data)
        {
            string[] parts = data.Split('|');
            if (parts.Length >= 4)
            {
                gen.level = int.Parse(parts[0]);
                gen.production_rate = int.Parse(parts[1]);
                gen.active = bool.Parse(parts[2]);
                gen.uptime = int.Parse(parts[3]);
                gen.Text = gen.level.ToString();
            }
        }

        // pengecekan apakah file save ada
        public static bool SaveFileExists()
        {
            return File.Exists(savePath);
        }

        // cek kosong ato ga
        public static bool IsSaveFileEmpty()
        {
            if (!SaveFileExists())
                return true;

            FileInfo fileInfo = new FileInfo(savePath);
            return fileInfo.Length == 0;
        }
    }
}