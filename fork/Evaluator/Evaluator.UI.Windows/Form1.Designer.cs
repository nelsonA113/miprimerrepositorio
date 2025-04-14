namespace Evaluator.UI.Windows
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
            Display = new TextBox();
            DPotencia = new Button();
            DAbrir = new Button();
            DCerrar = new Button();
            DLimpiar = new Button();
            DDividir = new Button();
            DSeven = new Button();
            DEight = new Button();
            DNine = new Button();
            DMultiplicacion = new Button();
            DFour = new Button();
            DFive = new Button();
            DSix = new Button();
            DRest = new Button();
            DOne = new Button();
            DTwo = new Button();
            DTree = new Button();
            DSuma = new Button();
            DPunto = new Button();
            DZero = new Button();
            DIgual = new Button();
            DDelete = new Button();
            SuspendLayout();
            // 
            // Display
            // 
            Display.Location = new Point(41, 32);
            Display.Name = "Display";
            Display.Size = new Size(705, 31);
            Display.TabIndex = 0;
            // 
            // DPotencia
            // 
            DPotencia.BackColor = Color.FromArgb(192, 255, 192);
            DPotencia.Font = new Font("Segoe UI", 17F);
            DPotencia.Location = new Point(66, 90);
            DPotencia.Name = "DPotencia";
            DPotencia.Size = new Size(143, 89);
            DPotencia.TabIndex = 1;
            DPotencia.Text = "^";
            DPotencia.UseVisualStyleBackColor = false;
            DPotencia.Click += DPotencia_Click;
            // 
            // DAbrir
            // 
            DAbrir.BackColor = Color.FromArgb(192, 255, 192);
            DAbrir.Font = new Font("Segoe UI", 17F);
            DAbrir.Location = new Point(224, 90);
            DAbrir.Name = "DAbrir";
            DAbrir.Size = new Size(143, 89);
            DAbrir.TabIndex = 2;
            DAbrir.Text = "(";
            DAbrir.UseVisualStyleBackColor = false;
            DAbrir.Click += DAbrir_Click;
            // 
            // DCerrar
            // 
            DCerrar.BackColor = Color.FromArgb(192, 255, 192);
            DCerrar.Font = new Font("Segoe UI", 17F);
            DCerrar.Location = new Point(388, 90);
            DCerrar.Name = "DCerrar";
            DCerrar.Size = new Size(143, 89);
            DCerrar.TabIndex = 3;
            DCerrar.Text = ")";
            DCerrar.UseVisualStyleBackColor = false;
            DCerrar.Click += DCerrar_Click;
            // 
            // DLimpiar
            // 
            DLimpiar.BackColor = Color.FromArgb(192, 255, 192);
            DLimpiar.Font = new Font("Segoe UI", 17F);
            DLimpiar.Location = new Point(552, 90);
            DLimpiar.Name = "DLimpiar";
            DLimpiar.Size = new Size(143, 89);
            DLimpiar.TabIndex = 4;
            DLimpiar.Text = "c";
            DLimpiar.UseVisualStyleBackColor = false;
            DLimpiar.Click += DLimpiar_Click;
            // 
            // DDividir
            // 
            DDividir.BackColor = Color.FromArgb(192, 255, 192);
            DDividir.Font = new Font("Segoe UI", 17F);
            DDividir.Location = new Point(66, 185);
            DDividir.Name = "DDividir";
            DDividir.Size = new Size(143, 89);
            DDividir.TabIndex = 5;
            DDividir.Text = "/";
            DDividir.UseVisualStyleBackColor = false;
            DDividir.Click += DDividir_Click;
            // 
            // DSeven
            // 
            DSeven.Font = new Font("Segoe UI", 17F);
            DSeven.Location = new Point(224, 185);
            DSeven.Name = "DSeven";
            DSeven.Size = new Size(143, 89);
            DSeven.TabIndex = 6;
            DSeven.Text = "7";
            DSeven.UseVisualStyleBackColor = true;
            DSeven.Click += DSeven_Click;
            // 
            // DEight
            // 
            DEight.Font = new Font("Segoe UI", 17F);
            DEight.Location = new Point(388, 185);
            DEight.Name = "DEight";
            DEight.Size = new Size(143, 89);
            DEight.TabIndex = 7;
            DEight.Text = "8";
            DEight.UseVisualStyleBackColor = true;
            DEight.Click += DEight_Click;
            // 
            // DNine
            // 
            DNine.Font = new Font("Segoe UI", 17F);
            DNine.Location = new Point(552, 185);
            DNine.Name = "DNine";
            DNine.Size = new Size(143, 89);
            DNine.TabIndex = 8;
            DNine.Text = "9";
            DNine.UseVisualStyleBackColor = true;
            DNine.Click += DNine_Click;
            // 
            // DMultiplicacion
            // 
            DMultiplicacion.BackColor = Color.FromArgb(192, 255, 192);
            DMultiplicacion.Font = new Font("Segoe UI", 17F);
            DMultiplicacion.Location = new Point(66, 280);
            DMultiplicacion.Name = "DMultiplicacion";
            DMultiplicacion.Size = new Size(143, 89);
            DMultiplicacion.TabIndex = 9;
            DMultiplicacion.Text = "*";
            DMultiplicacion.UseVisualStyleBackColor = false;
            DMultiplicacion.Click += DMultiplicacion_Click;
            // 
            // DFour
            // 
            DFour.Font = new Font("Segoe UI", 17F);
            DFour.Location = new Point(224, 280);
            DFour.Name = "DFour";
            DFour.Size = new Size(143, 89);
            DFour.TabIndex = 10;
            DFour.Text = "4";
            DFour.UseVisualStyleBackColor = true;
            DFour.Click += DFour_Click;
            // 
            // DFive
            // 
            DFive.Font = new Font("Segoe UI", 17F);
            DFive.Location = new Point(388, 280);
            DFive.Name = "DFive";
            DFive.Size = new Size(143, 89);
            DFive.TabIndex = 11;
            DFive.Text = "5";
            DFive.UseVisualStyleBackColor = true;
            DFive.Click += DFive_Click;
            // 
            // DSix
            // 
            DSix.Font = new Font("Segoe UI", 17F);
            DSix.Location = new Point(552, 280);
            DSix.Name = "DSix";
            DSix.Size = new Size(143, 89);
            DSix.TabIndex = 12;
            DSix.Text = "6";
            DSix.UseVisualStyleBackColor = true;
            DSix.Click += DSix_Click;
            // 
            // DRest
            // 
            DRest.BackColor = Color.FromArgb(192, 255, 192);
            DRest.Font = new Font("Segoe UI", 17F);
            DRest.Location = new Point(66, 375);
            DRest.Name = "DRest";
            DRest.Size = new Size(143, 89);
            DRest.TabIndex = 13;
            DRest.Text = "-";
            DRest.UseVisualStyleBackColor = false;
            DRest.Click += DRest_Click;
            // 
            // DOne
            // 
            DOne.Font = new Font("Segoe UI", 17F);
            DOne.Location = new Point(224, 375);
            DOne.Name = "DOne";
            DOne.Size = new Size(143, 89);
            DOne.TabIndex = 14;
            DOne.Text = "1";
            DOne.UseVisualStyleBackColor = true;
            DOne.Click += DOne_Click;
            // 
            // DTwo
            // 
            DTwo.Font = new Font("Segoe UI", 17F);
            DTwo.Location = new Point(388, 375);
            DTwo.Name = "DTwo";
            DTwo.Size = new Size(143, 89);
            DTwo.TabIndex = 15;
            DTwo.Text = "2";
            DTwo.UseVisualStyleBackColor = true;
            DTwo.Click += DTwo_Click;
            // 
            // DTree
            // 
            DTree.Font = new Font("Segoe UI", 17F);
            DTree.Location = new Point(552, 375);
            DTree.Name = "DTree";
            DTree.Size = new Size(76, 89);
            DTree.TabIndex = 16;
            DTree.Text = "3";
            DTree.UseVisualStyleBackColor = true;
            DTree.Click += DTree_Click;
            // 
            // DSuma
            // 
            DSuma.BackColor = Color.FromArgb(192, 255, 192);
            DSuma.Font = new Font("Segoe UI", 17F);
            DSuma.Location = new Point(66, 478);
            DSuma.Name = "DSuma";
            DSuma.Size = new Size(143, 89);
            DSuma.TabIndex = 17;
            DSuma.Text = "+";
            DSuma.UseVisualStyleBackColor = false;
            DSuma.Click += DSuma_Click;
            // 
            // DPunto
            // 
            DPunto.Font = new Font("Segoe UI", 17F);
            DPunto.Location = new Point(224, 478);
            DPunto.Name = "DPunto";
            DPunto.Size = new Size(143, 89);
            DPunto.TabIndex = 18;
            DPunto.Text = ".";
            DPunto.UseVisualStyleBackColor = true;
            DPunto.Click += DPunto_Click;
            // 
            // DZero
            // 
            DZero.Font = new Font("Segoe UI", 17F);
            DZero.Location = new Point(388, 478);
            DZero.Name = "DZero";
            DZero.Size = new Size(143, 89);
            DZero.TabIndex = 19;
            DZero.Text = "0";
            DZero.UseVisualStyleBackColor = true;
            DZero.Click += DZero_Click;
            // 
            // DIgual
            // 
            DIgual.BackColor = Color.FromArgb(255, 255, 192);
            DIgual.Font = new Font("Segoe UI", 17F);
            DIgual.Location = new Point(552, 478);
            DIgual.Name = "DIgual";
            DIgual.Size = new Size(143, 89);
            DIgual.TabIndex = 20;
            DIgual.Text = "=";
            DIgual.UseVisualStyleBackColor = false;
            DIgual.Click += DIgual_Click;
            // 
            // DDelete
            // 
            DDelete.BackColor = Color.FromArgb(255, 255, 192);
            DDelete.Font = new Font("Segoe UI", 17F);
            DDelete.Location = new Point(619, 375);
            DDelete.Name = "DDelete";
            DDelete.Size = new Size(76, 89);
            DDelete.TabIndex = 21;
            DDelete.Text = "x";
            DDelete.UseVisualStyleBackColor = false;
            DDelete.Click += DDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 579);
            Controls.Add(DDelete);
            Controls.Add(DIgual);
            Controls.Add(DZero);
            Controls.Add(DPunto);
            Controls.Add(DSuma);
            Controls.Add(DTree);
            Controls.Add(DTwo);
            Controls.Add(DOne);
            Controls.Add(DRest);
            Controls.Add(DSix);
            Controls.Add(DFive);
            Controls.Add(DFour);
            Controls.Add(DMultiplicacion);
            Controls.Add(DNine);
            Controls.Add(DEight);
            Controls.Add(DSeven);
            Controls.Add(DDividir);
            Controls.Add(DLimpiar);
            Controls.Add(DCerrar);
            Controls.Add(DAbrir);
            Controls.Add(DPotencia);
            Controls.Add(Display);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Display;
        private Button DPotencia;
        private Button DAbrir;
        private Button DCerrar;
        private Button DLimpiar;
        private Button DDividir;
        private Button DSeven;
        private Button DEight;
        private Button DNine;
        private Button DMultiplicacion;
        private Button DFour;
        private Button DFive;
        private Button DSix;
        private Button DRest;
        private Button DOne;
        private Button DTwo;
        private Button DTree;
        private Button DSuma;
        private Button DPunto;
        private Button DZero;
        private Button DIgual;
        private Button DDelete;
    }
}
