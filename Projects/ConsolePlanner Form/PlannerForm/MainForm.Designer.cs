namespace PlannerForm
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
            this.butShowTask = new System.Windows.Forms.Button();
            this.butAddTask = new System.Windows.Forms.Button();
            this.butDeleteTask = new System.Windows.Forms.Button();
            this.butSaveTask = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.BoxTaskContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butShowTask
            // 
            this.butShowTask.Location = new System.Drawing.Point(31, 22);
            this.butShowTask.Name = "butShowTask";
            this.butShowTask.Size = new System.Drawing.Size(75, 23);
            this.butShowTask.TabIndex = 0;
            this.butShowTask.Text = "SHOW";
            this.butShowTask.UseVisualStyleBackColor = true;
            // 
            // butAddTask
            // 
            this.butAddTask.Location = new System.Drawing.Point(31, 61);
            this.butAddTask.Name = "butAddTask";
            this.butAddTask.Size = new System.Drawing.Size(75, 23);
            this.butAddTask.TabIndex = 1;
            this.butAddTask.Text = "ADD";
            this.butAddTask.UseVisualStyleBackColor = true;
            // 
            // butDeleteTask
            // 
            this.butDeleteTask.Location = new System.Drawing.Point(31, 104);
            this.butDeleteTask.Name = "butDeleteTask";
            this.butDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.butDeleteTask.TabIndex = 2;
            this.butDeleteTask.Text = "DELETE";
            this.butDeleteTask.UseVisualStyleBackColor = true;
            // 
            // butSaveTask
            // 
            this.butSaveTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butSaveTask.Location = new System.Drawing.Point(280, 214);
            this.butSaveTask.Name = "butSaveTask";
            this.butSaveTask.Size = new System.Drawing.Size(75, 23);
            this.butSaveTask.TabIndex = 3;
            this.butSaveTask.Text = "SAVE";
            this.butSaveTask.UseVisualStyleBackColor = true;
            // 
            // butExit
            // 
            this.butExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butExit.Location = new System.Drawing.Point(31, 214);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(75, 23);
            this.butExit.TabIndex = 4;
            this.butExit.Text = "EXIT";
            this.butExit.UseVisualStyleBackColor = true;
            // 
            // BoxTaskContent
            // 
            this.BoxTaskContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxTaskContent.Location = new System.Drawing.Point(131, 22);
            this.BoxTaskContent.Multiline = true;
            this.BoxTaskContent.Name = "BoxTaskContent";
            this.BoxTaskContent.Size = new System.Drawing.Size(224, 171);
            this.BoxTaskContent.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 267);
            this.Controls.Add(this.BoxTaskContent);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butSaveTask);
            this.Controls.Add(this.butDeleteTask);
            this.Controls.Add(this.butAddTask);
            this.Controls.Add(this.butShowTask);
            this.MaximumSize = new System.Drawing.Size(483, 406);
            this.MinimumSize = new System.Drawing.Size(383, 306);
            this.Name = "MainForm";
            this.Text = "PlannerMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butShowTask;
        private System.Windows.Forms.Button butAddTask;
        private System.Windows.Forms.Button butDeleteTask;
        private System.Windows.Forms.Button butSaveTask;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.TextBox BoxTaskContent;
    }
}

