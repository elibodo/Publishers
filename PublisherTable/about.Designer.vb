<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lblheader = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblProgrammer = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(215, 205)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(83, 35)
        Me.btnexit.TabIndex = 0
        Me.btnexit.Text = "&Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'lblheader
        '
        Me.lblheader.AutoSize = True
        Me.lblheader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.Location = New System.Drawing.Point(12, 36)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(107, 17)
        Me.lblheader.TabIndex = 1
        Me.lblheader.Text = "Publisher Table"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(12, 93)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(80, 17)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Version 1.0"
        '
        'lblProgrammer
        '
        Me.lblProgrammer.AutoSize = True
        Me.lblProgrammer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgrammer.Location = New System.Drawing.Point(12, 150)
        Me.lblProgrammer.Name = "lblProgrammer"
        Me.lblProgrammer.Size = New System.Drawing.Size(92, 17)
        Me.lblProgrammer.TabIndex = 3
        Me.lblProgrammer.Text = "Eli Bodovinitz"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(185, 36)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(324, 68)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "Use the combobox to select a publisher and view" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "all of the information for them." &
    " You can see the ID," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name, Company Name, Address, City, State, ZIP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Code, Telep" &
    "hone Number, and their Fax Number. "
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 256)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblProgrammer)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblheader)
        Me.Controls.Add(Me.btnexit)
        Me.Name = "About"
        Me.Text = "about"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnexit As Button
    Friend WithEvents lblheader As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblProgrammer As Label
    Friend WithEvents lblDescription As Label
End Class
