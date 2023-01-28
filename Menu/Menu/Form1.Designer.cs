namespace Menu
{
    partial class Notepad
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.myMenu = new System.Windows.Forms.MenuStrip();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.textFile = new System.Windows.Forms.ToolStripMenuItem();
            this.rTFFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opennFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFile = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatFile = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpFile = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutForm1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myToolbar = new System.Windows.Forms.ToolStrip();
            this.openIcon = new System.Windows.Forms.ToolStripButton();
            this.newIcon = new System.Windows.Forms.ToolStripButton();
            this.saveIcon = new System.Windows.Forms.ToolStripButton();
            this.saveasIcon = new System.Windows.Forms.ToolStripButton();
            this.Separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutIcon = new System.Windows.Forms.ToolStripButton();
            this.copyIcon = new System.Windows.Forms.ToolStripButton();
            this.pasteIcon = new System.Windows.Forms.ToolStripButton();
            this.delIcon = new System.Windows.Forms.ToolStripButton();
            this.Separator4 = new System.Windows.Forms.ToolStripSeparator();
            this.findIcon = new System.Windows.Forms.ToolStripButton();
            this.replaceIcon = new System.Windows.Forms.ToolStripButton();
            this.Separator5 = new System.Windows.Forms.ToolStripSeparator();
            this.leftIcon = new System.Windows.Forms.ToolStripButton();
            this.centereIcon = new System.Windows.Forms.ToolStripButton();
            this.rightIcon = new System.Windows.Forms.ToolStripButton();
            this.Separator6 = new System.Windows.Forms.ToolStripSeparator();
            this.fontIcon = new System.Windows.Forms.ToolStripButton();
            this.colorIcon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitIcon = new System.Windows.Forms.ToolStripButton();
            this.ComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rtext = new System.Windows.Forms.RichTextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.clrd = new System.Windows.Forms.ColorDialog();
            this.ft_d = new System.Windows.Forms.FontDialog();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myMenu.SuspendLayout();
            this.myToolbar.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // myMenu
            // 
            this.myMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.editFile,
            this.formatFile,
            this.viewFile,
            this.helpFile});
            this.myMenu.Location = new System.Drawing.Point(0, 0);
            this.myMenu.Name = "myMenu";
            this.myMenu.Size = new System.Drawing.Size(759, 24);
            this.myMenu.TabIndex = 0;
            this.myMenu.Text = "myMenu";
            // 
            // OpenFile
            // 
            this.OpenFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFile,
            this.opennFile,
            this.SaveFile,
            this.saveAsFile,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.ShortcutKeyDisplayString = "&File";
            this.OpenFile.Size = new System.Drawing.Size(37, 20);
            this.OpenFile.Text = "&File";
            // 
            // newFile
            // 
            this.newFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textFile,
            this.rTFFileToolStripMenuItem});
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(152, 22);
            this.newFile.Text = "New";
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // textFile
            // 
            this.textFile.Name = "textFile";
            this.textFile.Size = new System.Drawing.Size(116, 22);
            this.textFile.Text = "Text File";
            // 
            // rTFFileToolStripMenuItem
            // 
            this.rTFFileToolStripMenuItem.Name = "rTFFileToolStripMenuItem";
            this.rTFFileToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.rTFFileToolStripMenuItem.Text = "RTF File";
            // 
            // opennFile
            // 
            this.opennFile.Name = "opennFile";
            this.opennFile.Size = new System.Drawing.Size(152, 22);
            this.opennFile.Text = "Open";
            this.opennFile.Click += new System.EventHandler(this.opennFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(152, 22);
            this.SaveFile.Text = "Save";
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // saveAsFile
            // 
            this.saveAsFile.Name = "saveAsFile";
            this.saveAsFile.Size = new System.Drawing.Size(152, 22);
            this.saveAsFile.Text = "Save As";
            this.saveAsFile.Click += new System.EventHandler(this.saveAsFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editFile
            // 
            this.editFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.toolStripSeparator2,
            this.deleteToolStripMenuItem});
            this.editFile.Name = "editFile";
            this.editFile.ShortcutKeyDisplayString = "&Edit";
            this.editFile.Size = new System.Drawing.Size(39, 20);
            this.editFile.Text = "&Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "Copy";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Cut";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // formatFile
            // 
            this.formatFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrapToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.formatFile.Name = "formatFile";
            this.formatFile.ShortcutKeyDisplayString = "&Format";
            this.formatFile.Size = new System.Drawing.Size(57, 20);
            this.formatFile.Text = "F&ormat";
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wordWrapToolStripMenuItem.Text = "Word Wrap";
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // viewFile
            // 
            this.viewFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.statusBarItem});
            this.viewFile.Name = "viewFile";
            this.viewFile.ShortcutKeyDisplayString = "&View";
            this.viewFile.Size = new System.Drawing.Size(44, 20);
            this.viewFile.Text = "&View";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.zoomResetToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // statusBarItem
            // 
            this.statusBarItem.Checked = true;
            this.statusBarItem.CheckOnClick = true;
            this.statusBarItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarItem.Name = "statusBarItem";
            this.statusBarItem.Size = new System.Drawing.Size(152, 22);
            this.statusBarItem.Text = "Status Bar";
            this.statusBarItem.Click += new System.EventHandler(this.statusBarItem_Click);
            // 
            // helpFile
            // 
            this.helpFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.sendFeedbackToolStripMenuItem,
            this.toolStripSeparator4,
            this.aboutForm1ToolStripMenuItem});
            this.helpFile.Name = "helpFile";
            this.helpFile.ShortcutKeyDisplayString = "&Help";
            this.helpFile.Size = new System.Drawing.Size(44, 20);
            this.helpFile.Text = "&Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // sendFeedbackToolStripMenuItem
            // 
            this.sendFeedbackToolStripMenuItem.Name = "sendFeedbackToolStripMenuItem";
            this.sendFeedbackToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sendFeedbackToolStripMenuItem.Text = "Send Feedback";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(150, 6);
            // 
            // aboutForm1ToolStripMenuItem
            // 
            this.aboutForm1ToolStripMenuItem.Name = "aboutForm1ToolStripMenuItem";
            this.aboutForm1ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.aboutForm1ToolStripMenuItem.Text = "About Form1";
            // 
            // myToolbar
            // 
            this.myToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openIcon,
            this.newIcon,
            this.saveIcon,
            this.saveasIcon,
            this.Separator3,
            this.cutIcon,
            this.copyIcon,
            this.pasteIcon,
            this.delIcon,
            this.Separator4,
            this.findIcon,
            this.replaceIcon,
            this.Separator5,
            this.leftIcon,
            this.centereIcon,
            this.rightIcon,
            this.Separator6,
            this.fontIcon,
            this.colorIcon,
            this.toolStripSeparator3,
            this.exitIcon,
            this.ComboBox1});
            this.myToolbar.Location = new System.Drawing.Point(0, 24);
            this.myToolbar.Name = "myToolbar";
            this.myToolbar.Size = new System.Drawing.Size(759, 38);
            this.myToolbar.TabIndex = 1;
            this.myToolbar.Text = "myToolbar";
            // 
            // openIcon
            // 
            this.openIcon.Image = ((System.Drawing.Image)(resources.GetObject("openIcon.Image")));
            this.openIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openIcon.Name = "openIcon";
            this.openIcon.Size = new System.Drawing.Size(40, 35);
            this.openIcon.Text = "Open";
            this.openIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.openIcon.Click += new System.EventHandler(this.openIcon_Click);
            // 
            // newIcon
            // 
            this.newIcon.Image = ((System.Drawing.Image)(resources.GetObject("newIcon.Image")));
            this.newIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newIcon.Name = "newIcon";
            this.newIcon.Size = new System.Drawing.Size(35, 35);
            this.newIcon.Text = "New";
            this.newIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // saveIcon
            // 
            this.saveIcon.Image = ((System.Drawing.Image)(resources.GetObject("saveIcon.Image")));
            this.saveIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveIcon.Name = "saveIcon";
            this.saveIcon.Size = new System.Drawing.Size(35, 35);
            this.saveIcon.Text = "Save";
            this.saveIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // saveasIcon
            // 
            this.saveasIcon.Image = ((System.Drawing.Image)(resources.GetObject("saveasIcon.Image")));
            this.saveasIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveasIcon.Name = "saveasIcon";
            this.saveasIcon.Size = new System.Drawing.Size(51, 35);
            this.saveasIcon.Text = "Save As";
            this.saveasIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Separator3
            // 
            this.Separator3.Name = "Separator3";
            this.Separator3.Size = new System.Drawing.Size(6, 38);
            // 
            // cutIcon
            // 
            this.cutIcon.Image = ((System.Drawing.Image)(resources.GetObject("cutIcon.Image")));
            this.cutIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutIcon.Name = "cutIcon";
            this.cutIcon.Size = new System.Drawing.Size(30, 35);
            this.cutIcon.Text = "Cut";
            this.cutIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // copyIcon
            // 
            this.copyIcon.Image = ((System.Drawing.Image)(resources.GetObject("copyIcon.Image")));
            this.copyIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyIcon.Name = "copyIcon";
            this.copyIcon.Size = new System.Drawing.Size(39, 35);
            this.copyIcon.Text = "Copy";
            this.copyIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // pasteIcon
            // 
            this.pasteIcon.Image = ((System.Drawing.Image)(resources.GetObject("pasteIcon.Image")));
            this.pasteIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteIcon.Name = "pasteIcon";
            this.pasteIcon.Size = new System.Drawing.Size(39, 35);
            this.pasteIcon.Text = "Paste";
            this.pasteIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // delIcon
            // 
            this.delIcon.Image = ((System.Drawing.Image)(resources.GetObject("delIcon.Image")));
            this.delIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delIcon.Name = "delIcon";
            this.delIcon.Size = new System.Drawing.Size(44, 35);
            this.delIcon.Text = "Delete";
            this.delIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Separator4
            // 
            this.Separator4.Name = "Separator4";
            this.Separator4.Size = new System.Drawing.Size(6, 38);
            // 
            // findIcon
            // 
            this.findIcon.Image = ((System.Drawing.Image)(resources.GetObject("findIcon.Image")));
            this.findIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findIcon.Name = "findIcon";
            this.findIcon.Size = new System.Drawing.Size(34, 35);
            this.findIcon.Text = "Find";
            this.findIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // replaceIcon
            // 
            this.replaceIcon.Image = ((System.Drawing.Image)(resources.GetObject("replaceIcon.Image")));
            this.replaceIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.replaceIcon.Name = "replaceIcon";
            this.replaceIcon.Size = new System.Drawing.Size(52, 35);
            this.replaceIcon.Text = "Replace";
            this.replaceIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Separator5
            // 
            this.Separator5.Name = "Separator5";
            this.Separator5.Size = new System.Drawing.Size(6, 38);
            // 
            // leftIcon
            // 
            this.leftIcon.Image = ((System.Drawing.Image)(resources.GetObject("leftIcon.Image")));
            this.leftIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftIcon.Name = "leftIcon";
            this.leftIcon.Size = new System.Drawing.Size(31, 35);
            this.leftIcon.Text = "Left";
            this.leftIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.leftIcon.Click += new System.EventHandler(this.leftIcon_Click);
            // 
            // centereIcon
            // 
            this.centereIcon.Image = ((System.Drawing.Image)(resources.GetObject("centereIcon.Image")));
            this.centereIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.centereIcon.Name = "centereIcon";
            this.centereIcon.Size = new System.Drawing.Size(46, 35);
            this.centereIcon.Text = "Center";
            this.centereIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.centereIcon.Click += new System.EventHandler(this.centereIcon_Click);
            // 
            // rightIcon
            // 
            this.rightIcon.Image = ((System.Drawing.Image)(resources.GetObject("rightIcon.Image")));
            this.rightIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightIcon.Name = "rightIcon";
            this.rightIcon.Size = new System.Drawing.Size(39, 35);
            this.rightIcon.Text = "Right";
            this.rightIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rightIcon.Click += new System.EventHandler(this.rightIcon_Click);
            // 
            // Separator6
            // 
            this.Separator6.Name = "Separator6";
            this.Separator6.Size = new System.Drawing.Size(6, 38);
            // 
            // fontIcon
            // 
            this.fontIcon.Image = ((System.Drawing.Image)(resources.GetObject("fontIcon.Image")));
            this.fontIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontIcon.Name = "fontIcon";
            this.fontIcon.Size = new System.Drawing.Size(35, 35);
            this.fontIcon.Text = "Font";
            this.fontIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.fontIcon.Click += new System.EventHandler(this.fontIcon_Click);
            // 
            // colorIcon
            // 
            this.colorIcon.Image = ((System.Drawing.Image)(resources.GetObject("colorIcon.Image")));
            this.colorIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorIcon.Name = "colorIcon";
            this.colorIcon.Size = new System.Drawing.Size(40, 35);
            this.colorIcon.Text = "Color";
            this.colorIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.colorIcon.Click += new System.EventHandler(this.colorIcon_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // exitIcon
            // 
            this.exitIcon.Image = ((System.Drawing.Image)(resources.GetObject("exitIcon.Image")));
            this.exitIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitIcon.Name = "exitIcon";
            this.exitIcon.Size = new System.Drawing.Size(30, 35);
            this.exitIcon.Text = "Exit";
            this.exitIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitIcon.Click += new System.EventHandler(this.exitIcon_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.Items.AddRange(new object[] {
            "Red"});
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 23);
            this.ComboBox1.Text = "Canvas_clr";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusDate,
            this.statusTime,
            this.statusMessage});
            this.statusStrip.Location = new System.Drawing.Point(0, 326);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(759, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusDate
            // 
            this.statusDate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.statusDate.Name = "statusDate";
            this.statusDate.Size = new System.Drawing.Size(103, 17);
            this.statusDate.Text = "29 December 2022";
            // 
            // statusTime
            // 
            this.statusTime.Name = "statusTime";
            this.statusTime.Size = new System.Drawing.Size(49, 17);
            this.statusTime.Text = "09:37:55";
            // 
            // statusMessage
            // 
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(59, 17);
            this.statusMessage.Text = "Message :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rtext
            // 
            this.rtext.Location = new System.Drawing.Point(0, 65);
            this.rtext.Name = "rtext";
            this.rtext.Size = new System.Drawing.Size(759, 258);
            this.rtext.TabIndex = 3;
            this.rtext.Text = "";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // zoomResetToolStripMenuItem
            // 
            this.zoomResetToolStripMenuItem.Name = "zoomResetToolStripMenuItem";
            this.zoomResetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zoomResetToolStripMenuItem.Text = "Zoom Reset";
            this.zoomResetToolStripMenuItem.Click += new System.EventHandler(this.zoomResetToolStripMenuItem_Click);
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 348);
            this.Controls.Add(this.rtext);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.myToolbar);
            this.Controls.Add(this.myMenu);
            this.MainMenuStrip = this.myMenu;
            this.Name = "Notepad";
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.Notepad_Load);
            this.myMenu.ResumeLayout(false);
            this.myMenu.PerformLayout();
            this.myToolbar.ResumeLayout(false);
            this.myToolbar.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip myMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem newFile;
        private System.Windows.Forms.ToolStripMenuItem textFile;
        private System.Windows.Forms.ToolStripMenuItem rTFFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFile;
        private System.Windows.Forms.ToolStripMenuItem saveAsFile;
        private System.Windows.Forms.ToolStripMenuItem opennFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFile;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatFile;
        private System.Windows.Forms.ToolStripMenuItem helpFile;
        private System.Windows.Forms.ToolStrip myToolbar;
        private System.Windows.Forms.ToolStripButton openIcon;
        private System.Windows.Forms.ToolStripButton newIcon;
        private System.Windows.Forms.ToolStripButton saveIcon;
        private System.Windows.Forms.ToolStripButton saveasIcon;
        private System.Windows.Forms.ToolStripSeparator Separator3;
        private System.Windows.Forms.ToolStripButton cutIcon;
        private System.Windows.Forms.ToolStripButton copyIcon;
        private System.Windows.Forms.ToolStripButton pasteIcon;
        private System.Windows.Forms.ToolStripButton delIcon;
        private System.Windows.Forms.ToolStripSeparator Separator4;
        private System.Windows.Forms.ToolStripButton findIcon;
        private System.Windows.Forms.ToolStripButton replaceIcon;
        private System.Windows.Forms.ToolStripSeparator Separator5;
        private System.Windows.Forms.ToolStripButton leftIcon;
        private System.Windows.Forms.ToolStripButton centereIcon;
        private System.Windows.Forms.ToolStripButton rightIcon;
        private System.Windows.Forms.ToolStripSeparator Separator6;
        private System.Windows.Forms.ToolStripButton fontIcon;
        private System.Windows.Forms.ToolStripButton colorIcon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton exitIcon;
        private System.Windows.Forms.ToolStripComboBox ComboBox1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem aboutForm1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFile;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarItem;
        private System.Windows.Forms.ToolStripStatusLabel statusDate;
        private System.Windows.Forms.ToolStripStatusLabel statusTime;
        private System.Windows.Forms.ToolStripStatusLabel statusMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox rtext;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.ColorDialog clrd;
        private System.Windows.Forms.FontDialog ft_d;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomResetToolStripMenuItem;
    }
}

