namespace AutoCapture
{
    partial class AutoCapture
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtStartX = new System.Windows.Forms.TextBox();
            this.txtStartY = new System.Windows.Forms.TextBox();
            this.txtEndX = new System.Windows.Forms.TextBox();
            this.txtEndY = new System.Windows.Forms.TextBox();
            this.txtMouseX = new System.Windows.Forms.TextBox();
            this.txtMouseY = new System.Windows.Forms.TextBox();
            this.lbPoint = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtStartX
            // 
            this.txtStartX.Location = new System.Drawing.Point(18, 18);
            this.txtStartX.Name = "txtStartX";
            this.txtStartX.Size = new System.Drawing.Size(262, 28);
            this.txtStartX.TabIndex = 0;
            // 
            // txtStartY
            // 
            this.txtStartY.Location = new System.Drawing.Point(18, 52);
            this.txtStartY.Name = "txtStartY";
            this.txtStartY.Size = new System.Drawing.Size(262, 28);
            this.txtStartY.TabIndex = 1;
            // 
            // txtEndX
            // 
            this.txtEndX.Location = new System.Drawing.Point(18, 99);
            this.txtEndX.Name = "txtEndX";
            this.txtEndX.Size = new System.Drawing.Size(262, 28);
            this.txtEndX.TabIndex = 2;
            // 
            // txtEndY
            // 
            this.txtEndY.Location = new System.Drawing.Point(18, 133);
            this.txtEndY.Name = "txtEndY";
            this.txtEndY.Size = new System.Drawing.Size(262, 28);
            this.txtEndY.TabIndex = 3;
            // 
            // txtMouseX
            // 
            this.txtMouseX.Location = new System.Drawing.Point(18, 180);
            this.txtMouseX.Name = "txtMouseX";
            this.txtMouseX.Size = new System.Drawing.Size(262, 28);
            this.txtMouseX.TabIndex = 4;
            // 
            // txtMouseY
            // 
            this.txtMouseY.Location = new System.Drawing.Point(18, 214);
            this.txtMouseY.Name = "txtMouseY";
            this.txtMouseY.Size = new System.Drawing.Size(262, 28);
            this.txtMouseY.TabIndex = 5;
            // 
            // lbPoint
            // 
            this.lbPoint.AutoSize = true;
            this.lbPoint.Location = new System.Drawing.Point(15, 254);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(0, 18);
            this.lbPoint.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(151, 283);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(129, 43);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(18, 283);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(129, 43);
            this.btnPoint.TabIndex = 8;
            this.btnPoint.Text = "Point";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // AutoCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 339);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbPoint);
            this.Controls.Add(this.txtMouseY);
            this.Controls.Add(this.txtMouseX);
            this.Controls.Add(this.txtEndY);
            this.Controls.Add(this.txtEndX);
            this.Controls.Add(this.txtStartY);
            this.Controls.Add(this.txtStartX);
            this.Name = "AutoCapture";
            this.Text = "AutoCapture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStartX;
        private System.Windows.Forms.TextBox txtStartY;
        private System.Windows.Forms.TextBox txtEndX;
        private System.Windows.Forms.TextBox txtEndY;
        private System.Windows.Forms.TextBox txtMouseX;
        private System.Windows.Forms.TextBox txtMouseY;
        private System.Windows.Forms.Label lbPoint;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Timer timer;
    }
}

