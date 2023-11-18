
namespace _20231111
{
    partial class MainForm
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
            this.lblLogIn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pboxMinimize = new System.Windows.Forms.PictureBox();
            this.pBoxExit = new System.Windows.Forms.PictureBox();
            this.pBoxLogIn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogInMsg = new System.Windows.Forms.Label();
            this.lblGrayScaleConverter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnOpenIMG = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBtnCheck = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogIn
            // 
            this.lblLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLogIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLogIn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLogIn.Location = new System.Drawing.Point(3, 116);
            this.lblLogIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(98, 39);
            this.lblLogIn.TabIndex = 2;
            this.lblLogIn.Text = "Log In";
            this.lblLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(211, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Exit";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pboxMinimize, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLogIn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pBoxExit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pBoxLogIn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1600, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.47619F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.52381F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(312, 159);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // pboxMinimize
            // 
            this.pboxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxMinimize.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pboxMinimize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxMinimize.Image = global::_20231111.Properties.Resources.free_icon_minimize_9147772;
            this.pboxMinimize.Location = new System.Drawing.Point(107, 4);
            this.pboxMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pboxMinimize.Name = "pboxMinimize";
            this.pboxMinimize.Size = new System.Drawing.Size(98, 104);
            this.pboxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboxMinimize.TabIndex = 27;
            this.pboxMinimize.TabStop = false;
            this.pboxMinimize.Click += new System.EventHandler(this.pboxMinimize_Click);
            // 
            // pBoxExit
            // 
            this.pBoxExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pBoxExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxExit.Image = global::_20231111.Properties.Resources.Exit;
            this.pBoxExit.Location = new System.Drawing.Point(211, 4);
            this.pBoxExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBoxExit.Name = "pBoxExit";
            this.pBoxExit.Size = new System.Drawing.Size(98, 104);
            this.pBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBoxExit.TabIndex = 4;
            this.pBoxExit.TabStop = false;
            this.pBoxExit.Click += new System.EventHandler(this.pBoxExit_Click);
            // 
            // pBoxLogIn
            // 
            this.pBoxLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxLogIn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pBoxLogIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxLogIn.Image = global::_20231111.Properties.Resources.Log_in_Icon;
            this.pBoxLogIn.Location = new System.Drawing.Point(3, 4);
            this.pBoxLogIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBoxLogIn.Name = "pBoxLogIn";
            this.pBoxLogIn.Size = new System.Drawing.Size(98, 104);
            this.pBoxLogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBoxLogIn.TabIndex = 19;
            this.pBoxLogIn.TabStop = false;
            this.pBoxLogIn.Click += new System.EventHandler(this.pBoxLogIn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(107, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 39);
            this.label1.TabIndex = 20;
            this.label1.Text = "Minimize";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogInMsg
            // 
            this.lblLogInMsg.BackColor = System.Drawing.Color.DimGray;
            this.lblLogInMsg.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLogInMsg.ForeColor = System.Drawing.Color.Black;
            this.lblLogInMsg.Location = new System.Drawing.Point(1600, 229);
            this.lblLogInMsg.Name = "lblLogInMsg";
            this.lblLogInMsg.Size = new System.Drawing.Size(323, 50);
            this.lblLogInMsg.TabIndex = 24;
            this.lblLogInMsg.Text = "로그인이 필요합니다!";
            this.lblLogInMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrayScaleConverter
            // 
            this.lblGrayScaleConverter.BackColor = System.Drawing.Color.DimGray;
            this.lblGrayScaleConverter.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGrayScaleConverter.ForeColor = System.Drawing.Color.Black;
            this.lblGrayScaleConverter.Location = new System.Drawing.Point(0, 0);
            this.lblGrayScaleConverter.Name = "lblGrayScaleConverter";
            this.lblGrayScaleConverter.Size = new System.Drawing.Size(1923, 206);
            this.lblGrayScaleConverter.TabIndex = 26;
            this.lblGrayScaleConverter.Text = "GrayScaleConverter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(162, 381);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 581);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lblInput
            // 
            this.lblInput.BackColor = System.Drawing.Color.DimGray;
            this.lblInput.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInput.Location = new System.Drawing.Point(325, 977);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(147, 75);
            this.lblInput.TabIndex = 29;
            this.lblInput.Text = "Input";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.DimGray;
            this.lblOutput.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOutput.Location = new System.Drawing.Point(988, 977);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(147, 75);
            this.lblOutput.TabIndex = 30;
            this.lblOutput.Text = "Output";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenIMG
            // 
            this.btnOpenIMG.BackColor = System.Drawing.Color.DimGray;
            this.btnOpenIMG.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOpenIMG.Location = new System.Drawing.Point(1499, 892);
            this.btnOpenIMG.Name = "btnOpenIMG";
            this.btnOpenIMG.Size = new System.Drawing.Size(112, 105);
            this.btnOpenIMG.TabIndex = 31;
            this.btnOpenIMG.Text = "Open IMG";
            this.btnOpenIMG.UseVisualStyleBackColor = false;
            this.btnOpenIMG.Click += new System.EventHandler(this.btnOpenIMG_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.DimGray;
            this.btnConvert.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConvert.Location = new System.Drawing.Point(1640, 892);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(112, 105);
            this.btnConvert.TabIndex = 33;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(808, 381);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(492, 581);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(1783, 891);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 105);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblBtnCheck
            // 
            this.lblBtnCheck.BackColor = System.Drawing.Color.DimGray;
            this.lblBtnCheck.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBtnCheck.ForeColor = System.Drawing.Color.Black;
            this.lblBtnCheck.Location = new System.Drawing.Point(1533, 799);
            this.lblBtnCheck.Name = "lblBtnCheck";
            this.lblBtnCheck.Size = new System.Drawing.Size(323, 50);
            this.lblBtnCheck.TabIndex = 36;
            this.lblBtnCheck.Text = "버튼 비활성화";
            this.lblBtnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.ControlBox = false;
            this.Controls.Add(this.lblBtnCheck);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnOpenIMG);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLogInMsg);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblGrayScaleConverter);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Project 1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.PictureBox pBoxExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pBoxLogIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblLogInMsg;
        private System.Windows.Forms.PictureBox pboxMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGrayScaleConverter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnOpenIMG;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblBtnCheck;
    }
}

