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

                // Save timestamp so we can calculate offline progress
                lines.Add("LASTSAVE");
                lines.Add(DateTime.UtcNow.ToString("o"));

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

                // Determine elapsed offline time (in seconds) from LASTSAVE if present
                double elapsedSeconds = 0;
                int lastSaveIndex = Array.IndexOf(lines, "LASTSAVE");
                if (lastSaveIndex >= 0 && lastSaveIndex + 1 < lines.Length)
                {
                    DateTime saved;
                    if (DateTime.TryParse(lines[lastSaveIndex + 1], null, System.Globalization.DateTimeStyles.RoundtripKind, out saved))
                    {
                        elapsedSeconds = (DateTime.UtcNow - saved.ToUniversalTime()).TotalSeconds;
                        if (elapsedSeconds < 0) elapsedSeconds = 0;
                    }
                }

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

                // Apply offline production for elapsedSeconds
                GameData.updateProduction(); // ensure produce_*_sum current
                if (elapsedSeconds > 0)
                {
                    // Add produced resources for elapsed time
                    GameData.res_clay += GameData.produce_clay_sum * elapsedSeconds/3600;
                    GameData.res_iron += GameData.produce_iron_sum * elapsedSeconds/3600;
                    GameData.res_wood += GameData.produce_wood_sum * elapsedSeconds/3600;
                    GameData.res_crop += GameData.produce_crop_sum * elapsedSeconds/3600;

                    // Reduce uptime for active generators and finish those that completed while offline
                    // If a generator finishes, finalize one level up and mark inactive (simple handling)
                    foreach (var gen in new Generator[] { GameData.clay1, GameData.clay2, GameData.clay3, GameData.clay4,
                                                          GameData.iron1, GameData.iron2, GameData.iron3, GameData.iron4,
                                                          GameData.wood1, GameData.wood2, GameData.wood3, GameData.wood4,
                                                          GameData.crop1, GameData.crop2, GameData.crop3, GameData.crop4, GameData.crop5, GameData.crop6 })
                    {
                        if (gen.active)
                        {
                            double remaining = gen.uptime - elapsedSeconds;
                            if (remaining <= 0)
                            {
                                // finished while offline
                                gen.active = false;
                                gen.level = Math.Min(20, gen.level + 1);
                                gen.uptime = 0;
                                gen.Text = gen.level.ToString(); // update visual text to new level
                                // update production_rate from dataset for new level
                                try
                                {
                                    int lvlIndex = gen.level - 1;
                                    if (lvlIndex >= 0)
                                    {
                                        if (gen.resource_ref == 1)
                                            gen.production_rate = (int)GlobalData.upg.clay.Rows[lvlIndex]["produksi"];
                                        else if (gen.resource_ref == 2)
                                            gen.production_rate = (int)GlobalData.upg.iron.Rows[lvlIndex]["produksi"];
                                        else if (gen.resource_ref == 3)
                                            gen.production_rate = (int)GlobalData.upg.wood.Rows[lvlIndex]["produksi"];
                                        else
                                            gen.production_rate = (int)GlobalData.upg.crop.Rows[lvlIndex]["produksi"];
                                    }
                                }
                                catch { }
                            }
                            else
                            {
                                gen.uptime = (int)Math.Ceiling(remaining);
                            }
                        }
                    }

                    // Recalculate production after possible level ups
                    GameData.updateProduction();
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