<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kontak
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPesan = New System.Windows.Forms.TextBox()
        Me.dtpTTL = New System.Windows.Forms.DateTimePicker()
        Me.cmbPilihan = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPesan = New System.Windows.Forms.Label()
        Me.lblPilihan = New System.Windows.Forms.Label()
        Me.lblTTL = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 43)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KONTAK"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(267, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 223)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Review Pesan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(35, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 50)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Kirim"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "TTL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Pilihan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Pesan"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(89, 56)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(157, 31)
        Me.txtNama.TabIndex = 9
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(89, 100)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(157, 31)
        Me.txtEmail.TabIndex = 10
        '
        'txtPesan
        '
        Me.txtPesan.Location = New System.Drawing.Point(89, 235)
        Me.txtPesan.Multiline = True
        Me.txtPesan.Name = "txtPesan"
        Me.txtPesan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPesan.Size = New System.Drawing.Size(157, 31)
        Me.txtPesan.TabIndex = 12
        '
        'dtpTTL
        '
        Me.dtpTTL.Location = New System.Drawing.Point(89, 146)
        Me.dtpTTL.Name = "dtpTTL"
        Me.dtpTTL.Size = New System.Drawing.Size(157, 31)
        Me.dtpTTL.TabIndex = 13
        '
        'cmbPilihan
        '
        Me.cmbPilihan.FormattingEnabled = True
        Me.cmbPilihan.Items.AddRange(New Object() {"Kecerdasan Buatan", "Desain Web"})
        Me.cmbPilihan.Location = New System.Drawing.Point(89, 191)
        Me.cmbPilihan.Name = "cmbPilihan"
        Me.cmbPilihan.Size = New System.Drawing.Size(157, 33)
        Me.cmbPilihan.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPesan)
        Me.GroupBox2.Controls.Add(Me.lblPilihan)
        Me.GroupBox2.Controls.Add(Me.lblTTL)
        Me.GroupBox2.Controls.Add(Me.lblEmail)
        Me.GroupBox2.Controls.Add(Me.lblNama)
        Me.GroupBox2.Location = New System.Drawing.Point(252, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 233)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Review Pesan"
        '
        'lblPesan
        '
        Me.lblPesan.AutoSize = True
        Me.lblPesan.Location = New System.Drawing.Point(0, 192)
        Me.lblPesan.Name = "lblPesan"
        Me.lblPesan.Size = New System.Drawing.Size(0, 25)
        Me.lblPesan.TabIndex = 20
        '
        'lblPilihan
        '
        Me.lblPilihan.AutoSize = True
        Me.lblPilihan.Location = New System.Drawing.Point(0, 148)
        Me.lblPilihan.Name = "lblPilihan"
        Me.lblPilihan.Size = New System.Drawing.Size(0, 25)
        Me.lblPilihan.TabIndex = 19
        '
        'lblTTL
        '
        Me.lblTTL.AutoSize = True
        Me.lblTTL.Location = New System.Drawing.Point(0, 103)
        Me.lblTTL.Name = "lblTTL"
        Me.lblTTL.Size = New System.Drawing.Size(0, 25)
        Me.lblTTL.TabIndex = 18
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(0, 57)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(0, 25)
        Me.lblEmail.TabIndex = 17
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(0, 19)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(0, 25)
        Me.lblNama.TabIndex = 16
        '
        'Kontak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmbPilihan)
        Me.Controls.Add(Me.dtpTTL)
        Me.Controls.Add(Me.txtPesan)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Kontak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPesan As TextBox
    Friend WithEvents dtpTTL As DateTimePicker
    Friend WithEvents cmbPilihan As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblPesan As Label
    Friend WithEvents lblPilihan As Label
    Friend WithEvents lblTTL As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblNama As Label
End Class
