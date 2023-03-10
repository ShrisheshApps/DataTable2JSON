namespace DataTable2JSON
{
    partial class Form1
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
            this.GetJSONButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetJSONButton
            // 
            this.GetJSONButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GetJSONButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetJSONButton.Location = new System.Drawing.Point(313, 205);
            this.GetJSONButton.Name = "GetJSONButton";
            this.GetJSONButton.Size = new System.Drawing.Size(108, 28);
            this.GetJSONButton.TabIndex = 0;
            this.GetJSONButton.Text = "Get JSON";
            this.GetJSONButton.UseVisualStyleBackColor = false;
            this.GetJSONButton.Click += new System.EventHandler(this.GetJSONButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(444, 254);
            this.Controls.Add(this.GetJSONButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetJSONButton;
    }
}

