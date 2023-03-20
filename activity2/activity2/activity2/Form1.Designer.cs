namespace activity2
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
            this.wishList = new System.Windows.Forms.ListBox();
            this.wishListLabel = new System.Windows.Forms.Label();
            this.fillBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.countBtn = new System.Windows.Forms.Button();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.selectionOutputBox = new System.Windows.Forms.TextBox();
            this.countOutputBox = new System.Windows.Forms.TextBox();
            this.sortBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wishList
            // 
            this.wishList.FormattingEnabled = true;
            this.wishList.Location = new System.Drawing.Point(33, 60);
            this.wishList.Name = "wishList";
            this.wishList.Size = new System.Drawing.Size(251, 212);
            this.wishList.TabIndex = 0;
            this.wishList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // wishListLabel
            // 
            this.wishListLabel.AutoSize = true;
            this.wishListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wishListLabel.Location = new System.Drawing.Point(28, 17);
            this.wishListLabel.Name = "wishListLabel";
            this.wishListLabel.Size = new System.Drawing.Size(118, 29);
            this.wishListLabel.TabIndex = 1;
            this.wishListLabel.Text = "Wish List";
            this.wishListLabel.UseWaitCursor = true;
            // 
            // fillBtn
            // 
            this.fillBtn.Location = new System.Drawing.Point(306, 69);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(75, 23);
            this.fillBtn.TabIndex = 2;
            this.fillBtn.Text = "Fill";
            this.fillBtn.UseVisualStyleBackColor = true;
            this.fillBtn.Click += new System.EventHandler(this.fillBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(306, 148);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // countBtn
            // 
            this.countBtn.Location = new System.Drawing.Point(306, 194);
            this.countBtn.Name = "countBtn";
            this.countBtn.Size = new System.Drawing.Size(75, 23);
            this.countBtn.TabIndex = 4;
            this.countBtn.Text = "Count";
            this.countBtn.UseVisualStyleBackColor = true;
            this.countBtn.Click += new System.EventHandler(this.countBtn_Click);
            // 
            // selectionLabel
            // 
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.Location = new System.Drawing.Point(21, 304);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(54, 13);
            this.selectionLabel.TabIndex = 5;
            this.selectionLabel.Text = "Selection:";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(21, 341);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(38, 13);
            this.countLabel.TabIndex = 6;
            this.countLabel.Text = "Count:";
            // 
            // selectionOutputBox
            // 
            this.selectionOutputBox.Location = new System.Drawing.Point(78, 301);
            this.selectionOutputBox.Name = "selectionOutputBox";
            this.selectionOutputBox.Size = new System.Drawing.Size(197, 20);
            this.selectionOutputBox.TabIndex = 7;
            this.selectionOutputBox.TextChanged += new System.EventHandler(this.selectionOutputBox_TextChanged);
            // 
            // countOutputBox
            // 
            this.countOutputBox.Location = new System.Drawing.Point(78, 338);
            this.countOutputBox.Name = "countOutputBox";
            this.countOutputBox.Size = new System.Drawing.Size(197, 20);
            this.countOutputBox.TabIndex = 8;
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(306, 107);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 9;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(306, 237);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 497);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.countOutputBox);
            this.Controls.Add(this.selectionOutputBox);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.selectionLabel);
            this.Controls.Add(this.countBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.fillBtn);
            this.Controls.Add(this.wishListLabel);
            this.Controls.Add(this.wishList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox wishList;
        private System.Windows.Forms.Label wishListLabel;
        private System.Windows.Forms.Button fillBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button countBtn;
        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.TextBox selectionOutputBox;
        private System.Windows.Forms.TextBox countOutputBox;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}

