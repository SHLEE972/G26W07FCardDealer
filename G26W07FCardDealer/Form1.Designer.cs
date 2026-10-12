namespace G26W07FCardDealer {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Card1 = new PictureBox();
            btnDeal = new Button();
            ((System.ComponentModel.ISupportInitialize)Card1).BeginInit();
            SuspendLayout();
            // 
            // Card1
            // 
            Card1.Image = Properties.Resources.red_joker;
            Card1.Location = new Point(9, 12);
            Card1.Name = "Card1";
            Card1.Size = new Size(218, 311);
            Card1.SizeMode = PictureBoxSizeMode.Zoom;
            Card1.TabIndex = 0;
            Card1.TabStop = false;
            // 
            // btnDeal
            // 
            btnDeal.Location = new Point(9, 329);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(215, 77);
            btnDeal.TabIndex = 1;
            btnDeal.Text = "카드분배";
            btnDeal.UseVisualStyleBackColor = true;
            btnDeal.Click += OnDeal;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 410);
            Controls.Add(btnDeal);
            Controls.Add(Card1);
            Name = "Form1";
            Text = "카드딜러";
            ((System.ComponentModel.ISupportInitialize)Card1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Card1;
        private Button btnDeal;
    }
}
