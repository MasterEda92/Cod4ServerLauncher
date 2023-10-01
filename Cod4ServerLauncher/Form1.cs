
using System.Diagnostics;

namespace Cod4ServerLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LaunchBtn_Click(object sender, EventArgs e)
        {
            if (CoD4PathInput.Text.Length > 0)
            {
                string CodPath = CoD4PathInput.Text;
                string CodExe = CodPath + "\\iw3mp.exe";

                string? CoDMap = MapList.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(CoDMap))
                {
                    string Dedicated = checkBoxDedicated.Checked ? "+set dedicated 1 " : "";
                    string Command = $"{Dedicated}+set fs_game \"mods/pezbot\" +set svr_pezbots {NumBots.Text} " +
                        $"+set svr_pezbots_team axis +set svr_pezbots_skill {SkillLvl.Text} " +
                        $"+set svr_pezbots_mode normal +set scr_war_scorelimit {ScoreLimit.Text} +map {CoDMap}";
                    ProcessStartInfo startInfo = new ProcessStartInfo(CodExe, Command);
                    startInfo.WorkingDirectory = CodPath;
                    Process.Start(startInfo);
                }
            }
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            var res = folderBrowserDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                MapList.Items.Clear();

                CoD4PathInput.Text = folderBrowserDialog1.SelectedPath;
                CoD4PathInput.Refresh();

                var MapFolder = CoD4PathInput.Text + "\\zone\\german";

                var Files = Directory.GetFiles(MapFolder, "mp_*.ff");
                foreach (var File in Files)
                {
                    var FileName = Path.GetFileNameWithoutExtension(File);
                    if (!FileName.EndsWith("load"))
                        MapList.Items.Add(FileName);
                }

                MapList.Refresh();
            }
        }
    }
}