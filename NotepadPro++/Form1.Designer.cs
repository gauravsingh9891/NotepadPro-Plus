namespace NotepadPro__
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileMenuItem = new ToolStripMenuItem();
            newFileMenuItem = new ToolStripMenuItem();
            openFileMenuItem = new ToolStripMenuItem();
            saveFileMenuItem = new ToolStripMenuItem();
            saveAsFileMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            printFileMenuItem = new ToolStripMenuItem();
            PrintPreviewFileMenu = new ToolStripMenuItem();
            PageSetupFileMenu = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            exitFileMenuItem = new ToolStripMenuItem();
            editMenuItem = new ToolStripMenuItem();
            undoEditMenuItem = new ToolStripMenuItem();
            redoMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            cutEditMenuItem = new ToolStripMenuItem();
            copyEditMenuItem = new ToolStripMenuItem();
            pasteEditMenuItem = new ToolStripMenuItem();
            deleteEditMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            findEditMenuItem = new ToolStripMenuItem();
            findNextEditMenuItem = new ToolStripMenuItem();
            replaceEditMenuItem = new ToolStripMenuItem();
            goToEditMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            selectAllEditMenuItem = new ToolStripMenuItem();
            timeDateEditMenuItem = new ToolStripMenuItem();
            formatMenuItem = new ToolStripMenuItem();
            fontFormatMenuItem = new ToolStripMenuItem();
            changeTextColorToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            normalToolStripMenuItem = new ToolStripMenuItem();
            boldToolStripMenuItem = new ToolStripMenuItem();
            italicToolStripMenuItem = new ToolStripMenuItem();
            underlineToolStripMenuItem = new ToolStripMenuItem();
            strikethroughToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            wordWrapFormatMenuItem = new ToolStripMenuItem();
            boldToolStripMenuItem1 = new ToolStripMenuItem();
            viewMenuItem = new ToolStripMenuItem();
            statusBarViewMenuItem = new ToolStripMenuItem();
            helpMenuItem = new ToolStripMenuItem();
            viewHelpMenuItem = new ToolStripMenuItem();
            aboutNotepadMenuItem = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
            statusStrip1 = new StatusStrip();
            rtbTextArea = new RichTextBox();
            toolStrip1 = new ToolStrip();
            newFileToolStrip = new ToolStripButton();
            openFileToolStrip = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            saveToolStrip = new ToolStripButton();
            saveAsToolStrip = new ToolStripButton();
            toolStripSeparator9 = new ToolStripSeparator();
            printToolStrip = new ToolStripButton();
            printPreviewToolStrip = new ToolStripButton();
            pageSetupToolStrip = new ToolStripButton();
            toolStripSeparator10 = new ToolStripSeparator();
            undoToolStrip = new ToolStripButton();
            redoToolStrip = new ToolStripButton();
            toolStripSeparator11 = new ToolStripSeparator();
            cutToolStrip = new ToolStripButton();
            copyToolStrip = new ToolStripButton();
            pasteToolStrip = new ToolStripButton();
            deleteToolStrip = new ToolStripButton();
            toolStripSeparator12 = new ToolStripSeparator();
            boldToolStrip = new ToolStripButton();
            ItalicToolStrip = new ToolStripButton();
            underlineToolStrip = new ToolStripButton();
            strikeToolStrip = new ToolStripButton();
            toolStripSeparator13 = new ToolStripSeparator();
            fontFormatToolStrip = new ToolStripButton();
            textColorToolStrip = new ToolStripButton();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            pageSetupDialog1 = new PageSetupDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            MessageToolStripStatusLabel = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileMenuItem, editMenuItem, formatMenuItem, viewMenuItem, helpMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(946, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newFileMenuItem, openFileMenuItem, saveFileMenuItem, saveAsFileMenuItem, toolStripSeparator1, printFileMenuItem, PrintPreviewFileMenu, PageSetupFileMenu, toolStripSeparator6, exitFileMenuItem });
            fileMenuItem.Name = "fileMenuItem";
            fileMenuItem.Size = new Size(37, 20);
            fileMenuItem.Text = "&File";
            // 
            // newFileMenuItem
            // 
            newFileMenuItem.Image = Properties.Resources.New;
            newFileMenuItem.Name = "newFileMenuItem";
            newFileMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newFileMenuItem.Size = new Size(195, 22);
            newFileMenuItem.Text = "&New";
            newFileMenuItem.Click += newFileMenuItem_Click;
            // 
            // openFileMenuItem
            // 
            openFileMenuItem.Image = Properties.Resources.Open;
            openFileMenuItem.Name = "openFileMenuItem";
            openFileMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openFileMenuItem.Size = new Size(195, 22);
            openFileMenuItem.Text = "&Open...";
            openFileMenuItem.Click += openFileMenuItem_Click;
            // 
            // saveFileMenuItem
            // 
            saveFileMenuItem.Image = Properties.Resources.Save;
            saveFileMenuItem.Name = "saveFileMenuItem";
            saveFileMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveFileMenuItem.Size = new Size(195, 22);
            saveFileMenuItem.Text = "&Save";
            saveFileMenuItem.Click += saveFileMenuItem_Click;
            // 
            // saveAsFileMenuItem
            // 
            saveAsFileMenuItem.Image = Properties.Resources.save_as;
            saveAsFileMenuItem.Name = "saveAsFileMenuItem";
            saveAsFileMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsFileMenuItem.Size = new Size(195, 22);
            saveAsFileMenuItem.Text = "Sa&ve As...";
            saveAsFileMenuItem.Click += saveAsFileMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(192, 6);
            // 
            // printFileMenuItem
            // 
            printFileMenuItem.Image = Properties.Resources.print;
            printFileMenuItem.Name = "printFileMenuItem";
            printFileMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printFileMenuItem.Size = new Size(195, 22);
            printFileMenuItem.Text = "P&rint...";
            printFileMenuItem.Click += printFileMenuItem_Click;
            // 
            // PrintPreviewFileMenu
            // 
            PrintPreviewFileMenu.Image = Properties.Resources.document;
            PrintPreviewFileMenu.Name = "PrintPreviewFileMenu";
            PrintPreviewFileMenu.Size = new Size(195, 22);
            PrintPreviewFileMenu.Text = "&Print Preview";
            PrintPreviewFileMenu.Click += PrintPreviewFile_Click;
            // 
            // PageSetupFileMenu
            // 
            PageSetupFileMenu.Image = Properties.Resources.settings;
            PageSetupFileMenu.Name = "PageSetupFileMenu";
            PageSetupFileMenu.Size = new Size(195, 22);
            PageSetupFileMenu.Text = "Page Se&tup";
            PageSetupFileMenu.Click += PageSetupFileMenu_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(192, 6);
            // 
            // exitFileMenuItem
            // 
            exitFileMenuItem.Image = Properties.Resources.close;
            exitFileMenuItem.Name = "exitFileMenuItem";
            exitFileMenuItem.Size = new Size(195, 22);
            exitFileMenuItem.Text = "E&xit";
            exitFileMenuItem.Click += exitFileMenuItem_Click;
            // 
            // editMenuItem
            // 
            editMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoEditMenuItem, redoMenuItem, toolStripSeparator3, cutEditMenuItem, copyEditMenuItem, pasteEditMenuItem, deleteEditMenuItem, toolStripSeparator4, findEditMenuItem, findNextEditMenuItem, replaceEditMenuItem, goToEditMenuItem, toolStripSeparator5, selectAllEditMenuItem, timeDateEditMenuItem });
            editMenuItem.Name = "editMenuItem";
            editMenuItem.Size = new Size(39, 20);
            editMenuItem.Text = "&Edit";
            // 
            // undoEditMenuItem
            // 
            undoEditMenuItem.Enabled = false;
            undoEditMenuItem.Image = Properties.Resources.arrow_undo;
            undoEditMenuItem.Name = "undoEditMenuItem";
            undoEditMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoEditMenuItem.Size = new Size(167, 22);
            undoEditMenuItem.Text = "&Undo";
            undoEditMenuItem.Click += undoEditMenuItem_Click;
            // 
            // redoMenuItem
            // 
            redoMenuItem.Enabled = false;
            redoMenuItem.Image = Properties.Resources.arrow_redo;
            redoMenuItem.Name = "redoMenuItem";
            redoMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoMenuItem.Size = new Size(167, 22);
            redoMenuItem.Text = "&Redo";
            redoMenuItem.Click += redoMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(164, 6);
            // 
            // cutEditMenuItem
            // 
            cutEditMenuItem.Image = Properties.Resources.cut_red;
            cutEditMenuItem.Name = "cutEditMenuItem";
            cutEditMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutEditMenuItem.Size = new Size(167, 22);
            cutEditMenuItem.Text = "&Cut";
            // 
            // copyEditMenuItem
            // 
            copyEditMenuItem.Image = Properties.Resources.copy;
            copyEditMenuItem.Name = "copyEditMenuItem";
            copyEditMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyEditMenuItem.Size = new Size(167, 22);
            copyEditMenuItem.Text = "Copy";
            // 
            // pasteEditMenuItem
            // 
            pasteEditMenuItem.Image = Properties.Resources.paste;
            pasteEditMenuItem.Name = "pasteEditMenuItem";
            pasteEditMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteEditMenuItem.Size = new Size(167, 22);
            pasteEditMenuItem.Text = "Paste";
            // 
            // deleteEditMenuItem
            // 
            deleteEditMenuItem.Image = Properties.Resources.delete;
            deleteEditMenuItem.Name = "deleteEditMenuItem";
            deleteEditMenuItem.ShortcutKeys = Keys.Delete;
            deleteEditMenuItem.Size = new Size(167, 22);
            deleteEditMenuItem.Text = "Delete";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(164, 6);
            // 
            // findEditMenuItem
            // 
            findEditMenuItem.Image = Properties.Resources.find;
            findEditMenuItem.Name = "findEditMenuItem";
            findEditMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            findEditMenuItem.Size = new Size(167, 22);
            findEditMenuItem.Text = "Find...";
            // 
            // findNextEditMenuItem
            // 
            findNextEditMenuItem.Image = Properties.Resources.FindNext;
            findNextEditMenuItem.Name = "findNextEditMenuItem";
            findNextEditMenuItem.ShortcutKeys = Keys.F3;
            findNextEditMenuItem.Size = new Size(167, 22);
            findNextEditMenuItem.Text = "Find Next";
            // 
            // replaceEditMenuItem
            // 
            replaceEditMenuItem.Image = Properties.Resources.text_replace;
            replaceEditMenuItem.Name = "replaceEditMenuItem";
            replaceEditMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            replaceEditMenuItem.Size = new Size(167, 22);
            replaceEditMenuItem.Text = "Replace...";
            // 
            // goToEditMenuItem
            // 
            goToEditMenuItem.Name = "goToEditMenuItem";
            goToEditMenuItem.ShortcutKeys = Keys.Control | Keys.G;
            goToEditMenuItem.Size = new Size(167, 22);
            goToEditMenuItem.Text = "Go To...";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(164, 6);
            // 
            // selectAllEditMenuItem
            // 
            selectAllEditMenuItem.Image = Properties.Resources.Select_all;
            selectAllEditMenuItem.Name = "selectAllEditMenuItem";
            selectAllEditMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllEditMenuItem.Size = new Size(167, 22);
            selectAllEditMenuItem.Text = "Se&lect All";
            selectAllEditMenuItem.Click += selectAllEditMenuItem_Click;
            // 
            // timeDateEditMenuItem
            // 
            timeDateEditMenuItem.Image = Properties.Resources.DateTime;
            timeDateEditMenuItem.Name = "timeDateEditMenuItem";
            timeDateEditMenuItem.ShortcutKeys = Keys.F5;
            timeDateEditMenuItem.Size = new Size(167, 22);
            timeDateEditMenuItem.Text = "Time/Date";
            timeDateEditMenuItem.Click += timeDateEditMenuItem_Click;
            // 
            // formatMenuItem
            // 
            formatMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontFormatMenuItem, changeTextColorToolStripMenuItem, toolStripSeparator2, normalToolStripMenuItem, boldToolStripMenuItem, italicToolStripMenuItem, underlineToolStripMenuItem, strikethroughToolStripMenuItem, toolStripSeparator7, wordWrapFormatMenuItem, boldToolStripMenuItem1 });
            formatMenuItem.Name = "formatMenuItem";
            formatMenuItem.Size = new Size(57, 20);
            formatMenuItem.Text = "&Format";
            // 
            // fontFormatMenuItem
            // 
            fontFormatMenuItem.Image = Properties.Resources.FormatFont;
            fontFormatMenuItem.Name = "fontFormatMenuItem";
            fontFormatMenuItem.Size = new Size(171, 22);
            fontFormatMenuItem.Text = "&Font...";
            fontFormatMenuItem.Click += fontFormatMenuItem_Click;
            // 
            // changeTextColorToolStripMenuItem
            // 
            changeTextColorToolStripMenuItem.Image = Properties.Resources.TextColor;
            changeTextColorToolStripMenuItem.Name = "changeTextColorToolStripMenuItem";
            changeTextColorToolStripMenuItem.Size = new Size(171, 22);
            changeTextColorToolStripMenuItem.Text = "&Change Text Color";
            changeTextColorToolStripMenuItem.Click += changeTextColorToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(168, 6);
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Image = Properties.Resources.NormalA;
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.Size = new Size(171, 22);
            normalToolStripMenuItem.Text = "&Normal";
            normalToolStripMenuItem.Click += normalToolStripMenuItem_Click;
            // 
            // boldToolStripMenuItem
            // 
            boldToolStripMenuItem.Image = Properties.Resources.BoldA;
            boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            boldToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
            boldToolStripMenuItem.Size = new Size(171, 22);
            boldToolStripMenuItem.Text = "&Bold";
            boldToolStripMenuItem.Click += boldToolStripMenuItem_Click;
            // 
            // italicToolStripMenuItem
            // 
            italicToolStripMenuItem.Image = Properties.Resources.ItalicA;
            italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            italicToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            italicToolStripMenuItem.Size = new Size(171, 22);
            italicToolStripMenuItem.Text = "&Italic";
            italicToolStripMenuItem.Click += italicToolStripMenuItem_Click;
            // 
            // underlineToolStripMenuItem
            // 
            underlineToolStripMenuItem.Image = Properties.Resources.UnderlineA;
            underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            underlineToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            underlineToolStripMenuItem.Size = new Size(171, 22);
            underlineToolStripMenuItem.Text = "&Underline";
            underlineToolStripMenuItem.Click += underlineToolStripMenuItem_Click;
            // 
            // strikethroughToolStripMenuItem
            // 
            strikethroughToolStripMenuItem.Image = Properties.Resources.StrikethroughA;
            strikethroughToolStripMenuItem.Name = "strikethroughToolStripMenuItem";
            strikethroughToolStripMenuItem.Size = new Size(171, 22);
            strikethroughToolStripMenuItem.Text = "Strikethrough";
            strikethroughToolStripMenuItem.Click += strikethroughToolStripMenuItem_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(168, 6);
            // 
            // wordWrapFormatMenuItem
            // 
            wordWrapFormatMenuItem.Checked = true;
            wordWrapFormatMenuItem.CheckState = CheckState.Checked;
            wordWrapFormatMenuItem.Name = "wordWrapFormatMenuItem";
            wordWrapFormatMenuItem.Size = new Size(171, 22);
            wordWrapFormatMenuItem.Text = "Word Wrap";
            // 
            // boldToolStripMenuItem1
            // 
            boldToolStripMenuItem1.Name = "boldToolStripMenuItem1";
            boldToolStripMenuItem1.Size = new Size(171, 22);
            boldToolStripMenuItem1.Text = "&Bold";
            // 
            // viewMenuItem
            // 
            viewMenuItem.DropDownItems.AddRange(new ToolStripItem[] { statusBarViewMenuItem });
            viewMenuItem.Name = "viewMenuItem";
            viewMenuItem.Size = new Size(44, 20);
            viewMenuItem.Text = "&View";
            // 
            // statusBarViewMenuItem
            // 
            statusBarViewMenuItem.Checked = true;
            statusBarViewMenuItem.CheckState = CheckState.Checked;
            statusBarViewMenuItem.Name = "statusBarViewMenuItem";
            statusBarViewMenuItem.Size = new Size(126, 22);
            statusBarViewMenuItem.Text = "Status Bar";
            // 
            // helpMenuItem
            // 
            helpMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewHelpMenuItem, aboutNotepadMenuItem });
            helpMenuItem.Name = "helpMenuItem";
            helpMenuItem.Size = new Size(44, 20);
            helpMenuItem.Text = "&Help";
            // 
            // viewHelpMenuItem
            // 
            viewHelpMenuItem.Image = Properties.Resources.help;
            viewHelpMenuItem.Name = "viewHelpMenuItem";
            viewHelpMenuItem.Size = new Size(193, 22);
            viewHelpMenuItem.Text = "View Help";
            // 
            // aboutNotepadMenuItem
            // 
            aboutNotepadMenuItem.Image = Properties.Resources.About;
            aboutNotepadMenuItem.Name = "aboutNotepadMenuItem";
            aboutNotepadMenuItem.Size = new Size(193, 22);
            aboutNotepadMenuItem.Text = "About Notepad Pro++";
            aboutNotepadMenuItem.Click += aboutNotepadMenuItem_Click;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(rtbTextArea);
            toolStripContainer1.ContentPanel.Size = new Size(946, 439);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 24);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(946, 486);
            toolStripContainer1.TabIndex = 1;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.Items.AddRange(new ToolStripItem[] { MessageToolStripStatusLabel });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(946, 22);
            statusStrip1.TabIndex = 0;
            // 
            // rtbTextArea
            // 
            rtbTextArea.Dock = DockStyle.Fill;
            rtbTextArea.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbTextArea.Location = new Point(0, 0);
            rtbTextArea.Name = "rtbTextArea";
            rtbTextArea.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            rtbTextArea.Size = new Size(946, 439);
            rtbTextArea.TabIndex = 0;
            rtbTextArea.Text = "";
            rtbTextArea.TextChanged += rtbTextArea_TextChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { newFileToolStrip, openFileToolStrip, toolStripSeparator8, saveToolStrip, saveAsToolStrip, toolStripSeparator9, printToolStrip, printPreviewToolStrip, pageSetupToolStrip, toolStripSeparator10, undoToolStrip, redoToolStrip, toolStripSeparator11, cutToolStrip, copyToolStrip, pasteToolStrip, deleteToolStrip, toolStripSeparator12, boldToolStrip, ItalicToolStrip, underlineToolStrip, strikeToolStrip, toolStripSeparator13, fontFormatToolStrip, textColorToolStrip });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(485, 25);
            toolStrip1.TabIndex = 0;
            // 
            // newFileToolStrip
            // 
            newFileToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newFileToolStrip.Image = Properties.Resources.New;
            newFileToolStrip.ImageTransparentColor = Color.Magenta;
            newFileToolStrip.Name = "newFileToolStrip";
            newFileToolStrip.Size = new Size(23, 22);
            newFileToolStrip.Text = "New File";
            newFileToolStrip.Click += newFileToolStrip_Click;
            // 
            // openFileToolStrip
            // 
            openFileToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openFileToolStrip.Image = Properties.Resources.Open;
            openFileToolStrip.ImageTransparentColor = Color.Magenta;
            openFileToolStrip.Name = "openFileToolStrip";
            openFileToolStrip.Size = new Size(23, 22);
            openFileToolStrip.Text = "Open File";
            openFileToolStrip.Click += openFileToolStrip_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 25);
            // 
            // saveToolStrip
            // 
            saveToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStrip.Image = Properties.Resources.Save;
            saveToolStrip.ImageTransparentColor = Color.Magenta;
            saveToolStrip.Name = "saveToolStrip";
            saveToolStrip.Size = new Size(23, 22);
            saveToolStrip.Text = "Save";
            saveToolStrip.Click += saveToolStrip_Click;
            // 
            // saveAsToolStrip
            // 
            saveAsToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveAsToolStrip.Image = Properties.Resources.save_as;
            saveAsToolStrip.ImageTransparentColor = Color.Magenta;
            saveAsToolStrip.Name = "saveAsToolStrip";
            saveAsToolStrip.Size = new Size(23, 22);
            saveAsToolStrip.Text = "Save As";
            saveAsToolStrip.Click += saveAsToolStrip_Click;
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(6, 25);
            // 
            // printToolStrip
            // 
            printToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printToolStrip.Image = Properties.Resources.print;
            printToolStrip.ImageTransparentColor = Color.Magenta;
            printToolStrip.Name = "printToolStrip";
            printToolStrip.Size = new Size(23, 22);
            printToolStrip.Text = "Print";
            printToolStrip.Click += printToolStrip_Click;
            // 
            // printPreviewToolStrip
            // 
            printPreviewToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printPreviewToolStrip.Image = Properties.Resources.printer_preview;
            printPreviewToolStrip.ImageTransparentColor = Color.Magenta;
            printPreviewToolStrip.Name = "printPreviewToolStrip";
            printPreviewToolStrip.Size = new Size(23, 22);
            printPreviewToolStrip.Text = "Print Preview";
            printPreviewToolStrip.Click += printPreviewToolStrip_Click;
            // 
            // pageSetupToolStrip
            // 
            pageSetupToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pageSetupToolStrip.Image = Properties.Resources.settings;
            pageSetupToolStrip.ImageTransparentColor = Color.Magenta;
            pageSetupToolStrip.Name = "pageSetupToolStrip";
            pageSetupToolStrip.Size = new Size(23, 22);
            pageSetupToolStrip.Text = "Page Setup";
            pageSetupToolStrip.Click += pageSetupToolStrip_Click;
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(6, 25);
            // 
            // undoToolStrip
            // 
            undoToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            undoToolStrip.Enabled = false;
            undoToolStrip.Image = Properties.Resources.arrow_undo;
            undoToolStrip.ImageTransparentColor = Color.Magenta;
            undoToolStrip.Name = "undoToolStrip";
            undoToolStrip.Size = new Size(23, 22);
            undoToolStrip.Text = "Undo";
            undoToolStrip.Click += undoToolStrip_Click;
            // 
            // redoToolStrip
            // 
            redoToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            redoToolStrip.Enabled = false;
            redoToolStrip.Image = Properties.Resources.arrow_redo;
            redoToolStrip.ImageTransparentColor = Color.Magenta;
            redoToolStrip.Name = "redoToolStrip";
            redoToolStrip.Size = new Size(23, 22);
            redoToolStrip.Text = "Redo";
            redoToolStrip.Click += redoToolStrip_Click;
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new Size(6, 25);
            // 
            // cutToolStrip
            // 
            cutToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cutToolStrip.Image = Properties.Resources.cut_red;
            cutToolStrip.ImageTransparentColor = Color.Magenta;
            cutToolStrip.Name = "cutToolStrip";
            cutToolStrip.Size = new Size(23, 22);
            cutToolStrip.Text = "Cut";
            cutToolStrip.Click += cutToolStrip_Click;
            // 
            // copyToolStrip
            // 
            copyToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copyToolStrip.Image = Properties.Resources.copy;
            copyToolStrip.ImageTransparentColor = Color.Magenta;
            copyToolStrip.Name = "copyToolStrip";
            copyToolStrip.Size = new Size(23, 22);
            copyToolStrip.Text = "Copy";
            copyToolStrip.Click += copyToolStrip_Click;
            // 
            // pasteToolStrip
            // 
            pasteToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pasteToolStrip.Image = Properties.Resources.paste;
            pasteToolStrip.ImageTransparentColor = Color.Magenta;
            pasteToolStrip.Name = "pasteToolStrip";
            pasteToolStrip.Size = new Size(23, 22);
            pasteToolStrip.Text = "Paste";
            pasteToolStrip.Click += pasteToolStrip_Click;
            // 
            // deleteToolStrip
            // 
            deleteToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            deleteToolStrip.Image = Properties.Resources.delete;
            deleteToolStrip.ImageTransparentColor = Color.Magenta;
            deleteToolStrip.Name = "deleteToolStrip";
            deleteToolStrip.Size = new Size(23, 22);
            deleteToolStrip.Text = "Delete";
            // 
            // toolStripSeparator12
            // 
            toolStripSeparator12.Name = "toolStripSeparator12";
            toolStripSeparator12.Size = new Size(6, 25);
            // 
            // boldToolStrip
            // 
            boldToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            boldToolStrip.Image = Properties.Resources.BoldA;
            boldToolStrip.ImageTransparentColor = Color.Magenta;
            boldToolStrip.Name = "boldToolStrip";
            boldToolStrip.Size = new Size(23, 22);
            boldToolStrip.Text = "Bold";
            boldToolStrip.Click += boldToolStrip_Click;
            // 
            // ItalicToolStrip
            // 
            ItalicToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ItalicToolStrip.Image = Properties.Resources.ItalicA;
            ItalicToolStrip.ImageTransparentColor = Color.Magenta;
            ItalicToolStrip.Name = "ItalicToolStrip";
            ItalicToolStrip.Size = new Size(23, 22);
            ItalicToolStrip.Text = "Italic";
            ItalicToolStrip.Click += ItalicToolStrip_Click;
            // 
            // underlineToolStrip
            // 
            underlineToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            underlineToolStrip.Image = Properties.Resources.UnderlineA;
            underlineToolStrip.ImageTransparentColor = Color.Magenta;
            underlineToolStrip.Name = "underlineToolStrip";
            underlineToolStrip.Size = new Size(23, 22);
            underlineToolStrip.Text = "Underline";
            underlineToolStrip.Click += underlineToolStrip_Click;
            // 
            // strikeToolStrip
            // 
            strikeToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            strikeToolStrip.Image = Properties.Resources.StrikethroughA;
            strikeToolStrip.ImageTransparentColor = Color.Magenta;
            strikeToolStrip.Name = "strikeToolStrip";
            strikeToolStrip.Size = new Size(23, 22);
            strikeToolStrip.Text = "Strikethrough";
            strikeToolStrip.Click += strikeToolStrip_Click;
            // 
            // toolStripSeparator13
            // 
            toolStripSeparator13.Name = "toolStripSeparator13";
            toolStripSeparator13.Size = new Size(6, 25);
            // 
            // fontFormatToolStrip
            // 
            fontFormatToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            fontFormatToolStrip.Image = Properties.Resources.FormatFont;
            fontFormatToolStrip.ImageTransparentColor = Color.Magenta;
            fontFormatToolStrip.Name = "fontFormatToolStrip";
            fontFormatToolStrip.Size = new Size(23, 22);
            fontFormatToolStrip.Text = "Font Format";
            fontFormatToolStrip.Click += fontFormatToolStrip_Click;
            // 
            // textColorToolStrip
            // 
            textColorToolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            textColorToolStrip.Image = Properties.Resources.TextColor;
            textColorToolStrip.ImageTransparentColor = Color.Magenta;
            textColorToolStrip.Name = "textColorToolStrip";
            textColorToolStrip.Size = new Size(23, 22);
            textColorToolStrip.Text = "Text Color";
            textColorToolStrip.Click += textColorToolStrip_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += OnPrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // fontDialog1
            // 
            fontDialog1.Apply += fontDialog1_Apply;
            // 
            // MessageToolStripStatusLabel
            // 
            MessageToolStripStatusLabel.AutoSize = false;
            MessageToolStripStatusLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            MessageToolStripStatusLabel.BorderStyle = Border3DStyle.Sunken;
            MessageToolStripStatusLabel.Name = "MessageToolStripStatusLabel";
            MessageToolStripStatusLabel.Size = new Size(350, 17);
            MessageToolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 510);
            Controls.Add(toolStripContainer1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Notepad Pro++";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem editMenuItem;
        private ToolStripMenuItem formatMenuItem;
        private ToolStripMenuItem viewMenuItem;
        private ToolStripMenuItem helpMenuItem;
        private ToolStripContainer toolStripContainer1;
        private StatusStrip statusStrip1;
        private RichTextBox rtbTextArea;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem newFileMenuItem;
        private ToolStripMenuItem openFileMenuItem;
        private ToolStripMenuItem saveFileMenuItem;
        private ToolStripMenuItem saveAsFileMenuItem;
        private ToolStripMenuItem exitFileMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printFileMenuItem;
        private ToolStripMenuItem undoEditMenuItem;
        private ToolStripMenuItem redoMenuItem;
        private ToolStripMenuItem cutEditMenuItem;
        private ToolStripMenuItem copyEditMenuItem;
        private ToolStripMenuItem pasteEditMenuItem;
        private ToolStripMenuItem deleteEditMenuItem;
        private ToolStripMenuItem findEditMenuItem;
        private ToolStripMenuItem findNextEditMenuItem;
        private ToolStripMenuItem replaceEditMenuItem;
        private ToolStripMenuItem goToEditMenuItem;
        private ToolStripMenuItem selectAllEditMenuItem;
        private ToolStripMenuItem timeDateEditMenuItem;
        private ToolStripMenuItem wordWrapFormatMenuItem;
        private ToolStripMenuItem fontFormatMenuItem;
        private ToolStripMenuItem statusBarViewMenuItem;
        private ToolStripMenuItem viewHelpMenuItem;
        private ToolStripMenuItem aboutNotepadMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem PrintPreviewFileMenu;
        private ToolStripMenuItem PageSetupFileMenu;
        private ToolStripSeparator toolStripSeparator6;
        private OpenFileDialog openFileDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PageSetupDialog pageSetupDialog1;
        private ToolStripMenuItem changeTextColorToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem italicToolStripMenuItem;
        private ToolStripMenuItem underlineToolStripMenuItem;
        private ToolStripMenuItem strikethroughToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private ToolStripButton newFileToolStrip;
        private ToolStripButton openFileToolStrip;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton saveToolStrip;
        private ToolStripButton saveAsToolStrip;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripButton printToolStrip;
        private ToolStripButton printPreviewToolStrip;
        private ToolStripButton pageSetupToolStrip;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripButton undoToolStrip;
        private ToolStripButton redoToolStrip;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripButton boldToolStrip;
        private ToolStripButton ItalicToolStrip;
        private ToolStripButton underlineToolStrip;
        private ToolStripButton strikeToolStrip;
        private ToolStripButton cutToolStrip;
        private ToolStripButton copyToolStrip;
        private ToolStripButton pasteToolStrip;
        private ToolStripButton deleteToolStrip;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripButton fontFormatToolStrip;
        private ToolStripButton textColorToolStrip;
        private ToolStripMenuItem boldToolStripMenuItem1;
        private ToolStripStatusLabel MessageToolStripStatusLabel;
    }
}
