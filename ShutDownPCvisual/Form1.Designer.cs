namespace ShutDownPCvisual
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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(279, 133);
            button1.TabIndex = 0;
            button1.Text = "Power OFF";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(303, 157);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "ShutDownPC";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}
