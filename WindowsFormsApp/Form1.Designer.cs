namespace WindowsFormsApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button saveFileButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBox = new TextBox();
            openFileButton = new Button();
            saveFileButton = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 12);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(776, 397);
            textBox.TabIndex = 0;
            // 
            // openFileButton
            // 
            openFileButton.Location = new Point(12, 415);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(100, 23);
            openFileButton.TabIndex = 1;
            openFileButton.Text = "Abrir archivo";
            openFileButton.UseVisualStyleBackColor = true;
            openFileButton.Click += openFileButton_Click;
            // 
            // saveFileButton
            // 
            saveFileButton.Location = new Point(688, 415);
            saveFileButton.Name = "saveFileButton";
            saveFileButton.Size = new Size(100, 23);
            saveFileButton.TabIndex = 2;
            saveFileButton.Text = "Guardar archivo";
            saveFileButton.UseVisualStyleBackColor = true;
            saveFileButton.Click += saveFileButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveFileButton);
            Controls.Add(openFileButton);
            Controls.Add(textBox);
            Name = "MainForm";
            Text = "Editor de archivos";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
