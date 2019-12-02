using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;

namespace WindowsFormsApplication6
{
	public partial class Form1 : Form
	{
		String str_path,str_curFile;
		bool bl_modify = false;
		List<String> maplist = new List<String>();
		public Form1()
		{
			InitializeComponent();
		}
        private void Form1_Load(object sender, EventArgs e)
		{
			cbx_mode.Items.Add("休闲模式");
			cbx_mode.Items.Add("竞技模式");
			cbx_mode.Items.Add("军备竞赛模式");
			cbx_mode.Items.Add("爆破模式");
			cbx_mode.Items.Add("死亡竞赛模式");
			str_curFile = "";
			for (int i = 0; i < 5; i++)
				cbx_bot_diff.Items.Add(i + 1);
		}
		private void refresh_map(String str_path)
		{
			str_path = Path.GetDirectoryName(str_path);
			DirectoryInfo Dir = new DirectoryInfo(str_path + @"\csgo\maps");
			foreach (FileInfo f in Dir.GetFiles("*.bsp", SearchOption.TopDirectoryOnly))
				maplist.Add(f.ToString().Substring(0, f.ToString().Length - 4));
			if (Directory.Exists(str_path + @"\csgo\maps\workshop"))
			{
				Dir = new DirectoryInfo(str_path + @"\csgo\maps\workshop");
				foreach (DirectoryInfo d in Dir.GetDirectories())
					foreach (FileInfo f in d.GetFiles("*.bsp", SearchOption.TopDirectoryOnly))
						maplist.Add(f.ToString().Substring(0, f.ToString().Length - 4));
			}
			maplist.Sort();
			foreach (String s in maplist)
				cbx_map.Items.Add(s);
		}

