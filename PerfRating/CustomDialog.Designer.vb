<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomDialog))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Messagebtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Teal
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Ok"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(125, 91)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Teal
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.LightBlue
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(67, 29)
        Me.BunifuFlatButton1.TabIndex = 1
        Me.BunifuFlatButton1.Text = "Ok"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel1.Location = New System.Drawing.Point(-12, 147)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(353, 100)
        Me.Panel1.TabIndex = 4
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 6.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(219, 2)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(115, 12)
        Me.BunifuCustomLabel4.TabIndex = 8
        Me.BunifuCustomLabel4.Text = "© OPA-HRMU Copyright 2020 "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Messagebtn)
        Me.Panel2.Location = New System.Drawing.Point(1, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(321, 150)
        Me.Panel2.TabIndex = 4
        '
        'Messagebtn
        '
        Me.Messagebtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Messagebtn.BackColor = System.Drawing.Color.Transparent
        Me.Messagebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Messagebtn.BorderRadius = 0
        Me.Messagebtn.ButtonText = "Performance Rating Saved!"
        Me.Messagebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Messagebtn.DisabledColor = System.Drawing.Color.Transparent
        Me.Messagebtn.Enabled = False
        Me.Messagebtn.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Messagebtn.ForeColor = System.Drawing.Color.DimGray
        Me.Messagebtn.Iconcolor = System.Drawing.Color.Transparent
        Me.Messagebtn.Iconimage = Nothing
        Me.Messagebtn.Iconimage_right = Nothing
        Me.Messagebtn.Iconimage_right_Selected = Nothing
        Me.Messagebtn.Iconimage_Selected = Nothing
        Me.Messagebtn.IconMarginLeft = 0
        Me.Messagebtn.IconMarginRight = 0
        Me.Messagebtn.IconRightVisible = True
        Me.Messagebtn.IconRightZoom = 0R
        Me.Messagebtn.IconVisible = True
        Me.Messagebtn.IconZoom = 90.0R
        Me.Messagebtn.IsTab = False
        Me.Messagebtn.Location = New System.Drawing.Point(-1, 26)
        Me.Messagebtn.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Messagebtn.Name = "Messagebtn"
        Me.Messagebtn.Normalcolor = System.Drawing.Color.Transparent
        Me.Messagebtn.OnHovercolor = System.Drawing.Color.Transparent
        Me.Messagebtn.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.Messagebtn.selected = False
        Me.Messagebtn.Size = New System.Drawing.Size(321, 51)
        Me.Messagebtn.TabIndex = 3
        Me.Messagebtn.Text = "Performance Rating Saved!"
        Me.Messagebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Messagebtn.Textcolor = System.Drawing.Color.DimGray
        Me.Messagebtn.TextFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        '
        'CustomDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(324, 165)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CustomDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Messagebtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
