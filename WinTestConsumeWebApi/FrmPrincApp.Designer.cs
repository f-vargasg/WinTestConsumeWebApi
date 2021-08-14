
namespace WinTestConsumeWebApi
{
    partial class FrmPrincApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.butDo = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cmbServicios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParameters = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrlFinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butDo
            // 
            this.butDo.Location = new System.Drawing.Point(12, 12);
            this.butDo.Name = "butDo";
            this.butDo.Size = new System.Drawing.Size(174, 41);
            this.butDo.TabIndex = 0;
            this.butDo.Text = "Execute";
            this.butDo.UseVisualStyleBackColor = true;
            this.butDo.Click += new System.EventHandler(this.butDo_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(12, 222);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(985, 328);
            this.txtOutput.TabIndex = 1;
            // 
            // cmbServicios
            // 
            this.cmbServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicios.FormattingEnabled = true;
            this.cmbServicios.Location = new System.Drawing.Point(175, 75);
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(491, 28);
            this.cmbServicios.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Url:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parameters:";
            // 
            // txtParameters
            // 
            this.txtParameters.Location = new System.Drawing.Point(175, 112);
            this.txtParameters.Name = "txtParameters";
            this.txtParameters.Size = new System.Drawing.Size(491, 27);
            this.txtParameters.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Url Final:";
            // 
            // txtUrlFinal
            // 
            this.txtUrlFinal.Location = new System.Drawing.Point(175, 148);
            this.txtUrlFinal.Multiline = true;
            this.txtUrlFinal.Name = "txtUrlFinal";
            this.txtUrlFinal.Size = new System.Drawing.Size(822, 68);
            this.txtUrlFinal.TabIndex = 7;
            // 
            // FrmPrincApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.txtUrlFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParameters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbServicios);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.butDo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butDo;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ComboBox cmbServicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParameters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrlFinal;
    }
}

