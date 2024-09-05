namespace OlaMundo
{
    partial class FormInputNome
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
            components = new System.ComponentModel.Container();
            TbNome = new TextBox();
            LblNome = new Label();
            BtnConfirmar = new Button();
            BtnCancelar = new Button();
            BsNome = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)BsNome).BeginInit();
            SuspendLayout();
            // 
            // TbNome
            // 
            TbNome.BackColor = SystemColors.Control;
            TbNome.Location = new Point(56, 72);
            TbNome.Name = "TbNome";
            TbNome.Size = new Size(328, 29);
            TbNome.TabIndex = 0;
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(168, 40);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(120, 21);
            LblNome.TabIndex = 1;
            LblNome.Text = "Insira seu nome";
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.DialogResult = DialogResult.OK;
            BtnConfirmar.Location = new Point(96, 128);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(96, 40);
            BtnConfirmar.TabIndex = 2;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.DialogResult = DialogResult.Cancel;
            BtnCancelar.Location = new Point(248, 128);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(96, 40);
            BtnCancelar.TabIndex = 3;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormInputNome
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(462, 239);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnConfirmar);
            Controls.Add(LblNome);
            Controls.Add(TbNome);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormInputNome";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nome";
            ((System.ComponentModel.ISupportInitialize)BsNome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbNome;
        private Label LblNome;
        private Button BtnConfirmar;
        private Button BtnCancelar;
        private BindingSource BsNome;
    }
}