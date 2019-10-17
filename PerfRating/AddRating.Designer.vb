<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddRating
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddRating))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bunifucl1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifutb1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifutb4 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuddown1 = New System.Windows.Forms.ComboBox()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.bunifuddown2 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LblName = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'bunifucl1
        '
        Me.bunifucl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bunifucl1.AutoSize = True
        Me.bunifucl1.BackColor = System.Drawing.Color.Transparent
        Me.bunifucl1.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.bunifucl1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.bunifucl1.Location = New System.Drawing.Point(44, 159)
        Me.bunifucl1.Name = "bunifucl1"
        Me.bunifucl1.Size = New System.Drawing.Size(66, 15)
        Me.bunifucl1.TabIndex = 100
        Me.bunifucl1.Text = "ID Number:"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(44, 206)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(94, 15)
        Me.BunifuCustomLabel1.TabIndex = 101
        Me.BunifuCustomLabel1.Text = "Select Semester:"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(44, 255)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(41, 15)
        Me.BunifuCustomLabel2.TabIndex = 103
        Me.BunifuCustomLabel2.Text = "Score:"
        '
        'bunifutb1
        '
        Me.bunifutb1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bunifutb1.BorderColorFocused = System.Drawing.Color.Teal
        Me.bunifutb1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifutb1.BorderColorMouseHover = System.Drawing.Color.PowderBlue
        Me.bunifutb1.BorderThickness = 1
        Me.bunifutb1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bunifutb1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.bunifutb1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifutb1.isPassword = False
        Me.bunifutb1.Location = New System.Drawing.Point(47, 178)
        Me.bunifutb1.Margin = New System.Windows.Forms.Padding(4)
        Me.bunifutb1.Name = "bunifutb1"
        Me.bunifutb1.Size = New System.Drawing.Size(178, 24)
        Me.bunifutb1.TabIndex = 1
        Me.bunifutb1.Tag = ""
        Me.bunifutb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(44, 300)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(44, 15)
        Me.BunifuCustomLabel3.TabIndex = 104
        Me.BunifuCustomLabel3.Text = "Rating:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(96, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(44, 346)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(35, 15)
        Me.BunifuCustomLabel4.TabIndex = 105
        Me.BunifuCustomLabel4.Text = "Year:"
        '
        'bunifutb4
        '
        Me.bunifutb4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bunifutb4.BorderColorFocused = System.Drawing.Color.Teal
        Me.bunifutb4.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifutb4.BorderColorMouseHover = System.Drawing.Color.PowderBlue
        Me.bunifutb4.BorderThickness = 1
        Me.bunifutb4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bunifutb4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.bunifutb4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifutb4.isPassword = False
        Me.bunifutb4.Location = New System.Drawing.Point(47, 365)
        Me.bunifutb4.Margin = New System.Windows.Forms.Padding(4)
        Me.bunifutb4.Name = "bunifutb4"
        Me.bunifutb4.Size = New System.Drawing.Size(178, 25)
        Me.bunifutb4.TabIndex = 4
        Me.bunifutb4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(3, 7)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(161, 32)
        Me.BunifuCustomLabel5.TabIndex = 19
        Me.BunifuCustomLabel5.Text = "Add Rating"
        '
        'bunifuddown1
        '
        Me.bunifuddown1.BackColor = System.Drawing.SystemColors.Control
        Me.bunifuddown1.DropDownHeight = 100
        Me.bunifuddown1.DropDownWidth = 200
        Me.bunifuddown1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.bunifuddown1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.bunifuddown1.FormattingEnabled = True
        Me.bunifuddown1.IntegralHeight = False
        Me.bunifuddown1.Items.AddRange(New Object() {"Jan to June", "July to Dec"})
        Me.bunifuddown1.Location = New System.Drawing.Point(47, 227)
        Me.bunifuddown1.Name = "bunifuddown1"
        Me.bunifuddown1.Size = New System.Drawing.Size(178, 25)
        Me.bunifuddown1.TabIndex = 2
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.Teal
        Me.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.savebtn.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.savebtn.ForeColor = System.Drawing.Color.White
        Me.savebtn.Location = New System.Drawing.Point(150, 397)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(75, 33)
        Me.savebtn.TabIndex = 107
        Me.savebtn.Text = "Save"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'bunifuddown2
        '
        Me.bunifuddown2.AutoCompleteCustomSource.AddRange(New String() {"Outsanding", "Very Satisfactory", "Satisfactoy", "Unsactisfactory", "Poor"})
        Me.bunifuddown2.BackColor = System.Drawing.SystemColors.Control
        Me.bunifuddown2.DropDownHeight = 100
        Me.bunifuddown2.DropDownWidth = 200
        Me.bunifuddown2.Enabled = False
        Me.bunifuddown2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.bunifuddown2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.bunifuddown2.FormattingEnabled = True
        Me.bunifuddown2.IntegralHeight = False
        Me.bunifuddown2.Items.AddRange(New Object() {"Outstanding", "Very Satisfactory", "Satisfactory", "Unsatisfactory", "Poor"})
        Me.bunifuddown2.Location = New System.Drawing.Point(47, 318)
        Me.bunifuddown2.Name = "bunifuddown2"
        Me.bunifuddown2.Size = New System.Drawing.Size(178, 25)
        Me.bunifuddown2.TabIndex = 108
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox1.Location = New System.Drawing.Point(47, 273)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 24)
        Me.TextBox1.TabIndex = 3
        '
        'LblName
        '
        Me.LblName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblName.AutoSize = True
        Me.LblName.BackColor = System.Drawing.Color.Transparent
        Me.LblName.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LblName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblName.Location = New System.Drawing.Point(12, 48)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(39, 15)
        Me.LblName.TabIndex = 109
        Me.LblName.Text = "Name"
        '
        'AddRating
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 489)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.bunifuddown2)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.bunifuddown1)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.bunifutb4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.bunifutb1)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.bunifucl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddRating"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bunifucl1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifutb1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifutb4 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuddown1 As ComboBox
    Friend WithEvents savebtn As Button
    Friend WithEvents bunifuddown2 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LblName As Bunifu.Framework.UI.BunifuCustomLabel
End Class
