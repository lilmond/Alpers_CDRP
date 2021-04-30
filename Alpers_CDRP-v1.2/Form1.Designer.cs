
namespace Alpers_CDRP_v1._2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.MainPanelLabel = new System.Windows.Forms.Label();
            this.APPIDLabel = new System.Windows.Forms.Label();
            this.APPID = new System.Windows.Forms.TextBox();
            this.DETAILS = new System.Windows.Forms.TextBox();
            this.DETAILSLabel = new System.Windows.Forms.Label();
            this.ICON = new System.Windows.Forms.TextBox();
            this.ICONLabel = new System.Windows.Forms.Label();
            this.STATE = new System.Windows.Forms.TextBox();
            this.STATELabel = new System.Windows.Forms.Label();
            this.LABEL = new System.Windows.Forms.TextBox();
            this.LABELLABEL = new System.Windows.Forms.Label();
            this.SetButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainPanel.Controls.Add(this.MainPanelLabel);
            this.MainPanel.Controls.Add(this.MinimizeButton);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(270, 30);
            this.MainPanel.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(230, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 30);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.TabStop = false;
            this.CloseButton.Text = "✕";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(190, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(40, 30);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Text = "—";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MainPanelLabel
            // 
            this.MainPanelLabel.AutoSize = true;
            this.MainPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPanelLabel.ForeColor = System.Drawing.Color.White;
            this.MainPanelLabel.Location = new System.Drawing.Point(3, 3);
            this.MainPanelLabel.Name = "MainPanelLabel";
            this.MainPanelLabel.Size = new System.Drawing.Size(139, 25);
            this.MainPanelLabel.TabIndex = 3;
            this.MainPanelLabel.Text = "Alpers CDRP";
            // 
            // APPIDLabel
            // 
            this.APPIDLabel.AutoSize = true;
            this.APPIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.APPIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPIDLabel.ForeColor = System.Drawing.Color.White;
            this.APPIDLabel.Location = new System.Drawing.Point(5, 40);
            this.APPIDLabel.Name = "APPIDLabel";
            this.APPIDLabel.Size = new System.Drawing.Size(82, 25);
            this.APPIDLabel.TabIndex = 1;
            this.APPIDLabel.Text = "APP ID";
            // 
            // APPID
            // 
            this.APPID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.APPID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.APPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPID.ForeColor = System.Drawing.Color.White;
            this.APPID.Location = new System.Drawing.Point(107, 40);
            this.APPID.Name = "APPID";
            this.APPID.Size = new System.Drawing.Size(156, 25);
            this.APPID.TabIndex = 2;
            // 
            // DETAILS
            // 
            this.DETAILS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DETAILS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DETAILS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DETAILS.ForeColor = System.Drawing.Color.White;
            this.DETAILS.Location = new System.Drawing.Point(107, 70);
            this.DETAILS.Name = "DETAILS";
            this.DETAILS.Size = new System.Drawing.Size(156, 25);
            this.DETAILS.TabIndex = 4;
            // 
            // DETAILSLabel
            // 
            this.DETAILSLabel.AutoSize = true;
            this.DETAILSLabel.BackColor = System.Drawing.Color.Transparent;
            this.DETAILSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DETAILSLabel.ForeColor = System.Drawing.Color.White;
            this.DETAILSLabel.Location = new System.Drawing.Point(5, 70);
            this.DETAILSLabel.Name = "DETAILSLabel";
            this.DETAILSLabel.Size = new System.Drawing.Size(103, 25);
            this.DETAILSLabel.TabIndex = 3;
            this.DETAILSLabel.Text = "DETAILS";
            // 
            // ICON
            // 
            this.ICON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ICON.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ICON.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICON.ForeColor = System.Drawing.Color.White;
            this.ICON.Location = new System.Drawing.Point(107, 131);
            this.ICON.Name = "ICON";
            this.ICON.Size = new System.Drawing.Size(156, 25);
            this.ICON.TabIndex = 8;
            // 
            // ICONLabel
            // 
            this.ICONLabel.AutoSize = true;
            this.ICONLabel.BackColor = System.Drawing.Color.Transparent;
            this.ICONLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICONLabel.ForeColor = System.Drawing.Color.White;
            this.ICONLabel.Location = new System.Drawing.Point(5, 131);
            this.ICONLabel.Name = "ICONLabel";
            this.ICONLabel.Size = new System.Drawing.Size(66, 25);
            this.ICONLabel.TabIndex = 7;
            this.ICONLabel.Text = "ICON";
            // 
            // STATE
            // 
            this.STATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.STATE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.STATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STATE.ForeColor = System.Drawing.Color.White;
            this.STATE.Location = new System.Drawing.Point(107, 101);
            this.STATE.Name = "STATE";
            this.STATE.Size = new System.Drawing.Size(156, 25);
            this.STATE.TabIndex = 6;
            // 
            // STATELabel
            // 
            this.STATELabel.AutoSize = true;
            this.STATELabel.BackColor = System.Drawing.Color.Transparent;
            this.STATELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STATELabel.ForeColor = System.Drawing.Color.White;
            this.STATELabel.Location = new System.Drawing.Point(5, 101);
            this.STATELabel.Name = "STATELabel";
            this.STATELabel.Size = new System.Drawing.Size(84, 25);
            this.STATELabel.TabIndex = 5;
            this.STATELabel.Text = "STATE";
            // 
            // LABEL
            // 
            this.LABEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LABEL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL.ForeColor = System.Drawing.Color.White;
            this.LABEL.Location = new System.Drawing.Point(107, 161);
            this.LABEL.Name = "LABEL";
            this.LABEL.Size = new System.Drawing.Size(156, 25);
            this.LABEL.TabIndex = 10;
            // 
            // LABELLABEL
            // 
            this.LABELLABEL.AutoSize = true;
            this.LABELLABEL.BackColor = System.Drawing.Color.Transparent;
            this.LABELLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABELLABEL.ForeColor = System.Drawing.Color.White;
            this.LABELLABEL.Location = new System.Drawing.Point(5, 161);
            this.LABELLABEL.Name = "LABELLABEL";
            this.LABELLABEL.Size = new System.Drawing.Size(79, 25);
            this.LABELLABEL.TabIndex = 9;
            this.LABELLABEL.Text = "LABEL";
            // 
            // SetButton
            // 
            this.SetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SetButton.FlatAppearance.BorderSize = 0;
            this.SetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.SetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetButton.ForeColor = System.Drawing.Color.White;
            this.SetButton.Location = new System.Drawing.Point(107, 195);
            this.SetButton.Margin = new System.Windows.Forms.Padding(0);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(156, 25);
            this.SetButton.TabIndex = 11;
            this.SetButton.TabStop = false;
            this.SetButton.Text = "SET";
            this.SetButton.UseMnemonic = false;
            this.SetButton.UseVisualStyleBackColor = false;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(10, 195);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(0);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(91, 25);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.TabStop = false;
            this.ClearButton.Text = "UNSET";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.MainPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.MainPanelLabel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(270, 228);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.LABEL);
            this.Controls.Add(this.LABELLABEL);
            this.Controls.Add(this.ICON);
            this.Controls.Add(this.ICONLabel);
            this.Controls.Add(this.STATE);
            this.Controls.Add(this.STATELabel);
            this.Controls.Add(this.DETAILS);
            this.Controls.Add(this.DETAILSLabel);
            this.Controls.Add(this.APPID);
            this.Controls.Add(this.APPIDLabel);
            this.Controls.Add(this.MainPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alpers CDRP V2.0";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Label MainPanelLabel;
        private System.Windows.Forms.Label APPIDLabel;
        private System.Windows.Forms.TextBox APPID;
        private System.Windows.Forms.TextBox DETAILS;
        private System.Windows.Forms.Label DETAILSLabel;
        private System.Windows.Forms.TextBox ICON;
        private System.Windows.Forms.Label ICONLabel;
        private System.Windows.Forms.TextBox STATE;
        private System.Windows.Forms.Label STATELabel;
        private System.Windows.Forms.TextBox LABEL;
        private System.Windows.Forms.Label LABELLABEL;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Button ClearButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}

