<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKaraokeMusicNight
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSongs = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(33, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Karaoka Music Night"
        '
        'cboType
        '
        Me.cboType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Hours in Private Karaoke Booth ($8.99)", "Number of Songs ($2.99)"})
        Me.cboType.Location = New System.Drawing.Point(30, 70)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(320, 28)
        Me.cboType.TabIndex = 1
        Me.cboType.Text = "Select Rental Type"
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHour.ForeColor = System.Drawing.Color.White
        Me.lblHour.Location = New System.Drawing.Point(39, 124)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(302, 25)
        Me.lblHour.TabIndex = 2
        Me.lblHour.Text = "Hourly Rental of Karoka Room"
        Me.lblHour.Visible = False
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(169, 156)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(43, 31)
        Me.txtAmount.TabIndex = 3
        Me.txtAmount.Visible = False
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.Color.White
        Me.btnCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCost.Location = New System.Drawing.Point(25, 247)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(135, 50)
        Me.btnCost.TabIndex = 6
        Me.btnCost.Text = "Total Cost"
        Me.btnCost.UseVisualStyleBackColor = False
        Me.btnCost.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClear.Location = New System.Drawing.Point(221, 247)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(135, 50)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'lblCost
        '
        Me.lblCost.BackColor = System.Drawing.Color.Transparent
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCost.Location = New System.Drawing.Point(18, 331)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(344, 25)
        Me.lblCost.TabIndex = 8
        Me.lblCost.Text = "Total Cost of Karoke Night: $XX.XX"
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblCost.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.IMAXTheatre.My.Resources.Resources.black_leather
        Me.Panel1.Controls.Add(Me.lblSongs)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblCost)
        Me.Panel1.Controls.Add(Me.cboType)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.lblHour)
        Me.Panel1.Controls.Add(Me.btnCost)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Location = New System.Drawing.Point(372, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 380)
        Me.Panel1.TabIndex = 9
        '
        'lblSongs
        '
        Me.lblSongs.AutoSize = True
        Me.lblSongs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSongs.ForeColor = System.Drawing.Color.White
        Me.lblSongs.Location = New System.Drawing.Point(98, 124)
        Me.lblSongs.Name = "lblSongs"
        Me.lblSongs.Size = New System.Drawing.Size(184, 25)
        Me.lblSongs.TabIndex = 9
        Me.lblSongs.Text = "Number of Songs:"
        Me.lblSongs.Visible = False
        '
        'frmKaraokeMusicNight
        '
        Me.AcceptButton = Me.btnCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IMAXTheatre.My.Resources.Resources.karaoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(753, 378)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmKaraokeMusicNight"
        Me.Text = "Karaoke Music Night"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents lblHour As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblCost As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSongs As Label
End Class