		private void btn_path_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "srcds.exe|srcds.exe";
			ofd.ValidateNames = true;
			ofd.CheckPathExists = true;
			ofd.CheckFileExists = true;
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				maplist.Clear();
				str_path = ofd.FileName;
				refresh_map(str_path);	
			}
			txt_path.Text = str_path;
		}

		private void btn_run_Click(object sender, EventArgs e)
		{
			String cmd =" -game csgo";
			if (rdb_worldwide.Checked) cmd += " -worldwide";
			else cmd += " -perfectworld";
			cmd += " -console";
			if (chb_rcon.Checked) cmd += " -usercon";
			if (rdb_tick64.Checked) cmd += " -tickrate 64";
			else cmd += " -tickrate 128";
			cmd += " -host \"" +txt_hostname.Text +"\"";
			if (rdb_lan.Checked)
				cmd += " -net_port_try 0";
			else
			{
				cmd += " +sv_setsteamaccount " + txt_token.Text;
				cmd += " -net_port_try 1";
			}
			if (rdb_uac_insecure.Checked) cmd += " -insecure";
			if (rdb_bot_dis.Checked) cmd += " -nobots";
			if (cbx_mode.SelectedIndex == 0) cmd += " +game_type 0 +game_mode 0";
			else if (cbx_mode.SelectedIndex == 1) cmd += " +game_type 0 +game_mode 1";
			else if (cbx_mode.SelectedIndex == 2) cmd += " +game_type 1 +game_mode 0";
			else if (cbx_mode.SelectedIndex == 3) cmd += " +game_type 1 +game_mode 1";
			else cmd += " +game_type 1 +game_mode 2";
			if (rdb_mg_en.Checked)
			{
				if (cbx_mode.SelectedIndex < 2) cmd += " +mapgroup mg_active";
				else if (cbx_mode.SelectedIndex == 2) cmd += " +mapgroup mg_armsrace";
				else if (cbx_mode.SelectedIndex == 3) cmd += " +mapgroup mg_demolition";
				else cmd += " +mapgroup mg_allclassic";
			}
			cmd += " +map " + maplist[cbx_map.SelectedIndex];
			cmd += " -authkey " + txt_design_token.Text;
			if (rdb_list_dis.Checked) cmd += " -nomaster";
			cmd += " -port " + txt_port.Text;

			File.WriteAllText(Path.GetDirectoryName(txt_path.Text) + @"\csgo\cfg\server.cfg","hostname \""+txt_hostname.Text+"\""+Environment.NewLine+"rcon_password \"" + txt_rcon.Text + "\"" + Environment.NewLine + "bot_difficult "+cbx_bot_diff.SelectedIndex+1);
            File.WriteAllText("C:\\text.txt", cmd);
			Console.WriteLine(cmd);
			Process process = new Process();//创建进程对象    
			ProcessStartInfo startInfo = new ProcessStartInfo(txt_path.Text, cmd); // 括号里是(程序名,参数)
			process.StartInfo = startInfo;
			process.Start();
		}

		private void chb_rcon_CheckedChanged(object sender, EventArgs e)
		{
			txt_rcon.Enabled = chb_rcon.Checked;
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void 加载配置ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			String str_path;
			OperateIniFile OIFile = new OperateIniFile();
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "*.ini|*.ini";
			ofd.ValidateNames = true;
			ofd.CheckPathExists = true;
			ofd.CheckFileExists = true;
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				String str_res;
				str_path = ofd.FileName;
				txt_path.Text = OIFile.ReadIniData("data", "path", "", str_path);
				refresh_map(txt_path.Text);
				str_res = OIFile.ReadIniData("data", "server_type", "", str_path);
				if (str_res == "perfectworld") rdb_pworld.Checked = true;
				else rdb_worldwide.Checked = true;

				str_res = OIFile.ReadIniData("data", "tick_rate", "", str_path);
				if (str_res == "64") rdb_tick64.Checked = true;
				else rdb_tick128.Checked = true;

				txt_hostname.Text = OIFile.ReadIniData("data", "host_name", "", str_path);

				str_res = OIFile.ReadIniData("data", "vac", "", str_path);
				if (str_res == "on") rdb_vac_secure.Checked = true;
				else rdb_uac_insecure.Checked = true;

				str_res = OIFile.ReadIniData("data", "bot_switch", "", str_path);
				if (str_res == "on") rdb_bot_en.Checked = true;
				else rdb_bot_dis.Checked = true;

				str_res = OIFile.ReadIniData("data", "bot_difficult", "", str_path);
				cbx_bot_diff.SelectedIndex = int.Parse(str_res) - 1;

				str_res = OIFile.ReadIniData("data", "master", "", str_path);
				if (str_res == "on") rdb_list_en.Checked = true;
				else rdb_list_dis.Checked = true;

				txt_port.Text = OIFile.ReadIniData("data", "port", "", str_path);

				str_res = OIFile.ReadIniData("data", "rcon", "", str_path);
				if (str_res == "on") chb_rcon.Checked = true;
				else chb_rcon.Checked = true;

				txt_rcon.Text = OIFile.ReadIniData("data", "rcon_password", "", str_path);

				str_res = OIFile.ReadIniData("data", "net", "", str_path);
				if (str_res == "lan") rdb_lan.Checked = true;
				else rdb_wan.Checked = true;

				txt_token.Text = OIFile.ReadIniData("data", "token", "", str_path);

				str_res = OIFile.ReadIniData("data", "mode", "", str_path);
				cbx_mode.SelectedIndex = int.Parse(str_res);

				str_res = OIFile.ReadIniData("data", "map_group", "", str_path);
				if (str_res == "on") rdb_mg_en.Checked = true;
				else rdb_mg_dis.Checked = true;

				str_res = OIFile.ReadIniData("data", "map", "", str_path);
				bool f = false;
				for (int i = 0; i<cbx_map.Items.Count; i++)
				{
					if (str_res == cbx_map.GetItemText(cbx_map.Items[i]))
					{
						cbx_map.SelectedIndex = i;
						f = true;
						break;
					}
				}
				if(!f) cbx_map.SelectedIndex = 0;

				txt_design_token.Text = OIFile.ReadIniData("data", "design_token", "", str_path);

				str_curFile = str_path;
				toolStripStatusLabel1.Text = Path.GetFileName(str_curFile);

				bl_modify = false;
				关闭配置CToolStripMenuItem.Enabled = true;
			}
		}

		private void 保存配置ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!bl_modify) return;
			String str_path;
			if (str_curFile == "")
			{
				SaveFileDialog sfd = new SaveFileDialog();

				sfd.Filter = "配置文件 (*.ini)|*.ini";
				sfd.FilterIndex = 2;
				sfd.RestoreDirectory = true;
				
				if (sfd.ShowDialog() != DialogResult.OK)
					return;
				str_path = sfd.FileName;
			}
			else
				str_path = str_curFile;

			OperateIniFile OIFile = new OperateIniFile();

			OIFile.WriteIniData("data", "path", txt_path.Text, str_path);

			if (rdb_pworld.Checked) OIFile.WriteIniData("data", "server_type", "perfectworld", str_path);
			else OIFile.WriteIniData("data", "server_type", "worldwide", str_path);


			if (rdb_tick64.Checked) OIFile.WriteIniData("data", "tick_rate", "64", str_path);
			else OIFile.WriteIniData("data", "tick_rate", "128", str_path);

			OIFile.WriteIniData("data", "host_name", txt_hostname.Text, str_path);

			if (rdb_vac_secure.Checked) OIFile.WriteIniData("data", "vac", "on", str_path);
			else OIFile.WriteIniData("data", "vac", "off", str_path);

			if (rdb_bot_en.Checked) OIFile.WriteIniData("data", "bot_switch", "on", str_path);
			else OIFile.WriteIniData("data", "bot_switch", "off", str_path);

			OIFile.WriteIniData("data", "bot_difficult", (cbx_bot_diff.SelectedIndex + 1).ToString(), str_path);

			if (rdb_list_en.Checked) OIFile.WriteIniData("data", "master", "on", str_path);
			else OIFile.WriteIniData("data", "master", "off", str_path);

			OIFile.WriteIniData("data", "port", txt_port.Text, str_path);


			if (chb_rcon.Checked) OIFile.WriteIniData("data", "rcon", "on", str_path);
			else OIFile.WriteIniData("data", "rcon", "off", str_path);

			OIFile.WriteIniData("data", "rcon_password", txt_rcon.Text, str_path);

			if (rdb_lan.Checked) OIFile.WriteIniData("data", "net", "lan", str_path);
			else OIFile.WriteIniData("data", "net", "wan", str_path);

			OIFile.WriteIniData("data", "token", txt_token.Text, str_path);

			OIFile.WriteIniData("data", "mode", cbx_mode.SelectedIndex.ToString(), str_path);

			if (rdb_mg_en.Checked) OIFile.WriteIniData("data", "map_group", "on", str_path);
			else OIFile.WriteIniData("data", "map_group", "off", str_path);

			OIFile.WriteIniData("data", "map", cbx_map.GetItemText(cbx_map.SelectedItem), str_path);

			OIFile.WriteIniData("data", "design_token", txt_design_token.Text, str_path);

			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile);

			bl_modify = false;

		}

		private void 关闭配置CToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!bl_modify)
			{
				str_curFile = "";
				toolStripStatusLabel1.Text = Path.GetFileName(str_curFile);
				关闭配置CToolStripMenuItem.Enabled = false;
			}
			else
			{
				DialogResult ret = MessageBox.Show("是否将更改保存到" + Path.GetFileName(str_curFile) + "中?", "配置管理器", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (ret == DialogResult.No)
				{
					str_curFile = "";
					toolStripStatusLabel1.Text = Path.GetFileName(str_curFile);
					bl_modify = false;
					关闭配置CToolStripMenuItem.Enabled = false;
					return;
				}
				String str_path = str_curFile;

				OperateIniFile OIFile = new OperateIniFile();

				OIFile.WriteIniData("data", "path", txt_path.Text, str_path);

				if (rdb_pworld.Checked) OIFile.WriteIniData("data", "server_type", "perfectworld", str_path);
				else OIFile.WriteIniData("data", "server_type", "worldwide", str_path);


				if (rdb_tick64.Checked) OIFile.WriteIniData("data", "tick_rate", "64", str_path);
				else OIFile.WriteIniData("data", "tick_rate", "128", str_path);

				OIFile.WriteIniData("data", "host_name", txt_hostname.Text, str_path);

				if (rdb_vac_secure.Checked) OIFile.WriteIniData("data", "vac", "on", str_path);
				else OIFile.WriteIniData("data", "vac", "off", str_path);

				if (rdb_bot_en.Checked) OIFile.WriteIniData("data", "bot_switch", "on", str_path);
				else OIFile.WriteIniData("data", "bot_switch", "off", str_path);

				OIFile.WriteIniData("data", "bot_difficult", (cbx_bot_diff.SelectedIndex + 1).ToString(), str_path);

				if (rdb_list_en.Checked) OIFile.WriteIniData("data", "master", "on", str_path);
				else OIFile.WriteIniData("data", "master", "off", str_path);

				OIFile.WriteIniData("data", "port", txt_port.Text, str_path);


				if (chb_rcon.Checked) OIFile.WriteIniData("data", "rcon", "on", str_path);
				else OIFile.WriteIniData("data", "rcon", "off", str_path);

				OIFile.WriteIniData("data", "rcon_password", txt_rcon.Text, str_path);

				if (rdb_lan.Checked) OIFile.WriteIniData("data", "net", "lan", str_path);
				else OIFile.WriteIniData("data", "net", "wan", str_path);

				OIFile.WriteIniData("data", "token", txt_token.Text, str_path);

				OIFile.WriteIniData("data", "mode", cbx_mode.SelectedIndex.ToString(), str_path);

				if (rdb_mg_en.Checked) OIFile.WriteIniData("data", "map_group", "on", str_path);
				else OIFile.WriteIniData("data", "map_group", "off", str_path);

				OIFile.WriteIniData("data", "map", cbx_map.GetItemText(cbx_map.SelectedItem), str_path);

				OIFile.WriteIniData("data", "design_token", txt_design_token.Text, str_path);

				str_curFile = "";
				toolStripStatusLabel1.Text = Path.GetFileName(str_curFile);

				bl_modify = false; 
				关闭配置CToolStripMenuItem.Enabled = false;
			}
		}

		private void txt_path_TextChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void rdb_worldwide_CheckedChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void rdb_pworld_CheckedChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void rdb_tick64_CheckedChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void rdb_tick128_CheckedChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void txt_hostname_TextChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void rdb_vac_secure_CheckedChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void rdb_uac_insecure_CheckedChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void rdb_bot_en_CheckedChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void rdb_bot_dis_CheckedChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void cbx_bot_diff_SelectedIndexChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void rdb_list_en_CheckedChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void rdb_list_dis_CheckedChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void txt_port_TextChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void txt_rcon_TextChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void txt_token_TextChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void cbx_mode_SelectedIndexChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void rdb_mg_en_CheckedChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void rdb_mg_dis_CheckedChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void cbx_map_SelectedIndexChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void txt_design_token_TextChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
		}

		private void rdb_lan_CheckedChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
			txt_token.Enabled = !rdb_lan.Checked;
		}
        private void rdb_wan_CheckedChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(str_curFile) + " *";
			bl_modify = true;
			txt_token.Enabled = rdb_wan.Checked;
		}

		
	}
}
