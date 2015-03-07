namespace server
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtport = new System.Windows.Forms.TextBox();
            this.listcontents = new System.Windows.Forms.ListBox();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.listen = new System.Windows.Forms.Button();
            this.txtsend = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "本机ip";
            // 
            // txtip
            // 
            this.txtip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtip.Location = new System.Drawing.Point(72, 18);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(152, 21);
            this.txtip.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(244, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "本机port";
            // 
            // txtport
            // 
            this.txtport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtport.Location = new System.Drawing.Point(309, 21);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(90, 21);
            this.txtport.TabIndex = 3;
            // 
            // listcontents
            // 
            this.listcontents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listcontents.FormattingEnabled = true;
            this.listcontents.ItemHeight = 12;
            this.listcontents.Location = new System.Drawing.Point(507, 54);
            this.listcontents.Name = "listcontents";
            this.listcontents.Size = new System.Drawing.Size(176, 218);
            this.listcontents.TabIndex = 4;
            // 
            // txtmessage
            // 
            this.txtmessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmessage.Location = new System.Drawing.Point(23, 85);
            this.txtmessage.Multiline = true;
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.ReadOnly = true;
            this.txtmessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtmessage.Size = new System.Drawing.Size(453, 159);
            this.txtmessage.TabIndex = 5;
            // 
            // listen
            // 
            this.listen.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listen.Location = new System.Drawing.Point(72, 56);
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(75, 23);
            this.listen.TabIndex = 6;
            this.listen.Text = "开始监听";
            this.listen.UseVisualStyleBackColor = true;
            this.listen.Click += new System.EventHandler(this.listen_Click);
            // 
            // txtsend
            // 
            this.txtsend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsend.Location = new System.Drawing.Point(23, 280);
            this.txtsend.Name = "txtsend";
            this.txtsend.Size = new System.Drawing.Size(453, 21);
            this.txtsend.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(548, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "发送";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(566, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "客户端";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(180, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "无监听";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 315);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtsend);
            this.Controls.Add(this.listen);
            this.Controls.Add(this.txtmessage);
            this.Controls.Add(this.listcontents);
            this.Controls.Add(this.txtport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtip);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.ListBox listcontents;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.Button listen;
        private System.Windows.Forms.TextBox txtsend;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

