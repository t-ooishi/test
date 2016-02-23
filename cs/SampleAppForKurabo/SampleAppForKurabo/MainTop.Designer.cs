namespace SampleAppForKurabo
{
    partial class MainTop
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.defButton2 = new SampleAppForKurabo.DefButton();
            this.defButton3 = new SampleAppForKurabo.DefButton();
            this.defButton1 = new SampleAppForKurabo.DefButton();
            this.defLabel1 = new SampleAppForKurabo.DefLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SampleAppForKurabo.Properties.Resources.header_logo;
            this.pictureBox1.Location = new System.Drawing.Point(1052, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Image = global::SampleAppForKurabo.Properties.Resources.MSGBOX01;
            this.button2.Location = new System.Drawing.Point(471, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 98);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Image = global::SampleAppForKurabo.Properties.Resources.hcamera;
            this.button1.Location = new System.Drawing.Point(27, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 98);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // defButton2
            // 
            this.defButton2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.defButton2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.defButton2.Id = ((ushort)(0));
            this.defButton2.Image = global::SampleAppForKurabo.Properties.Resources.MSGBOX01;
            this.defButton2.Location = new System.Drawing.Point(200, 0);
            this.defButton2.Name = "defButton2";
            this.defButton2.Size = new System.Drawing.Size(200, 70);
            this.defButton2.TabIndex = 4;
            this.defButton2.Text = "defButton2";
            this.defButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.defButton2.UseVisualStyleBackColor = false;
            // 
            // defButton3
            // 
            this.defButton3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.defButton3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.defButton3.Id = ((ushort)(0));
            this.defButton3.Image = global::SampleAppForKurabo.Properties.Resources.WRENCH;
            this.defButton3.Location = new System.Drawing.Point(400, 0);
            this.defButton3.Name = "defButton3";
            this.defButton3.Size = new System.Drawing.Size(200, 70);
            this.defButton3.TabIndex = 3;
            this.defButton3.Text = "defButton3";
            this.defButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.defButton3.UseVisualStyleBackColor = false;
            // 
            // defButton1
            // 
            this.defButton1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.defButton1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.defButton1.Id = ((ushort)(0));
            this.defButton1.Image = global::SampleAppForKurabo.Properties.Resources.hcamera;
            this.defButton1.Location = new System.Drawing.Point(0, 0);
            this.defButton1.Name = "defButton1";
            this.defButton1.Size = new System.Drawing.Size(200, 70);
            this.defButton1.TabIndex = 3;
            this.defButton1.Text = "defButton1";
            this.defButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.defButton1.UseVisualStyleBackColor = false;
            // 
            // defLabel1
            // 
            this.defLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.defLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defLabel1.Id = ((ushort)(0));
            this.defLabel1.Location = new System.Drawing.Point(650, 12);
            this.defLabel1.Name = "defLabel1";
            this.defLabel1.Size = new System.Drawing.Size(200, 50);
            this.defLabel1.TabIndex = 6;
            this.defLabel1.Text = "defLabel1";
            // 
            // MainTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.defLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.defButton2);
            this.Controls.Add(this.defButton3);
            this.Controls.Add(this.defButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainTop";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "MainTop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private DefButton defButton1;
        private DefButton defButton2;
        private DefButton defButton3;
        private System.Windows.Forms.Label label1;
        private DefLabel defLabel1;
    }
}

