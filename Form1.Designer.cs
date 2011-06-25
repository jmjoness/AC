namespace AC {
   partial class Form1 {
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
         if (disposing && (components != null)) {
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
         this.label1 = new System.Windows.Forms.Label();
         this.areaCodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.stateTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(57, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Area Code";
         // 
         // areaCodeMaskedTextBox
         // 
         this.areaCodeMaskedTextBox.Location = new System.Drawing.Point(12, 25);
         this.areaCodeMaskedTextBox.Mask = "000";
         this.areaCodeMaskedTextBox.Name = "areaCodeMaskedTextBox";
         this.areaCodeMaskedTextBox.Size = new System.Drawing.Size(57, 20);
         this.areaCodeMaskedTextBox.TabIndex = 1;
         this.areaCodeMaskedTextBox.TextChanged += new System.EventHandler(this.areaCodeMaskedTextBox_TextChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(9, 62);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(32, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "State";
         // 
         // stateTextBox
         // 
         this.stateTextBox.Location = new System.Drawing.Point(12, 78);
         this.stateTextBox.Name = "stateTextBox";
         this.stateTextBox.Size = new System.Drawing.Size(100, 20);
         this.stateTextBox.TabIndex = 3;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(129, 109);
         this.Controls.Add(this.stateTextBox);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.areaCodeMaskedTextBox);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.MaskedTextBox areaCodeMaskedTextBox;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox stateTextBox;
   }
}

