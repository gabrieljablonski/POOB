namespace CadastroAlunoMateria
{
    partial class formMainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAluno = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoverAluno = new System.Windows.Forms.Button();
            this.btnAdicionarAluno = new System.Windows.Forms.Button();
            this.dataGridAlunos = new System.Windows.Forms.DataGridView();
            this.colANum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colANome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageMateria = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdicionarMateria = new System.Windows.Forms.Button();
            this.btnRemoverMateria = new System.Windows.Forms.Button();
            this.dataGridMaterias = new System.Windows.Forms.DataGridView();
            this.colMCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMProf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRelatorio = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.comboAlunos = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnRemoverCadastro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRMat = new System.Windows.Forms.TextBox();
            this.dataGridRelatorio = new System.Windows.Forms.DataGridView();
            this.colRCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRProf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPageAluno.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlunos)).BeginInit();
            this.tabPageMateria.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaterias)).BeginInit();
            this.tabRelatorio.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAluno);
            this.tabControl.Controls.Add(this.tabPageMateria);
            this.tabControl.Controls.Add(this.tabRelatorio);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(696, 361);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabPageAluno
            // 
            this.tabPageAluno.Controls.Add(this.tableLayoutPanel1);
            this.tabPageAluno.Location = new System.Drawing.Point(4, 22);
            this.tabPageAluno.Name = "tabPageAluno";
            this.tabPageAluno.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAluno.Size = new System.Drawing.Size(688, 335);
            this.tabPageAluno.TabIndex = 0;
            this.tabPageAluno.Text = "Alunos";
            this.tabPageAluno.UseVisualStyleBackColor = true;
            this.tabPageAluno.Click += new System.EventHandler(this.tabPageAluno_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.87342F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.12658F));
            this.tableLayoutPanel1.Controls.Add(this.btnRemoverAluno, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdicionarAluno, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridAlunos, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.14985F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.85015F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 329);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnRemoverAluno
            // 
            this.btnRemoverAluno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoverAluno.Location = new System.Drawing.Point(343, 3);
            this.btnRemoverAluno.Name = "btnRemoverAluno";
            this.btnRemoverAluno.Size = new System.Drawing.Size(336, 37);
            this.btnRemoverAluno.TabIndex = 1;
            this.btnRemoverAluno.Text = "Remover aluno";
            this.btnRemoverAluno.UseVisualStyleBackColor = true;
            this.btnRemoverAluno.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionarAluno
            // 
            this.btnAdicionarAluno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdicionarAluno.Location = new System.Drawing.Point(3, 3);
            this.btnAdicionarAluno.Name = "btnAdicionarAluno";
            this.btnAdicionarAluno.Size = new System.Drawing.Size(334, 37);
            this.btnAdicionarAluno.TabIndex = 0;
            this.btnAdicionarAluno.Text = "Adicionar aluno";
            this.btnAdicionarAluno.UseVisualStyleBackColor = true;
            this.btnAdicionarAluno.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dataGridAlunos
            // 
            this.dataGridAlunos.AllowUserToAddRows = false;
            this.dataGridAlunos.AllowUserToDeleteRows = false;
            this.dataGridAlunos.AllowUserToResizeColumns = false;
            this.dataGridAlunos.AllowUserToResizeRows = false;
            this.dataGridAlunos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colANum,
            this.colANome,
            this.colAMat});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridAlunos, 2);
            this.dataGridAlunos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAlunos.Location = new System.Drawing.Point(3, 46);
            this.dataGridAlunos.Name = "dataGridAlunos";
            this.dataGridAlunos.RowHeadersVisible = false;
            this.dataGridAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAlunos.Size = new System.Drawing.Size(676, 280);
            this.dataGridAlunos.TabIndex = 2;
            // 
            // colANum
            // 
            this.colANum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colANum.DefaultCellStyle = dataGridViewCellStyle25;
            this.colANum.FillWeight = 30.45685F;
            this.colANum.HeaderText = "#";
            this.colANum.Name = "colANum";
            this.colANum.ReadOnly = true;
            this.colANum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colANum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colANome
            // 
            this.colANome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colANome.FillWeight = 134.7716F;
            this.colANome.HeaderText = "Nome";
            this.colANome.Name = "colANome";
            this.colANome.ReadOnly = true;
            this.colANome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colAMat
            // 
            this.colAMat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colAMat.DefaultCellStyle = dataGridViewCellStyle26;
            this.colAMat.FillWeight = 134.7716F;
            this.colAMat.HeaderText = "Número de Matrícula";
            this.colAMat.Name = "colAMat";
            this.colAMat.ReadOnly = true;
            this.colAMat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tabPageMateria
            // 
            this.tabPageMateria.Controls.Add(this.tableLayoutPanel2);
            this.tabPageMateria.Location = new System.Drawing.Point(4, 22);
            this.tabPageMateria.Name = "tabPageMateria";
            this.tabPageMateria.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMateria.Size = new System.Drawing.Size(688, 335);
            this.tabPageMateria.TabIndex = 1;
            this.tabPageMateria.Text = "Matérias";
            this.tabPageMateria.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdicionarMateria, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRemoverMateria, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridMaterias, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.06991F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.93009F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(682, 329);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAdicionarMateria
            // 
            this.btnAdicionarMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdicionarMateria.Location = new System.Drawing.Point(3, 3);
            this.btnAdicionarMateria.Name = "btnAdicionarMateria";
            this.btnAdicionarMateria.Size = new System.Drawing.Size(335, 37);
            this.btnAdicionarMateria.TabIndex = 0;
            this.btnAdicionarMateria.Text = "Adicionar matéria";
            this.btnAdicionarMateria.UseVisualStyleBackColor = true;
            this.btnAdicionarMateria.Click += new System.EventHandler(this.btnAdicionarMateria_Click);
            // 
            // btnRemoverMateria
            // 
            this.btnRemoverMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoverMateria.Location = new System.Drawing.Point(344, 3);
            this.btnRemoverMateria.Name = "btnRemoverMateria";
            this.btnRemoverMateria.Size = new System.Drawing.Size(335, 37);
            this.btnRemoverMateria.TabIndex = 1;
            this.btnRemoverMateria.Text = "Remover matéria";
            this.btnRemoverMateria.UseVisualStyleBackColor = true;
            this.btnRemoverMateria.Click += new System.EventHandler(this.btnRemoverMateria_Click);
            // 
            // dataGridMaterias
            // 
            this.dataGridMaterias.AllowUserToAddRows = false;
            this.dataGridMaterias.AllowUserToDeleteRows = false;
            this.dataGridMaterias.AllowUserToResizeColumns = false;
            this.dataGridMaterias.AllowUserToResizeRows = false;
            this.dataGridMaterias.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMCod,
            this.colMNome,
            this.colMProf});
            this.tableLayoutPanel2.SetColumnSpan(this.dataGridMaterias, 2);
            this.dataGridMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridMaterias.Location = new System.Drawing.Point(3, 46);
            this.dataGridMaterias.Name = "dataGridMaterias";
            this.dataGridMaterias.RowHeadersVisible = false;
            this.dataGridMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMaterias.Size = new System.Drawing.Size(676, 280);
            this.dataGridMaterias.TabIndex = 2;
            // 
            // colMCod
            // 
            this.colMCod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colMCod.DefaultCellStyle = dataGridViewCellStyle27;
            this.colMCod.FillWeight = 49.80088F;
            this.colMCod.HeaderText = "Código";
            this.colMCod.Name = "colMCod";
            this.colMCod.ReadOnly = true;
            // 
            // colMNome
            // 
            this.colMNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colMNome.DefaultCellStyle = dataGridViewCellStyle28;
            this.colMNome.FillWeight = 97.91485F;
            this.colMNome.HeaderText = "Nome";
            this.colMNome.Name = "colMNome";
            this.colMNome.ReadOnly = true;
            // 
            // colMProf
            // 
            this.colMProf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colMProf.DefaultCellStyle = dataGridViewCellStyle29;
            this.colMProf.FillWeight = 152.2843F;
            this.colMProf.HeaderText = "Professor";
            this.colMProf.Name = "colMProf";
            this.colMProf.ReadOnly = true;
            // 
            // tabRelatorio
            // 
            this.tabRelatorio.Controls.Add(this.tableLayoutPanel3);
            this.tabRelatorio.Location = new System.Drawing.Point(4, 22);
            this.tabRelatorio.Name = "tabRelatorio";
            this.tabRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelatorio.Size = new System.Drawing.Size(688, 335);
            this.tabRelatorio.TabIndex = 2;
            this.tabRelatorio.Text = "Relatório";
            this.tabRelatorio.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.08504F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 507F));
            this.tableLayoutPanel3.Controls.Add(this.comboAlunos, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCadastrar, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnRemoverCadastro, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtRMat, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.dataGridRelatorio, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(682, 329);
            this.tableLayoutPanel3.TabIndex = 0;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // comboAlunos
            // 
            this.comboAlunos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboAlunos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableLayoutPanel3.SetColumnSpan(this.comboAlunos, 2);
            this.comboAlunos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboAlunos.FormattingEnabled = true;
            this.comboAlunos.Location = new System.Drawing.Point(3, 3);
            this.comboAlunos.Name = "comboAlunos";
            this.comboAlunos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboAlunos.Size = new System.Drawing.Size(169, 21);
            this.comboAlunos.TabIndex = 0;
            this.comboAlunos.SelectedIndexChanged += new System.EventHandler(this.comboAlunos_SelectedIndexChanged);
            // 
            // btnCadastrar
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.btnCadastrar, 2);
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCadastrar.Location = new System.Drawing.Point(3, 216);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(169, 52);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar matéria";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnRemoverCadastro
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.btnRemoverCadastro, 2);
            this.btnRemoverCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoverCadastro.Location = new System.Drawing.Point(3, 274);
            this.btnRemoverCadastro.Name = "btnRemoverCadastro";
            this.btnRemoverCadastro.Size = new System.Drawing.Size(169, 52);
            this.btnRemoverCadastro.TabIndex = 2;
            this.btnRemoverCadastro.Text = "Remover cadastro";
            this.btnRemoverCadastro.UseVisualStyleBackColor = true;
            this.btnRemoverCadastro.Click += new System.EventHandler(this.btnRemoverCadastro_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matrícula:";
            // 
            // txtRMat
            // 
            this.txtRMat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRMat.Enabled = false;
            this.txtRMat.Location = new System.Drawing.Point(67, 31);
            this.txtRMat.Name = "txtRMat";
            this.txtRMat.Size = new System.Drawing.Size(105, 20);
            this.txtRMat.TabIndex = 4;
            this.txtRMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridRelatorio
            // 
            this.dataGridRelatorio.AllowUserToAddRows = false;
            this.dataGridRelatorio.AllowUserToDeleteRows = false;
            this.dataGridRelatorio.AllowUserToResizeColumns = false;
            this.dataGridRelatorio.AllowUserToResizeRows = false;
            this.dataGridRelatorio.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRelatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRCod,
            this.colRNome,
            this.colRProf});
            this.dataGridRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRelatorio.Location = new System.Drawing.Point(178, 3);
            this.dataGridRelatorio.Name = "dataGridRelatorio";
            this.dataGridRelatorio.ReadOnly = true;
            this.dataGridRelatorio.RowHeadersVisible = false;
            this.tableLayoutPanel3.SetRowSpan(this.dataGridRelatorio, 4);
            this.dataGridRelatorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRelatorio.Size = new System.Drawing.Size(501, 323);
            this.dataGridRelatorio.TabIndex = 5;
            // 
            // colRCod
            // 
            this.colRCod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colRCod.DefaultCellStyle = dataGridViewCellStyle30;
            this.colRCod.FillWeight = 30F;
            this.colRCod.HeaderText = "Código";
            this.colRCod.Name = "colRCod";
            this.colRCod.ReadOnly = true;
            // 
            // colRNome
            // 
            this.colRNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colRNome.DefaultCellStyle = dataGridViewCellStyle31;
            this.colRNome.FillWeight = 73.85786F;
            this.colRNome.HeaderText = "Nome";
            this.colRNome.Name = "colRNome";
            this.colRNome.ReadOnly = true;
            // 
            // colRProf
            // 
            this.colRProf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colRProf.DefaultCellStyle = dataGridViewCellStyle32;
            this.colRProf.FillWeight = 73.85786F;
            this.colRProf.HeaderText = "Professor";
            this.colRProf.Name = "colRProf";
            this.colRProf.ReadOnly = true;
            // 
            // formMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 361);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(712, 400);
            this.Name = "formMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Aluno/Materia";
            this.tabControl.ResumeLayout(false);
            this.tabPageAluno.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlunos)).EndInit();
            this.tabPageMateria.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaterias)).EndInit();
            this.tabRelatorio.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAluno;
        private System.Windows.Forms.TabPage tabPageMateria;
        private System.Windows.Forms.TabPage tabRelatorio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridAlunos;
        private System.Windows.Forms.Button btnAdicionarAluno;
        private System.Windows.Forms.Button btnRemoverAluno;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colANum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colANome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAMat;
        private System.Windows.Forms.Button btnAdicionarMateria;
        private System.Windows.Forms.Button btnRemoverMateria;
        private System.Windows.Forms.DataGridView dataGridMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMProf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox comboAlunos;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnRemoverCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRMat;
        private System.Windows.Forms.DataGridView dataGridRelatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRProf;
    }
}

