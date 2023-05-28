using Images.Properties;
namespace Images
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            Baku = new Button();
            London = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // Baku
            // 
            Baku.Location = new Point(0, 0);
            Baku.Name = "Baku";
            Baku.Size = new Size(180, 74);
            Baku.TabIndex = 0;
            Baku.Text = "Baku";
            Baku.UseVisualStyleBackColor = true;
            Baku.Click += Baku_Click;
            // 
            // London
            // 
            London.Location = new Point(620, 0);
            London.Name = "London";
            London.Size = new Size(177, 74);
            London.TabIndex = 1;
            London.Text = "London";
            London.UseVisualStyleBackColor = true;
            London.Click += London_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.baku;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(London);
            Controls.Add(Baku);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private Button Baku;
        private Button London;

    }
}