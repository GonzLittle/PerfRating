<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bunifutb1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.bunifucd1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.bunifucl1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pers_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstRating = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstRating_adj = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SecondRating = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecondRating_adj = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Rating = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adj = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bunifucd1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(4, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(273, 32)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Performance Rating"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(15, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'bunifutb1
        '
        Me.bunifutb1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bunifutb1.BorderColorFocused = System.Drawing.Color.Teal
        Me.bunifutb1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifutb1.BorderColorMouseHover = System.Drawing.Color.PowderBlue
        Me.bunifutb1.BorderThickness = 3
        Me.bunifutb1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bunifutb1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.bunifutb1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifutb1.isPassword = False
        Me.bunifutb1.Location = New System.Drawing.Point(15, 232)
        Me.bunifutb1.Margin = New System.Windows.Forms.Padding(4)
        Me.bunifutb1.Name = "bunifutb1"
        Me.bunifutb1.Size = New System.Drawing.Size(120, 30)
        Me.bunifutb1.TabIndex = 1
        Me.bunifutb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bunifucd1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue
        Me.bunifucd1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.bunifucd1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bunifucd1.BackgroundColor = System.Drawing.Color.White
        Me.bunifucd1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bunifucd1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bunifucd1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.bunifucd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.bunifucd1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pers_id, Me.FirstRating, Me.FirstRating_adj, Me.SecondRating, Me.SecondRating_adj, Me.Rating, Me.Adj, Me.Year})
        Me.bunifucd1.DoubleBuffered = True
        Me.bunifucd1.EnableHeadersVisualStyles = False
        Me.bunifucd1.HeaderBgColor = System.Drawing.Color.Teal
        Me.bunifucd1.HeaderForeColor = System.Drawing.Color.White
        Me.bunifucd1.Location = New System.Drawing.Point(142, 95)
        Me.bunifucd1.Name = "bunifucd1"
        Me.bunifucd1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.bunifucd1.RowHeadersWidth = 10
        Me.bunifucd1.Size = New System.Drawing.Size(850, 323)
        Me.bunifucd1.TabIndex = 3
        '
        'bunifucl1
        '
        Me.bunifucl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bunifucl1.AutoSize = True
        Me.bunifucl1.BackColor = System.Drawing.Color.Transparent
        Me.bunifucl1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bunifucl1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.bunifucl1.Location = New System.Drawing.Point(11, 73)
        Me.bunifucl1.Name = "bunifucl1"
        Me.bunifucl1.Size = New System.Drawing.Size(140, 19)
        Me.bunifucl1.TabIndex = 4
        Me.bunifucl1.Text = "Employee Name"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Segoe UI Light", 8.0!, System.Drawing.FontStyle.Italic)
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Gray
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(12, 266)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(78, 13)
        Me.BunifuCustomLabel3.TabIndex = 6
        Me.BunifuCustomLabel3.Text = "* ID # or Name"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 6.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(896, 438)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(115, 12)
        Me.BunifuCustomLabel4.TabIndex = 7
        Me.BunifuCustomLabel4.Text = "© OPA-HRMU Copyright 2020 "
        '
        'pers_id
        '
        Me.pers_id.DataPropertyName = "pers_id"
        Me.pers_id.HeaderText = "Pers ID"
        Me.pers_id.MinimumWidth = 3
        Me.pers_id.Name = "pers_id"
        Me.pers_id.Width = 70
        '
        'FirstRating
        '
        Me.FirstRating.DataPropertyName = "FirstRating"
        Me.FirstRating.HeaderText = "Jan to June Score"
        Me.FirstRating.Name = "FirstRating"
        Me.FirstRating.Width = 125
        '
        'FirstRating_adj
        '
        Me.FirstRating_adj.DataPropertyName = "FirstRating_adj"
        Me.FirstRating_adj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FirstRating_adj.HeaderText = "Jan to June Rating"
        Me.FirstRating_adj.Items.AddRange(New Object() {"Outstanding", "Very Satisfactory", "Satisfactory", "Unsatisfactory", "Poor"})
        Me.FirstRating_adj.Name = "FirstRating_adj"
        Me.FirstRating_adj.Width = 109
        '
        'SecondRating
        '
        Me.SecondRating.DataPropertyName = "SecondRating"
        Me.SecondRating.HeaderText = "July to Dec Score"
        Me.SecondRating.Name = "SecondRating"
        Me.SecondRating.Width = 123
        '
        'SecondRating_adj
        '
        Me.SecondRating_adj.DataPropertyName = "SecondRating_adj"
        Me.SecondRating_adj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SecondRating_adj.HeaderText = "July to Dec Rating"
        Me.SecondRating_adj.Items.AddRange(New Object() {"Outstanding", "Very Satisfactory", "Satisfactory", "Unsatisfactory", "Poor"})
        Me.SecondRating_adj.Name = "SecondRating_adj"
        Me.SecondRating_adj.Width = 107
        '
        'Rating
        '
        Me.Rating.DataPropertyName = "Rating"
        Me.Rating.HeaderText = "Overall Score"
        Me.Rating.Name = "Rating"
        Me.Rating.Width = 103
        '
        'Adj
        '
        Me.Adj.DataPropertyName = "Adj"
        Me.Adj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Adj.HeaderText = "Overall Rating"
        Me.Adj.Items.AddRange(New Object() {"Outstanding", "Very Satisfactory", "Satisfactory", "Unsatisfactory", "Poor"})
        Me.Adj.Name = "Adj"
        Me.Adj.Width = 87
        '
        'Year
        '
        Me.Year.DataPropertyName = "Year"
        Me.Year.HeaderText = "Year"
        Me.Year.Name = "Year"
        Me.Year.Width = 58
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 450)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.bunifucl1)
        Me.Controls.Add(Me.bunifucd1)
        Me.Controls.Add(Me.bunifutb1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bunifucd1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifutb1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bunifucl1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifucd1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pers_id As DataGridViewTextBoxColumn
    Friend WithEvents FirstRating As DataGridViewTextBoxColumn
    Friend WithEvents FirstRating_adj As DataGridViewComboBoxColumn
    Friend WithEvents SecondRating As DataGridViewTextBoxColumn
    Friend WithEvents SecondRating_adj As DataGridViewComboBoxColumn
    Friend WithEvents Rating As DataGridViewTextBoxColumn
    Friend WithEvents Adj As DataGridViewComboBoxColumn
    Friend WithEvents Year As DataGridViewTextBoxColumn
End Class
