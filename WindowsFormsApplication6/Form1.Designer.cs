namespace WindowsFormsApplication6
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_pworld = new System.Windows.Forms.RadioButton();
            this.rdb_worldwide = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdb_tick128 = new System.Windows.Forms.RadioButton();
            this.rdb_tick64 = new System.Windows.Forms.RadioButton();
            this.txt_hostname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdb_uac_insecure = new System.Windows.Forms.RadioButton();
            this.rdb_vac_secure = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdb_bot_dis = new System.Windows.Forms.RadioButton();
            this.rdb_bot_en = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdb_list_dis = new System.Windows.Forms.RadioButton();
            this.rdb_list_en = new System.Windows.Forms.RadioButton();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rdb_wan = new System.Windows.Forms.RadioButton();
            this.rdb_lan = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_token = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbx_mode = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rdb_mg_dis = new System.Windows.Forms.RadioButton();
            this.rdb_mg_en = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.cbx_map = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_design_token = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_path = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_bot_diff = new System.Windows.Forms.ComboBox();
            this.chb_rcon = new System.Windows.Forms.CheckBox();
            this.txt_rcon = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加载配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭配置CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdb_pworld);
            this.panel1.Controls.Add(this.rdb_worldwide);
            this.panel1.Location = new System.Drawing.Point(84, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 27);
            this.panel1.TabIndex = 0;
            // 
            // rdb_pworld
            // 
            this.rdb_pworld.AutoSize = true;
            this.rdb_pworld.Location = new System.Drawing.Point(74, 5);
            this.rdb_pworld.Name = "rdb_pworld";
            this.rdb_pworld.Size = new System.Drawing.Size(47, 16);
            this.rdb_pworld.TabIndex = 2;
            this.rdb_pworld.TabStop = true;
            this.rdb_pworld.Text = "国服";
            this.rdb_pworld.UseVisualStyleBackColor = true;
            this.rdb_pworld.CheckedChanged += new System.EventHandler(this.rdb_pworld_CheckedChanged);
            // 
            // rdb_worldwide
            // 
            this.rdb_worldwide.AutoSize = true;
            this.rdb_worldwide.Location = new System.Drawing.Point(9, 5);
            this.rdb_worldwide.Name = "rdb_worldwide";
            this.rdb_worldwide.Size = new System.Drawing.Size(59, 16);
            this.rdb_worldwide.TabIndex = 1;
            this.rdb_worldwide.TabStop = true;
            this.rdb_worldwide.Text = "世界服";
            this.rdb_worldwide.UseVisualStyleBackColor = true;
            this.rdb_worldwide.CheckedChanged += new System.EventHandler(this.rdb_worldwide_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdb_tick128);
            this.panel2.Controls.Add(this.rdb_tick64);
            this.panel2.Location = new System.Drawing.Point(84, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 27);
            this.panel2.TabIndex = 3;
            // 
            // rdb_tick128
            // 
            this.rdb_tick128.AutoSize = true;
            this.rdb_tick128.Location = new System.Drawing.Point(74, 5);
            this.rdb_tick128.Name = "rdb_tick128";
            this.rdb_tick128.Size = new System.Drawing.Size(65, 16);
            this.rdb_tick128.TabIndex = 2;
            this.rdb_tick128.TabStop = true;
            this.rdb_tick128.Text = "128tick";
            this.rdb_tick128.UseVisualStyleBackColor = true;
            this.rdb_tick128.CheckedChanged += new System.EventHandler(this.rdb_tick128_CheckedChanged);
            // 
            // rdb_tick64
            // 
            this.rdb_tick64.AutoSize = true;
            this.rdb_tick64.Location = new System.Drawing.Point(9, 5);
            this.rdb_tick64.Name = "rdb_tick64";
            this.rdb_tick64.Size = new System.Drawing.Size(59, 16);
            this.rdb_tick64.TabIndex = 1;
            this.rdb_tick64.TabStop = true;
            this.rdb_tick64.Text = "64tick";
            this.rdb_tick64.UseVisualStyleBackColor = true;
            this.rdb_tick64.CheckedChanged += new System.EventHandler(this.rdb_tick64_CheckedChanged);
            // 
            // txt_hostname
            // 
            this.txt_hostname.Location = new System.Drawing.Point(92, 100);
            this.txt_hostname.Name = "txt_hostname";
            this.txt_hostname.Size = new System.Drawing.Size(100, 21);
            this.txt_hostname.TabIndex = 4;
            this.txt_hostname.TextChanged += new System.EventHandler(this.txt_hostname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "tick";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "主机名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "VAC选项";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdb_uac_insecure);
            this.panel3.Controls.Add(this.rdb_vac_secure);
            this.panel3.Location = new System.Drawing.Point(84, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(134, 27);
            this.panel3.TabIndex = 3;
            // 
            // rdb_uac_insecure
            // 
            this.rdb_uac_insecure.AutoSize = true;
            this.rdb_uac_insecure.Location = new System.Drawing.Point(74, 5);
            this.rdb_uac_insecure.Name = "rdb_uac_insecure";
            this.rdb_uac_insecure.Size = new System.Drawing.Size(47, 16);
            this.rdb_uac_insecure.TabIndex = 2;
            this.rdb_uac_insecure.TabStop = true;
            this.rdb_uac_insecure.Text = "禁用";
            this.rdb_uac_insecure.UseVisualStyleBackColor = true;
            this.rdb_uac_insecure.CheckedChanged += new System.EventHandler(this.rdb_uac_insecure_CheckedChanged);
            // 
            // rdb_vac_secure
            // 
            this.rdb_vac_secure.AutoSize = true;
            this.rdb_vac_secure.Location = new System.Drawing.Point(9, 5);
            this.rdb_vac_secure.Name = "rdb_vac_secure";
            this.rdb_vac_secure.Size = new System.Drawing.Size(47, 16);
            this.rdb_vac_secure.TabIndex = 1;
            this.rdb_vac_secure.TabStop = true;
            this.rdb_vac_secure.Text = "启用";
            this.rdb_vac_secure.UseVisualStyleBackColor = true;
            this.rdb_vac_secure.CheckedChanged += new System.EventHandler(this.rdb_vac_secure_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "BOT";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdb_bot_dis);
            this.panel4.Controls.Add(this.rdb_bot_en);
            this.panel4.Location = new System.Drawing.Point(84, 148);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(134, 27);
            this.panel4.TabIndex = 4;
            // 
            // rdb_bot_dis
            // 
            this.rdb_bot_dis.AutoSize = true;
            this.rdb_bot_dis.Location = new System.Drawing.Point(74, 5);
            this.rdb_bot_dis.Name = "rdb_bot_dis";
            this.rdb_bot_dis.Size = new System.Drawing.Size(47, 16);
            this.rdb_bot_dis.TabIndex = 2;
            this.rdb_bot_dis.TabStop = true;
            this.rdb_bot_dis.Text = "禁用";
            this.rdb_bot_dis.UseVisualStyleBackColor = true;
            this.rdb_bot_dis.CheckedChanged += new System.EventHandler(this.rdb_bot_dis_CheckedChanged);
            // 
            // rdb_bot_en
            // 
            this.rdb_bot_en.AutoSize = true;
            this.rdb_bot_en.Location = new System.Drawing.Point(9, 5);
            this.rdb_bot_en.Name = "rdb_bot_en";
            this.rdb_bot_en.Size = new System.Drawing.Size(47, 16);
            this.rdb_bot_en.TabIndex = 1;
            this.rdb_bot_en.TabStop = true;
            this.rdb_bot_en.Text = "启用";
            this.rdb_bot_en.UseVisualStyleBackColor = true;
            this.rdb_bot_en.CheckedChanged += new System.EventHandler(this.rdb_bot_en_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "服务器列表";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rdb_list_dis);
            this.panel5.Controls.Add(this.rdb_list_en);
            this.panel5.Location = new System.Drawing.Point(84, 197);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(134, 27);
            this.panel5.TabIndex = 5;
            // 
            // rdb_list_dis
            // 
            this.rdb_list_dis.AutoSize = true;
            this.rdb_list_dis.Location = new System.Drawing.Point(74, 5);
            this.rdb_list_dis.Name = "rdb_list_dis";
            this.rdb_list_dis.Size = new System.Drawing.Size(47, 16);
            this.rdb_list_dis.TabIndex = 2;
            this.rdb_list_dis.TabStop = true;
            this.rdb_list_dis.Text = "隐藏";
            this.rdb_list_dis.UseVisualStyleBackColor = true;
            this.rdb_list_dis.CheckedChanged += new System.EventHandler(this.rdb_list_dis_CheckedChanged);
            // 
            // rdb_list_en
            // 
            this.rdb_list_en.AutoSize = true;
            this.rdb_list_en.Location = new System.Drawing.Point(9, 5);
            this.rdb_list_en.Name = "rdb_list_en";
            this.rdb_list_en.Size = new System.Drawing.Size(47, 16);
            this.rdb_list_en.TabIndex = 1;
            this.rdb_list_en.TabStop = true;
            this.rdb_list_en.Text = "显示";
            this.rdb_list_en.UseVisualStyleBackColor = true;
            this.rdb_list_en.CheckedChanged += new System.EventHandler(this.rdb_list_en_CheckedChanged);
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(340, 34);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(100, 21);
            this.txt_port.TabIndex = 14;
            this.txt_port.TextChanged += new System.EventHandler(this.txt_port_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "主机端口号";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "RCON";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.rdb_wan);
            this.panel7.Controls.Add(this.rdb_lan);
            this.panel7.Location = new System.Drawing.Point(332, 82);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(134, 27);
            this.panel7.TabIndex = 15;
            // 
            // rdb_wan
            // 
            this.rdb_wan.AutoSize = true;
            this.rdb_wan.Location = new System.Drawing.Point(74, 5);
            this.rdb_wan.Name = "rdb_wan";
            this.rdb_wan.Size = new System.Drawing.Size(59, 16);
            this.rdb_wan.TabIndex = 2;
            this.rdb_wan.TabStop = true;
            this.rdb_wan.Text = "因特网";
            this.rdb_wan.UseVisualStyleBackColor = true;
            this.rdb_wan.CheckedChanged += new System.EventHandler(this.rdb_wan_CheckedChanged);
            // 
            // rdb_lan
            // 
            this.rdb_lan.AutoSize = true;
            this.rdb_lan.Location = new System.Drawing.Point(9, 5);
            this.rdb_lan.Name = "rdb_lan";
            this.rdb_lan.Size = new System.Drawing.Size(47, 16);
            this.rdb_lan.TabIndex = 1;
            this.rdb_lan.TabStop = true;
            this.rdb_lan.Text = "本地";
            this.rdb_lan.UseVisualStyleBackColor = true;
            this.rdb_lan.CheckedChanged += new System.EventHandler(this.rdb_lan_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(265, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "网络";
            // 
            // txt_token
            // 
            this.txt_token.Location = new System.Drawing.Point(340, 109);
            this.txt_token.Name = "txt_token";
            this.txt_token.Size = new System.Drawing.Size(100, 21);
            this.txt_token.TabIndex = 18;
            this.txt_token.TextChanged += new System.EventHandler(this.txt_token_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "登录令牌";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(265, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "游戏模式";
            // 
            // cbx_mode
            // 
            this.cbx_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_mode.FormattingEnabled = true;
            this.cbx_mode.Location = new System.Drawing.Point(340, 131);
            this.cbx_mode.Name = "cbx_mode";
            this.cbx_mode.Size = new System.Drawing.Size(100, 20);
            this.cbx_mode.TabIndex = 20;
            this.cbx_mode.SelectedIndexChanged += new System.EventHandler(this.cbx_mode_SelectedIndexChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rdb_mg_dis);
            this.panel8.Controls.Add(this.rdb_mg_en);
            this.panel8.Location = new System.Drawing.Point(332, 152);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(134, 27);
            this.panel8.TabIndex = 17;
            // 
            // rdb_mg_dis
            // 
            this.rdb_mg_dis.AutoSize = true;
            this.rdb_mg_dis.Location = new System.Drawing.Point(74, 5);
            this.rdb_mg_dis.Name = "rdb_mg_dis";
            this.rdb_mg_dis.Size = new System.Drawing.Size(47, 16);
            this.rdb_mg_dis.TabIndex = 2;
            this.rdb_mg_dis.TabStop = true;
            this.rdb_mg_dis.Text = "禁用";
            this.rdb_mg_dis.UseVisualStyleBackColor = true;
            this.rdb_mg_dis.CheckedChanged += new System.EventHandler(this.rdb_mg_dis_CheckedChanged);
            // 
            // rdb_mg_en
            // 
            this.rdb_mg_en.AutoSize = true;
            this.rdb_mg_en.Location = new System.Drawing.Point(9, 5);
            this.rdb_mg_en.Name = "rdb_mg_en";
            this.rdb_mg_en.Size = new System.Drawing.Size(47, 16);
            this.rdb_mg_en.TabIndex = 1;
            this.rdb_mg_en.TabStop = true;
            this.rdb_mg_en.Text = "启用";
            this.rdb_mg_en.UseVisualStyleBackColor = true;
            this.rdb_mg_en.CheckedChanged += new System.EventHandler(this.rdb_mg_en_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(265, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 18;
            this.label13.Text = "地图组";
            // 
            // cbx_map
            // 
            this.cbx_map.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_map.FormattingEnabled = true;
            this.cbx_map.Location = new System.Drawing.Point(341, 179);
            this.cbx_map.Name = "cbx_map";
            this.cbx_map.Size = new System.Drawing.Size(100, 20);
            this.cbx_map.TabIndex = 22;
            this.cbx_map.SelectedIndexChanged += new System.EventHandler(this.cbx_map_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(266, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 21;
            this.label14.Text = "初始地图";
            // 
            // txt_design_token
            // 
            this.txt_design_token.Location = new System.Drawing.Point(341, 199);
            this.txt_design_token.Name = "txt_design_token";
            this.txt_design_token.Size = new System.Drawing.Size(100, 21);
            this.txt_design_token.TabIndex = 24;
            this.txt_design_token.TextChanged += new System.EventHandler(this.txt_design_token_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(266, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 23;
            this.label15.Text = "创意工坊令牌";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 26;
            this.label16.Text = "srcds路径";
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(92, 24);
            this.txt_path.Name = "txt_path";
            this.txt_path.ReadOnly = true;
            this.txt_path.Size = new System.Drawing.Size(100, 21);
            this.txt_path.TabIndex = 25;
            this.txt_path.TextChanged += new System.EventHandler(this.txt_path_TextChanged);
            // 
            // btn_path
            // 
            this.btn_path.Location = new System.Drawing.Point(198, 22);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(20, 23);
            this.btn_path.TabIndex = 27;
            this.btn_path.Text = "...";
            this.btn_path.UseVisualStyleBackColor = true;
            this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(231, 224);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 28;
            this.btn_run.Text = "启动游戏";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "BOT难度";
            // 
            // cbx_bot_diff
            // 
            this.cbx_bot_diff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_bot_diff.FormattingEnabled = true;
            this.cbx_bot_diff.Location = new System.Drawing.Point(92, 176);
            this.cbx_bot_diff.Name = "cbx_bot_diff";
            this.cbx_bot_diff.Size = new System.Drawing.Size(100, 20);
            this.cbx_bot_diff.TabIndex = 30;
            this.cbx_bot_diff.SelectedIndexChanged += new System.EventHandler(this.cbx_bot_diff_SelectedIndexChanged);
            // 
            // chb_rcon
            // 
            this.chb_rcon.Location = new System.Drawing.Point(446, 55);
            this.chb_rcon.Name = "chb_rcon";
            this.chb_rcon.Size = new System.Drawing.Size(20, 24);
            this.chb_rcon.TabIndex = 33;
            this.chb_rcon.CheckedChanged += new System.EventHandler(this.chb_rcon_CheckedChanged);
            // 
            // txt_rcon
            // 
            this.txt_rcon.Location = new System.Drawing.Point(340, 57);
            this.txt_rcon.Name = "txt_rcon";
            this.txt_rcon.Size = new System.Drawing.Size(100, 21);
            this.txt_rcon.TabIndex = 32;
            this.txt_rcon.TextChanged += new System.EventHandler(this.txt_rcon_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(506, 25);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加载配置ToolStripMenuItem,
            this.保存配置ToolStripMenuItem,
            this.关闭配置CToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 加载配置ToolStripMenuItem
            // 
            this.加载配置ToolStripMenuItem.Name = "加载配置ToolStripMenuItem";
            this.加载配置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.加载配置ToolStripMenuItem.Text = "加载配置(&L)";
            this.加载配置ToolStripMenuItem.Click += new System.EventHandler(this.加载配置ToolStripMenuItem_Click);
            // 
            // 保存配置ToolStripMenuItem
            // 
            this.保存配置ToolStripMenuItem.Name = "保存配置ToolStripMenuItem";
            this.保存配置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.保存配置ToolStripMenuItem.Text = "保存配置(&S)";
            this.保存配置ToolStripMenuItem.Click += new System.EventHandler(this.保存配置ToolStripMenuItem_Click);
            // 
            // 关闭配置CToolStripMenuItem
            // 
            this.关闭配置CToolStripMenuItem.Enabled = false;
            this.关闭配置CToolStripMenuItem.Name = "关闭配置CToolStripMenuItem";
            this.关闭配置CToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.关闭配置CToolStripMenuItem.Text = "关闭配置(&C)";
            this.关闭配置CToolStripMenuItem.Click += new System.EventHandler(this.关闭配置CToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 261);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(506, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 283);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txt_rcon);
            this.Controls.Add(this.chb_rcon);
            this.Controls.Add(this.cbx_bot_diff);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.btn_path);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.txt_design_token);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbx_map);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbx_mode);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_token);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_hostname);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rdb_pworld;
		private System.Windows.Forms.RadioButton rdb_worldwide;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rdb_tick128;
		private System.Windows.Forms.RadioButton rdb_tick64;
		private System.Windows.Forms.TextBox txt_hostname;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.RadioButton rdb_uac_insecure;
		private System.Windows.Forms.RadioButton rdb_vac_secure;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.RadioButton rdb_bot_dis;
		private System.Windows.Forms.RadioButton rdb_bot_en;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.RadioButton rdb_list_dis;
		private System.Windows.Forms.RadioButton rdb_list_en;
		private System.Windows.Forms.TextBox txt_port;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.RadioButton rdb_wan;
		private System.Windows.Forms.RadioButton rdb_lan;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txt_token;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox cbx_mode;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.RadioButton rdb_mg_dis;
		private System.Windows.Forms.RadioButton rdb_mg_en;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cbx_map;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txt_design_token;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txt_path;
		private System.Windows.Forms.Button btn_path;
		private System.Windows.Forms.Button btn_run;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbx_bot_diff;
		private System.Windows.Forms.CheckBox chb_rcon;
		private System.Windows.Forms.TextBox txt_rcon;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 加载配置ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 保存配置ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 关闭配置CToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

