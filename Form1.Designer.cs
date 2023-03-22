namespace WinFormsApp1
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            crearToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            archivoToolStripMenuItem1 = new ToolStripMenuItem();
            alumnosToolStripMenuItem1 = new ToolStripMenuItem();
            crearToolStripMenuItem1 = new ToolStripMenuItem();
            listarToolStripMenuItem1 = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, alumnosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1433, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // alumnosToolStripMenuItem
            // 
            alumnosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearToolStripMenuItem, listarToolStripMenuItem });
            alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            alumnosToolStripMenuItem.Size = new Size(67, 20);
            alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // crearToolStripMenuItem
            // 
            crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            crearToolStripMenuItem.Size = new Size(102, 22);
            crearToolStripMenuItem.Text = "Crear";
            crearToolStripMenuItem.Click += crearToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(102, 22);
            listarToolStripMenuItem.Text = "Listar";
            listarToolStripMenuItem.Click += listarToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(1, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(1433, 558);
            panel1.TabIndex = 4;
            // 
            // archivoToolStripMenuItem1
            // 
            archivoToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { alumnosToolStripMenuItem1, crearToolStripMenuItem1, listarToolStripMenuItem1 });
            archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            archivoToolStripMenuItem1.Size = new Size(115, 22);
            archivoToolStripMenuItem1.Text = "Archivo";
            // 
            // alumnosToolStripMenuItem1
            // 
            alumnosToolStripMenuItem1.Name = "alumnosToolStripMenuItem1";
            alumnosToolStripMenuItem1.Size = new Size(122, 22);
            alumnosToolStripMenuItem1.Text = "Alumnos";
            // 
            // crearToolStripMenuItem1
            // 
            crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            crearToolStripMenuItem1.Size = new Size(122, 22);
            crearToolStripMenuItem1.Text = "Crear";
            // 
            // listarToolStripMenuItem1
            // 
            listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            listarToolStripMenuItem1.Size = new Size(122, 22);
            listarToolStripMenuItem1.Text = "Listar";
            // 
            // cerrarToolStripMenuItem
            // 
            cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            cerrarToolStripMenuItem.Size = new Size(115, 22);
            cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 583);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem crearToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem archivoToolStripMenuItem1;
        private ToolStripMenuItem alumnosToolStripMenuItem1;
        private ToolStripMenuItem crearToolStripMenuItem1;
        private ToolStripMenuItem listarToolStripMenuItem1;
        private ToolStripMenuItem cerrarToolStripMenuItem;
    }
}