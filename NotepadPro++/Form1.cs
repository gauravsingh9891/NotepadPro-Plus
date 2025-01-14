using System.Drawing.Printing;
using System.Linq;
using System.Text;
using static System.Windows.Forms.LinkLabel;
using System.Windows.Forms;

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

        ///New File feature of Menu Strip
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

        ///Exit Application feature of Menu Strip
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

        //Save As feature of Menu Strip
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

        //Save feature of Menu Strip
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
        //Page Preview feature of Menu Strip
        private void PrintPreviewFile_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        //Page Setup feature of Menu Strip
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

        //Print feature of Menu Strip
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

        //Undo Feature of Menu Strip
        private void undoEditMenuItem_Click(object sender, EventArgs e)
        {
            rtbTextArea.Undo();
            redoMenuItem.Enabled = true;
            undoEditMenuItem.Enabled = false;
        }

        //Redo Features of Menu Strip
        private void redoMenuItem_Click(object sender, EventArgs e)
        {
            rtbTextArea.Redo();
            undoEditMenuItem.Enabled = true;
            redoMenuItem.Enabled = false;
        }
    }
}
