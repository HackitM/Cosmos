﻿namespace Cosmos.VS.Package
{
	partial class CosmosPage
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      this.panel1 = new System.Windows.Forms.Panel();
      this.lablCurrentProfile = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.TabControl1 = new System.Windows.Forms.TabControl();
      this.tabProfile = new System.Windows.Forms.TabPage();
      this.lablNonFunctional = new System.Windows.Forms.Label();
      this.lablDeployText = new System.Windows.Forms.Label();
      this.lablBuildOnly = new System.Windows.Forms.Label();
      this.lboxProfile = new System.Windows.Forms.ListBox();
      this.tabCompile = new System.Windows.Forms.TabPage();
      this.comboFramework = new System.Windows.Forms.ComboBox();
      this.buttonOutputBrowse = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.textOutputPath = new System.Windows.Forms.TextBox();
      this.labelFramework = new System.Windows.Forms.Label();
      this.tabAssembler = new System.Windows.Forms.TabPage();
      this.checkUseInternalAssembler = new System.Windows.Forms.CheckBox();
      this.labelInternalAssembler = new System.Windows.Forms.Label();
      this.tabDebug = new System.Windows.Forms.TabPage();
      this.chckEnableDebugStub = new System.Windows.Forms.CheckBox();
      this.panlDebugSettings = new System.Windows.Forms.Panel();
      this.label4 = new System.Windows.Forms.Label();
      this.cmboVisusalStudioPort = new System.Windows.Forms.ComboBox();
      this.comboTraceMode = new System.Windows.Forms.ComboBox();
      this.cmboCosmosPort = new System.Windows.Forms.ComboBox();
      this.comboDebugMode = new System.Windows.Forms.ComboBox();
      this.label10 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.checkIgnoreDebugStubAttribute = new System.Windows.Forms.CheckBox();
      this.tabDeployment = new System.Windows.Forms.TabPage();
      this.lboxDeployment = new System.Windows.Forms.ListBox();
      this.tabLaunch = new System.Windows.Forms.TabPage();
      this.lboxLaunch = new System.Windows.Forms.ListBox();
      this.tabVMware = new System.Windows.Forms.TabPage();
      this.checkEnableGDB = new System.Windows.Forms.CheckBox();
      this.checkStartCosmosGDB = new System.Windows.Forms.CheckBox();
      this.label3 = new System.Windows.Forms.Label();
      this.cmboVMwareEdition = new System.Windows.Forms.ComboBox();
      this.tabPXE = new System.Windows.Forms.TabPage();
      this.label6 = new System.Windows.Forms.Label();
      this.tabUSB = new System.Windows.Forms.TabPage();
      this.label7 = new System.Windows.Forms.Label();
      this.tabISO = new System.Windows.Forms.TabPage();
      this.label8 = new System.Windows.Forms.Label();
      this.tabSlave = new System.Windows.Forms.TabPage();
      this.panel1.SuspendLayout();
      this.TabControl1.SuspendLayout();
      this.tabProfile.SuspendLayout();
      this.tabCompile.SuspendLayout();
      this.tabAssembler.SuspendLayout();
      this.tabDebug.SuspendLayout();
      this.panlDebugSettings.SuspendLayout();
      this.tabDeployment.SuspendLayout();
      this.tabLaunch.SuspendLayout();
      this.tabVMware.SuspendLayout();
      this.tabPXE.SuspendLayout();
      this.tabUSB.SuspendLayout();
      this.tabISO.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.lablCurrentProfile);
      this.panel1.Controls.Add(this.label11);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(635, 43);
      this.panel1.TabIndex = 3;
      // 
      // lablCurrentProfile
      // 
      this.lablCurrentProfile.AutoSize = true;
      this.lablCurrentProfile.Location = new System.Drawing.Point(99, 17);
      this.lablCurrentProfile.Name = "lablCurrentProfile";
      this.lablCurrentProfile.Size = new System.Drawing.Size(41, 13);
      this.lablCurrentProfile.TabIndex = 1;
      this.lablCurrentProfile.Text = "label12";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(17, 17);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(76, 13);
      this.label11.TabIndex = 0;
      this.label11.Text = "Current Profile:";
      // 
      // TabControl1
      // 
      this.TabControl1.Controls.Add(this.tabProfile);
      this.TabControl1.Controls.Add(this.tabCompile);
      this.TabControl1.Controls.Add(this.tabAssembler);
      this.TabControl1.Controls.Add(this.tabDebug);
      this.TabControl1.Controls.Add(this.tabDeployment);
      this.TabControl1.Controls.Add(this.tabLaunch);
      this.TabControl1.Controls.Add(this.tabVMware);
      this.TabControl1.Controls.Add(this.tabPXE);
      this.TabControl1.Controls.Add(this.tabUSB);
      this.TabControl1.Controls.Add(this.tabISO);
      this.TabControl1.Controls.Add(this.tabSlave);
      this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TabControl1.Location = new System.Drawing.Point(0, 43);
      this.TabControl1.Multiline = true;
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      this.TabControl1.Size = new System.Drawing.Size(635, 413);
      this.TabControl1.TabIndex = 4;
      // 
      // tabProfile
      // 
      this.tabProfile.Controls.Add(this.lablNonFunctional);
      this.tabProfile.Controls.Add(this.lablDeployText);
      this.tabProfile.Controls.Add(this.lablBuildOnly);
      this.tabProfile.Controls.Add(this.lboxProfile);
      this.tabProfile.Location = new System.Drawing.Point(4, 22);
      this.tabProfile.Name = "tabProfile";
      this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
      this.tabProfile.Size = new System.Drawing.Size(627, 387);
      this.tabProfile.TabIndex = 8;
      this.tabProfile.Text = "Profile";
      this.tabProfile.UseVisualStyleBackColor = true;
      // 
      // lablNonFunctional
      // 
      this.lablNonFunctional.AutoSize = true;
      this.lablNonFunctional.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lablNonFunctional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lablNonFunctional.Location = new System.Drawing.Point(226, 188);
      this.lablNonFunctional.Name = "lablNonFunctional";
      this.lablNonFunctional.Size = new System.Drawing.Size(206, 13);
      this.lablNonFunctional.TabIndex = 5;
      this.lablNonFunctional.Text = "This option is not currently functional.";
      // 
      // lablDeployText
      // 
      this.lablDeployText.Location = new System.Drawing.Point(226, 13);
      this.lablDeployText.Name = "lablDeployText";
      this.lablDeployText.Size = new System.Drawing.Size(228, 137);
      this.lablDeployText.TabIndex = 4;
      this.lablDeployText.Text = "label1";
      // 
      // lablBuildOnly
      // 
      this.lablBuildOnly.AutoSize = true;
      this.lablBuildOnly.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lablBuildOnly.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.lablBuildOnly.Location = new System.Drawing.Point(226, 166);
      this.lablBuildOnly.Name = "lablBuildOnly";
      this.lablBuildOnly.Size = new System.Drawing.Size(207, 13);
      this.lablBuildOnly.TabIndex = 3;
      this.lablBuildOnly.Text = "You have selected a build only option.";
      // 
      // lboxProfile
      // 
      this.lboxProfile.Dock = System.Windows.Forms.DockStyle.Left;
      this.lboxProfile.FormattingEnabled = true;
      this.lboxProfile.Location = new System.Drawing.Point(3, 3);
      this.lboxProfile.Name = "lboxProfile";
      this.lboxProfile.Size = new System.Drawing.Size(206, 381);
      this.lboxProfile.Sorted = true;
      this.lboxProfile.TabIndex = 2;
      // 
      // tabCompile
      // 
      this.tabCompile.AutoScroll = true;
      this.tabCompile.Controls.Add(this.comboFramework);
      this.tabCompile.Controls.Add(this.buttonOutputBrowse);
      this.tabCompile.Controls.Add(this.label2);
      this.tabCompile.Controls.Add(this.textOutputPath);
      this.tabCompile.Controls.Add(this.labelFramework);
      this.tabCompile.Location = new System.Drawing.Point(4, 22);
      this.tabCompile.Name = "tabCompile";
      this.tabCompile.Padding = new System.Windows.Forms.Padding(3);
      this.tabCompile.Size = new System.Drawing.Size(627, 387);
      this.tabCompile.TabIndex = 0;
      this.tabCompile.Text = "Compile";
      this.tabCompile.UseVisualStyleBackColor = true;
      // 
      // comboFramework
      // 
      this.comboFramework.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboFramework.Enabled = false;
      this.comboFramework.FormattingEnabled = true;
      this.comboFramework.Location = new System.Drawing.Point(34, 87);
      this.comboFramework.Name = "comboFramework";
      this.comboFramework.Size = new System.Drawing.Size(228, 21);
      this.comboFramework.TabIndex = 22;
      // 
      // buttonOutputBrowse
      // 
      this.buttonOutputBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonOutputBrowse.Location = new System.Drawing.Point(430, 37);
      this.buttonOutputBrowse.Name = "buttonOutputBrowse";
      this.buttonOutputBrowse.Size = new System.Drawing.Size(21, 23);
      this.buttonOutputBrowse.TabIndex = 20;
      this.buttonOutputBrowse.Text = "..";
      this.buttonOutputBrowse.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(18, 17);
      this.label2.Margin = new System.Windows.Forms.Padding(22, 3, 0, 3);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(75, 15);
      this.label2.TabIndex = 19;
      this.label2.Text = "Output path:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // textOutputPath
      // 
      this.textOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textOutputPath.Location = new System.Drawing.Point(34, 38);
      this.textOutputPath.Name = "textOutputPath";
      this.textOutputPath.Size = new System.Drawing.Size(390, 20);
      this.textOutputPath.TabIndex = 18;
      // 
      // labelFramework
      // 
      this.labelFramework.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.labelFramework.AutoSize = true;
      this.labelFramework.Enabled = false;
      this.labelFramework.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelFramework.Location = new System.Drawing.Point(18, 66);
      this.labelFramework.Margin = new System.Windows.Forms.Padding(22, 3, 0, 3);
      this.labelFramework.Name = "labelFramework";
      this.labelFramework.Size = new System.Drawing.Size(69, 15);
      this.labelFramework.TabIndex = 21;
      this.labelFramework.Text = "Framework:";
      this.labelFramework.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tabAssembler
      // 
      this.tabAssembler.Controls.Add(this.checkUseInternalAssembler);
      this.tabAssembler.Controls.Add(this.labelInternalAssembler);
      this.tabAssembler.Location = new System.Drawing.Point(4, 22);
      this.tabAssembler.Name = "tabAssembler";
      this.tabAssembler.Size = new System.Drawing.Size(627, 387);
      this.tabAssembler.TabIndex = 10;
      this.tabAssembler.Text = "Assembler";
      this.tabAssembler.UseVisualStyleBackColor = true;
      // 
      // checkUseInternalAssembler
      // 
      this.checkUseInternalAssembler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.checkUseInternalAssembler.AutoSize = true;
      this.checkUseInternalAssembler.Enabled = false;
      this.checkUseInternalAssembler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkUseInternalAssembler.Location = new System.Drawing.Point(18, 12);
      this.checkUseInternalAssembler.Margin = new System.Windows.Forms.Padding(22, 12, 3, 3);
      this.checkUseInternalAssembler.Name = "checkUseInternalAssembler";
      this.checkUseInternalAssembler.Size = new System.Drawing.Size(146, 19);
      this.checkUseInternalAssembler.TabIndex = 21;
      this.checkUseInternalAssembler.Text = "Use Internal Assembler";
      this.checkUseInternalAssembler.UseVisualStyleBackColor = true;
      // 
      // labelInternalAssembler
      // 
      this.labelInternalAssembler.Enabled = false;
      this.labelInternalAssembler.Location = new System.Drawing.Point(40, 32);
      this.labelInternalAssembler.Margin = new System.Windows.Forms.Padding(44, 0, 3, 0);
      this.labelInternalAssembler.Name = "labelInternalAssembler";
      this.labelInternalAssembler.Size = new System.Drawing.Size(224, 18);
      this.labelInternalAssembler.TabIndex = 20;
      this.labelInternalAssembler.Text = "Experimental. Check if you like to crash!";
      // 
      // tabDebug
      // 
      this.tabDebug.AutoScroll = true;
      this.tabDebug.Controls.Add(this.chckEnableDebugStub);
      this.tabDebug.Controls.Add(this.panlDebugSettings);
      this.tabDebug.Location = new System.Drawing.Point(4, 22);
      this.tabDebug.Name = "tabDebug";
      this.tabDebug.Padding = new System.Windows.Forms.Padding(3);
      this.tabDebug.Size = new System.Drawing.Size(627, 387);
      this.tabDebug.TabIndex = 2;
      this.tabDebug.Text = "Debug";
      this.tabDebug.UseVisualStyleBackColor = true;
      // 
      // chckEnableDebugStub
      // 
      this.chckEnableDebugStub.AutoSize = true;
      this.chckEnableDebugStub.Location = new System.Drawing.Point(14, 17);
      this.chckEnableDebugStub.Name = "chckEnableDebugStub";
      this.chckEnableDebugStub.Size = new System.Drawing.Size(154, 17);
      this.chckEnableDebugStub.TabIndex = 34;
      this.chckEnableDebugStub.Text = "Enable Remote Debugging";
      this.chckEnableDebugStub.UseVisualStyleBackColor = true;
      // 
      // panlDebugSettings
      // 
      this.panlDebugSettings.Controls.Add(this.label4);
      this.panlDebugSettings.Controls.Add(this.cmboVisusalStudioPort);
      this.panlDebugSettings.Controls.Add(this.comboTraceMode);
      this.panlDebugSettings.Controls.Add(this.cmboCosmosPort);
      this.panlDebugSettings.Controls.Add(this.comboDebugMode);
      this.panlDebugSettings.Controls.Add(this.label10);
      this.panlDebugSettings.Controls.Add(this.label5);
      this.panlDebugSettings.Controls.Add(this.label9);
      this.panlDebugSettings.Controls.Add(this.checkIgnoreDebugStubAttribute);
      this.panlDebugSettings.Location = new System.Drawing.Point(6, 51);
      this.panlDebugSettings.Name = "panlDebugSettings";
      this.panlDebugSettings.Size = new System.Drawing.Size(280, 259);
      this.panlDebugSettings.TabIndex = 33;
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(5, 4);
      this.label4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(98, 21);
      this.label4.TabIndex = 24;
      this.label4.Text = "Debug Level:";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cmboVisusalStudioPort
      // 
      this.cmboVisusalStudioPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmboVisusalStudioPort.FormattingEnabled = true;
      this.cmboVisusalStudioPort.Items.AddRange(new object[] {
            "Serial Com1",
            "Serial Com2",
            "Serial Com3",
            "Serial Com4",
            "Ethernet (not supported yet)"});
      this.cmboVisusalStudioPort.Location = new System.Drawing.Point(23, 226);
      this.cmboVisusalStudioPort.Name = "cmboVisusalStudioPort";
      this.cmboVisusalStudioPort.Size = new System.Drawing.Size(163, 21);
      this.cmboVisusalStudioPort.TabIndex = 32;
      // 
      // comboTraceMode
      // 
      this.comboTraceMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboTraceMode.FormattingEnabled = true;
      this.comboTraceMode.Location = new System.Drawing.Point(23, 79);
      this.comboTraceMode.Name = "comboTraceMode";
      this.comboTraceMode.Size = new System.Drawing.Size(221, 21);
      this.comboTraceMode.TabIndex = 25;
      // 
      // cmboCosmosPort
      // 
      this.cmboCosmosPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmboCosmosPort.FormattingEnabled = true;
      this.cmboCosmosPort.Items.AddRange(new object[] {
            "Serial Com1",
            "Serial Com2",
            "Serial Com3",
            "Serial Com4",
            "Ethernet (not supported yet)"});
      this.cmboCosmosPort.Location = new System.Drawing.Point(23, 178);
      this.cmboCosmosPort.Name = "cmboCosmosPort";
      this.cmboCosmosPort.Size = new System.Drawing.Size(163, 21);
      this.cmboCosmosPort.TabIndex = 31;
      // 
      // comboDebugMode
      // 
      this.comboDebugMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboDebugMode.FormattingEnabled = true;
      this.comboDebugMode.Location = new System.Drawing.Point(23, 31);
      this.comboDebugMode.Name = "comboDebugMode";
      this.comboDebugMode.Size = new System.Drawing.Size(221, 21);
      this.comboDebugMode.TabIndex = 27;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(9, 207);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(93, 13);
      this.label10.TabIndex = 30;
      this.label10.Text = "Visual Studio Port:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(5, 58);
      this.label5.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(50, 15);
      this.label5.TabIndex = 26;
      this.label5.Text = "Tracing:";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(9, 155);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(69, 13);
      this.label9.TabIndex = 29;
      this.label9.Text = "Cosmos Port:";
      // 
      // checkIgnoreDebugStubAttribute
      // 
      this.checkIgnoreDebugStubAttribute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkIgnoreDebugStubAttribute.Location = new System.Drawing.Point(8, 120);
      this.checkIgnoreDebugStubAttribute.Name = "checkIgnoreDebugStubAttribute";
      this.checkIgnoreDebugStubAttribute.Size = new System.Drawing.Size(218, 20);
      this.checkIgnoreDebugStubAttribute.TabIndex = 28;
      this.checkIgnoreDebugStubAttribute.Text = "Ignore DebugStub Attribute Settings";
      this.checkIgnoreDebugStubAttribute.UseVisualStyleBackColor = true;
      // 
      // tabDeployment
      // 
      this.tabDeployment.Controls.Add(this.lboxDeployment);
      this.tabDeployment.Location = new System.Drawing.Point(4, 22);
      this.tabDeployment.Name = "tabDeployment";
      this.tabDeployment.Size = new System.Drawing.Size(627, 387);
      this.tabDeployment.TabIndex = 11;
      this.tabDeployment.Text = "Deployment";
      this.tabDeployment.UseVisualStyleBackColor = true;
      // 
      // lboxDeployment
      // 
      this.lboxDeployment.Dock = System.Windows.Forms.DockStyle.Left;
      this.lboxDeployment.FormattingEnabled = true;
      this.lboxDeployment.Location = new System.Drawing.Point(0, 0);
      this.lboxDeployment.Name = "lboxDeployment";
      this.lboxDeployment.Size = new System.Drawing.Size(206, 293);
      this.lboxDeployment.Sorted = true;
      this.lboxDeployment.TabIndex = 3;
      // 
      // tabLaunch
      // 
      this.tabLaunch.Controls.Add(this.lboxLaunch);
      this.tabLaunch.Location = new System.Drawing.Point(4, 22);
      this.tabLaunch.Name = "tabLaunch";
      this.tabLaunch.Size = new System.Drawing.Size(627, 387);
      this.tabLaunch.TabIndex = 12;
      this.tabLaunch.Text = "Launch";
      this.tabLaunch.UseVisualStyleBackColor = true;
      // 
      // lboxLaunch
      // 
      this.lboxLaunch.Dock = System.Windows.Forms.DockStyle.Left;
      this.lboxLaunch.FormattingEnabled = true;
      this.lboxLaunch.Location = new System.Drawing.Point(0, 0);
      this.lboxLaunch.Name = "lboxLaunch";
      this.lboxLaunch.Size = new System.Drawing.Size(206, 293);
      this.lboxLaunch.Sorted = true;
      this.lboxLaunch.TabIndex = 3;
      // 
      // tabVMware
      // 
      this.tabVMware.Controls.Add(this.checkEnableGDB);
      this.tabVMware.Controls.Add(this.checkStartCosmosGDB);
      this.tabVMware.Controls.Add(this.label3);
      this.tabVMware.Controls.Add(this.cmboVMwareEdition);
      this.tabVMware.Location = new System.Drawing.Point(4, 22);
      this.tabVMware.Name = "tabVMware";
      this.tabVMware.Padding = new System.Windows.Forms.Padding(3);
      this.tabVMware.Size = new System.Drawing.Size(627, 387);
      this.tabVMware.TabIndex = 4;
      this.tabVMware.Text = "VMware";
      this.tabVMware.UseVisualStyleBackColor = true;
      // 
      // checkEnableGDB
      // 
      this.checkEnableGDB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkEnableGDB.Location = new System.Drawing.Point(9, 77);
      this.checkEnableGDB.Name = "checkEnableGDB";
      this.checkEnableGDB.Size = new System.Drawing.Size(218, 20);
      this.checkEnableGDB.TabIndex = 25;
      this.checkEnableGDB.Text = "Enable GDB Debugger";
      this.checkEnableGDB.UseVisualStyleBackColor = true;
      // 
      // checkStartCosmosGDB
      // 
      this.checkStartCosmosGDB.AutoSize = true;
      this.checkStartCosmosGDB.Enabled = false;
      this.checkStartCosmosGDB.Location = new System.Drawing.Point(24, 103);
      this.checkStartCosmosGDB.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
      this.checkStartCosmosGDB.Name = "checkStartCosmosGDB";
      this.checkStartCosmosGDB.Size = new System.Drawing.Size(140, 17);
      this.checkStartCosmosGDB.TabIndex = 26;
      this.checkStartCosmosGDB.Text = "Use Cosmos GDB Client";
      this.checkStartCosmosGDB.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 12);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(42, 13);
      this.label3.TabIndex = 18;
      this.label3.Text = "Edition:";
      // 
      // cmboVMwareEdition
      // 
      this.cmboVMwareEdition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmboVMwareEdition.FormattingEnabled = true;
      this.cmboVMwareEdition.Location = new System.Drawing.Point(26, 37);
      this.cmboVMwareEdition.Name = "cmboVMwareEdition";
      this.cmboVMwareEdition.Size = new System.Drawing.Size(143, 21);
      this.cmboVMwareEdition.Sorted = true;
      this.cmboVMwareEdition.TabIndex = 17;
      // 
      // tabPXE
      // 
      this.tabPXE.Controls.Add(this.label6);
      this.tabPXE.Location = new System.Drawing.Point(4, 22);
      this.tabPXE.Name = "tabPXE";
      this.tabPXE.Padding = new System.Windows.Forms.Padding(3);
      this.tabPXE.Size = new System.Drawing.Size(627, 387);
      this.tabPXE.TabIndex = 5;
      this.tabPXE.Text = "PXE";
      this.tabPXE.UseVisualStyleBackColor = true;
      // 
      // label6
      // 
      this.label6.Location = new System.Drawing.Point(23, 22);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(375, 102);
      this.label6.TabIndex = 0;
      this.label6.Text = "Currently PXE is locked to 192.168.42.1 to avoid configuration conflicts among Co" +
    "smos developers. For now please use this configuation.";
      // 
      // tabUSB
      // 
      this.tabUSB.Controls.Add(this.label7);
      this.tabUSB.Location = new System.Drawing.Point(4, 22);
      this.tabUSB.Name = "tabUSB";
      this.tabUSB.Padding = new System.Windows.Forms.Padding(3);
      this.tabUSB.Size = new System.Drawing.Size(627, 387);
      this.tabUSB.TabIndex = 6;
      this.tabUSB.Text = "USB";
      this.tabUSB.UseVisualStyleBackColor = true;
      // 
      // label7
      // 
      this.label7.Location = new System.Drawing.Point(16, 15);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(375, 102);
      this.label7.TabIndex = 1;
      this.label7.Text = "There are no current USB options. The target drive will be asked when you run the" +
    " project.";
      // 
      // tabISO
      // 
      this.tabISO.Controls.Add(this.label8);
      this.tabISO.Location = new System.Drawing.Point(4, 22);
      this.tabISO.Name = "tabISO";
      this.tabISO.Padding = new System.Windows.Forms.Padding(3);
      this.tabISO.Size = new System.Drawing.Size(627, 387);
      this.tabISO.TabIndex = 7;
      this.tabISO.Text = "ISO";
      this.tabISO.UseVisualStyleBackColor = true;
      // 
      // label8
      // 
      this.label8.Location = new System.Drawing.Point(17, 16);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(375, 102);
      this.label8.TabIndex = 1;
      this.label8.Text = "There are currently no ISO options.";
      // 
      // tabSlave
      // 
      this.tabSlave.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.tabSlave.Location = new System.Drawing.Point(4, 22);
      this.tabSlave.Name = "tabSlave";
      this.tabSlave.Size = new System.Drawing.Size(627, 387);
      this.tabSlave.TabIndex = 9;
      this.tabSlave.Text = "Slave";
      this.tabSlave.UseVisualStyleBackColor = true;
      // 
      // CosmosPage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.TabControl1);
      this.Controls.Add(this.panel1);
      this.Name = "CosmosPage";
      this.Size = new System.Drawing.Size(635, 456);
      this.Title = "Cosmos";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.TabControl1.ResumeLayout(false);
      this.tabProfile.ResumeLayout(false);
      this.tabProfile.PerformLayout();
      this.tabCompile.ResumeLayout(false);
      this.tabCompile.PerformLayout();
      this.tabAssembler.ResumeLayout(false);
      this.tabAssembler.PerformLayout();
      this.tabDebug.ResumeLayout(false);
      this.tabDebug.PerformLayout();
      this.panlDebugSettings.ResumeLayout(false);
      this.panlDebugSettings.PerformLayout();
      this.tabDeployment.ResumeLayout(false);
      this.tabLaunch.ResumeLayout(false);
      this.tabVMware.ResumeLayout(false);
      this.tabVMware.PerformLayout();
      this.tabPXE.ResumeLayout(false);
      this.tabUSB.ResumeLayout(false);
      this.tabISO.ResumeLayout(false);
      this.ResumeLayout(false);

		}

		#endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lablCurrentProfile;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TabControl TabControl1;
    private System.Windows.Forms.TabPage tabProfile;
    private System.Windows.Forms.Label lablNonFunctional;
    private System.Windows.Forms.Label lablDeployText;
    private System.Windows.Forms.Label lablBuildOnly;
    private System.Windows.Forms.ListBox lboxProfile;
    private System.Windows.Forms.TabPage tabDeployment;
    private System.Windows.Forms.ListBox lboxDeployment;
    private System.Windows.Forms.TabPage tabLaunch;
    private System.Windows.Forms.ListBox lboxLaunch;
    private System.Windows.Forms.TabPage tabCompile;
    private System.Windows.Forms.ComboBox comboFramework;
    private System.Windows.Forms.Button buttonOutputBrowse;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textOutputPath;
    private System.Windows.Forms.Label labelFramework;
    private System.Windows.Forms.TabPage tabAssembler;
    private System.Windows.Forms.CheckBox checkUseInternalAssembler;
    private System.Windows.Forms.Label labelInternalAssembler;
    private System.Windows.Forms.TabPage tabDebug;
    private System.Windows.Forms.CheckBox chckEnableDebugStub;
    private System.Windows.Forms.Panel panlDebugSettings;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cmboVisusalStudioPort;
    private System.Windows.Forms.ComboBox comboTraceMode;
    private System.Windows.Forms.ComboBox cmboCosmosPort;
    private System.Windows.Forms.ComboBox comboDebugMode;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.CheckBox checkIgnoreDebugStubAttribute;
    private System.Windows.Forms.TabPage tabVMware;
    private System.Windows.Forms.CheckBox checkEnableGDB;
    private System.Windows.Forms.CheckBox checkStartCosmosGDB;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cmboVMwareEdition;
    private System.Windows.Forms.TabPage tabPXE;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TabPage tabUSB;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TabPage tabISO;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TabPage tabSlave;




  }
}
