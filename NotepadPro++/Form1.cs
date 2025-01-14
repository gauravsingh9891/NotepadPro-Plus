using System.Drawing.Printing;
using System.Linq;
using System.Text;
using static System.Windows.Forms.LinkLabel;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NotepadPro__
{
    public partial class Form1 : Form
    {
        #region Fields
        private bool IsFileAlreadySaved;
        private bool IsFileModified;
        private string CurrOpenFileName;
        private int linesPrinted;
        private string[] lines;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        ///About Notepad Pro++ of Help Menu
        private void aboutNotepadMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fb = new Form2();
            fb.ShowDialog();
        }

        ///New File feature of FileMenu Strip
        private void newFileMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFileModified)
            {
                DialogResult dr = MessageBox.Show("Do you want to save this file ?", "File Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (dr)
                {
                    case DialogResult.Yes:
                        SaveFileMenu();  //Call SaveFileMenu Function
                        ClearScreen();
                        break;
                    case DialogResult.No:
                        ClearScreen();
                        break;
                }

            }

            ClearScreen();
            EnableDisableUndoRedoProcess(false);
        }

        ///Exit Application feature of FileMenu Strip
        private void exitFileMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Open File feature of Menu Strip
        private void openFileMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog1.FileName) == ".txt")
                {
                    rtbTextArea.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                else if (Path.GetExtension(openFileDialog1.FileName) == ".rtf")
                {
                    rtbTextArea.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                this.Text = Path.GetFileName(openFileDialog1.FileName) + " - Notepad Pro++";

                IsFileAlreadySaved = true;
                IsFileModified = false;
                CurrOpenFileName = openFileDialog1.FileName;
                EnableDisableUndoRedoProcess(false);
            }
        }

        private void EnableDisableUndoRedoProcess(bool enable)
        {
            undoEditMenuItem.Enabled = enable;
            redoMenuItem.Enabled = enable;
        }

        //Save As feature of FileMenu Strip
        private void saveAsFileMenuItem_Click(object sender, EventArgs e)
        {
            //Call SaveFileMenu Code
            SaveAsFileMenu();
        }

        private void SaveAsFileMenu()
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (Path.GetExtension(saveFileDialog1.FileName) == ".txt")
                {
                    rtbTextArea.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                else if (Path.GetExtension(saveFileDialog1.FileName) == ".rtf")
                {
                    rtbTextArea.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                this.Text = Path.GetFileName(saveFileDialog1.FileName) + " - Notepad Pro++";
                IsFileAlreadySaved = true;
                IsFileModified = false;
                CurrOpenFileName = saveFileDialog1.FileName;
            }
        }

        //Save feature of FileMenu Strip
        private void saveFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileMenu();
        }

        //Implementing: Save File Menu code
        private void SaveFileMenu()
        {
            if (IsFileAlreadySaved)
            {
                if (Path.GetExtension(CurrOpenFileName) == ".txt")
                {
                    rtbTextArea.SaveFile(CurrOpenFileName, RichTextBoxStreamType.PlainText);
                }
                else if (Path.GetExtension(CurrOpenFileName) == ".rtf")
                {
                    rtbTextArea.SaveFile(CurrOpenFileName, RichTextBoxStreamType.RichText);
                }
                IsFileModified = false;
                this.Text = Path.GetFileName(CurrOpenFileName) + " - Notepad Pro++";
            }
            else
            {
                if (IsFileModified)
                {
                    SaveAsFileMenu();
                }
                else
                {
                    ClearScreen();
                }
            }
        }

        private void ClearScreen()
        {
            rtbTextArea.Clear();
            this.Text = "Untitled - Notepad Pro++";
            IsFileModified = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsFileAlreadySaved = false;
            IsFileModified = false;
            CurrOpenFileName = "Untitled";
            this.Text = CurrOpenFileName + " - Notepad Pro++";
        }

        //Implementing: TextArea Text Changed Event 
        private void rtbTextArea_TextChanged(object sender, EventArgs e)
        {
            IsFileModified = true;
            //if (CurrOpenFileName != Path.GetFileName(CurrOpenFileName))
            //    CurrOpenFileName = Path.GetFileName(CurrOpenFileName);
            //this.Text = "*" + CurrOpenFileName + "- Notepad Pro++";

            undoEditMenuItem.Enabled = true;
        }

        //private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    e.Graphics.DrawString(rtbTextArea.Text, new Font("Arial", 12, FontStyle.Regular), SystemBrushes.WindowText, new Point(25, 25));
        //}
        //Page Preview feature of FileMenu Strip
        private void PrintPreviewFile_Click(object sender, EventArgs e)
        {
            PreviewPrint();
        }

        private void PreviewPrint()
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }



        //Page Setup feature of FileMenu Strip
        private void PageSetupFileMenu_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PrinterSettings = printDocument1.PrinterSettings;
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
            DialogResult dr = pageSetupDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                printDocument1.PrinterSettings = pageSetupDialog1.PrinterSettings;
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
            }
        }

        //Print feature of FileMenu Strip
        private void printFileMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        //Implementing PrintDocument Page Setup
        private void OnPrintPage(object sender, PrintPageEventArgs e)
        {
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            Brush brush = new SolidBrush(rtbTextArea.ForeColor);

            while (linesPrinted < lines.Length)
            {
                e.Graphics.DrawString(lines[linesPrinted++],
                    rtbTextArea.Font, brush, x, y);
                y += 15;
                if (y >= e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            linesPrinted = 0;
            e.HasMorePages = false;
        }

        //Implementing PrintDocument Page Starting position to print
        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            char[] param = { '\n' };

            if (printDialog1.PrinterSettings.PrintRange == PrintRange.Selection)
            {
                lines = rtbTextArea.SelectedText.Split(param);
            }
            else
            {
                lines = rtbTextArea.Text.Split(param);
            }

            int i = 0;
            char[] trimParam = { '\r' };
            foreach (string s in lines)
            {
                lines[i++] = s.TrimEnd(trimParam);
            }
        }

        //Undo Feature of EditMenu Strip
        private void undoEditMenuItem_Click(object sender, EventArgs e)
        {
            rtbTextArea.Undo();
            redoMenuItem.Enabled = true;
            undoEditMenuItem.Enabled = false;
        }

        //Redo Features of EditMenu Strip
        private void redoMenuItem_Click(object sender, EventArgs e)
        {
            rtbTextArea.Redo();
            undoEditMenuItem.Enabled = true;
            redoMenuItem.Enabled = false;
        }

        //Text Select All Features of EditMenu Strip
        private void selectAllEditMenuItem_Click(object sender, EventArgs e)
        {
            rtbTextArea.SelectAll();
        }

        //TimeDate Features of EditMenu Strip
        private void timeDateEditMenuItem_Click(object sender, EventArgs e)
        {
            rtbTextArea.SelectedText = DateTime.Now.ToString();
        }

        private void FormatText(FontStyle fontStyle)
        {
            rtbTextArea.SelectionFont = new Font(rtbTextArea.Font, fontStyle);
        }

        //Text Bold Features of FormatMenu Strip
        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatText(FontStyle.Bold);
        }

        //Text Italic Features of FormatMenu Strip
        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatText(FontStyle.Italic);
        }

        //Text Underline Features of FormatMenu Strip
        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatText(FontStyle.Underline);
        }

        //Text Strikeout Features of FormatMenu Strip
        private void strikethroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatText(FontStyle.Strikeout);
        }

        //Text Normal Features of FormatMenu Strip
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatText(FontStyle.Regular);
        }

        //Font Format Features of FormatMenu Strip
        private void fontFormatMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowApply = true;
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (rtbTextArea.SelectionLength > 0)
                {
                    rtbTextArea.SelectionFont = fontDialog1.Font;
                    rtbTextArea.SelectionColor = fontDialog1.Color;
                }
            }
            else
            {
                rtbTextArea.SelectionFont = rtbTextArea.Font;
                rtbTextArea.SelectionColor = rtbTextArea.ForeColor;
            }
        }

        //Implementing Apply option into Format Dialog of FormatMenu
        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            if (rtbTextArea.SelectionLength > 0)
            {
                rtbTextArea.SelectionFont = fontDialog1.Font;
                rtbTextArea.SelectionColor = fontDialog1.Color;
            }
        }

        //ChangeTextColor Features of FormatMenu Strip
        private void changeTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (rtbTextArea.SelectionLength > 0)
                {
                    rtbTextArea.SelectionColor = colorDialog1.Color;
                }
            }
        }

        private void newFileToolStrip_Click(object sender, EventArgs e)
        {
            newFileMenuItem.PerformClick();
        }

        private void openFileToolStrip_Click(object sender, EventArgs e)
        {
            openFileMenuItem.PerformClick();
        }

        private void saveToolStrip_Click(object sender, EventArgs e)
        {
            saveFileMenuItem.PerformClick();
        }

        private void saveAsToolStrip_Click(object sender, EventArgs e)
        {
            saveAsFileMenuItem.PerformClick();
        }

        private void printToolStrip_Click(object sender, EventArgs e)
        {
            printFileMenuItem.PerformClick();
        }

        private void printPreviewToolStrip_Click(object sender, EventArgs e)
        {
            PreviewPrint();
        }

        private void pageSetupToolStrip_Click(object sender, EventArgs e)
        {
            PageSetupFileMenu.PerformClick();
        }

        private void cutToolStrip_Click(object sender, EventArgs e)
        {
            cutEditMenuItem.PerformClick();
        }

        private void copyToolStrip_Click(object sender, EventArgs e)
        {
            copyEditMenuItem.PerformClick();
        }

        private void pasteToolStrip_Click(object sender, EventArgs e)
        {
            pasteEditMenuItem.PerformClick();
        }

        private void boldToolStrip_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem.PerformClick();
        }

        private void ItalicToolStrip_Click(object sender, EventArgs e)
        {
            italicToolStripMenuItem.PerformClick();
        }

        private void underlineToolStrip_Click(object sender, EventArgs e)
        {
            underlineToolStripMenuItem.PerformClick();
        }

        private void strikeToolStrip_Click(object sender, EventArgs e)
        {
            strikethroughToolStripMenuItem.PerformClick();
        }

        private void fontFormatToolStrip_Click(object sender, EventArgs e)
        {
            fontFormatMenuItem.PerformClick();
        }

        private void textColorToolStrip_Click(object sender, EventArgs e)
        {
            changeTextColorToolStripMenuItem.PerformClick();
        }
    }
}
