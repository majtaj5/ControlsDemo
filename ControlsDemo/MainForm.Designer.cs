namespace ControlsDemo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.cboOptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTextStyleCount = new System.Windows.Forms.Label();
            this.lblLineTypeCount = new System.Windows.Forms.Label();
            this.lblLayerCount = new System.Windows.Forms.Label();
            this.lstTextStyle = new System.Windows.Forms.ListBox();
            this.lstLIneType = new System.Windows.Forms.ListBox();
            this.lstLayer = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearAll);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.cboOptions);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options  Conteiner";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(172, 384);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(31, 384);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Show Items";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // cboOptions
            // 
            this.cboOptions.FormattingEnabled = true;
            this.cboOptions.Items.AddRange(new object[] {
            "All",
            "Layer",
            "LineType",
            "TextType"});
            this.cboOptions.Location = new System.Drawing.Point(172, 44);
            this.cboOptions.Name = "cboOptions";
            this.cboOptions.Size = new System.Drawing.Size(121, 21);
            this.cboOptions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select item to display";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTextStyleCount);
            this.groupBox2.Controls.Add(this.lblLineTypeCount);
            this.groupBox2.Controls.Add(this.lblLayerCount);
            this.groupBox2.Controls.Add(this.lstTextStyle);
            this.groupBox2.Controls.Add(this.lstLIneType);
            this.groupBox2.Controls.Add(this.lstLayer);
            this.groupBox2.Location = new System.Drawing.Point(423, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 413);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Cointeiner";
            // 
            // lblTextStyleCount
            // 
            this.lblTextStyleCount.AutoSize = true;
            this.lblTextStyleCount.Location = new System.Drawing.Point(229, 384);
            this.lblTextStyleCount.Name = "lblTextStyleCount";
            this.lblTextStyleCount.Size = new System.Drawing.Size(16, 13);
            this.lblTextStyleCount.TabIndex = 5;
            this.lblTextStyleCount.Text = "...";
            // 
            // lblLineTypeCount
            // 
            this.lblLineTypeCount.AutoSize = true;
            this.lblLineTypeCount.Location = new System.Drawing.Point(126, 384);
            this.lblLineTypeCount.Name = "lblLineTypeCount";
            this.lblLineTypeCount.Size = new System.Drawing.Size(16, 13);
            this.lblLineTypeCount.TabIndex = 4;
            this.lblLineTypeCount.Text = "...";
            // 
            // lblLayerCount
            // 
            this.lblLayerCount.AutoSize = true;
            this.lblLayerCount.Location = new System.Drawing.Point(6, 384);
            this.lblLayerCount.Name = "lblLayerCount";
            this.lblLayerCount.Size = new System.Drawing.Size(16, 13);
            this.lblLayerCount.TabIndex = 3;
            this.lblLayerCount.Text = "...";
            // 
            // lstTextStyle
            // 
            this.lstTextStyle.FormattingEnabled = true;
            this.lstTextStyle.Location = new System.Drawing.Point(229, 33);
            this.lstTextStyle.Name = "lstTextStyle";
            this.lstTextStyle.Size = new System.Drawing.Size(120, 342);
            this.lstTextStyle.TabIndex = 2;
            // 
            // lstLIneType
            // 
            this.lstLIneType.FormattingEnabled = true;
            this.lstLIneType.Location = new System.Drawing.Point(126, 33);
            this.lstLIneType.Name = "lstLIneType";
            this.lstLIneType.Size = new System.Drawing.Size(85, 342);
            this.lstLIneType.TabIndex = 1;
            // 
            // lstLayer
            // 
            this.lstLayer.FormattingEnabled = true;
            this.lstLayer.Location = new System.Drawing.Point(6, 33);
            this.lstLayer.Name = "lstLayer";
            this.lstLayer.Size = new System.Drawing.Size(104, 342);
            this.lstLayer.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblTextStyleCount;
        private System.Windows.Forms.Label lblLineTypeCount;
        private System.Windows.Forms.Label lblLayerCount;
        private System.Windows.Forms.ListBox lstTextStyle;
        private System.Windows.Forms.ListBox lstLIneType;
        private System.Windows.Forms.ListBox lstLayer;
    }
}