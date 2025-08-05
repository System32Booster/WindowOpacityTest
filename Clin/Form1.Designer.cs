namespace Clin
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackBarAlpha = new System.Windows.Forms.TrackBar();
            this.labelAlphaValue = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.checkBoxEnableLayered = new System.Windows.Forms.CheckBox();
            this.Credit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarAlpha
            // 
            this.trackBarAlpha.Location = new System.Drawing.Point(22, 22);
            this.trackBarAlpha.Margin = new System.Windows.Forms.Padding(6);
            this.trackBarAlpha.Name = "trackBarAlpha";
            this.trackBarAlpha.Size = new System.Drawing.Size(476, 45);
            this.trackBarAlpha.TabIndex = 0;
            this.trackBarAlpha.Scroll += new System.EventHandler(this.trackBarAlpha_Scroll);
            // 
            // labelAlphaValue
            // 
            this.labelAlphaValue.AutoSize = true;
            this.labelAlphaValue.Location = new System.Drawing.Point(22, 82);
            this.labelAlphaValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAlphaValue.Name = "labelAlphaValue";
            this.labelAlphaValue.Size = new System.Drawing.Size(101, 22);
            this.labelAlphaValue.TabIndex = 1;
            this.labelAlphaValue.Text = "Alpha: 255";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(15, 361);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(6);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(483, 132);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "適用";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // checkBoxEnableLayered
            // 
            this.checkBoxEnableLayered.AutoSize = true;
            this.checkBoxEnableLayered.Location = new System.Drawing.Point(340, 326);
            this.checkBoxEnableLayered.Name = "checkBoxEnableLayered";
            this.checkBoxEnableLayered.Size = new System.Drawing.Size(158, 26);
            this.checkBoxEnableLayered.TabIndex = 3;
            this.checkBoxEnableLayered.Text = "透過を有効にする";
            this.checkBoxEnableLayered.UseVisualStyleBackColor = true;
            // 
            // Credit
            // 
            this.Credit.AutoSize = true;
            this.Credit.Location = new System.Drawing.Point(2, 497);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(223, 22);
            this.Credit.TabIndex = 4;
            this.Credit.Text = "Created by RVL-Veemon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 528);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.checkBoxEnableLayered);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.labelAlphaValue);
            this.Controls.Add(this.trackBarAlpha);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Window Opacity Test";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarAlpha;
        private System.Windows.Forms.Label labelAlphaValue;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.CheckBox checkBoxEnableLayered;
        private System.Windows.Forms.Label Credit;
    }
}

