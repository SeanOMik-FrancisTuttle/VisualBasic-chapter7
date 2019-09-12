<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIMAXTheatre
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
        Me.lblTickets = New System.Windows.Forms.Label()
        Me.txtTickets = New System.Windows.Forms.TextBox()
        Me.btnTicketCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(33, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IMAX Theatre Tickets"
        '
        'cboType
        '
        Me.cboType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Matinee ($16)", "Evening ($27)"})
        Me.cboType.Location = New System.Drawing.Point(105, 70)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(157, 32)
        Me.cboType.TabIndex = 1
        Me.cboType.Text = "Select Type:"
        '
        'lblTickets
        '
        Me.lblTickets.AutoSize = True
        Me.lblTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTickets.Location = New System.Drawing.Point(94, 124)
        Me.lblTickets.Name = "lblTickets"
        Me.lblTickets.Size = New System.Drawing.Size(192, 25)
        Me.lblTickets.TabIndex = 2
        Me.lblTickets.Text = "Number of Tickets:"
        Me.lblTickets.Visible = False
        '
        'txtTickets
        '
        Me.txtTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTickets.Location = New System.Drawing.Point(169, 152)
        Me.txtTickets.Name = "txtTickets"
        Me.txtTickets.Size = New System.Drawing.Size(43, 31)
        Me.txtTickets.TabIndex = 3
        Me.txtTickets.Visible = False
        '
        'btnTicketCost
        '
        Me.btnTicketCost.BackColor = System.Drawing.Color.SteelBlue
        Me.btnTicketCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTicketCost.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTicketCost.Location = New System.Drawing.Point(123, 205)
        Me.btnTicketCost.Name = "btnTicketCost"
        Me.btnTicketCost.Size = New System.Drawing.Size(135, 50)
        Me.btnTicketCost.TabIndex = 6
        Me.btnTicketCost.Text = "Ticket Cost"
        Me.btnTicketCost.UseVisualStyleBackColor = False
        Me.btnTicketCost.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.Control
        Me.btnClear.Location = New System.Drawing.Point(123, 261)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(135, 50)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'lblCost
        '
        Me.lblCost.BackColor = System.Drawing.Color.SteelBlue
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCost.Location = New System.Drawing.Point(80, 330)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(220, 25)
        Me.lblCost.TabIndex = 8
        Me.lblCost.Text = "$XXX.X for the tickets"
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblCost.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblCost)
        Me.Panel1.Controls.Add(Me.cboType)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.lblTickets)
        Me.Panel1.Controls.Add(Me.btnTicketCost)
        Me.Panel1.Controls.Add(Me.txtTickets)
        Me.Panel1.Location = New System.Drawing.Point(372, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 380)
        Me.Panel1.TabIndex = 9
        '
        'frmIMAXTheatre
        '
        Me.AcceptButton = Me.btnTicketCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IMAXTheatre.My.Resources.Resources.imax
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(753, 378)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmIMAXTheatre"
        Me.Text = "IMAX Theatre"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents lblTickets As Label
    Friend WithEvents txtTickets As TextBox
    Friend WithEvents btnTicketCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblCost As Label
    Friend WithEvents Panel1 As Panel
End Class
