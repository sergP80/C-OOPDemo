namespace VectorCalculator2
{
    partial class VectorCalculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbX11 = new System.Windows.Forms.TextBox();
            this.lbX1 = new System.Windows.Forms.Label();
            this.lbY1 = new System.Windows.Forms.Label();
            this.txbY12 = new System.Windows.Forms.TextBox();
            this.lbY2 = new System.Windows.Forms.Label();
            this.txbY14 = new System.Windows.Forms.TextBox();
            this.lbX2 = new System.Windows.Forms.Label();
            this.txbX13 = new System.Windows.Forms.TextBox();
            this.gbxOperations = new System.Windows.Forms.GroupBox();
            this.rbScalarProdOp = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbAddVector = new System.Windows.Forms.RadioButton();
            this.lbResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbY24 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbX23 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbY22 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbX21 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbxOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbX11
            // 
            this.txbX11.Location = new System.Drawing.Point(112, 23);
            this.txbX11.Name = "txbX11";
            this.txbX11.Size = new System.Drawing.Size(70, 22);
            this.txbX11.TabIndex = 0;
            this.txbX11.Tag = "11";
            this.txbX11.TextChanged += new System.EventHandler(this.txbX1_TextChanged);
            // 
            // lbX1
            // 
            this.lbX1.AutoSize = true;
            this.lbX1.Location = new System.Drawing.Point(81, 26);
            this.lbX1.Name = "lbX1";
            this.lbX1.Size = new System.Drawing.Size(25, 17);
            this.lbX1.TabIndex = 1;
            this.lbX1.Text = "X1";
            // 
            // lbY1
            // 
            this.lbY1.AutoSize = true;
            this.lbY1.Location = new System.Drawing.Point(209, 26);
            this.lbY1.Name = "lbY1";
            this.lbY1.Size = new System.Drawing.Size(25, 17);
            this.lbY1.TabIndex = 3;
            this.lbY1.Text = "Y1";
            // 
            // txbY12
            // 
            this.txbY12.Location = new System.Drawing.Point(240, 23);
            this.txbY12.Name = "txbY12";
            this.txbY12.Size = new System.Drawing.Size(70, 22);
            this.txbY12.TabIndex = 2;
            this.txbY12.Tag = "12";
            this.txbY12.TextChanged += new System.EventHandler(this.txbX1_TextChanged);
            // 
            // lbY2
            // 
            this.lbY2.AutoSize = true;
            this.lbY2.Location = new System.Drawing.Point(445, 26);
            this.lbY2.Name = "lbY2";
            this.lbY2.Size = new System.Drawing.Size(25, 17);
            this.lbY2.TabIndex = 7;
            this.lbY2.Text = "Y2";
            // 
            // txbY14
            // 
            this.txbY14.Location = new System.Drawing.Point(476, 23);
            this.txbY14.Name = "txbY14";
            this.txbY14.Size = new System.Drawing.Size(70, 22);
            this.txbY14.TabIndex = 6;
            this.txbY14.Tag = "14";
            this.txbY14.TextChanged += new System.EventHandler(this.txbX1_TextChanged);
            // 
            // lbX2
            // 
            this.lbX2.AutoSize = true;
            this.lbX2.Location = new System.Drawing.Point(317, 26);
            this.lbX2.Name = "lbX2";
            this.lbX2.Size = new System.Drawing.Size(25, 17);
            this.lbX2.TabIndex = 5;
            this.lbX2.Text = "X2";
            // 
            // txbX13
            // 
            this.txbX13.Location = new System.Drawing.Point(348, 23);
            this.txbX13.Name = "txbX13";
            this.txbX13.Size = new System.Drawing.Size(70, 22);
            this.txbX13.TabIndex = 4;
            this.txbX13.Tag = "13";
            this.txbX13.TextChanged += new System.EventHandler(this.txbX1_TextChanged);
            // 
            // gbxOperations
            // 
            this.gbxOperations.Controls.Add(this.rbScalarProdOp);
            this.gbxOperations.Controls.Add(this.radioButton1);
            this.gbxOperations.Controls.Add(this.rbAddVector);
            this.gbxOperations.Location = new System.Drawing.Point(32, 116);
            this.gbxOperations.Name = "gbxOperations";
            this.gbxOperations.Size = new System.Drawing.Size(226, 135);
            this.gbxOperations.TabIndex = 8;
            this.gbxOperations.TabStop = false;
            this.gbxOperations.Text = "VectorOperations";
            // 
            // rbScalarProdOp
            // 
            this.rbScalarProdOp.AutoSize = true;
            this.rbScalarProdOp.Location = new System.Drawing.Point(6, 84);
            this.rbScalarProdOp.Name = "rbScalarProdOp";
            this.rbScalarProdOp.Size = new System.Drawing.Size(64, 21);
            this.rbScalarProdOp.TabIndex = 2;
            this.rbScalarProdOp.TabStop = true;
            this.rbScalarProdOp.Tag = "3";
            this.rbScalarProdOp.Text = "v1*v2";
            this.rbScalarProdOp.UseVisualStyleBackColor = true;
            this.rbScalarProdOp.Click += new System.EventHandler(this.rbAddVector_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 57);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "2";
            this.radioButton1.Text = "v1 - v2";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.rbAddVector_Click);
            // 
            // rbAddVector
            // 
            this.rbAddVector.AutoSize = true;
            this.rbAddVector.Location = new System.Drawing.Point(6, 30);
            this.rbAddVector.Name = "rbAddVector";
            this.rbAddVector.Size = new System.Drawing.Size(75, 21);
            this.rbAddVector.TabIndex = 0;
            this.rbAddVector.TabStop = true;
            this.rbAddVector.Tag = "1";
            this.rbAddVector.Text = "v1 + v2";
            this.rbAddVector.UseVisualStyleBackColor = true;
            this.rbAddVector.Click += new System.EventHandler(this.rbAddVector_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(35, 270);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(52, 17);
            this.lbResult.TabIndex = 9;
            this.lbResult.Text = "Result:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Y2";
            // 
            // txbY24
            // 
            this.txbY24.Location = new System.Drawing.Point(476, 63);
            this.txbY24.Name = "txbY24";
            this.txbY24.Size = new System.Drawing.Size(70, 22);
            this.txbY24.TabIndex = 16;
            this.txbY24.Tag = "24";
            this.txbY24.TextChanged += new System.EventHandler(this.txbX1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "X2";
            // 
            // txbX23
            // 
            this.txbX23.Location = new System.Drawing.Point(348, 63);
            this.txbX23.Name = "txbX23";
            this.txbX23.Size = new System.Drawing.Size(70, 22);
            this.txbX23.TabIndex = 14;
            this.txbX23.Tag = "23";
            this.txbX23.TextChanged += new System.EventHandler(this.txbX1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Y1";
            // 
            // txbY22
            // 
            this.txbY22.Location = new System.Drawing.Point(240, 63);
            this.txbY22.Name = "txbY22";
            this.txbY22.Size = new System.Drawing.Size(70, 22);
            this.txbY22.TabIndex = 12;
            this.txbY22.Tag = "22";
            this.txbY22.TextChanged += new System.EventHandler(this.txbX1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "X1";
            // 
            // txbX21
            // 
            this.txbX21.Location = new System.Drawing.Point(112, 63);
            this.txbX21.Name = "txbX21";
            this.txbX21.Size = new System.Drawing.Size(70, 22);
            this.txbX21.TabIndex = 10;
            this.txbX21.Tag = "21";
            this.txbX21.TextChanged += new System.EventHandler(this.txbX1_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(27, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // VectorCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 343);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbY24);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbX23);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbY22);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbX21);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.gbxOperations);
            this.Controls.Add(this.lbY2);
            this.Controls.Add(this.txbY14);
            this.Controls.Add(this.lbX2);
            this.Controls.Add(this.txbX13);
            this.Controls.Add(this.lbY1);
            this.Controls.Add(this.txbY12);
            this.Controls.Add(this.lbX1);
            this.Controls.Add(this.txbX11);
            this.Name = "VectorCalculator";
            this.Text = "Vector calculator";
            this.gbxOperations.ResumeLayout(false);
            this.gbxOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbX11;
        private System.Windows.Forms.Label lbX1;
        private System.Windows.Forms.Label lbY1;
        private System.Windows.Forms.TextBox txbY12;
        private System.Windows.Forms.Label lbY2;
        private System.Windows.Forms.TextBox txbY14;
        private System.Windows.Forms.Label lbX2;
        private System.Windows.Forms.TextBox txbX13;
        private System.Windows.Forms.GroupBox gbxOperations;
        private System.Windows.Forms.RadioButton rbScalarProdOp;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbAddVector;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbY24;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbX23;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbY22;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbX21;
        private System.Windows.Forms.Button btnUpdate;
    }
}

