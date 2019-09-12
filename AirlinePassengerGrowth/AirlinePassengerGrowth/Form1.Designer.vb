<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnGrowth = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstGrowth = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnYear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.mtxtYear = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGrowth
        '
        Me.btnGrowth.Location = New System.Drawing.Point(19, 3)
        Me.btnGrowth.Name = "btnGrowth"
        Me.btnGrowth.Size = New System.Drawing.Size(115, 23)
        Me.btnGrowth.TabIndex = 0
        Me.btnGrowth.Text = "Calculate Growth"
        Me.btnGrowth.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Arilines Passenger Growth"
        '
        'lstGrowth
        '
        Me.lstGrowth.FormattingEnabled = True
        Me.lstGrowth.Location = New System.Drawing.Point(160, 37)
        Me.lstGrowth.Name = "lstGrowth"
        Me.lstGrowth.Size = New System.Drawing.Size(120, 134)
        Me.lstGrowth.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Get amount for year:"
        '
        'btnYear
        '
        Me.btnYear.Location = New System.Drawing.Point(14, 86)
        Me.btnYear.Name = "btnYear"
        Me.btnYear.Size = New System.Drawing.Size(128, 23)
        Me.btnYear.TabIndex = 5
        Me.btnYear.Text = "Get Year Amount"
        Me.btnYear.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.mtxtYear)
        Me.Panel1.Controls.Add(Me.lblYear)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnYear)
        Me.Panel1.Controls.Add(Me.btnGrowth)
        Me.Panel1.Location = New System.Drawing.Point(3, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(152, 134)
        Me.Panel1.TabIndex = 6
        '
        'lblYear
        '
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblYear.Location = New System.Drawing.Point(0, 111)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(152, 23)
        Me.lblYear.TabIndex = 6
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'mtxtYear
        '
        Me.mtxtYear.Location = New System.Drawing.Point(127, 61)
        Me.mtxtYear.Mask = "00"
        Me.mtxtYear.Name = "mtxtYear"
        Me.mtxtYear.Size = New System.Drawing.Size(18, 20)
        Me.mtxtYear.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 176)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lstGrowth)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = " Airline Passenger Growth"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGrowth As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lstGrowth As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnYear As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblYear As Label
    Friend WithEvents mtxtYear As MaskedTextBox
End Class
