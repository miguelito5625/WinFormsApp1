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
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            textBoxLastName = new TextBox();
            label3 = new Label();
            textBoxAge = new TextBox();
            label4 = new Label();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Registro Alumno";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 58);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombres";
            label2.Click += label2_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(75, 55);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(221, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(75, 98);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(221, 23);
            textBoxLastName.TabIndex = 4;
            textBoxLastName.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 101);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "Apellidos";
            label3.Click += label3_Click;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(75, 141);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(221, 23);
            textBoxAge.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 144);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 5;
            label4.Text = "Edad";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(13, 181);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(158, 42);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Guardar";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 237);
            Controls.Add(buttonSave);
            Controls.Add(textBoxAge);
            Controls.Add(label4);
            Controls.Add(textBoxLastName);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxName;
        private TextBox textBoxLastName;
        private Label label3;
        private TextBox textBoxAge;
        private Label label4;
        private Button buttonSave;
    }
}