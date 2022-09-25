namespace IntroduccionCsh.Presentacion
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_insert = new System.Windows.Forms.Button();
            this.pb_search = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.lb_header = new System.Windows.Forms.Label();
            this.dg_data = new System.Windows.Forms.DataGridView();
            this.pnl_info = new System.Windows.Forms.Panel();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_saveChanges = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.lb_icon = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_data)).BeginInit();
            this.pnl_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_header);
            this.panel1.Controls.Add(this.lb_header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 90);
            this.panel1.TabIndex = 0;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_header.Controls.Add(this.btn_insert);
            this.pnl_header.Controls.Add(this.pb_search);
            this.pnl_header.Controls.Add(this.panel3);
            this.pnl_header.Controls.Add(this.tb_search);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_header.Location = new System.Drawing.Point(0, 42);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(800, 48);
            this.pnl_header.TabIndex = 1;
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_insert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_insert.Location = new System.Drawing.Point(408, 7);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(89, 30);
            this.btn_insert.TabIndex = 5;
            this.btn_insert.Text = "Agregar";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // pb_search
            // 
            this.pb_search.Image = ((System.Drawing.Image)(resources.GetObject("pb_search.Image")));
            this.pb_search.Location = new System.Drawing.Point(309, 12);
            this.pb_search.Name = "pb_search";
            this.pb_search.Size = new System.Drawing.Size(25, 25);
            this.pb_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_search.TabIndex = 4;
            this.pb_search.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Location = new System.Drawing.Point(14, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 2);
            this.panel3.TabIndex = 3;
            // 
            // tb_search
            // 
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(14, 12);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(280, 16);
            this.tb_search.TabIndex = 2;
            // 
            // lb_header
            // 
            this.lb_header.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lb_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_header.ForeColor = System.Drawing.Color.White;
            this.lb_header.Location = new System.Drawing.Point(0, 0);
            this.lb_header.Name = "lb_header";
            this.lb_header.Size = new System.Drawing.Size(800, 42);
            this.lb_header.TabIndex = 0;
            this.lb_header.Text = "Usuarios";
            this.lb_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dg_data
            // 
            this.dg_data.AllowUserToAddRows = false;
            this.dg_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.dg_data.Location = new System.Drawing.Point(12, 96);
            this.dg_data.Name = "dg_data";
            this.dg_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_data.ShowCellErrors = false;
            this.dg_data.ShowRowErrors = false;
            this.dg_data.Size = new System.Drawing.Size(776, 342);
            this.dg_data.TabIndex = 1;
            this.dg_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_data_CellClick);
            // 
            // pnl_info
            // 
            this.pnl_info.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_info.Controls.Add(this.btn_return);
            this.pnl_info.Controls.Add(this.btn_saveChanges);
            this.pnl_info.Controls.Add(this.btn_save);
            this.pnl_info.Controls.Add(this.pb_foto);
            this.pnl_info.Controls.Add(this.lb_icon);
            this.pnl_info.Controls.Add(this.lb_pass);
            this.pnl_info.Controls.Add(this.lb_usuario);
            this.pnl_info.Controls.Add(this.tb_pass);
            this.pnl_info.Controls.Add(this.tb_usuario);
            this.pnl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_info.Location = new System.Drawing.Point(111, 105);
            this.pnl_info.Name = "pnl_info";
            this.pnl_info.Size = new System.Drawing.Size(591, 320);
            this.pnl_info.TabIndex = 2;
            this.pnl_info.Visible = false;
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_return.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_return.Location = new System.Drawing.Point(411, 268);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(89, 30);
            this.btn_return.TabIndex = 8;
            this.btn_return.Text = "Volver";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_saveChanges.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_saveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveChanges.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_saveChanges.Location = new System.Drawing.Point(235, 268);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(170, 30);
            this.btn_saveChanges.TabIndex = 7;
            this.btn_saveChanges.Text = "Guardar cambios";
            this.btn_saveChanges.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_save.Location = new System.Drawing.Point(140, 268);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(89, 30);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pb_foto
            // 
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_foto.Image = ((System.Drawing.Image)(resources.GetObject("pb_foto.Image")));
            this.pb_foto.Location = new System.Drawing.Point(140, 124);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(120, 120);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_foto.TabIndex = 5;
            this.pb_foto.TabStop = false;
            this.pb_foto.Click += new System.EventHandler(this.pb_foto_Click);
            // 
            // lb_icon
            // 
            this.lb_icon.AutoSize = true;
            this.lb_icon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_icon.Location = new System.Drawing.Point(137, 95);
            this.lb_icon.Name = "lb_icon";
            this.lb_icon.Size = new System.Drawing.Size(36, 17);
            this.lb_icon.TabIndex = 4;
            this.lb_icon.Text = "Foto";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Location = new System.Drawing.Point(37, 59);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(96, 20);
            this.lb_pass.TabIndex = 3;
            this.lb_pass.Text = "Contraseña:";
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Location = new System.Drawing.Point(65, 27);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(68, 20);
            this.lb_usuario.TabIndex = 2;
            this.lb_usuario.Text = "Usuario:";
            // 
            // tb_pass
            // 
            this.tb_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_pass.Location = new System.Drawing.Point(139, 53);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(194, 26);
            this.tb_pass.TabIndex = 1;
            // 
            // tb_usuario
            // 
            this.tb_usuario.BackColor = System.Drawing.SystemColors.Window;
            this.tb_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_usuario.Location = new System.Drawing.Point(139, 21);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(194, 26);
            this.tb_usuario.TabIndex = 0;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_info);
            this.Controls.Add(this.dg_data);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.panel1.ResumeLayout(false);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_data)).EndInit();
            this.pnl_info.ResumeLayout(false);
            this.pnl_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_header;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pb_search;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.DataGridView dg_data;
        private System.Windows.Forms.Panel pnl_info;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_saveChanges;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.Label lb_icon;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}