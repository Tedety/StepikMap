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
            this.buttonPlaceFlags = new System.Windows.Forms.Button();
            this.buttonReadData = new System.Windows.Forms.Button();
            labelFreeFlag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMap
            // 
            resources.ApplyResources(this.pictureBoxMap, "pictureBoxMap");
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMap_MouseDown);
            // 
            // buttonPlaceFlags
            // 
            resources.ApplyResources(this.buttonPlaceFlags, "buttonPlaceFlags");
            this.buttonPlaceFlags.Name = "buttonPlaceFlags";
            this.buttonPlaceFlags.UseVisualStyleBackColor = true;
            this.buttonPlaceFlags.Click += new System.EventHandler(this.buttonPlaceFlags_Click);
            // 
            // buttonReadData
            // 
            resources.ApplyResources(this.buttonReadData, "buttonReadData");
            this.buttonReadData.Name = "buttonReadData";
            this.buttonReadData.UseVisualStyleBackColor = true;
            this.buttonReadData.Click += new System.EventHandler(this.buttonReadData_Click);
            // 
            // labelFreeFlag
            // 
            resources.ApplyResources(labelFreeFlag, "labelFreeFlag");
            labelFreeFlag.Name = "labelFreeFlag";
            // 
            // FormMap
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(labelFreeFlag);
            this.Controls.Add(this.buttonReadData);
            this.Controls.Add(this.buttonPlaceFlags);
            this.Controls.Add(this.pictureBoxMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.Button buttonPlaceFlags;
        private System.Windows.Forms.Button buttonReadData;
        public static System.Windows.Forms.Label labelFreeFlag;
    }
}

