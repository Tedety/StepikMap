namespace StepikMap
{
    partial class FormPlaceFlag
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
            this.labelCountFlags = new System.Windows.Forms.Label();
            this.buttonPlace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCountFlags
            // 
            this.labelCountFlags.AutoSize = true;
            this.labelCountFlags.Location = new System.Drawing.Point(12, 9);
            this.labelCountFlags.Name = "labelCountFlags";
            this.labelCountFlags.Size = new System.Drawing.Size(204, 16);
            this.labelCountFlags.TabIndex = 0;
            this.labelCountFlags.Text = "Осталось разместить флагов:";
            // 
            // buttonPlace
            // 
            this.buttonPlace.Location = new System.Drawing.Point(290, 117);
            this.buttonPlace.Name = "buttonPlace";
            this.buttonPlace.Size = new System.Drawing.Size(116, 31);
            this.buttonPlace.TabIndex = 1;
            this.buttonPlace.Text = "Разместить";
            this.buttonPlace.UseVisualStyleBackColor = true;
            this.buttonPlace.Click += new System.EventHandler(this.buttonPlace_Click);
            // 
            // FormPlaceFlag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 160);
            this.Controls.Add(this.buttonPlace);
            this.Controls.Add(this.labelCountFlags);
            this.Name = "FormPlaceFlag";
            this.Text = "Рамещение флага";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCountFlags;
        private System.Windows.Forms.Button buttonPlace;
    }
}