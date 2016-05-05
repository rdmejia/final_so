namespace ThreadPool_ProducerConsumer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgvProducers = new System.Windows.Forms.DataGridView();
            this.pId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.working = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvConsumers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(272, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 62);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Agregar Registro";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(363, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 62);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Eliminar Registro";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgvProducers
            // 
            this.dgvProducers.AllowUserToAddRows = false;
            this.dgvProducers.AllowUserToDeleteRows = false;
            this.dgvProducers.AllowUserToResizeColumns = false;
            this.dgvProducers.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            this.dgvProducers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvProducers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProducers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProducers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pId,
            this.working});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducers.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvProducers.Location = new System.Drawing.Point(12, 112);
            this.dgvProducers.MultiSelect = false;
            this.dgvProducers.Name = "dgvProducers";
            this.dgvProducers.ReadOnly = true;
            this.dgvProducers.RowHeadersVisible = false;
            this.dgvProducers.Size = new System.Drawing.Size(140, 234);
            this.dgvProducers.TabIndex = 2;
            // 
            // pId
            // 
            this.pId.HeaderText = "ID";
            this.pId.Name = "pId";
            this.pId.ReadOnly = true;
            this.pId.Width = 50;
            // 
            // working
            // 
            this.working.HeaderText = "Trabajando";
            this.working.Name = "working";
            this.working.ReadOnly = true;
            this.working.Width = 75;
            // 
            // dgvConsumers
            // 
            this.dgvConsumers.AllowUserToAddRows = false;
            this.dgvConsumers.AllowUserToDeleteRows = false;
            this.dgvConsumers.AllowUserToResizeColumns = false;
            this.dgvConsumers.AllowUserToResizeRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            this.dgvConsumers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvConsumers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvConsumers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsumers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvConsumers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvConsumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsumers.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvConsumers.Location = new System.Drawing.Point(158, 112);
            this.dgvConsumers.MultiSelect = false;
            this.dgvConsumers.Name = "dgvConsumers";
            this.dgvConsumers.ReadOnly = true;
            this.dgvConsumers.RowHeadersVisible = false;
            this.dgvConsumers.Size = new System.Drawing.Size(140, 234);
            this.dgvConsumers.TabIndex = 3;
            this.dgvConsumers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsumers_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Trabajando";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Productores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Consumidores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsumers);
            this.Controls.Add(this.dgvProducers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvProducers;
        private System.Windows.Forms.DataGridViewTextBoxColumn pId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn working;
        private System.Windows.Forms.DataGridView dgvConsumers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

