namespace WinFormsApp1.Forms
{
    partial class AddForm
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
            textBoxName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            textBoxLastName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            textBoxAge = new MaterialSkin.Controls.MaterialSingleLineTextField();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Depth = 0;
            textBoxName.Hint = "";
            textBoxName.Location = new Point(86, 73);
            textBoxName.MouseState = MaterialSkin.MouseState.HOVER;
            textBoxName.Name = "textBoxName";
            textBoxName.PasswordChar = '\0';
            textBoxName.SelectedText = "";
            textBoxName.SelectionLength = 0;
            textBoxName.SelectionStart = 0;
            textBoxName.Size = new Size(221, 23);
            textBoxName.TabIndex = 8;
            textBoxName.UseSystemPasswordChar = false;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Depth = 0;
            textBoxLastName.Hint = "";
            textBoxLastName.Location = new Point(86, 116);
            textBoxLastName.MouseState = MaterialSkin.MouseState.HOVER;
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PasswordChar = '\0';
            textBoxLastName.SelectedText = "";
            textBoxLastName.SelectionLength = 0;
            textBoxLastName.SelectionStart = 0;
            textBoxLastName.Size = new Size(221, 23);
            textBoxLastName.TabIndex = 9;
            textBoxLastName.UseSystemPasswordChar = false;
            // 
            // textBoxAge
            // 
            textBoxAge.Depth = 0;
            textBoxAge.Hint = "";
            textBoxAge.Location = new Point(86, 159);
            textBoxAge.MouseState = MaterialSkin.MouseState.HOVER;
            textBoxAge.Name = "textBoxAge";
            textBoxAge.PasswordChar = '\0';
            textBoxAge.SelectedText = "";
            textBoxAge.SelectionLength = 0;
            textBoxAge.SelectionStart = 0;
            textBoxAge.Size = new Size(221, 23);
            textBoxAge.TabIndex = 10;
            textBoxAge.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(8, 76);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(71, 19);
            materialLabel1.TabIndex = 11;
            materialLabel1.Text = "Nombres";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel2.Location = new Point(8, 120);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(72, 19);
            materialLabel2.TabIndex = 12;
            materialLabel2.Text = "Apellidos";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel3.Location = new Point(8, 163);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(42, 19);
            materialLabel3.TabIndex = 13;
            materialLabel3.Text = "Edad";
            // 
            // materialRaisedButton1
            // 
            materialRaisedButton1.Depth = 0;
            materialRaisedButton1.Location = new Point(70, 204);
            materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialRaisedButton1.Name = "materialRaisedButton1";
            materialRaisedButton1.Primary = true;
            materialRaisedButton1.Size = new Size(158, 44);
            materialRaisedButton1.TabIndex = 15;
            materialRaisedButton1.Text = "Guardar";
            materialRaisedButton1.UseVisualStyleBackColor = true;
            materialRaisedButton1.Click += materialRaisedButton1_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(317, 263);
            Controls.Add(materialRaisedButton1);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxName);
            Name = "AddForm";
            Text = "Registrar Alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxName;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxLastName;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxAge;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}