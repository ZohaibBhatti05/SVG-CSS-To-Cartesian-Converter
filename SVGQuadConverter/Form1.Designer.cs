
namespace SVGQuadConverter
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
            this.txtSVG = new System.Windows.Forms.TextBox();
            this.txtCSS = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblSVG = new System.Windows.Forms.Label();
            this.lblCSS = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.chbTriStr = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtSVG
            // 
            this.txtSVG.Location = new System.Drawing.Point(12, 32);
            this.txtSVG.Multiline = true;
            this.txtSVG.Name = "txtSVG";
            this.txtSVG.Size = new System.Drawing.Size(109, 406);
            this.txtSVG.TabIndex = 0;
            // 
            // txtCSS
            // 
            this.txtCSS.Location = new System.Drawing.Point(136, 32);
            this.txtCSS.Multiline = true;
            this.txtCSS.Name = "txtCSS";
            this.txtCSS.Size = new System.Drawing.Size(109, 406);
            this.txtCSS.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.AcceptsReturn = true;
            this.txtOutput.Location = new System.Drawing.Point(372, 32);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(312, 406);
            this.txtOutput.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(251, 30);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(115, 29);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblSVG
            // 
            this.lblSVG.AutoSize = true;
            this.lblSVG.Location = new System.Drawing.Point(12, 9);
            this.lblSVG.Name = "lblSVG";
            this.lblSVG.Size = new System.Drawing.Size(39, 20);
            this.lblSVG.TabIndex = 4;
            this.lblSVG.Text = "SVG:";
            // 
            // lblCSS
            // 
            this.lblCSS.AutoSize = true;
            this.lblCSS.Location = new System.Drawing.Point(136, 9);
            this.lblCSS.Name = "lblCSS";
            this.lblCSS.Size = new System.Drawing.Size(37, 20);
            this.lblCSS.TabIndex = 5;
            this.lblCSS.Text = "CSS:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(372, 9);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(58, 20);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "Output:";
            // 
            // chbTriStr
            // 
            this.chbTriStr.AutoSize = true;
            this.chbTriStr.Location = new System.Drawing.Point(251, 65);
            this.chbTriStr.Name = "chbTriStr";
            this.chbTriStr.Size = new System.Drawing.Size(115, 24);
            this.chbTriStr.TabIndex = 7;
            this.chbTriStr.Text = "TriangleStrip";
            this.chbTriStr.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chbTriStr);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblCSS);
            this.Controls.Add(this.lblSVG);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtCSS);
            this.Controls.Add(this.txtSVG);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSVG;
        private System.Windows.Forms.TextBox txtCSS;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblSVG;
        private System.Windows.Forms.Label lblCSS;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.CheckBox chbTriStr;
    }
}

