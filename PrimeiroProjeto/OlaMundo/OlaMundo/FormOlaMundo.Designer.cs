

namespace OlaMundo
{
    partial class FormOlaMundo
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
            components = new System.ComponentModel.Container();
            BtnCliqueAqui = new Button();
            LblOlaMundo = new Label();
            BtnCliqueAquiUser = new Button();
            TimerOlaMundo = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // BtnCliqueAqui
            // 
            BtnCliqueAqui.Anchor = AnchorStyles.None;
            BtnCliqueAqui.BackColor = SystemColors.Control;
            BtnCliqueAqui.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCliqueAqui.ForeColor = SystemColors.ControlText;
            BtnCliqueAqui.Location = new Point(283, 204);
            BtnCliqueAqui.Name = "BtnCliqueAqui";
            BtnCliqueAqui.Size = new Size(107, 52);
            BtnCliqueAqui.TabIndex = 0;
            BtnCliqueAqui.Text = "Clique Aqui!";
            BtnCliqueAqui.UseVisualStyleBackColor = false;
            BtnCliqueAqui.Click += BtnCliqueAqui_Click;
            // 
            // LblOlaMundo
            // 
            LblOlaMundo.Anchor = AnchorStyles.None;
            LblOlaMundo.AutoSize = true;
            LblOlaMundo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblOlaMundo.ForeColor = SystemColors.Control;
            LblOlaMundo.Location = new Point(328, 128);
            LblOlaMundo.Name = "LblOlaMundo";
            LblOlaMundo.Size = new Size(105, 21);
            LblOlaMundo.TabIndex = 1;
            LblOlaMundo.Text = "LblOlaMundo";
            LblOlaMundo.Visible = false;
            // 
            // BtnCliqueAquiUser
            // 
            BtnCliqueAquiUser.Anchor = AnchorStyles.None;
            BtnCliqueAquiUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCliqueAquiUser.Location = new Point(411, 204);
            BtnCliqueAquiUser.Name = "BtnCliqueAquiUser";
            BtnCliqueAquiUser.Size = new Size(122, 52);
            BtnCliqueAquiUser.TabIndex = 2;
            BtnCliqueAquiUser.Text = "Apresentar-se";
            BtnCliqueAquiUser.UseVisualStyleBackColor = true;
            BtnCliqueAquiUser.Click += BtnCliqueAquiUser_Click;
            // 
            // TimerOlaMundo
            // 
            TimerOlaMundo.Interval = 10000;
            TimerOlaMundo.Tick += TimerOlaMundo_Tick;
            // 
            // FormOlaMundo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCliqueAquiUser);
            Controls.Add(BtnCliqueAqui);
            Controls.Add(LblOlaMundo);
            Name = "FormOlaMundo";
            Text = "Ola Mundo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCliqueAqui;
        private Label LblOlaMundo;
        private Button BtnCliqueAquiUser;
        private System.Windows.Forms.Timer TimerOlaMundo;
    }
}
