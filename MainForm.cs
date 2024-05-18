using System;
using System.IO;
using System.Windows.Forms;
namespace Comments_Remover
{
	// Written. 2024.04.30 19:25.
	// Commercial application may not be free.
	// The application was not written to be used commercially.
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		private void button_exit_Click(object sender, EventArgs e)
		{
			Close();
		}
		string filename = "";
		private void remove_from_file_click(object sender, EventArgs e)
		{
			OpenFileDialog file_open = new OpenFileDialog();
			if (file_open.ShowDialog() == DialogResult.OK)
			{
				filename = file_open.FileName;
				remove_2_slash = checkBox_remove_2.Checked;
				remove_3_slash = checkBox_remove_3.Checked;
			}
			RemoveLinesFromFile(filename);
		}
		bool remove_2_slash = true;
		bool remove_3_slash = true;
		void RemoveLinesFromFile(string filepath)
		{
			Console.WriteLine(DateTime.Now.ToString("HH:mm:ss") + " " + "File: " + filepath);
			StreamReader file_read = new StreamReader(filepath);
			string filepath_temp = Path.GetDirectoryName(filepath) + "\\temp_" + Path.GetFileName(filepath);
			StreamWriter file_write = new StreamWriter(filepath_temp);
			while (file_read.EndOfStream == false)
			{
				string fileline = file_read.ReadLine();
				string trim_fileline = fileline.Trim(' ', '\t');

				// 2024.05.18 19:26. Moscow. Hostel. Rostokino. Sequence of if there is important.
				// with remove_2_flash it could delete the line with /// while it is not checked
				// it checks // and does not check another / and removes the line.
				if (remove_3_slash == true)
				{
					if (trim_fileline.Length >= 3)
					{
						if ((trim_fileline[0] == '/') &&
							(trim_fileline[1] == '/') &&
							(trim_fileline[2] == '/'))
						{
							Console.WriteLine(DateTime.Now.ToString("HH:mm:ss") + " " + "Removed line: " + fileline);
							continue;
						}
					}
				}
				if (remove_2_slash == true)
				{
					if (trim_fileline.Length >= 2)
					{
						if ((trim_fileline[0] == '/') &&
							(trim_fileline[1] == '/'))
						{
							Console.WriteLine(DateTime.Now.ToString("HH:mm:ss") + " " + "Removed line: " + fileline);
							continue;
						}
					}
				}
				file_write.WriteLine(fileline);
			}
			file_read.Close();
			file_write.Close();
			File.Copy(filepath_temp, filepath, true);
			File.Delete(filepath_temp);
		}
		private void button_remove_from_folder_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog open_folder = new FolderBrowserDialog();
			if (open_folder.ShowDialog() == DialogResult.OK)
			{
				remove_2_slash = checkBox_remove_2.Checked;
				remove_3_slash = checkBox_remove_3.Checked;
				string[] folder_filenames = Directory.GetFiles(open_folder.SelectedPath);
				for (int i = 0; i < folder_filenames.Length; i++)
				{
					RemoveLinesFromFile(folder_filenames[i]);
				}
			}
		}
		private void MainForm_Load(object sender, EventArgs e)
		{
		}
	}
}
