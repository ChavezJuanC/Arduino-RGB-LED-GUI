namespace Arduino_RGB_LED_GUI
{
    partial class MasterForm
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
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.RGBSumButton = new System.Windows.Forms.Button();
            this.UserInputLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BlueLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BlueInput = new System.Windows.Forms.TextBox();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.GreenLayout = new System.Windows.Forms.TableLayoutPanel();
            this.GreenInput = new System.Windows.Forms.TextBox();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.RedLayout = new System.Windows.Forms.TableLayoutPanel();
            this.RedLabel = new System.Windows.Forms.Label();
            this.RedInput = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MainLayout.SuspendLayout();
            this.UserInputLayout.SuspendLayout();
            this.BlueLayout.SuspendLayout();
            this.GreenLayout.SuspendLayout();
            this.RedLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.Controls.Add(this.RGBSumButton, 0, 1);
            this.MainLayout.Controls.Add(this.UserInputLayout, 0, 2);
            this.MainLayout.Controls.Add(this.TitleLabel, 0, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.Size = new System.Drawing.Size(534, 221);
            this.MainLayout.TabIndex = 0;
            // 
            // RGBSumButton
            // 
            this.RGBSumButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RGBSumButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RGBSumButton.FlatAppearance.BorderSize = 2;
            this.RGBSumButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RGBSumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RGBSumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RGBSumButton.Font = new System.Drawing.Font("Lucida Console", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGBSumButton.ForeColor = System.Drawing.Color.White;
            this.RGBSumButton.Location = new System.Drawing.Point(237, 78);
            this.RGBSumButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.RGBSumButton.Name = "RGBSumButton";
            this.RGBSumButton.Size = new System.Drawing.Size(60, 60);
            this.RGBSumButton.TabIndex = 0;
            this.RGBSumButton.Text = "Click!";
            this.RGBSumButton.UseVisualStyleBackColor = true;
            this.RGBSumButton.Click += new System.EventHandler(this.RGBSumButton_Click);
            // 
            // UserInputLayout
            // 
            this.UserInputLayout.ColumnCount = 5;
            this.UserInputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.UserInputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.UserInputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.UserInputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.UserInputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.UserInputLayout.Controls.Add(this.BlueLayout, 3, 0);
            this.UserInputLayout.Controls.Add(this.GreenLayout, 2, 0);
            this.UserInputLayout.Controls.Add(this.RedLayout, 1, 0);
            this.UserInputLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserInputLayout.Location = new System.Drawing.Point(3, 149);
            this.UserInputLayout.Name = "UserInputLayout";
            this.UserInputLayout.RowCount = 1;
            this.UserInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserInputLayout.Size = new System.Drawing.Size(528, 69);
            this.UserInputLayout.TabIndex = 0;
            // 
            // BlueLayout
            // 
            this.BlueLayout.ColumnCount = 2;
            this.BlueLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BlueLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BlueLayout.Controls.Add(this.BlueInput, 1, 0);
            this.BlueLayout.Controls.Add(this.BlueLabel, 0, 0);
            this.BlueLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BlueLayout.Location = new System.Drawing.Point(318, 20);
            this.BlueLayout.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.BlueLayout.Name = "BlueLayout";
            this.BlueLayout.RowCount = 1;
            this.BlueLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BlueLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.BlueLayout.Size = new System.Drawing.Size(99, 46);
            this.BlueLayout.TabIndex = 3;
            // 
            // BlueInput
            // 
            this.BlueInput.Location = new System.Drawing.Point(52, 3);
            this.BlueInput.Name = "BlueInput";
            this.BlueInput.Size = new System.Drawing.Size(44, 20);
            this.BlueInput.TabIndex = 2;
            this.BlueInput.TextChanged += new System.EventHandler(this.BlueInput_TextChanged);
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.BackColor = System.Drawing.Color.Transparent;
            this.BlueLabel.ForeColor = System.Drawing.Color.White;
            this.BlueLabel.Location = new System.Drawing.Point(3, 4);
            this.BlueLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(37, 13);
            this.BlueLabel.TabIndex = 1;
            this.BlueLabel.Text = "Blue - ";
            // 
            // GreenLayout
            // 
            this.GreenLayout.ColumnCount = 2;
            this.GreenLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GreenLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GreenLayout.Controls.Add(this.GreenInput, 1, 0);
            this.GreenLayout.Controls.Add(this.GreenLabel, 0, 0);
            this.GreenLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GreenLayout.Location = new System.Drawing.Point(213, 20);
            this.GreenLayout.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.GreenLayout.Name = "GreenLayout";
            this.GreenLayout.RowCount = 1;
            this.GreenLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GreenLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.GreenLayout.Size = new System.Drawing.Size(99, 46);
            this.GreenLayout.TabIndex = 2;
            // 
            // GreenInput
            // 
            this.GreenInput.Location = new System.Drawing.Point(52, 3);
            this.GreenInput.Name = "GreenInput";
            this.GreenInput.Size = new System.Drawing.Size(44, 20);
            this.GreenInput.TabIndex = 2;
            this.GreenInput.TextChanged += new System.EventHandler(this.GreenInput_TextChanged);
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.ForeColor = System.Drawing.Color.White;
            this.GreenLabel.Location = new System.Drawing.Point(3, 4);
            this.GreenLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(42, 13);
            this.GreenLabel.TabIndex = 1;
            this.GreenLabel.Text = "Green - ";
            // 
            // RedLayout
            // 
            this.RedLayout.ColumnCount = 2;
            this.RedLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RedLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RedLayout.Controls.Add(this.RedLabel, 0, 0);
            this.RedLayout.Controls.Add(this.RedInput, 1, 0);
            this.RedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RedLayout.Location = new System.Drawing.Point(108, 20);
            this.RedLayout.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.RedLayout.Name = "RedLayout";
            this.RedLayout.RowCount = 1;
            this.RedLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RedLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.RedLayout.Size = new System.Drawing.Size(99, 46);
            this.RedLayout.TabIndex = 0;
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.ForeColor = System.Drawing.Color.White;
            this.RedLabel.Location = new System.Drawing.Point(3, 4);
            this.RedLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(36, 13);
            this.RedLabel.TabIndex = 0;
            this.RedLabel.Text = "Red - ";
            // 
            // RedInput
            // 
            this.RedInput.Location = new System.Drawing.Point(52, 3);
            this.RedInput.Name = "RedInput";
            this.RedInput.Size = new System.Drawing.Size(44, 20);
            this.RedInput.TabIndex = 1;
            this.RedInput.TextChanged += new System.EventHandler(this.RedInput_TextChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.TitleLabel.Location = new System.Drawing.Point(3, 3);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(528, 67);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Arduino RGB LED Controller";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(534, 221);
            this.Controls.Add(this.MainLayout);
            this.MaximumSize = new System.Drawing.Size(750, 400);
            this.MinimumSize = new System.Drawing.Size(550, 260);
            this.Name = "MasterForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MasterForm_Load);
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            this.UserInputLayout.ResumeLayout(false);
            this.BlueLayout.ResumeLayout(false);
            this.BlueLayout.PerformLayout();
            this.GreenLayout.ResumeLayout(false);
            this.GreenLayout.PerformLayout();
            this.RedLayout.ResumeLayout(false);
            this.RedLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel UserInputLayout;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button RGBSumButton;
        private System.Windows.Forms.TableLayoutPanel RedLayout;
        private System.Windows.Forms.TableLayoutPanel BlueLayout;
        private System.Windows.Forms.TableLayoutPanel GreenLayout;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.TextBox BlueInput;
        private System.Windows.Forms.TextBox GreenInput;
        private System.Windows.Forms.TextBox RedInput;
    }
}

