<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.txtRes = New System.Windows.Forms.TextBox()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKte = New System.Windows.Forms.TextBox()
        Me.btnMultiplicarKte = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X = "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Y = "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Res = "
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(46, 17)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(222, 20)
        Me.txtX.TabIndex = 3
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(46, 59)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(222, 20)
        Me.txtY.TabIndex = 4
        '
        'txtRes
        '
        Me.txtRes.Location = New System.Drawing.Point(46, 135)
        Me.txtRes.Name = "txtRes"
        Me.txtRes.Size = New System.Drawing.Size(222, 20)
        Me.txtRes.TabIndex = 5
        '
        'btnSumar
        '
        Me.btnSumar.Location = New System.Drawing.Point(203, 182)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(65, 23)
        Me.btnSumar.TabIndex = 6
        Me.btnSumar.Text = "+"
        Me.btnSumar.UseVisualStyleBackColor = True
        '
        'btnAsignar
        '
        Me.btnAsignar.Location = New System.Drawing.Point(193, 271)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(75, 23)
        Me.btnAsignar.TabIndex = 7
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Kte = "
        '
        'txtKte
        '
        Me.txtKte.Location = New System.Drawing.Point(46, 236)
        Me.txtKte.Name = "txtKte"
        Me.txtKte.Size = New System.Drawing.Size(222, 20)
        Me.txtKte.TabIndex = 9
        '
        'btnMultiplicarKte
        '
        Me.btnMultiplicarKte.Location = New System.Drawing.Point(46, 270)
        Me.btnMultiplicarKte.Name = "btnMultiplicarKte"
        Me.btnMultiplicarKte.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiplicarKte.TabIndex = 10
        Me.btnMultiplicarKte.Text = "* Kte"
        Me.btnMultiplicarKte.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 306)
        Me.Controls.Add(Me.btnMultiplicarKte)
        Me.Controls.Add(Me.txtKte)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.btnSumar)
        Me.Controls.Add(Me.txtRes)
        Me.Controls.Add(Me.txtY)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtX As TextBox
    Friend WithEvents txtY As TextBox
    Friend WithEvents txtRes As TextBox
    Friend WithEvents btnSumar As Button
    Friend WithEvents btnAsignar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKte As TextBox
    Friend WithEvents btnMultiplicarKte As Button
End Class
