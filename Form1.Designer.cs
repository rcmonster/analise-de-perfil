namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Dispose to clean up the resources being used.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        // Método requerido para suporte à Designer
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtHabilidades = new System.Windows.Forms.TextBox();
            this.txtFormacao = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTestePersonalidade = new System.Windows.Forms.TextBox();
            this.txtSoftSkills = new System.Windows.Forms.TextBox();
            this.btnGerarPDF = new System.Windows.Forms.Button();
            this.lblNomePlaceholder = new System.Windows.Forms.Label();
            this.lblIdadePlaceholder = new System.Windows.Forms.Label();
            this.lblHabilidadesPlaceholder = new System.Windows.Forms.Label();
            this.lblFormacaoPlaceholder = new System.Windows.Forms.Label();
            this.lblEnderecoPlaceholder = new System.Windows.Forms.Label();
            this.lblTestePersonalidadePlaceholder = new System.Windows.Forms.Label();
            this.lblSoftSkillsPlaceholder = new System.Windows.Forms.Label();

            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(260, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);

            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(12, 70);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(260, 20);
            this.txtIdade.TabIndex = 1;
            this.txtIdade.Enter += new System.EventHandler(this.txtIdade_Enter);
            this.txtIdade.Leave += new System.EventHandler(this.txtIdade_Leave);

            // 
            // txtHabilidades
            // 
            this.txtHabilidades.Location = new System.Drawing.Point(12, 110);
            this.txtHabilidades.Name = "txtHabilidades";
            this.txtHabilidades.Size = new System.Drawing.Size(260, 20);
            this.txtHabilidades.TabIndex = 2;
            this.txtHabilidades.Enter += new System.EventHandler(this.txtHabilidades_Enter);
            this.txtHabilidades.Leave += new System.EventHandler(this.txtHabilidades_Leave);

            // 
            // txtFormacao
            // 
            this.txtFormacao.Location = new System.Drawing.Point(12, 150);
            this.txtFormacao.Name = "txtFormacao";
            this.txtFormacao.Size = new System.Drawing.Size(260, 20);
            this.txtFormacao.TabIndex = 3;
            this.txtFormacao.Enter += new System.EventHandler(this.txtFormacao_Enter);
            this.txtFormacao.Leave += new System.EventHandler(this.txtFormacao_Leave);

            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(12, 190);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(260, 20);
            this.txtEndereco.TabIndex = 4;
            this.txtEndereco.Enter += new System.EventHandler(this.txtEndereco_Enter);
            this.txtEndereco.Leave += new System.EventHandler(this.txtEndereco_Leave);

            // 
            // txtTestePersonalidade
            // 
            this.txtTestePersonalidade.Location = new System.Drawing.Point(12, 230);
            this.txtTestePersonalidade.Name = "txtTestePersonalidade";
            this.txtTestePersonalidade.Size = new System.Drawing.Size(260, 20);
            this.txtTestePersonalidade.TabIndex = 5;
            this.txtTestePersonalidade.Enter += new System.EventHandler(this.txtTestePersonalidade_Enter);
            this.txtTestePersonalidade.Leave += new System.EventHandler(this.txtTestePersonalidade_Leave);

            // 
            // txtSoftSkills
            // 
            this.txtSoftSkills.Location = new System.Drawing.Point(12, 270);
            this.txtSoftSkills.Name = "txtSoftSkills";
            this.txtSoftSkills.Size = new System.Drawing.Size(260, 20);
            this.txtSoftSkills.TabIndex = 6;
            this.txtSoftSkills.Enter += new System.EventHandler(this.txtSoftSkills_Enter);
            this.txtSoftSkills.Leave += new System.EventHandler(this.txtSoftSkills_Leave);

            // 
            // btnGerarPDF
            // 
            this.btnGerarPDF.Location = new System.Drawing.Point(12, 310);
            this.btnGerarPDF.Name = "btnGerarPDF";
            this.btnGerarPDF.Size = new System.Drawing.Size(260, 23);
            this.btnGerarPDF.TabIndex = 7;
            this.btnGerarPDF.Text = "Gerar PDF";
            this.btnGerarPDF.UseVisualStyleBackColor = true;
            this.btnGerarPDF.Click += new System.EventHandler(this.btnGerarPDF_Click);

            // 
            // lblNomePlaceholder
            // 
            this.lblNomePlaceholder.AutoSize = true;
            this.lblNomePlaceholder.Location = new System.Drawing.Point(12, 15);
            this.lblNomePlaceholder.Name = "lblNomePlaceholder";
            this.lblNomePlaceholder.Size = new System.Drawing.Size(38, 13);
            this.lblNomePlaceholder.TabIndex = 8;
            this.lblNomePlaceholder.Text = "Nome:";
            this.lblNomePlaceholder.Visible = false;

            // 
            // lblIdadePlaceholder
            // 
            this.lblIdadePlaceholder.AutoSize = true;
            this.lblIdadePlaceholder.Location = new System.Drawing.Point(12, 55);
            this.lblIdadePlaceholder.Name = "lblIdadePlaceholder";
            this.lblIdadePlaceholder.Size = new System.Drawing.Size(39, 13);
            this.lblIdadePlaceholder.TabIndex = 9;
            this.lblIdadePlaceholder.Text = "Idade:";
            this.lblIdadePlaceholder.Visible = false;

            // 
            // lblHabilidadesPlaceholder
            // 
            this.lblHabilidadesPlaceholder.AutoSize = true;
            this.lblHabilidadesPlaceholder.Location = new System.Drawing.Point(12, 95);
            this.lblHabilidadesPlaceholder.Name = "lblHabilidadesPlaceholder";
            this.lblHabilidadesPlaceholder.Size = new System.Drawing.Size(66, 13);
            this.lblHabilidadesPlaceholder.TabIndex = 10;
            this.lblHabilidadesPlaceholder.Text = "Habilidades:";
            this.lblHabilidadesPlaceholder.Visible = false;

            // 
            // lblFormacaoPlaceholder
            // 
            this.lblFormacaoPlaceholder.AutoSize = true;
            this.lblFormacaoPlaceholder.Location = new System.Drawing.Point(12, 135);
            this.lblFormacaoPlaceholder.Name = "lblFormacaoPlaceholder";
            this.lblFormacaoPlaceholder.Size = new System.Drawing.Size(61, 13);
            this.lblFormacaoPlaceholder.TabIndex = 11;
            this.lblFormacaoPlaceholder.Text = "Formação:";
            this.lblFormacaoPlaceholder.Visible = false;

            // 
            // lblEnderecoPlaceholder
            // 
            this.lblEnderecoPlaceholder.AutoSize = true;
            this.lblEnderecoPlaceholder.Location = new System.Drawing.Point(12, 175);
            this.lblEnderecoPlaceholder.Name = "lblEnderecoPlaceholder";
            this.lblEnderecoPlaceholder.Size = new System.Drawing.Size(60, 13);
            this.lblEnderecoPlaceholder.TabIndex = 12;
            this.lblEnderecoPlaceholder.Text = "Endereço:";
            this.lblEnderecoPlaceholder.Visible = false;

            // 
            // lblTestePersonalidadePlaceholder
            // 
            this.lblTestePersonalidadePlaceholder.AutoSize = true;
            this.lblTestePersonalidadePlaceholder.Location = new System.Drawing.Point(12, 215);
            this.lblTestePersonalidadePlaceholder.Name = "lblTestePersonalidadePlaceholder";
            this.lblTestePersonalidadePlaceholder.Size = new System.Drawing.Size(108, 13);
            this.lblTestePersonalidadePlaceholder.TabIndex = 13;
            this.lblTestePersonalidadePlaceholder.Text = "Teste de Personalidade:";
            this.lblTestePersonalidadePlaceholder.Visible = false;

            // 
            // lblSoftSkillsPlaceholder
            // 
            this.lblSoftSkillsPlaceholder.AutoSize = true;
            this.lblSoftSkillsPlaceholder.Location = new System.Drawing.Point(12, 255);
            this.lblSoftSkillsPlaceholder.Name = "lblSoftSkillsPlaceholder";
            this.lblSoftSkillsPlaceholder.Size = new System.Drawing.Size(58, 13);
            this.lblSoftSkillsPlaceholder.TabIndex = 14;
            this.lblSoftSkillsPlaceholder.Text = "Soft Skills:";
            this.lblSoftSkillsPlaceholder.Visible = false;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.lblSoftSkillsPlaceholder);
            this.Controls.Add(this.lblTestePersonalidadePlaceholder);
            this.Controls.Add(this.lblEnderecoPlaceholder);
            this.Controls.Add(this.lblFormacaoPlaceholder);
            this.Controls.Add(this.lblHabilidadesPlaceholder);
            this.Controls.Add(this.lblIdadePlaceholder);
            this.Controls.Add(this.lblNomePlaceholder);
            this.Controls.Add(this.btnGerarPDF);
            this.Controls.Add(this.txtSoftSkills);
            this.Controls.Add(this.txtTestePersonalidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtFormacao);
            this.Controls.Add(this.txtHabilidades);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Gerador de Currículo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtHabilidades;
        private System.Windows.Forms.TextBox txtFormacao;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtTestePersonalidade;
        private System.Windows.Forms.TextBox txtSoftSkills;
        private System.Windows.Forms.Button btnGerarPDF;
        private System.Windows.Forms.Label lblNomePlaceholder;
        private System.Windows.Forms.Label lblIdadePlaceholder;
        private System.Windows.Forms.Label lblHabilidadesPlaceholder;
        private System.Windows.Forms.Label lblFormacaoPlaceholder;
        private System.Windows.Forms.Label lblEnderecoPlaceholder;
        private System.Windows.Forms.Label lblTestePersonalidadePlaceholder;
        private System.Windows.Forms.Label lblSoftSkillsPlaceholder;
    }
}
