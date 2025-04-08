using System.IO;
namespace Mod6_Notepad_Demo_Dave
{
    public partial class Form1 : Form
    {
        string filepath;
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextArea.Clear(); //Clear the area
            richTextArea.Focus(); //put cursor in the RTA--the typing cursor
            saveToolStripMenuItem.Enabled = true; //Makes Save(as) available after clicking File-New
            saveAsToolStripMenuItem.Enabled = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog(); //Create an instance of the OpenFileDialog class
            //Filters out the filetypes to be able to open (.pdf, .txt, .png, etc...)
            //"Text Files(*.txt)" is the actual display--|*.txt is the actual file type
            openFile.Filter = "Text Files(*.txt)|*.txt";
            openFile.Title = "Open text files"; //Title displayed at top of dialog box
            openFile.ShowDialog();
            if (openFile.FileName != string.Empty) //If file name is not empty, use filePath variable to hold the filename
            {
                filepath = openFile.FileName;
                richTextArea.Text = File.ReadAllText(filepath); //Read all the text from the file path and put it as RTA text
            }
            saveAsToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(filepath))
            {
                File.WriteAllText(filepath, richTextArea.Text); //filepath tells you where to write it, richTextArea.Text tells you what to write
            }
            else //if File doesn't exist
            {
                SaveFileDialog saveFile = new SaveFileDialog(); //open new savefiledialog box to show where to save it
                saveFile.Filter = "Text Files(*.txt)|*.txt";
                if (saveFile.ShowDialog() == DialogResult.OK) //If you click OK on save in the dialog box
                {
                    filepath = saveFile.FileName; //Make the filepath variable as...(?)
                    Stream stream = saveFile.OpenFile(); //can also use var stream if unsure of file type
                    StreamWriter writer = new StreamWriter(stream);
                    writer.WriteLine(richTextArea.Text);
                    writer.Close(); //StreamWriter has to close first before the stream
                    stream.Close();
                }

            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files(*.txt)|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                filepath = saveFile.FileName;
                Stream stream = saveFile.OpenFile();
                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine(richTextArea.Text);
                writer.Close();
                stream.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            richTextArea.SelectionFont = fontDialog.Font;
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            richTextArea.SelectionColor = colorDialog.Color;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextArea.SelectedText); //Whichever text is selected will go into clipboard
            richTextArea.SelectedText = string.Empty; //line you selected goes away--CUT
        }
    }
}
