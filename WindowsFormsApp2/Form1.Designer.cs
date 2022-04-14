
namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.addresult = new System.Windows.Forms.Button();
            this.clearall = new System.Windows.Forms.Button();
            this.deleteselected = new System.Windows.Forms.Button();
            this.clearhistory = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.showMod = new System.Windows.Forms.RadioButton();
            this.hideMul = new System.Windows.Forms.CheckBox();
            this.hideDiv = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hideMod = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Operator";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(255, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(456, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Second Operator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(178, 133);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(97, 27);
            this.Add.TabIndex = 8;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // mul
            // 
            this.mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul.Location = new System.Drawing.Point(178, 199);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(97, 27);
            this.mul.TabIndex = 9;
            this.mul.Text = "Mul";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(178, 166);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(97, 27);
            this.sub.TabIndex = 10;
            this.sub.Text = "Sub";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(178, 232);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(97, 27);
            this.div.TabIndex = 11;
            this.div.Text = "Div";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mod
            // 
            this.mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod.Location = new System.Drawing.Point(178, 265);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(97, 27);
            this.mod.TabIndex = 12;
            this.mod.Text = "Modulus";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // addresult
            // 
            this.addresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresult.Location = new System.Drawing.Point(321, 136);
            this.addresult.Name = "addresult";
            this.addresult.Size = new System.Drawing.Size(129, 39);
            this.addresult.TabIndex = 13;
            this.addresult.Text = "Add Result";
            this.addresult.UseVisualStyleBackColor = true;
            this.addresult.Click += new System.EventHandler(this.addresult_Click);
            // 
            // clearall
            // 
            this.clearall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearall.Location = new System.Drawing.Point(321, 181);
            this.clearall.Name = "clearall";
            this.clearall.Size = new System.Drawing.Size(129, 39);
            this.clearall.TabIndex = 14;
            this.clearall.Text = "Clear All Field";
            this.clearall.UseVisualStyleBackColor = true;
            this.clearall.Click += new System.EventHandler(this.clearall_Click);
            // 
            // deleteselected
            // 
            this.deleteselected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteselected.Location = new System.Drawing.Point(321, 226);
            this.deleteselected.Name = "deleteselected";
            this.deleteselected.Size = new System.Drawing.Size(129, 51);
            this.deleteselected.TabIndex = 15;
            this.deleteselected.Text = "Delete Selected Item";
            this.deleteselected.UseVisualStyleBackColor = true;
            this.deleteselected.Click += new System.EventHandler(this.deleteselected_Click);
            // 
            // clearhistory
            // 
            this.clearhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearhistory.Location = new System.Drawing.Point(471, 293);
            this.clearhistory.Name = "clearhistory";
            this.clearhistory.Size = new System.Drawing.Size(159, 39);
            this.clearhistory.TabIndex = 16;
            this.clearhistory.Text = "Clear History";
            this.clearhistory.UseVisualStyleBackColor = true;
            this.clearhistory.Click += new System.EventHandler(this.clearhistory_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(471, 133);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 160);
            this.listBox1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "History";
            // 
            // showMod
            // 
            this.showMod.AutoSize = true;
            this.showMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showMod.Location = new System.Drawing.Point(6, 22);
            this.showMod.Name = "showMod";
            this.showMod.Size = new System.Drawing.Size(121, 19);
            this.showMod.TabIndex = 19;
            this.showMod.TabStop = true;
            this.showMod.Text = "Show % Button";
            this.showMod.UseVisualStyleBackColor = true;
            this.showMod.CheckedChanged += new System.EventHandler(this.showMod_CheckedChanged);
            // 
            // hideMul
            // 
            this.hideMul.AutoSize = true;
            this.hideMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideMul.Location = new System.Drawing.Point(35, 176);
            this.hideMul.Name = "hideMul";
            this.hideMul.Size = new System.Drawing.Size(130, 19);
            this.hideMul.TabIndex = 20;
            this.hideMul.Text = "HIDE MULTIPLY";
            this.hideMul.UseVisualStyleBackColor = true;
            this.hideMul.CheckedChanged += new System.EventHandler(this.hideMul_CheckedChanged);
            // 
            // hideDiv
            // 
            this.hideDiv.AutoSize = true;
            this.hideDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideDiv.Location = new System.Drawing.Point(35, 207);
            this.hideDiv.Name = "hideDiv";
            this.hideDiv.Size = new System.Drawing.Size(108, 19);
            this.hideDiv.TabIndex = 21;
            this.hideDiv.Text = "HIDE DIVIDE";
            this.hideDiv.UseVisualStyleBackColor = true;
            this.hideDiv.CheckedChanged += new System.EventHandler(this.hideDiv_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hideMod);
            this.groupBox1.Controls.Add(this.showMod);
            this.groupBox1.Location = new System.Drawing.Point(35, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 79);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MODULUS";
            // 
            // hideMod
            // 
            this.hideMod.AutoSize = true;
            this.hideMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideMod.Location = new System.Drawing.Point(6, 45);
            this.hideMod.Name = "hideMod";
            this.hideMod.Size = new System.Drawing.Size(116, 19);
            this.hideMod.TabIndex = 20;
            this.hideMod.TabStop = true;
            this.hideMod.Text = "Hide % Button";
            this.hideMod.UseVisualStyleBackColor = true;
            this.hideMod.CheckedChanged += new System.EventHandler(this.hideMod_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hideDiv);
            this.Controls.Add(this.hideMul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.clearhistory);
            this.Controls.Add(this.deleteselected);
            this.Controls.Add(this.clearall);
            this.Controls.Add(this.addresult);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.div);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button addresult;
        private System.Windows.Forms.Button clearall;
        private System.Windows.Forms.Button deleteselected;
        private System.Windows.Forms.Button clearhistory;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton showMod;
        private System.Windows.Forms.CheckBox hideMul;
        private System.Windows.Forms.CheckBox hideDiv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton hideMod;
    }
}

