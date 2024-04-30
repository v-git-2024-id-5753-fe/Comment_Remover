namespace Comments_Remover
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button_remove_from_file = new System.Windows.Forms.Button();
			this.button_exit = new System.Windows.Forms.Button();
			this.checkBox_remove_2 = new System.Windows.Forms.CheckBox();
			this.checkBox_remove_3 = new System.Windows.Forms.CheckBox();
			this.button_remove_from_folder = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_remove_from_file
			// 
			this.button_remove_from_file.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_remove_from_file.Location = new System.Drawing.Point(12, 12);
			this.button_remove_from_file.Name = "button_remove_from_file";
			this.button_remove_from_file.Size = new System.Drawing.Size(120, 40);
			this.button_remove_from_file.TabIndex = 0;
			this.button_remove_from_file.Text = "From File";
			this.button_remove_from_file.UseVisualStyleBackColor = true;
			this.button_remove_from_file.Click += new System.EventHandler(this.remove_from_file_click);
			// 
			// button_exit
			// 
			this.button_exit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_exit.Location = new System.Drawing.Point(284, 12);
			this.button_exit.Name = "button_exit";
			this.button_exit.Size = new System.Drawing.Size(90, 30);
			this.button_exit.TabIndex = 1;
			this.button_exit.Text = "Exit";
			this.button_exit.UseVisualStyleBackColor = true;
			this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
			// 
			// checkBox_remove_2
			// 
			this.checkBox_remove_2.AutoSize = true;
			this.checkBox_remove_2.Checked = true;
			this.checkBox_remove_2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_remove_2.Location = new System.Drawing.Point(12, 104);
			this.checkBox_remove_2.Name = "checkBox_remove_2";
			this.checkBox_remove_2.Size = new System.Drawing.Size(118, 23);
			this.checkBox_remove_2.TabIndex = 4;
			this.checkBox_remove_2.Text = "Remove // ";
			this.checkBox_remove_2.UseVisualStyleBackColor = true;
			// 
			// checkBox_remove_3
			// 
			this.checkBox_remove_3.AutoSize = true;
			this.checkBox_remove_3.Checked = true;
			this.checkBox_remove_3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_remove_3.Location = new System.Drawing.Point(12, 133);
			this.checkBox_remove_3.Name = "checkBox_remove_3";
			this.checkBox_remove_3.Size = new System.Drawing.Size(118, 23);
			this.checkBox_remove_3.TabIndex = 5;
			this.checkBox_remove_3.Text = "Remove ///";
			this.checkBox_remove_3.UseVisualStyleBackColor = true;
			// 
			// button_remove_from_folder
			// 
			this.button_remove_from_folder.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_remove_from_folder.Location = new System.Drawing.Point(12, 58);
			this.button_remove_from_folder.Name = "button_remove_from_folder";
			this.button_remove_from_folder.Size = new System.Drawing.Size(120, 40);
			this.button_remove_from_folder.TabIndex = 6;
			this.button_remove_from_folder.Text = "From Folder";
			this.button_remove_from_folder.UseVisualStyleBackColor = true;
			this.button_remove_from_folder.Click += new System.EventHandler(this.button_remove_from_folder_Click);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(386, 168);
			this.ControlBox = false;
			this.Controls.Add(this.button_remove_from_folder);
			this.Controls.Add(this.checkBox_remove_3);
			this.Controls.Add(this.checkBox_remove_2);
			this.Controls.Add(this.button_exit);
			this.Controls.Add(this.button_remove_from_file);
			this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "MainForm";
			this.Text = "Line Erase";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_remove_from_file;
		private System.Windows.Forms.Button button_exit;
		private System.Windows.Forms.CheckBox checkBox_remove_2;
		private System.Windows.Forms.CheckBox checkBox_remove_3;
		private System.Windows.Forms.Button button_remove_from_folder;
	}
}

