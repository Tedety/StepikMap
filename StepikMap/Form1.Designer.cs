namespace StepikMap
{
    partial class FormMap
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

            
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMap));
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.buttonLoadFlags = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMap
            // 
            resources.ApplyResources(this.pictureBoxMap, "pictureBoxMap");
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.TabStop = false;
            // 
            // buttonLoadFlags
            // 
            resources.ApplyResources(this.buttonLoadFlags, "buttonLoadFlags");
            this.buttonLoadFlags.Name = "buttonLoadFlags";
            this.buttonLoadFlags.UseVisualStyleBackColor = true;
            this.buttonLoadFlags.Click += new System.EventHandler(this.buttonLoadFlags_Click);
            // 
            // FormMap
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLoadFlags);
            this.Controls.Add(this.pictureBoxMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.Button buttonLoadFlags;
    }
}

