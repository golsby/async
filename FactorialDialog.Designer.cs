namespace async
{
  partial class FactorialDialog
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
      this.btnCompute1 = new System.Windows.Forms.Button();
      this.txtInput = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnChangeBackground = new System.Windows.Forms.Button();
      this.labelResult = new System.Windows.Forms.Label();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.comboComputeMethod = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnCompute1
      // 
      this.btnCompute1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnCompute1.Location = new System.Drawing.Point(57, 218);
      this.btnCompute1.Name = "btnCompute1";
      this.btnCompute1.Size = new System.Drawing.Size(119, 29);
      this.btnCompute1.TabIndex = 0;
      this.btnCompute1.Text = "Compute...";
      this.btnCompute1.UseVisualStyleBackColor = true;
      this.btnCompute1.Click += new System.EventHandler(this.buttonCompute_Click);
      // 
      // txtInput
      // 
      this.txtInput.Location = new System.Drawing.Point(160, 112);
      this.txtInput.Name = "txtInput";
      this.txtInput.Size = new System.Drawing.Size(57, 22);
      this.txtInput.TabIndex = 1;
      this.txtInput.Text = "10";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 112);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(91, 17);
      this.label1.TabIndex = 2;
      this.label1.Text = "Input integer:";
      // 
      // btnChangeBackground
      // 
      this.btnChangeBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnChangeBackground.Location = new System.Drawing.Point(182, 218);
      this.btnChangeBackground.Name = "btnChangeBackground";
      this.btnChangeBackground.Size = new System.Drawing.Size(160, 29);
      this.btnChangeBackground.TabIndex = 3;
      this.btnChangeBackground.Text = "Change Background";
      this.btnChangeBackground.UseVisualStyleBackColor = true;
      this.btnChangeBackground.Click += new System.EventHandler(this.buttonChangeBackground_Click);
      // 
      // labelResult
      // 
      this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelResult.Location = new System.Drawing.Point(157, 168);
      this.labelResult.Name = "labelResult";
      this.labelResult.Size = new System.Drawing.Size(233, 22);
      this.labelResult.TabIndex = 4;
      this.labelResult.Text = "Result";
      // 
      // buttonCancel
      // 
      this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.buttonCancel.Enabled = false;
      this.buttonCancel.Location = new System.Drawing.Point(348, 218);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(81, 29);
      this.buttonCancel.TabIndex = 7;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(12, 13);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(473, 76);
      this.label2.TabIndex = 8;
      this.label2.Text = "Enter a number below, then compute the factorial one of three ways. While the com" +
    "putation is going, click \"Change Background\" to see that the UI is still live.";
      // 
      // comboComputeMethod
      // 
      this.comboComputeMethod.FormattingEnabled = true;
      this.comboComputeMethod.Items.AddRange(new object[] {
            "Synchronous",
            "Asynchronous",
            "Async with Progress",
            "Async with Progress and Cancel"});
      this.comboComputeMethod.Location = new System.Drawing.Point(160, 140);
      this.comboComputeMethod.Name = "comboComputeMethod";
      this.comboComputeMethod.Size = new System.Drawing.Size(316, 24);
      this.comboComputeMethod.TabIndex = 9;
      this.comboComputeMethod.Text = "Synchronous";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 143);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(142, 17);
      this.label3.TabIndex = 10;
      this.label3.Text = "Computation Method:";
      // 
      // FactorialDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(488, 259);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.comboComputeMethod);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.labelResult);
      this.Controls.Add(this.btnChangeBackground);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtInput);
      this.Controls.Add(this.btnCompute1);
      this.Name = "FactorialDialog";
      this.Text = "Async Test";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCompute1;
    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnChangeBackground;
    private System.Windows.Forms.Label labelResult;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox comboComputeMethod;
    private System.Windows.Forms.Label label3;
  }
}

