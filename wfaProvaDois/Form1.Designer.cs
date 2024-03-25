namespace wfaProvaDois
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
            this.rbOnibus = new System.Windows.Forms.RadioButton();
            this.rbCaminhao = new System.Windows.Forms.RadioButton();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.tbQntAssentos = new System.Windows.Forms.TextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.mktbPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.lbAssentos = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // rbOnibus
            // 
            this.rbOnibus.AutoSize = true;
            this.rbOnibus.Location = new System.Drawing.Point(57, 29);
            this.rbOnibus.Name = "rbOnibus";
            this.rbOnibus.Size = new System.Drawing.Size(70, 20);
            this.rbOnibus.TabIndex = 0;
            this.rbOnibus.TabStop = true;
            this.rbOnibus.Text = "Onibus";
            this.rbOnibus.UseVisualStyleBackColor = true;
            // 
            // rbCaminhao
            // 
            this.rbCaminhao.AutoSize = true;
            this.rbCaminhao.Location = new System.Drawing.Point(240, 29);
            this.rbCaminhao.Name = "rbCaminhao";
            this.rbCaminhao.Size = new System.Drawing.Size(89, 20);
            this.rbCaminhao.TabIndex = 1;
            this.rbCaminhao.TabStop = true;
            this.rbCaminhao.Text = "Caminhao";
            this.rbCaminhao.UseVisualStyleBackColor = true;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(156, 223);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 2;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(286, 223);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 3;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // tbQntAssentos
            // 
            this.tbQntAssentos.Location = new System.Drawing.Point(209, 149);
            this.tbQntAssentos.Name = "tbQntAssentos";
            this.tbQntAssentos.Size = new System.Drawing.Size(100, 22);
            this.tbQntAssentos.TabIndex = 4;
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(209, 100);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(100, 22);
            this.tbAno.TabIndex = 5;
            // 
            // mktbPlaca
            // 
            this.mktbPlaca.Location = new System.Drawing.Point(209, 55);
            this.mktbPlaca.Name = "mktbPlaca";
            this.mktbPlaca.Size = new System.Drawing.Size(100, 22);
            this.mktbPlaca.TabIndex = 6;
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(91, 58);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(42, 16);
            this.lbPlaca.TabIndex = 7;
            this.lbPlaca.Text = "Placa";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(91, 103);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(31, 16);
            this.lbAno.TabIndex = 8;
            this.lbAno.Text = "Ano";
            // 
            // lbAssentos
            // 
            this.lbAssentos.AutoSize = true;
            this.lbAssentos.Location = new System.Drawing.Point(91, 155);
            this.lbAssentos.Name = "lbAssentos";
            this.lbAssentos.Size = new System.Drawing.Size(87, 16);
            this.lbAssentos.TabIndex = 9;
            this.lbAssentos.Text = "Qtd Assentos";
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(63, 291);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(653, 97);
            this.listView.TabIndex = 10;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.lbAssentos);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.mktbPlaca);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.tbQntAssentos);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.rbCaminhao);
            this.Controls.Add(this.rbOnibus);
            this.Name = "Form1";
            this.Text = "Prova";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbOnibus;
        private System.Windows.Forms.RadioButton rbCaminhao;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.TextBox tbQntAssentos;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.MaskedTextBox mktbPlaca;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label lbAssentos;
        private System.Windows.Forms.ListView listView;
    }
}

