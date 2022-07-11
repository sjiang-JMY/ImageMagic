namespace ImageMagic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputBtn = new System.Windows.Forms.Button();
            this.fromInput = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.outputBtn = new System.Windows.Forms.Button();
            this.outInput = new System.Windows.Forms.TextBox();
            this.formatLable = new System.Windows.Forms.Label();
            this.formatComba = new System.Windows.Forms.ComboBox();
            this.widthLable = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.widthUnit = new System.Windows.Forms.Label();
            this.heightLable = new System.Windows.Forms.Label();
            this.heightUnit = new System.Windows.Forms.Label();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.consoleBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // inputBtn
            // 
            this.inputBtn.Location = new System.Drawing.Point(45, 83);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(183, 29);
            this.inputBtn.TabIndex = 0;
            this.inputBtn.Text = "请选择图片输入路径";
            this.inputBtn.UseVisualStyleBackColor = true;
            this.inputBtn.Click += new System.EventHandler(this.SelectFoler);
            // 
            // fromInput
            // 
            this.fromInput.Location = new System.Drawing.Point(264, 85);
            this.fromInput.Name = "fromInput";
            this.fromInput.Size = new System.Drawing.Size(486, 27);
            this.fromInput.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(302, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(203, 37);
            this.title.TabIndex = 2;
            this.title.Text = "图片处理工具";
            // 
            // outputBtn
            // 
            this.outputBtn.Location = new System.Drawing.Point(45, 134);
            this.outputBtn.Name = "outputBtn";
            this.outputBtn.Size = new System.Drawing.Size(183, 29);
            this.outputBtn.TabIndex = 3;
            this.outputBtn.Text = "请选择图片输出路径";
            this.outputBtn.UseVisualStyleBackColor = true;
            this.outputBtn.Click += new System.EventHandler(this.outputFolder);
            // 
            // outInput
            // 
            this.outInput.Location = new System.Drawing.Point(264, 136);
            this.outInput.Name = "outInput";
            this.outInput.Size = new System.Drawing.Size(486, 27);
            this.outInput.TabIndex = 4;
            // 
            // formatLable
            // 
            this.formatLable.AutoSize = true;
            this.formatLable.Location = new System.Drawing.Point(45, 191);
            this.formatLable.Name = "formatLable";
            this.formatLable.Size = new System.Drawing.Size(89, 20);
            this.formatLable.TabIndex = 5;
            this.formatLable.Text = "输出格式：";
            // 
            // formatComba
            // 
            this.formatComba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatComba.FormattingEnabled = true;
            this.formatComba.Location = new System.Drawing.Point(140, 188);
            this.formatComba.Name = "formatComba";
            this.formatComba.Size = new System.Drawing.Size(211, 28);
            this.formatComba.TabIndex = 6;
            // 
            // widthLable
            // 
            this.widthLable.AutoSize = true;
            this.widthLable.Location = new System.Drawing.Point(45, 248);
            this.widthLable.Name = "widthLable";
            this.widthLable.Size = new System.Drawing.Size(57, 20);
            this.widthLable.TabIndex = 7;
            this.widthLable.Text = "宽度：";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(140, 245);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(211, 27);
            this.widthInput.TabIndex = 8;
            this.widthInput.TextChanged += new System.EventHandler(this.widthInput_TextChanged);
            // 
            // widthUnit
            // 
            this.widthUnit.AutoSize = true;
            this.widthUnit.Location = new System.Drawing.Point(357, 248);
            this.widthUnit.Name = "widthUnit";
            this.widthUnit.Size = new System.Drawing.Size(25, 20);
            this.widthUnit.TabIndex = 9;
            this.widthUnit.Text = "px";
            // 
            // heightLable
            // 
            this.heightLable.AutoSize = true;
            this.heightLable.Location = new System.Drawing.Point(45, 298);
            this.heightLable.Name = "heightLable";
            this.heightLable.Size = new System.Drawing.Size(57, 20);
            this.heightLable.TabIndex = 10;
            this.heightLable.Text = "高度：";
            // 
            // heightUnit
            // 
            this.heightUnit.AutoSize = true;
            this.heightUnit.Location = new System.Drawing.Point(357, 294);
            this.heightUnit.Name = "heightUnit";
            this.heightUnit.Size = new System.Drawing.Size(25, 20);
            this.heightUnit.TabIndex = 12;
            this.heightUnit.Text = "px";
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(140, 291);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(211, 27);
            this.heightInput.TabIndex = 11;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.submitBtn.Location = new System.Drawing.Point(275, 359);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(107, 29);
            this.submitBtn.TabIndex = 13;
            this.submitBtn.Text = "提交";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.resetBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.resetBtn.Location = new System.Drawing.Point(407, 359);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(107, 29);
            this.resetBtn.TabIndex = 14;
            this.resetBtn.Text = "重置";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // consoleBox
            // 
            this.consoleBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.consoleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consoleBox.Enabled = false;
            this.consoleBox.Location = new System.Drawing.Point(405, 188);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.Size = new System.Drawing.Size(345, 131);
            this.consoleBox.TabIndex = 15;
            this.consoleBox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.heightUnit);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.heightLable);
            this.Controls.Add(this.widthUnit);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.widthLable);
            this.Controls.Add(this.formatComba);
            this.Controls.Add(this.formatLable);
            this.Controls.Add(this.outInput);
            this.Controls.Add(this.outputBtn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.fromInput);
            this.Controls.Add(this.inputBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ImageMagic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputBtn;
        private System.Windows.Forms.TextBox fromInput;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button outputBtn;
        private System.Windows.Forms.TextBox outInput;
        private System.Windows.Forms.Label formatLable;
        private System.Windows.Forms.ComboBox formatComba;
        private System.Windows.Forms.Label widthLable;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label widthUnit;
        private System.Windows.Forms.Label heightLable;
        private System.Windows.Forms.Label heightUnit;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.RichTextBox consoleBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
