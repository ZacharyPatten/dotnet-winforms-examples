
namespace dotnet_winforms_examples
{
	partial class NavigationBarExampleUserControl
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.view3Button = new System.Windows.Forms.Button();
			this.homeButton = new System.Windows.Forms.Button();
			this.view2Button = new System.Windows.Forms.Button();
			this.view1Button = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.splitContainer1.Panel1.Controls.Add(this.view3Button);
			this.splitContainer1.Panel1.Controls.Add(this.view2Button);
			this.splitContainer1.Panel1.Controls.Add(this.view1Button);
			this.splitContainer1.Panel1.Controls.Add(this.homeButton);
			this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.splitContainer1.Size = new System.Drawing.Size(650, 424);
			this.splitContainer1.SplitterDistance = 216;
			this.splitContainer1.TabIndex = 0;
			// 
			// view3Button
			// 
			this.view3Button.BackColor = System.Drawing.SystemColors.ControlLight;
			this.view3Button.Dock = System.Windows.Forms.DockStyle.Top;
			this.view3Button.FlatAppearance.BorderSize = 0;
			this.view3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.view3Button.Location = new System.Drawing.Point(0, 210);
			this.view3Button.Margin = new System.Windows.Forms.Padding(0);
			this.view3Button.Name = "view3Button";
			this.view3Button.Size = new System.Drawing.Size(216, 70);
			this.view3Button.TabIndex = 3;
			this.view3Button.Text = "View 3";
			this.view3Button.UseVisualStyleBackColor = false;
			this.view3Button.Click += new System.EventHandler(this.button_Click);
			// 
			// homeButton
			// 
			this.homeButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.homeButton.FlatAppearance.BorderSize = 0;
			this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.homeButton.Location = new System.Drawing.Point(0, 0);
			this.homeButton.Margin = new System.Windows.Forms.Padding(0);
			this.homeButton.Name = "homeButton";
			this.homeButton.Size = new System.Drawing.Size(216, 70);
			this.homeButton.TabIndex = 0;
			this.homeButton.Text = "Home";
			this.homeButton.UseVisualStyleBackColor = false;
			this.homeButton.Click += new System.EventHandler(this.button_Click);
			// 
			// view2Button
			// 
			this.view2Button.BackColor = System.Drawing.SystemColors.ControlLight;
			this.view2Button.Dock = System.Windows.Forms.DockStyle.Top;
			this.view2Button.FlatAppearance.BorderSize = 0;
			this.view2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.view2Button.Location = new System.Drawing.Point(0, 140);
			this.view2Button.Margin = new System.Windows.Forms.Padding(0);
			this.view2Button.Name = "view2Button";
			this.view2Button.Size = new System.Drawing.Size(216, 70);
			this.view2Button.TabIndex = 2;
			this.view2Button.Text = "View 2";
			this.view2Button.UseVisualStyleBackColor = false;
			this.view2Button.Click += new System.EventHandler(this.button_Click);
			// 
			// view1Button
			// 
			this.view1Button.BackColor = System.Drawing.SystemColors.ControlLight;
			this.view1Button.Dock = System.Windows.Forms.DockStyle.Top;
			this.view1Button.FlatAppearance.BorderSize = 0;
			this.view1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.view1Button.Location = new System.Drawing.Point(0, 70);
			this.view1Button.Margin = new System.Windows.Forms.Padding(0);
			this.view1Button.Name = "view1Button";
			this.view1Button.Size = new System.Drawing.Size(216, 70);
			this.view1Button.TabIndex = 1;
			this.view1Button.Text = "View 1";
			this.view1Button.UseVisualStyleBackColor = false;
			this.view1Button.Click += new System.EventHandler(this.button_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(172, 210);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Home Screen";
			// 
			// NavigationBarExampleUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "NavigationBarExampleUserControl";
			this.Size = new System.Drawing.Size(650, 424);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button view3Button;
		private System.Windows.Forms.Button view2Button;
		private System.Windows.Forms.Button view1Button;
		private System.Windows.Forms.Button homeButton;
		private System.Windows.Forms.Label label1;
	}
}
