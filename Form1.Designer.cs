namespace HM_Geometry2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTriangle = new System.Windows.Forms.TabPage();
            this.btnClearTriangle = new System.Windows.Forms.Button();
            this.btnComputeTriangle = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblSide3 = new System.Windows.Forms.Label();
            this.lblSide2 = new System.Windows.Forms.Label();
            this.lblSide1 = new System.Windows.Forms.Label();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.tbPerimeter = new System.Windows.Forms.TextBox();
            this.tbSide3 = new System.Windows.Forms.TextBox();
            this.tbSide2 = new System.Windows.Forms.TextBox();
            this.tbSide1 = new System.Windows.Forms.TextBox();
            this.tpCircle = new System.Windows.Forms.TabPage();
            this.btnClearCircle = new System.Windows.Forms.Button();
            this.btnComputeCircle = new System.Windows.Forms.Button();
            this.lblAreaCircle = new System.Windows.Forms.Label();
            this.lblPerimeterCircle = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.tbAreaCircle = new System.Windows.Forms.TextBox();
            this.tbPerimeterCircle = new System.Windows.Forms.TextBox();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.tpRectangle = new System.Windows.Forms.TabPage();
            this.btnClearRectangle = new System.Windows.Forms.Button();
            this.btnComputeRectangle = new System.Windows.Forms.Button();
            this.lblAreaRactangle = new System.Windows.Forms.Label();
            this.lblPerimeterRectangle = new System.Windows.Forms.Label();
            this.lblSide2Rectangle = new System.Windows.Forms.Label();
            this.lblSide1Rectangle = new System.Windows.Forms.Label();
            this.lblInfoRectangle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAreaRectangle = new System.Windows.Forms.TextBox();
            this.tbPerimeterRectangle = new System.Windows.Forms.TextBox();
            this.tbSide2Rectangle = new System.Windows.Forms.TextBox();
            this.tbSide1Rectangle = new System.Windows.Forms.TextBox();
            this.tpSquare = new System.Windows.Forms.TabPage();
            this.btnClearSquare = new System.Windows.Forms.Button();
            this.btnComputeSqure = new System.Windows.Forms.Button();
            this.lblAreaSquare = new System.Windows.Forms.Label();
            this.lblPerimeterSquare = new System.Windows.Forms.Label();
            this.lblSideSquare = new System.Windows.Forms.Label();
            this.tbAreaSquare = new System.Windows.Forms.TextBox();
            this.tbPerimeterSquare = new System.Windows.Forms.TextBox();
            this.tbSideSquare = new System.Windows.Forms.TextBox();
            this.tpRhomb = new System.Windows.Forms.TabPage();
            this.tbDiagonal1Rhomb = new System.Windows.Forms.TextBox();
            this.tbDiagonal2Rhomb = new System.Windows.Forms.TextBox();
            this.tbPerimeterRhomb = new System.Windows.Forms.TextBox();
            this.tbAreaRhomb = new System.Windows.Forms.TextBox();
            this.lblDiagonal1Rhomb = new System.Windows.Forms.Label();
            this.lblDiagonal2Rhomb = new System.Windows.Forms.Label();
            this.lblPerimeterRhomb = new System.Windows.Forms.Label();
            this.lblAreaRhomb = new System.Windows.Forms.Label();
            this.btnComputeRhomb = new System.Windows.Forms.Button();
            this.btnClearRhomb = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpTriangle.SuspendLayout();
            this.tpCircle.SuspendLayout();
            this.tpRectangle.SuspendLayout();
            this.tpSquare.SuspendLayout();
            this.tpRhomb.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTriangle);
            this.tabControl1.Controls.Add(this.tpCircle);
            this.tabControl1.Controls.Add(this.tpRectangle);
            this.tabControl1.Controls.Add(this.tpSquare);
            this.tabControl1.Controls.Add(this.tpRhomb);
            this.tabControl1.Location = new System.Drawing.Point(12, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 4;
            this.tabControl1.Size = new System.Drawing.Size(457, 413);
            this.tabControl1.TabIndex = 0;
            // 
            // tpTriangle
            // 
            this.tpTriangle.Controls.Add(this.btnClearTriangle);
            this.tpTriangle.Controls.Add(this.btnComputeTriangle);
            this.tpTriangle.Controls.Add(this.lblArea);
            this.tpTriangle.Controls.Add(this.lblPerimeter);
            this.tpTriangle.Controls.Add(this.lblSide3);
            this.tpTriangle.Controls.Add(this.lblSide2);
            this.tpTriangle.Controls.Add(this.lblSide1);
            this.tpTriangle.Controls.Add(this.tbArea);
            this.tpTriangle.Controls.Add(this.tbPerimeter);
            this.tpTriangle.Controls.Add(this.tbSide3);
            this.tpTriangle.Controls.Add(this.tbSide2);
            this.tpTriangle.Controls.Add(this.tbSide1);
            this.tpTriangle.Location = new System.Drawing.Point(4, 29);
            this.tpTriangle.Name = "tpTriangle";
            this.tpTriangle.Padding = new System.Windows.Forms.Padding(3);
            this.tpTriangle.Size = new System.Drawing.Size(449, 380);
            this.tpTriangle.TabIndex = 0;
            this.tpTriangle.Text = "Трикутник";
            this.tpTriangle.UseVisualStyleBackColor = true;
            // 
            // btnClearTriangle
            // 
            this.btnClearTriangle.Location = new System.Drawing.Point(346, 14);
            this.btnClearTriangle.Name = "btnClearTriangle";
            this.btnClearTriangle.Size = new System.Drawing.Size(94, 29);
            this.btnClearTriangle.TabIndex = 11;
            this.btnClearTriangle.Text = "Очистити";
            this.btnClearTriangle.UseVisualStyleBackColor = true;
            this.btnClearTriangle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClearTriangle_MouseClick);
            // 
            // btnComputeTriangle
            // 
            this.btnComputeTriangle.Location = new System.Drawing.Point(282, 304);
            this.btnComputeTriangle.Name = "btnComputeTriangle";
            this.btnComputeTriangle.Size = new System.Drawing.Size(164, 73);
            this.btnComputeTriangle.TabIndex = 10;
            this.btnComputeTriangle.Text = "Розрахувати";
            this.btnComputeTriangle.UseVisualStyleBackColor = true;
            this.btnComputeTriangle.Click += new System.EventHandler(this.btnComputeTriangle_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(173, 320);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(57, 20);
            this.lblArea.TabIndex = 9;
            this.lblArea.Text = "Площа";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(173, 260);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(80, 20);
            this.lblPerimeter.TabIndex = 8;
            this.lblPerimeter.Text = "Периметр";
            // 
            // lblSide3
            // 
            this.lblSide3.AutoSize = true;
            this.lblSide3.Location = new System.Drawing.Point(173, 200);
            this.lblSide3.Name = "lblSide3";
            this.lblSide3.Size = new System.Drawing.Size(109, 20);
            this.lblSide3.TabIndex = 7;
            this.lblSide3.Text = "Третя сторона";
            // 
            // lblSide2
            // 
            this.lblSide2.AutoSize = true;
            this.lblSide2.Location = new System.Drawing.Point(173, 152);
            this.lblSide2.Name = "lblSide2";
            this.lblSide2.Size = new System.Drawing.Size(110, 20);
            this.lblSide2.TabIndex = 6;
            this.lblSide2.Text = "Друга сторона";
            // 
            // lblSide1
            // 
            this.lblSide1.AutoSize = true;
            this.lblSide1.Location = new System.Drawing.Point(173, 103);
            this.lblSide1.Name = "lblSide1";
            this.lblSide1.Size = new System.Drawing.Size(118, 20);
            this.lblSide1.TabIndex = 5;
            this.lblSide1.Text = "Перша сторона";
            this.lblSide1.Click += new System.EventHandler(this.lblSide1_Click);
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(30, 323);
            this.tbArea.Name = "tbArea";
            this.tbArea.ReadOnly = true;
            this.tbArea.Size = new System.Drawing.Size(125, 27);
            this.tbArea.TabIndex = 4;
            // 
            // tbPerimeter
            // 
            this.tbPerimeter.Location = new System.Drawing.Point(30, 263);
            this.tbPerimeter.Name = "tbPerimeter";
            this.tbPerimeter.ReadOnly = true;
            this.tbPerimeter.Size = new System.Drawing.Size(125, 27);
            this.tbPerimeter.TabIndex = 3;
            // 
            // tbSide3
            // 
            this.tbSide3.Location = new System.Drawing.Point(30, 203);
            this.tbSide3.Name = "tbSide3";
            this.tbSide3.Size = new System.Drawing.Size(125, 27);
            this.tbSide3.TabIndex = 2;
            // 
            // tbSide2
            // 
            this.tbSide2.Location = new System.Drawing.Point(30, 155);
            this.tbSide2.Name = "tbSide2";
            this.tbSide2.Size = new System.Drawing.Size(125, 27);
            this.tbSide2.TabIndex = 1;
            // 
            // tbSide1
            // 
            this.tbSide1.Location = new System.Drawing.Point(30, 106);
            this.tbSide1.Name = "tbSide1";
            this.tbSide1.Size = new System.Drawing.Size(125, 27);
            this.tbSide1.TabIndex = 0;
            // 
            // tpCircle
            // 
            this.tpCircle.Controls.Add(this.btnClearCircle);
            this.tpCircle.Controls.Add(this.btnComputeCircle);
            this.tpCircle.Controls.Add(this.lblAreaCircle);
            this.tpCircle.Controls.Add(this.lblPerimeterCircle);
            this.tpCircle.Controls.Add(this.lblRadius);
            this.tpCircle.Controls.Add(this.tbAreaCircle);
            this.tpCircle.Controls.Add(this.tbPerimeterCircle);
            this.tpCircle.Controls.Add(this.tbRadius);
            this.tpCircle.Location = new System.Drawing.Point(4, 29);
            this.tpCircle.Name = "tpCircle";
            this.tpCircle.Padding = new System.Windows.Forms.Padding(3);
            this.tpCircle.Size = new System.Drawing.Size(449, 380);
            this.tpCircle.TabIndex = 1;
            this.tpCircle.Text = "Круг";
            this.tpCircle.UseVisualStyleBackColor = true;
            // 
            // btnClearCircle
            // 
            this.btnClearCircle.Location = new System.Drawing.Point(283, 298);
            this.btnClearCircle.Name = "btnClearCircle";
            this.btnClearCircle.Size = new System.Drawing.Size(163, 79);
            this.btnClearCircle.TabIndex = 7;
            this.btnClearCircle.Text = "Очистити";
            this.btnClearCircle.UseVisualStyleBackColor = true;
            this.btnClearCircle.Click += new System.EventHandler(this.btnClearCircle_Click);
            // 
            // btnComputeCircle
            // 
            this.btnComputeCircle.Location = new System.Drawing.Point(4, 298);
            this.btnComputeCircle.Name = "btnComputeCircle";
            this.btnComputeCircle.Size = new System.Drawing.Size(163, 79);
            this.btnComputeCircle.TabIndex = 6;
            this.btnComputeCircle.Text = "Розрахувати";
            this.btnComputeCircle.UseVisualStyleBackColor = true;
            this.btnComputeCircle.Click += new System.EventHandler(this.btnComputeCircle_Click);
            // 
            // lblAreaCircle
            // 
            this.lblAreaCircle.AutoSize = true;
            this.lblAreaCircle.Location = new System.Drawing.Point(220, 230);
            this.lblAreaCircle.Name = "lblAreaCircle";
            this.lblAreaCircle.Size = new System.Drawing.Size(57, 20);
            this.lblAreaCircle.TabIndex = 5;
            this.lblAreaCircle.Text = "Площа";
            // 
            // lblPerimeterCircle
            // 
            this.lblPerimeterCircle.AutoSize = true;
            this.lblPerimeterCircle.Location = new System.Drawing.Point(220, 147);
            this.lblPerimeterCircle.Name = "lblPerimeterCircle";
            this.lblPerimeterCircle.Size = new System.Drawing.Size(109, 20);
            this.lblPerimeterCircle.TabIndex = 4;
            this.lblPerimeterCircle.Text = "Довжина кола";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(220, 71);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(51, 20);
            this.lblRadius.TabIndex = 3;
            this.lblRadius.Text = "Радіус";
            // 
            // tbAreaCircle
            // 
            this.tbAreaCircle.Location = new System.Drawing.Point(78, 230);
            this.tbAreaCircle.Name = "tbAreaCircle";
            this.tbAreaCircle.ReadOnly = true;
            this.tbAreaCircle.Size = new System.Drawing.Size(125, 27);
            this.tbAreaCircle.TabIndex = 2;
            // 
            // tbPerimeterCircle
            // 
            this.tbPerimeterCircle.Location = new System.Drawing.Point(78, 147);
            this.tbPerimeterCircle.Name = "tbPerimeterCircle";
            this.tbPerimeterCircle.ReadOnly = true;
            this.tbPerimeterCircle.Size = new System.Drawing.Size(125, 27);
            this.tbPerimeterCircle.TabIndex = 1;
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(78, 71);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(125, 27);
            this.tbRadius.TabIndex = 0;
            // 
            // tpRectangle
            // 
            this.tpRectangle.Controls.Add(this.btnClearRectangle);
            this.tpRectangle.Controls.Add(this.btnComputeRectangle);
            this.tpRectangle.Controls.Add(this.lblAreaRactangle);
            this.tpRectangle.Controls.Add(this.lblPerimeterRectangle);
            this.tpRectangle.Controls.Add(this.lblSide2Rectangle);
            this.tpRectangle.Controls.Add(this.lblSide1Rectangle);
            this.tpRectangle.Controls.Add(this.lblInfoRectangle);
            this.tpRectangle.Controls.Add(this.label1);
            this.tpRectangle.Controls.Add(this.tbAreaRectangle);
            this.tpRectangle.Controls.Add(this.tbPerimeterRectangle);
            this.tpRectangle.Controls.Add(this.tbSide2Rectangle);
            this.tpRectangle.Controls.Add(this.tbSide1Rectangle);
            this.tpRectangle.Location = new System.Drawing.Point(4, 29);
            this.tpRectangle.Name = "tpRectangle";
            this.tpRectangle.Size = new System.Drawing.Size(449, 380);
            this.tpRectangle.TabIndex = 2;
            this.tpRectangle.Text = "Прямокутник";
            // 
            // btnClearRectangle
            // 
            this.btnClearRectangle.Location = new System.Drawing.Point(333, 331);
            this.btnClearRectangle.Name = "btnClearRectangle";
            this.btnClearRectangle.Size = new System.Drawing.Size(113, 46);
            this.btnClearRectangle.TabIndex = 12;
            this.btnClearRectangle.Text = "Очистити";
            this.btnClearRectangle.UseVisualStyleBackColor = true;
            this.btnClearRectangle.Click += new System.EventHandler(this.btnClearRectangle_Click);
            // 
            // btnComputeRectangle
            // 
            this.btnComputeRectangle.Location = new System.Drawing.Point(4, 331);
            this.btnComputeRectangle.Name = "btnComputeRectangle";
            this.btnComputeRectangle.Size = new System.Drawing.Size(111, 46);
            this.btnComputeRectangle.TabIndex = 10;
            this.btnComputeRectangle.Text = "Розрахувати";
            this.btnComputeRectangle.UseVisualStyleBackColor = true;
            this.btnComputeRectangle.Click += new System.EventHandler(this.btnComputeRectangle_Click_1);
            // 
            // lblAreaRactangle
            // 
            this.lblAreaRactangle.AutoSize = true;
            this.lblAreaRactangle.Location = new System.Drawing.Point(168, 261);
            this.lblAreaRactangle.Name = "lblAreaRactangle";
            this.lblAreaRactangle.Size = new System.Drawing.Size(57, 20);
            this.lblAreaRactangle.TabIndex = 9;
            this.lblAreaRactangle.Text = "Площа";
            // 
            // lblPerimeterRectangle
            // 
            this.lblPerimeterRectangle.AutoSize = true;
            this.lblPerimeterRectangle.Location = new System.Drawing.Point(168, 200);
            this.lblPerimeterRectangle.Name = "lblPerimeterRectangle";
            this.lblPerimeterRectangle.Size = new System.Drawing.Size(80, 20);
            this.lblPerimeterRectangle.TabIndex = 8;
            this.lblPerimeterRectangle.Text = "Периметр";
            // 
            // lblSide2Rectangle
            // 
            this.lblSide2Rectangle.AutoSize = true;
            this.lblSide2Rectangle.Location = new System.Drawing.Point(168, 138);
            this.lblSide2Rectangle.Name = "lblSide2Rectangle";
            this.lblSide2Rectangle.Size = new System.Drawing.Size(110, 20);
            this.lblSide2Rectangle.TabIndex = 7;
            this.lblSide2Rectangle.Text = "Друга сторона";
            // 
            // lblSide1Rectangle
            // 
            this.lblSide1Rectangle.AutoSize = true;
            this.lblSide1Rectangle.Location = new System.Drawing.Point(168, 83);
            this.lblSide1Rectangle.Name = "lblSide1Rectangle";
            this.lblSide1Rectangle.Size = new System.Drawing.Size(118, 20);
            this.lblSide1Rectangle.TabIndex = 6;
            this.lblSide1Rectangle.Text = "Перша сторона";
            // 
            // lblInfoRectangle
            // 
            this.lblInfoRectangle.AutoSize = true;
            this.lblInfoRectangle.Location = new System.Drawing.Point(15, 43);
            this.lblInfoRectangle.Name = "lblInfoRectangle";
            this.lblInfoRectangle.Size = new System.Drawing.Size(207, 20);
            this.lblInfoRectangle.TabIndex = 5;
            this.lblInfoRectangle.Text = "Введіть дві суміжні сторони ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // tbAreaRectangle
            // 
            this.tbAreaRectangle.Location = new System.Drawing.Point(22, 264);
            this.tbAreaRectangle.Name = "tbAreaRectangle";
            this.tbAreaRectangle.ReadOnly = true;
            this.tbAreaRectangle.Size = new System.Drawing.Size(125, 27);
            this.tbAreaRectangle.TabIndex = 3;
            // 
            // tbPerimeterRectangle
            // 
            this.tbPerimeterRectangle.Location = new System.Drawing.Point(22, 203);
            this.tbPerimeterRectangle.Name = "tbPerimeterRectangle";
            this.tbPerimeterRectangle.ReadOnly = true;
            this.tbPerimeterRectangle.Size = new System.Drawing.Size(125, 27);
            this.tbPerimeterRectangle.TabIndex = 2;
            // 
            // tbSide2Rectangle
            // 
            this.tbSide2Rectangle.Location = new System.Drawing.Point(22, 141);
            this.tbSide2Rectangle.Name = "tbSide2Rectangle";
            this.tbSide2Rectangle.Size = new System.Drawing.Size(125, 27);
            this.tbSide2Rectangle.TabIndex = 1;
            // 
            // tbSide1Rectangle
            // 
            this.tbSide1Rectangle.Location = new System.Drawing.Point(22, 86);
            this.tbSide1Rectangle.Name = "tbSide1Rectangle";
            this.tbSide1Rectangle.Size = new System.Drawing.Size(125, 27);
            this.tbSide1Rectangle.TabIndex = 0;
            // 
            // tpSquare
            // 
            this.tpSquare.Controls.Add(this.btnClearSquare);
            this.tpSquare.Controls.Add(this.btnComputeSqure);
            this.tpSquare.Controls.Add(this.lblAreaSquare);
            this.tpSquare.Controls.Add(this.lblPerimeterSquare);
            this.tpSquare.Controls.Add(this.lblSideSquare);
            this.tpSquare.Controls.Add(this.tbAreaSquare);
            this.tpSquare.Controls.Add(this.tbPerimeterSquare);
            this.tpSquare.Controls.Add(this.tbSideSquare);
            this.tpSquare.Location = new System.Drawing.Point(4, 29);
            this.tpSquare.Name = "tpSquare";
            this.tpSquare.Size = new System.Drawing.Size(449, 380);
            this.tpSquare.TabIndex = 3;
            this.tpSquare.Text = "Квадрат";
            // 
            // btnClearSquare
            // 
            this.btnClearSquare.Location = new System.Drawing.Point(320, 325);
            this.btnClearSquare.Name = "btnClearSquare";
            this.btnClearSquare.Size = new System.Drawing.Size(126, 52);
            this.btnClearSquare.TabIndex = 7;
            this.btnClearSquare.Text = "Очистити";
            this.btnClearSquare.UseVisualStyleBackColor = true;
            this.btnClearSquare.Click += new System.EventHandler(this.btnClearSquare_Click);
            // 
            // btnComputeSqure
            // 
            this.btnComputeSqure.Location = new System.Drawing.Point(4, 325);
            this.btnComputeSqure.Name = "btnComputeSqure";
            this.btnComputeSqure.Size = new System.Drawing.Size(127, 52);
            this.btnComputeSqure.TabIndex = 6;
            this.btnComputeSqure.Text = "Розрахувати";
            this.btnComputeSqure.UseVisualStyleBackColor = true;
            this.btnComputeSqure.Click += new System.EventHandler(this.btnComputeSqure_Click);
            // 
            // lblAreaSquare
            // 
            this.lblAreaSquare.AutoSize = true;
            this.lblAreaSquare.Location = new System.Drawing.Point(192, 171);
            this.lblAreaSquare.Name = "lblAreaSquare";
            this.lblAreaSquare.Size = new System.Drawing.Size(57, 20);
            this.lblAreaSquare.TabIndex = 5;
            this.lblAreaSquare.Text = "Площа";
            // 
            // lblPerimeterSquare
            // 
            this.lblPerimeterSquare.AutoSize = true;
            this.lblPerimeterSquare.Location = new System.Drawing.Point(192, 103);
            this.lblPerimeterSquare.Name = "lblPerimeterSquare";
            this.lblPerimeterSquare.Size = new System.Drawing.Size(80, 20);
            this.lblPerimeterSquare.TabIndex = 4;
            this.lblPerimeterSquare.Text = "Периметр";
            // 
            // lblSideSquare
            // 
            this.lblSideSquare.AutoSize = true;
            this.lblSideSquare.Location = new System.Drawing.Point(192, 46);
            this.lblSideSquare.Name = "lblSideSquare";
            this.lblSideSquare.Size = new System.Drawing.Size(68, 20);
            this.lblSideSquare.TabIndex = 3;
            this.lblSideSquare.Text = "Сторона";
            // 
            // tbAreaSquare
            // 
            this.tbAreaSquare.Location = new System.Drawing.Point(40, 174);
            this.tbAreaSquare.Name = "tbAreaSquare";
            this.tbAreaSquare.ReadOnly = true;
            this.tbAreaSquare.Size = new System.Drawing.Size(125, 27);
            this.tbAreaSquare.TabIndex = 2;
            // 
            // tbPerimeterSquare
            // 
            this.tbPerimeterSquare.Location = new System.Drawing.Point(40, 106);
            this.tbPerimeterSquare.Name = "tbPerimeterSquare";
            this.tbPerimeterSquare.ReadOnly = true;
            this.tbPerimeterSquare.Size = new System.Drawing.Size(125, 27);
            this.tbPerimeterSquare.TabIndex = 1;
            // 
            // tbSideSquare
            // 
            this.tbSideSquare.Location = new System.Drawing.Point(40, 49);
            this.tbSideSquare.Name = "tbSideSquare";
            this.tbSideSquare.Size = new System.Drawing.Size(125, 27);
            this.tbSideSquare.TabIndex = 0;
            // 
            // tpRhomb
            // 
            this.tpRhomb.Controls.Add(this.btnClearRhomb);
            this.tpRhomb.Controls.Add(this.btnComputeRhomb);
            this.tpRhomb.Controls.Add(this.lblAreaRhomb);
            this.tpRhomb.Controls.Add(this.lblPerimeterRhomb);
            this.tpRhomb.Controls.Add(this.lblDiagonal2Rhomb);
            this.tpRhomb.Controls.Add(this.lblDiagonal1Rhomb);
            this.tpRhomb.Controls.Add(this.tbAreaRhomb);
            this.tpRhomb.Controls.Add(this.tbPerimeterRhomb);
            this.tpRhomb.Controls.Add(this.tbDiagonal2Rhomb);
            this.tpRhomb.Controls.Add(this.tbDiagonal1Rhomb);
            this.tpRhomb.Location = new System.Drawing.Point(4, 29);
            this.tpRhomb.Name = "tpRhomb";
            this.tpRhomb.Size = new System.Drawing.Size(449, 380);
            this.tpRhomb.TabIndex = 4;
            this.tpRhomb.Text = "Ромб";
            // 
            // tbDiagonal1Rhomb
            // 
            this.tbDiagonal1Rhomb.Location = new System.Drawing.Point(51, 67);
            this.tbDiagonal1Rhomb.Name = "tbDiagonal1Rhomb";
            this.tbDiagonal1Rhomb.Size = new System.Drawing.Size(125, 27);
            this.tbDiagonal1Rhomb.TabIndex = 0;
            // 
            // tbDiagonal2Rhomb
            // 
            this.tbDiagonal2Rhomb.Location = new System.Drawing.Point(51, 128);
            this.tbDiagonal2Rhomb.Name = "tbDiagonal2Rhomb";
            this.tbDiagonal2Rhomb.Size = new System.Drawing.Size(125, 27);
            this.tbDiagonal2Rhomb.TabIndex = 1;
            // 
            // tbPerimeterRhomb
            // 
            this.tbPerimeterRhomb.Location = new System.Drawing.Point(51, 204);
            this.tbPerimeterRhomb.Name = "tbPerimeterRhomb";
            this.tbPerimeterRhomb.ReadOnly = true;
            this.tbPerimeterRhomb.Size = new System.Drawing.Size(125, 27);
            this.tbPerimeterRhomb.TabIndex = 2;
            // 
            // tbAreaRhomb
            // 
            this.tbAreaRhomb.Location = new System.Drawing.Point(51, 263);
            this.tbAreaRhomb.Name = "tbAreaRhomb";
            this.tbAreaRhomb.ReadOnly = true;
            this.tbAreaRhomb.Size = new System.Drawing.Size(125, 27);
            this.tbAreaRhomb.TabIndex = 3;
            // 
            // lblDiagonal1Rhomb
            // 
            this.lblDiagonal1Rhomb.AutoSize = true;
            this.lblDiagonal1Rhomb.Location = new System.Drawing.Point(198, 64);
            this.lblDiagonal1Rhomb.Name = "lblDiagonal1Rhomb";
            this.lblDiagonal1Rhomb.Size = new System.Drawing.Size(129, 20);
            this.lblDiagonal1Rhomb.TabIndex = 4;
            this.lblDiagonal1Rhomb.Text = "Перша діагональ";
            // 
            // lblDiagonal2Rhomb
            // 
            this.lblDiagonal2Rhomb.AutoSize = true;
            this.lblDiagonal2Rhomb.Location = new System.Drawing.Point(198, 125);
            this.lblDiagonal2Rhomb.Name = "lblDiagonal2Rhomb";
            this.lblDiagonal2Rhomb.Size = new System.Drawing.Size(121, 20);
            this.lblDiagonal2Rhomb.TabIndex = 5;
            this.lblDiagonal2Rhomb.Text = "Друга діагональ";
            // 
            // lblPerimeterRhomb
            // 
            this.lblPerimeterRhomb.AutoSize = true;
            this.lblPerimeterRhomb.Location = new System.Drawing.Point(198, 201);
            this.lblPerimeterRhomb.Name = "lblPerimeterRhomb";
            this.lblPerimeterRhomb.Size = new System.Drawing.Size(80, 20);
            this.lblPerimeterRhomb.TabIndex = 6;
            this.lblPerimeterRhomb.Text = "Периметр";
            // 
            // lblAreaRhomb
            // 
            this.lblAreaRhomb.AutoSize = true;
            this.lblAreaRhomb.Location = new System.Drawing.Point(198, 260);
            this.lblAreaRhomb.Name = "lblAreaRhomb";
            this.lblAreaRhomb.Size = new System.Drawing.Size(57, 20);
            this.lblAreaRhomb.TabIndex = 7;
            this.lblAreaRhomb.Text = "Площа";
            // 
            // btnComputeRhomb
            // 
            this.btnComputeRhomb.Location = new System.Drawing.Point(4, 318);
            this.btnComputeRhomb.Name = "btnComputeRhomb";
            this.btnComputeRhomb.Size = new System.Drawing.Size(159, 59);
            this.btnComputeRhomb.TabIndex = 8;
            this.btnComputeRhomb.Text = "Розрахувати";
            this.btnComputeRhomb.UseVisualStyleBackColor = true;
            this.btnComputeRhomb.Click += new System.EventHandler(this.btnComputeRhomb_Click);
            // 
            // btnClearRhomb
            // 
            this.btnClearRhomb.Location = new System.Drawing.Point(290, 318);
            this.btnClearRhomb.Name = "btnClearRhomb";
            this.btnClearRhomb.Size = new System.Drawing.Size(154, 59);
            this.btnClearRhomb.TabIndex = 9;
            this.btnClearRhomb.Text = "Очистити";
            this.btnClearRhomb.UseVisualStyleBackColor = true;
            this.btnClearRhomb.Click += new System.EventHandler(this.btnClearRhomb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 425);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tpTriangle.ResumeLayout(false);
            this.tpTriangle.PerformLayout();
            this.tpCircle.ResumeLayout(false);
            this.tpCircle.PerformLayout();
            this.tpRectangle.ResumeLayout(false);
            this.tpRectangle.PerformLayout();
            this.tpSquare.ResumeLayout(false);
            this.tpSquare.PerformLayout();
            this.tpRhomb.ResumeLayout(false);
            this.tpRhomb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTriangle;
        private System.Windows.Forms.Button btnComputeTriangle;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblSide3;
        private System.Windows.Forms.Label lblSide2;
        private System.Windows.Forms.Label lblSide1;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.TextBox tbPerimeter;
        private System.Windows.Forms.TextBox tbSide3;
        private System.Windows.Forms.TextBox tbSide2;
        private System.Windows.Forms.TextBox tbSide1;
        private System.Windows.Forms.TabPage tpCircle;
        private System.Windows.Forms.Button btnClearTriangle;
        private System.Windows.Forms.Button btnClearCircle;
        private System.Windows.Forms.Button btnComputeCircle;
        private System.Windows.Forms.Label lblAreaCircle;
        private System.Windows.Forms.Label lblPerimeterCircle;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox tbAreaCircle;
        private System.Windows.Forms.TextBox tbPerimeterCircle;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.TabPage tpRectangle;
        private System.Windows.Forms.Button btnClearRectangle;
        private System.Windows.Forms.Button btnComputeRectangle;
        private System.Windows.Forms.Label lblAreaRactangle;
        private System.Windows.Forms.Label lblPerimeterRectangle;
        private System.Windows.Forms.Label lblSide2Rectangle;
        private System.Windows.Forms.Label lblSide1Rectangle;
        private System.Windows.Forms.Label lblInfoRectangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAreaRectangle;
        private System.Windows.Forms.TextBox tbPerimeterRectangle;
        private System.Windows.Forms.TextBox tbSide2Rectangle;
        private System.Windows.Forms.TextBox tbSide1Rectangle;
        private System.Windows.Forms.TabPage tpSquare;
        private System.Windows.Forms.TabPage tpRhomb;
        private System.Windows.Forms.Button btnClearSquare;
        private System.Windows.Forms.Button btnComputeSqure;
        private System.Windows.Forms.Label lblAreaSquare;
        private System.Windows.Forms.Label lblPerimeterSquare;
        private System.Windows.Forms.Label lblSideSquare;
        private System.Windows.Forms.TextBox tbAreaSquare;
        private System.Windows.Forms.TextBox tbPerimeterSquare;
        private System.Windows.Forms.TextBox tbSideSquare;
        private System.Windows.Forms.Button btnClearRhomb;
        private System.Windows.Forms.Button btnComputeRhomb;
        private System.Windows.Forms.Label lblAreaRhomb;
        private System.Windows.Forms.Label lblPerimeterRhomb;
        private System.Windows.Forms.Label lblDiagonal2Rhomb;
        private System.Windows.Forms.Label lblDiagonal1Rhomb;
        private System.Windows.Forms.TextBox tbAreaRhomb;
        private System.Windows.Forms.TextBox tbPerimeterRhomb;
        private System.Windows.Forms.TextBox tbDiagonal2Rhomb;
        private System.Windows.Forms.TextBox tbDiagonal1Rhomb;
    }
}

