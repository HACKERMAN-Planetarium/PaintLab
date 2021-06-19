
namespace PaintOOP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Linebutton = new System.Windows.Forms.Button();
            this.Ellipsebutton = new System.Windows.Forms.Button();
            this.RegPolygonbutton = new System.Windows.Forms.Button();
            this.Rectanglebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PenWidthLabel = new System.Windows.Forms.Label();
            this.CornersNumLabel = new System.Windows.Forms.Label();
            this.FirstColorButton = new System.Windows.Forms.Button();
            this.PenWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.SecondColorButton = new System.Windows.Forms.Button();
            this.CornersTrackBar = new System.Windows.Forms.TrackBar();
            this.IsFeelCheck = new System.Windows.Forms.CheckBox();
            this.BrokenLinebutton = new System.Windows.Forms.Button();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.UndoButton = new System.Windows.Forms.Button();
            this.RedoButton = new System.Windows.Forms.Button();
            this.SerializerButton = new System.Windows.Forms.Button();
            this.DeserializerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenWidthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CornersTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox.BackColor = System.Drawing.Color.White;
            this.PictureBox.Location = new System.Drawing.Point(72, 117);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(1493, 711);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseClick);
            this.PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // Linebutton
            // 
            this.Linebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Linebutton.BackgroundImage")));
            this.Linebutton.Location = new System.Drawing.Point(12, 164);
            this.Linebutton.Name = "Linebutton";
            this.Linebutton.Size = new System.Drawing.Size(42, 42);
            this.Linebutton.TabIndex = 8;
            this.Linebutton.UseVisualStyleBackColor = true;
            this.Linebutton.Click += new System.EventHandler(this.Linebutton_Click);
            // 
            // Ellipsebutton
            // 
            this.Ellipsebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ellipsebutton.BackgroundImage")));
            this.Ellipsebutton.Location = new System.Drawing.Point(12, 116);
            this.Ellipsebutton.Name = "Ellipsebutton";
            this.Ellipsebutton.Size = new System.Drawing.Size(42, 42);
            this.Ellipsebutton.TabIndex = 9;
            this.Ellipsebutton.UseVisualStyleBackColor = true;
            this.Ellipsebutton.Click += new System.EventHandler(this.Ellipsebutton_Click);
            // 
            // RegPolygonbutton
            // 
            this.RegPolygonbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegPolygonbutton.BackgroundImage")));
            this.RegPolygonbutton.Location = new System.Drawing.Point(12, 260);
            this.RegPolygonbutton.Name = "RegPolygonbutton";
            this.RegPolygonbutton.Size = new System.Drawing.Size(42, 42);
            this.RegPolygonbutton.TabIndex = 10;
            this.RegPolygonbutton.UseVisualStyleBackColor = true;
            this.RegPolygonbutton.Click += new System.EventHandler(this.RegPolygonbutton_Click);
            // 
            // Rectanglebutton
            // 
            this.Rectanglebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rectanglebutton.BackgroundImage")));
            this.Rectanglebutton.Location = new System.Drawing.Point(12, 212);
            this.Rectanglebutton.Name = "Rectanglebutton";
            this.Rectanglebutton.Size = new System.Drawing.Size(42, 42);
            this.Rectanglebutton.TabIndex = 11;
            this.Rectanglebutton.UseVisualStyleBackColor = true;
            this.Rectanglebutton.Click += new System.EventHandler(this.Rectanglebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Цвет заливки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Цвет контура";
            // 
            // PenWidthLabel
            // 
            this.PenWidthLabel.AutoSize = true;
            this.PenWidthLabel.Location = new System.Drawing.Point(68, 9);
            this.PenWidthLabel.Name = "PenWidthLabel";
            this.PenWidthLabel.Size = new System.Drawing.Size(162, 25);
            this.PenWidthLabel.TabIndex = 17;
            this.PenWidthLabel.Text = "Размер контура: 3";
            // 
            // CornersNumLabel
            // 
            this.CornersNumLabel.AutoSize = true;
            this.CornersNumLabel.Location = new System.Drawing.Point(491, 9);
            this.CornersNumLabel.Name = "CornersNumLabel";
            this.CornersNumLabel.Size = new System.Drawing.Size(189, 25);
            this.CornersNumLabel.TabIndex = 18;
            this.CornersNumLabel.Text = "Количество сторон: 3";
            // 
            // FirstColorButton
            // 
            this.FirstColorButton.BackColor = System.Drawing.Color.Black;
            this.FirstColorButton.Location = new System.Drawing.Point(266, 41);
            this.FirstColorButton.Name = "FirstColorButton";
            this.FirstColorButton.Size = new System.Drawing.Size(60, 60);
            this.FirstColorButton.TabIndex = 19;
            this.FirstColorButton.UseVisualStyleBackColor = false;
            this.FirstColorButton.Click += new System.EventHandler(this.FirstColorButton_Click);
            // 
            // PenWidthTrackBar
            // 
            this.PenWidthTrackBar.Location = new System.Drawing.Point(72, 41);
            this.PenWidthTrackBar.Minimum = 1;
            this.PenWidthTrackBar.Name = "PenWidthTrackBar";
            this.PenWidthTrackBar.Size = new System.Drawing.Size(156, 69);
            this.PenWidthTrackBar.TabIndex = 12;
            this.PenWidthTrackBar.Value = 3;
            this.PenWidthTrackBar.Scroll += new System.EventHandler(this.PenWidthTrackBar_Scroll);
            // 
            // SecondColorButton
            // 
            this.SecondColorButton.BackColor = System.Drawing.Color.White;
            this.SecondColorButton.Location = new System.Drawing.Point(387, 41);
            this.SecondColorButton.Name = "SecondColorButton";
            this.SecondColorButton.Size = new System.Drawing.Size(60, 60);
            this.SecondColorButton.TabIndex = 21;
            this.SecondColorButton.UseVisualStyleBackColor = false;
            this.SecondColorButton.Click += new System.EventHandler(this.SecondColorButton_Click);
            // 
            // CornersTrackBar
            // 
            this.CornersTrackBar.Location = new System.Drawing.Point(491, 41);
            this.CornersTrackBar.Minimum = 3;
            this.CornersTrackBar.Name = "CornersTrackBar";
            this.CornersTrackBar.Size = new System.Drawing.Size(156, 69);
            this.CornersTrackBar.TabIndex = 14;
            this.CornersTrackBar.Value = 3;
            this.CornersTrackBar.Scroll += new System.EventHandler(this.CornerTrackBar_Scroll);
            // 
            // IsFeelCheck
            // 
            this.IsFeelCheck.AutoSize = true;
            this.IsFeelCheck.Location = new System.Drawing.Point(682, 41);
            this.IsFeelCheck.Name = "IsFeelCheck";
            this.IsFeelCheck.Size = new System.Drawing.Size(104, 29);
            this.IsFeelCheck.TabIndex = 23;
            this.IsFeelCheck.Text = "Заливка";
            this.IsFeelCheck.UseVisualStyleBackColor = true;
            this.IsFeelCheck.CheckedChanged += new System.EventHandler(this.IsFeelCheck_CheckedChanged);
            // 
            // BrokenLinebutton
            // 
            this.BrokenLinebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BrokenLinebutton.BackgroundImage")));
            this.BrokenLinebutton.Location = new System.Drawing.Point(12, 308);
            this.BrokenLinebutton.Name = "BrokenLinebutton";
            this.BrokenLinebutton.Size = new System.Drawing.Size(42, 42);
            this.BrokenLinebutton.TabIndex = 24;
            this.BrokenLinebutton.UseVisualStyleBackColor = true;
            this.BrokenLinebutton.Click += new System.EventHandler(this.BrokenLinebutton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.Location = new System.Drawing.Point(12, 382);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(46, 31);
            this.UndoButton.TabIndex = 25;
            this.UndoButton.Text = "<<";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.Location = new System.Drawing.Point(12, 419);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(46, 31);
            this.RedoButton.TabIndex = 26;
            this.RedoButton.Text = ">>";
            this.RedoButton.UseVisualStyleBackColor = true;
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // SerializerButton
            // 
            this.SerializerButton.BackColor = System.Drawing.Color.White;
            this.SerializerButton.Location = new System.Drawing.Point(1236, 41);
            this.SerializerButton.Name = "SerializerButton";
            this.SerializerButton.Size = new System.Drawing.Size(148, 41);
            this.SerializerButton.TabIndex = 27;
            this.SerializerButton.Text = "Serielize";
            this.SerializerButton.UseVisualStyleBackColor = false;
            this.SerializerButton.Click += new System.EventHandler(this.SerializerButton_Click);
            // 
            // DeserializerButton
            // 
            this.DeserializerButton.BackColor = System.Drawing.Color.White;
            this.DeserializerButton.Location = new System.Drawing.Point(1403, 41);
            this.DeserializerButton.Name = "DeserializerButton";
            this.DeserializerButton.Size = new System.Drawing.Size(148, 41);
            this.DeserializerButton.TabIndex = 28;
            this.DeserializerButton.Text = "Deserielize";
            this.DeserializerButton.UseVisualStyleBackColor = false;
            this.DeserializerButton.Click += new System.EventHandler(this.DeserializerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 841);
            this.Controls.Add(this.DeserializerButton);
            this.Controls.Add(this.SerializerButton);
            this.Controls.Add(this.RedoButton);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.BrokenLinebutton);
            this.Controls.Add(this.IsFeelCheck);
            this.Controls.Add(this.CornersTrackBar);
            this.Controls.Add(this.SecondColorButton);
            this.Controls.Add(this.PenWidthTrackBar);
            this.Controls.Add(this.FirstColorButton);
            this.Controls.Add(this.CornersNumLabel);
            this.Controls.Add(this.PenWidthLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rectanglebutton);
            this.Controls.Add(this.RegPolygonbutton);
            this.Controls.Add(this.Ellipsebutton);
            this.Controls.Add(this.Linebutton);
            this.Controls.Add(this.PictureBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Размер контура";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenWidthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CornersTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button Linebutton;
        private System.Windows.Forms.Button Ellipsebutton;
        private System.Windows.Forms.Button RegPolygonbutton;
        private System.Windows.Forms.Button Rectanglebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PenWidthLabel;
        private System.Windows.Forms.Label CornersNumLabel;
        private System.Windows.Forms.Button FirstColorButton;
        private System.Windows.Forms.TrackBar PenWidthTrackBar;
        private System.Windows.Forms.Button SecondColorButton;
        private System.Windows.Forms.TrackBar CornersTrackBar;
        private System.Windows.Forms.CheckBox IsFeelCheck;
        private System.Windows.Forms.Button BrokenLinebutton;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button RedoButton;
        private System.Windows.Forms.Button SerializerButton;
        private System.Windows.Forms.Button DeserializerButton;
    }
}

