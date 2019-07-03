namespace calculator
{
    partial class CalcComponent
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(0, 0);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 0;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(0, 0);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(75, 23);
            this.subtract.TabIndex = 0;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(0, 0);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 23);
            this.multiply.TabIndex = 0;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(0, 0);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 23);
            this.divide.TabIndex = 0;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(0, 0);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(75, 23);
            this.equals.TabIndex = 0;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button equals;
    }
}
