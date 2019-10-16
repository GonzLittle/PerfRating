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
        Me.bunifuddown1 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.bunifutb2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.bunifutb3 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Savebtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifutb4 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
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
        Me.bunifucl1.TabIndex = 5
        Me.bunifucl1.Text = "ID Number:"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(44, 212)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(94, 15)
        Me.BunifuCustomLabel1.TabIndex = 6
        Me.BunifuCustomLabel1.Text = "Select Semester:"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(44, 261)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(41, 15)
        Me.BunifuCustomLabel2.TabIndex = 7
        Me.BunifuCustomLabel2.Text = "Score:"
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
        Me.bunifutb1.Location = New System.Drawing.Point(47, 178)
        Me.bunifutb1.Margin = New System.Windows.Forms.Padding(4)
        Me.bunifutb1.Name = "bunifutb1"
        Me.bunifutb1.Size = New System.Drawing.Size(178, 30)
        Me.bunifutb1.TabIndex = 10
        Me.bunifutb1.Tag = "1"
        Me.bunifutb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bunifuddown1
        '
        Me.bunifuddown1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bunifuddown1.BackColor = System.Drawing.Color.Transparent
        Me.bunifuddown1.BorderRadius = 3
        Me.bunifuddown1.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuddown1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.bunifuddown1.ForeColor = System.Drawing.Color.White
        Me.bunifuddown1.Items = New String() {"Jan to June", "July to Dec"}
        Me.bunifuddown1.Location = New System.Drawing.Point(47, 231)
        Me.bunifuddown1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bunifuddown1.Name = "bunifuddown1"
        Me.bunifuddown1.NomalColor = System.Drawing.Color.Teal
        Me.bunifuddown1.onHoverColor = System.Drawing.Color.LightBlue
        Me.bunifuddown1.selectedIndex = -1
        Me.bunifuddown1.Size = New System.Drawing.Size(178, 26)
        Me.bunifuddown1.TabIndex = 5
        '
        'bunifutb2
        '
        Me.bunifutb2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bunifutb2.BorderColorFocused = System.Drawing.Color.Teal
        Me.bunifutb2.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifutb2.BorderColorMouseHover = System.Drawing.Color.PowderBlue
        Me.bunifutb2.BorderThickness = 3
        Me.bunifutb2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bunifutb2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.bunifutb2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifutb2.isPassword = False
        Me.bunifutb2.Location = New System.Drawing.Point(47, 280)
        Me.bunifutb2.Margin = New System.Windows.Forms.Padding(4)
        Me.bunifutb2.Name = "bunifutb2"
        Me.bunifutb2.Size = New System.Drawing.Size(178, 30)
        Me.bunifutb2.TabIndex = 2
        Me.bunifutb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bunifutb3
        '
        Me.bunifutb3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bunifutb3.BorderColorFocused = System.Drawing.Color.Teal
        Me.bunifutb3.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifutb3.BorderColorMouseHover = System.Drawing.Color.PowderBlue
        Me.bunifutb3.BorderThickness = 3
        Me.bunifutb3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bunifutb3.Enabled = False
        Me.bunifutb3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.bunifutb3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifutb3.isPassword = False
        Me.bunifutb3.Location = New System.Drawing.Point(47, 333)
        Me.bunifutb3.Margin = New System.Windows.Forms.Padding(4)
        Me.bunifutb3.Name = "bunifutb3"
        Me.bunifutb3.Size = New System.Drawing.Size(178, 30)
        Me.bunifutb3.TabIndex = 3
        Me.bunifutb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(44, 314)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(44, 15)
        Me.BunifuCustomLabel3.TabIndex = 14
        Me.BunifuCustomLabel3.Text = "Rating:"
        '
        'Savebtn
        '
        Me.Savebtn.Activecolor = System.Drawing.Color.Teal
        Me.Savebtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Savebtn.BackColor = System.Drawing.Color.Teal
        Me.Savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Savebtn.BorderRadius = 0
        Me.Savebtn.ButtonText = "Save"
        Me.Savebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Savebtn.DisabledColor = System.Drawing.Color.Gray
        Me.Savebtn.Iconcolor = System.Drawing.Color.Transparent
        Me.Savebtn.Iconimage = CType(resources.GetObject("Savebtn.Iconimage"), System.Drawing.Image)
        Me.Savebtn.Iconimage_right = Nothing
        Me.Savebtn.Iconimage_right_Selected = Nothing
        Me.Savebtn.Iconimage_Selected = Nothing
        Me.Savebtn.IconMarginLeft = 0
        Me.Savebtn.IconMarginRight = 0
        Me.Savebtn.IconRightVisible = True
        Me.Savebtn.IconRightZoom = 0R
        Me.Savebtn.IconVisible = True
        Me.Savebtn.IconZoom = 90.0R
        Me.Savebtn.IsTab = False
        Me.Savebtn.Location = New System.Drawing.Point(145, 432)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Normalcolor = System.Drawing.Color.Teal
        Me.Savebtn.OnHovercolor = System.Drawing.Color.LightBlue
        Me.Savebtn.OnHoverTextColor = System.Drawing.Color.White
        Me.Savebtn.selected = False
        Me.Savebtn.Size = New System.Drawing.Size(80, 28)
        Me.Savebtn.TabIndex = 15
        Me.Savebtn.Text = "Save"
        Me.Savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Savebtn.Textcolor = System.Drawing.Color.White
        Me.Savebtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(44, 367)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(35, 15)
        Me.BunifuCustomLabel4.TabIndex = 18
        Me.BunifuCustomLabel4.Text = "Year:"
        '
        'bunifutb4
        '
        Me.bunifutb4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bunifutb4.BorderColorFocused = System.Drawing.Color.Teal
        Me.bunifutb4.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifutb4.BorderColorMouseHover = System.Drawing.Color.PowderBlue
        Me.bunifutb4.BorderThickness = 3
        Me.bunifutb4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bunifutb4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.bunifutb4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifutb4.isPassword = False
        Me.bunifutb4.Location = New System.Drawing.Point(47, 386)
        Me.bunifutb4.Margin = New System.Windows.Forms.Padding(4)
        Me.bunifutb4.Name = "bunifutb4"
        Me.bunifutb4.Size = New System.Drawing.Size(178, 30)
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
        'AddRating
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 489)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.bunifutb4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Savebtn)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.bunifutb3)
        Me.Controls.Add(Me.bunifutb2)
        Me.Controls.Add(Me.bunifuddown1)
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
    Friend WithEvents bunifuddown1 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents bunifutb1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifutb3 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents bunifutb2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Savebtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifutb4 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
