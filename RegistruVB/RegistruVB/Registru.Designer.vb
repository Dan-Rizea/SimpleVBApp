<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registru
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdaugaCheltuieli = New System.Windows.Forms.Button()
        Me.btnAdaugaSold = New System.Windows.Forms.Button()
        Me.txtSold = New System.Windows.Forms.TextBox()
        Me.txtCheltuieli = New System.Windows.Forms.TextBox()
        Me.btnTerminaZiua = New System.Windows.Forms.Button()
        Me.btnRaport = New System.Windows.Forms.Button()
        Me.txtRaportIncasari = New System.Windows.Forms.TextBox()
        Me.txtRaportCheltuieli = New System.Windows.Forms.TextBox()
        Me.lblIncasari = New System.Windows.Forms.Label()
        Me.lblRaportCheltuieli = New System.Windows.Forms.Label()
        Me.btnDebug = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(507, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sold"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(656, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cheltuieli"
        '
        'btnAdaugaCheltuieli
        '
        Me.btnAdaugaCheltuieli.Location = New System.Drawing.Point(644, 146)
        Me.btnAdaugaCheltuieli.Name = "btnAdaugaCheltuieli"
        Me.btnAdaugaCheltuieli.Size = New System.Drawing.Size(130, 32)
        Me.btnAdaugaCheltuieli.TabIndex = 2
        Me.btnAdaugaCheltuieli.Text = "Adauga Cheltuieli"
        Me.btnAdaugaCheltuieli.UseVisualStyleBackColor = True
        '
        'btnAdaugaSold
        '
        Me.btnAdaugaSold.Location = New System.Drawing.Point(510, 146)
        Me.btnAdaugaSold.Name = "btnAdaugaSold"
        Me.btnAdaugaSold.Size = New System.Drawing.Size(100, 32)
        Me.btnAdaugaSold.TabIndex = 3
        Me.btnAdaugaSold.Text = "Adauga Sold"
        Me.btnAdaugaSold.UseVisualStyleBackColor = True
        '
        'txtSold
        '
        Me.txtSold.Location = New System.Drawing.Point(510, 118)
        Me.txtSold.Name = "txtSold"
        Me.txtSold.Size = New System.Drawing.Size(100, 22)
        Me.txtSold.TabIndex = 4
        '
        'txtCheltuieli
        '
        Me.txtCheltuieli.Location = New System.Drawing.Point(659, 118)
        Me.txtCheltuieli.Name = "txtCheltuieli"
        Me.txtCheltuieli.Size = New System.Drawing.Size(100, 22)
        Me.txtCheltuieli.TabIndex = 5
        '
        'btnTerminaZiua
        '
        Me.btnTerminaZiua.Location = New System.Drawing.Point(510, 206)
        Me.btnTerminaZiua.Name = "btnTerminaZiua"
        Me.btnTerminaZiua.Size = New System.Drawing.Size(103, 44)
        Me.btnTerminaZiua.TabIndex = 6
        Me.btnTerminaZiua.Text = "Termina ziua"
        Me.btnTerminaZiua.UseVisualStyleBackColor = True
        '
        'btnRaport
        '
        Me.btnRaport.Location = New System.Drawing.Point(644, 205)
        Me.btnRaport.Name = "btnRaport"
        Me.btnRaport.Size = New System.Drawing.Size(130, 47)
        Me.btnRaport.TabIndex = 7
        Me.btnRaport.Text = "Genereaza raport"
        Me.btnRaport.UseVisualStyleBackColor = True
        '
        'txtRaportIncasari
        '
        Me.txtRaportIncasari.Location = New System.Drawing.Point(12, 118)
        Me.txtRaportIncasari.Multiline = True
        Me.txtRaportIncasari.Name = "txtRaportIncasari"
        Me.txtRaportIncasari.Size = New System.Drawing.Size(220, 320)
        Me.txtRaportIncasari.TabIndex = 9
        '
        'txtRaportCheltuieli
        '
        Me.txtRaportCheltuieli.Location = New System.Drawing.Point(250, 118)
        Me.txtRaportCheltuieli.Multiline = True
        Me.txtRaportCheltuieli.Name = "txtRaportCheltuieli"
        Me.txtRaportCheltuieli.Size = New System.Drawing.Size(226, 320)
        Me.txtRaportCheltuieli.TabIndex = 10
        '
        'lblIncasari
        '
        Me.lblIncasari.AutoSize = True
        Me.lblIncasari.Location = New System.Drawing.Point(91, 98)
        Me.lblIncasari.Name = "lblIncasari"
        Me.lblIncasari.Size = New System.Drawing.Size(57, 17)
        Me.lblIncasari.TabIndex = 11
        Me.lblIncasari.Text = "Incasari"
        '
        'lblRaportCheltuieli
        '
        Me.lblRaportCheltuieli.AutoSize = True
        Me.lblRaportCheltuieli.Location = New System.Drawing.Point(328, 98)
        Me.lblRaportCheltuieli.Name = "lblRaportCheltuieli"
        Me.lblRaportCheltuieli.Size = New System.Drawing.Size(65, 17)
        Me.lblRaportCheltuieli.TabIndex = 12
        Me.lblRaportCheltuieli.Text = "Cheltuieli"
        '
        'btnDebug
        '
        Me.btnDebug.Location = New System.Drawing.Point(612, 317)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(75, 50)
        Me.btnDebug.TabIndex = 13
        Me.btnDebug.Text = "Debug"
        Me.btnDebug.UseVisualStyleBackColor = True
        '
        'Registru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDebug)
        Me.Controls.Add(Me.lblRaportCheltuieli)
        Me.Controls.Add(Me.lblIncasari)
        Me.Controls.Add(Me.txtRaportCheltuieli)
        Me.Controls.Add(Me.txtRaportIncasari)
        Me.Controls.Add(Me.btnRaport)
        Me.Controls.Add(Me.btnTerminaZiua)
        Me.Controls.Add(Me.txtCheltuieli)
        Me.Controls.Add(Me.txtSold)
        Me.Controls.Add(Me.btnAdaugaSold)
        Me.Controls.Add(Me.btnAdaugaCheltuieli)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registru"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdaugaCheltuieli As Button
    Friend WithEvents btnAdaugaSold As Button
    Friend WithEvents txtSold As TextBox
    Friend WithEvents txtCheltuieli As TextBox
    Friend WithEvents btnTerminaZiua As Button
    Friend WithEvents btnRaport As Button
    Friend WithEvents txtRaportIncasari As TextBox
    Friend WithEvents txtRaportCheltuieli As TextBox
    Friend WithEvents lblIncasari As Label
    Friend WithEvents lblRaportCheltuieli As Label
    Friend WithEvents btnDebug As Button
End Class
