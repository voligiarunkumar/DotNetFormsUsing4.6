namespace Varible
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addstringtoarray = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.elementtextbox = new System.Windows.Forms.TextBox();
            this.element = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Indexcount = new System.Windows.Forms.Label();
            this.errormessage = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.arraylength = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.addstringtoarray, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(767, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(386, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // addstringtoarray
            // 
            this.addstringtoarray.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addstringtoarray.AutoSize = true;
            this.addstringtoarray.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addstringtoarray.Location = new System.Drawing.Point(108, 17);
            this.addstringtoarray.Name = "addstringtoarray";
            this.addstringtoarray.Size = new System.Drawing.Size(166, 20);
            this.addstringtoarray.TabIndex = 1;
            this.addstringtoarray.Text = "Add String To Array";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.errormessage, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(462, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.84746F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.15254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(773, 526);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.elementtextbox, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.element, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(767, 52);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // elementtextbox
            // 
            this.elementtextbox.Location = new System.Drawing.Point(386, 3);
            this.elementtextbox.Name = "elementtextbox";
            this.elementtextbox.Size = new System.Drawing.Size(100, 26);
            this.elementtextbox.TabIndex = 0;
            // 
            // element
            // 
            this.element.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.element.AutoSize = true;
            this.element.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.element.Location = new System.Drawing.Point(117, 16);
            this.element.Name = "element";
            this.element.Size = new System.Drawing.Size(148, 20);
            this.element.TabIndex = 1;
            this.element.Text = "Element Of Index";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.93481F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.06519F));
            this.tableLayoutPanel3.Controls.Add(this.textBox2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Indexcount, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 249);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(767, 84);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(386, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 0;
            // 
            // Indexcount
            // 
            this.Indexcount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Indexcount.AutoSize = true;
            this.Indexcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Indexcount.Location = new System.Drawing.Point(138, 32);
            this.Indexcount.Name = "Indexcount";
            this.Indexcount.Size = new System.Drawing.Size(106, 20);
            this.Indexcount.TabIndex = 1;
            this.Indexcount.Text = "Index Count";
            // 
            // errormessage
            // 
            this.errormessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errormessage.AutoSize = true;
            this.errormessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errormessage.ForeColor = System.Drawing.Color.Red;
            this.errormessage.Location = new System.Drawing.Point(210, 375);
            this.errormessage.Name = "errormessage";
            this.errormessage.Size = new System.Drawing.Size(353, 55);
            this.errormessage.TabIndex = 2;
            this.errormessage.Text = "Error Message";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.arraylength, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox3, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 121);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(767, 122);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // arraylength
            // 
            this.arraylength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arraylength.AutoSize = true;
            this.arraylength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arraylength.Location = new System.Drawing.Point(88, 51);
            this.arraylength.Name = "arraylength";
            this.arraylength.Size = new System.Drawing.Size(206, 20);
            this.arraylength.TabIndex = 0;
            this.arraylength.Text = "Total Number of InTakes";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(386, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(3, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(767, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1793, 617);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "First Form Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label addstringtoarray;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Indexcount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label arraylength;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label errormessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox elementtextbox;
        private System.Windows.Forms.Label element;
    }
}

