namespace ElliottProject1
{
    partial class frmStackProgram
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.lblLastAction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(15, 221);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(118, 221);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(209, 221);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(15, 195);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 3;
            this.txtValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValue_KeyDown);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(15, 176);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(71, 13);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "Value to Add:";
            // 
            // lblList
            // 
            this.lblList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblList.Location = new System.Drawing.Point(144, 22);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(140, 193);
            this.lblList.TabIndex = 5;
            // 
            // lblLastAction
            // 
            this.lblLastAction.Location = new System.Drawing.Point(12, 22);
            this.lblLastAction.Name = "lblLastAction";
            this.lblLastAction.Size = new System.Drawing.Size(125, 142);
            this.lblLastAction.TabIndex = 6;
            // 
            // frmStackProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 256);
            this.Controls.Add(this.lblLastAction);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Name = "frmStackProgram";
            this.Text = "Stack Program";
            this.Shown += new System.EventHandler(this.frmStackProgram_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblLastAction;
    }
}

