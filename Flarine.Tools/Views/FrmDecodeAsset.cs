using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCommon;

namespace Flarine.Tools.Views
{
    public partial class FrmDecodeAsset : Form
    {
        public FrmDecodeAsset()
        {
            InitializeComponent();
            Files = new List<string>();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Json File|*.json";
                ofd.Multiselect = true;

                var dResult = ofd.ShowDialog();
                if(dResult == DialogResult.OK)
                {
                    Files.Clear();
                    Files.AddRange(ofd.FileNames);

                    if (Files.Count == 1)
                        txtPath.Text = Files[0];
                    else
                        txtPath.Text = string.Format($"{Files.Count} files selected");

                    btnStart.Enabled = Files.Count > 0;
                    progressBar.Maximum = Files.Count;
                }
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnBrowse.Enabled = false;
            rbClientTexts.Enabled = false;
            rbGameData.Enabled = false;
            Cursor = Cursors.WaitCursor;
            ControlBox = false;
            exitToolStripMenuItem.Enabled = false;

            if (rbClientTexts.Checked)
            {
                foreach (var file in Files)
                {
                    await Task.Run(() =>
                    {
                        using (var stream = new FileStream(file, FileMode.Open))
                        {
                            var formatter = new BinaryFormatter();
                            var clientTextsBase64 = (string)formatter.Deserialize(stream);

                            var clientTexts = new WPDClientTexts();

                            try
                            {
                                clientTexts.DeserializeFromBase64String(clientTextsBase64);
                            }
                            catch(Exception)
                            {
                                MessageBox.Show($"File: {file} was invalid!", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            var jsonEncoded = JsonConvert.SerializeObject(clientTexts, Formatting.Indented);
                            var output = Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file) + "_unpacked.json");

                            using (var outStream = new FileStream(output, FileMode.Create))
                            using (var writer = new StreamWriter(outStream))
                            {
                                writer.WriteLine(jsonEncoded);
                            }
                        }

                    });
                    progressBar.Increment(1);
                }
                MessageBox.Show($"Done unpacking {Files.Count} ClientTexts.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(rbGameData.Checked)
            {
                foreach (var file in Files)
                {
                    await Task.Run(() =>
                    {
                        using (var stream = new FileStream(file, FileMode.Open))
                        {
                            var formatter = new BinaryFormatter();
                            var gameDataBase64 = (string)formatter.Deserialize(stream);

                            var gameDatas = new WPDGameDatas();

                            try
                            {
                                gameDatas.DeserializeFromBase64String(gameDataBase64);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show($"File: {file} was invalid!", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            var jObj = JObject.FromObject(gameDatas);
                            var output = Path.Combine(Path.GetDirectoryName(file), "GameDatas");
                            if (!Directory.Exists(output))
                                Directory.CreateDirectory(output);
                            
                            foreach (var obj in jObj)
                            {
                                using (var outStream = new FileStream(Path.Combine(output, $"{obj.Key}.json"), FileMode.Create))
                                using (var writer = new StreamWriter(outStream))
                                {
                                    writer.WriteLine(obj.Value.ToString());
                                }
                            }
                        }
                        
                    });

                    progressBar.Increment(1);
                }
                MessageBox.Show($"Done unpacking {Files.Count} GameDatas.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            btnStart.Enabled = true;
            btnBrowse.Enabled = true;
            rbClientTexts.Enabled = true;
            rbGameData.Enabled = true;
            Cursor = Cursors.Default;
            ControlBox = true;
            exitToolStripMenuItem.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private readonly List<string> Files;
    }
}