namespace SteveBowder_CSP7_Phase2_Project
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
            this.listItems = new System.Windows.Forms.ListBox();
            this.btnSortCost = new System.Windows.Forms.Button();
            this.btnSortName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listItems
            // 
            this.listItems.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listItems.FormattingEnabled = true;
            this.listItems.ItemHeight = 18;
            this.listItems.Location = new System.Drawing.Point(12, 12);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(342, 184);
            this.listItems.TabIndex = 0;
            this.listItems.SelectedIndexChanged += new System.EventHandler(this.listItems_SelectedIndexChanged);
            // 
            // btnSortCost
            // 
            this.btnSortCost.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortCost.Location = new System.Drawing.Point(12, 205);
            this.btnSortCost.Name = "btnSortCost";
            this.btnSortCost.Size = new System.Drawing.Size(96, 45);
            this.btnSortCost.TabIndex = 1;
            this.btnSortCost.Text = "Sort by Cost";
            this.btnSortCost.UseVisualStyleBackColor = true;
            this.btnSortCost.Click += new System.EventHandler(this.btnSortCost_Click);
            // 
            // btnSortName
            // 
            this.btnSortName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortName.Location = new System.Drawing.Point(258, 205);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(96, 45);
            this.btnSortName.TabIndex = 2;
            this.btnSortName.Text = "Sort by Name";
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 262);
            this.Controls.Add(this.btnSortName);
            this.Controls.Add(this.btnSortCost);
            this.Controls.Add(this.listItems);
            this.Name = "MainForm";
            this.Text = "Steve Bowder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listItems;
        private System.Windows.Forms.Button btnSortCost;
        private System.Windows.Forms.Button btnSortName;
    }
}

