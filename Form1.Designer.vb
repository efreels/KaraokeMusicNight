<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKaraokeNight
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pnlBlack = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.lblKaraokeType = New System.Windows.Forms.Label()
        Me.cboKaraokeChoice = New System.Windows.Forms.ComboBox()
        Me.lblKaraokeTitle = New System.Windows.Forms.Label()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.pnlBlack.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(267, 316)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 33)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'pnlBlack
        '
        Me.pnlBlack.BackColor = System.Drawing.Color.Black
        Me.pnlBlack.Controls.Add(Me.lblTotal)
        Me.pnlBlack.Controls.Add(Me.txtUserInput)
        Me.pnlBlack.Controls.Add(Me.lblKaraokeType)
        Me.pnlBlack.Controls.Add(Me.cboKaraokeChoice)
        Me.pnlBlack.Controls.Add(Me.lblKaraokeTitle)
        Me.pnlBlack.Controls.Add(Me.btnTotal)
        Me.pnlBlack.Controls.Add(Me.btnClear)
        Me.pnlBlack.Location = New System.Drawing.Point(316, -1)
        Me.pnlBlack.Name = "pnlBlack"
        Me.pnlBlack.Size = New System.Drawing.Size(483, 451)
        Me.pnlBlack.TabIndex = 1
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(79, 389)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(259, 22)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "Total Cost of Karaoke Night - "
        '
        'txtUserInput
        '
        Me.txtUserInput.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserInput.Location = New System.Drawing.Point(216, 249)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(50, 32)
        Me.txtUserInput.TabIndex = 5
        Me.txtUserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblKaraokeType
        '
        Me.lblKaraokeType.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKaraokeType.ForeColor = System.Drawing.Color.White
        Me.lblKaraokeType.Location = New System.Drawing.Point(91, 198)
        Me.lblKaraokeType.Name = "lblKaraokeType"
        Me.lblKaraokeType.Size = New System.Drawing.Size(300, 22)
        Me.lblKaraokeType.TabIndex = 4
        Me.lblKaraokeType.Text = "Karaoke type goes here"
        Me.lblKaraokeType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboKaraokeChoice
        '
        Me.cboKaraokeChoice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKaraokeChoice.FormattingEnabled = True
        Me.cboKaraokeChoice.Items.AddRange(New Object() {"Number of Karaoke Songs ($2.99 per song)", "Hours in Private Karaoke Room ($8.99 per hour)"})
        Me.cboKaraokeChoice.Location = New System.Drawing.Point(65, 116)
        Me.cboKaraokeChoice.Name = "cboKaraokeChoice"
        Me.cboKaraokeChoice.Size = New System.Drawing.Size(352, 27)
        Me.cboKaraokeChoice.TabIndex = 3
        Me.cboKaraokeChoice.Text = "Customize Your Karaoke Night"
        '
        'lblKaraokeTitle
        '
        Me.lblKaraokeTitle.AutoSize = True
        Me.lblKaraokeTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKaraokeTitle.ForeColor = System.Drawing.Color.White
        Me.lblKaraokeTitle.Location = New System.Drawing.Point(69, 49)
        Me.lblKaraokeTitle.Name = "lblKaraokeTitle"
        Me.lblKaraokeTitle.Size = New System.Drawing.Size(339, 37)
        Me.lblKaraokeTitle.TabIndex = 2
        Me.lblKaraokeTitle.Text = "Karaoke Music Night"
        '
        'btnTotal
        '
        Me.btnTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(65, 316)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(150, 33)
        Me.btnTotal.TabIndex = 1
        Me.btnTotal.Text = "Total Cost"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'frmKaraokeNight
        '
        Me.AcceptButton = Me.btnTotal
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.KaraokeMusicNight.My.Resources.Resources.karaoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlBlack)
        Me.Name = "frmKaraokeNight"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karaoke Music Night"
        Me.pnlBlack.ResumeLayout(False)
        Me.pnlBlack.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents pnlBlack As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents lblKaraokeType As Label
    Friend WithEvents cboKaraokeChoice As ComboBox
    Friend WithEvents lblKaraokeTitle As Label
    Friend WithEvents btnTotal As Button
End Class
