<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnumstudents = New System.Windows.Forms.TextBox()
        Me.txtdisplay = New System.Windows.Forms.TextBox()
        Me.btn_calculate = New System.Windows.Forms.Button()
        Me.btn_display = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTopStud = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number of students"
        '
        'txtnumstudents
        '
        Me.txtnumstudents.Location = New System.Drawing.Point(108, 12)
        Me.txtnumstudents.Name = "txtnumstudents"
        Me.txtnumstudents.Size = New System.Drawing.Size(313, 20)
        Me.txtnumstudents.TabIndex = 2
        '
        'txtdisplay
        '
        Me.txtdisplay.Location = New System.Drawing.Point(6, 88)
        Me.txtdisplay.Multiline = True
        Me.txtdisplay.Name = "txtdisplay"
        Me.txtdisplay.Size = New System.Drawing.Size(415, 146)
        Me.txtdisplay.TabIndex = 3
        '
        'btn_calculate
        '
        Me.btn_calculate.Location = New System.Drawing.Point(31, 60)
        Me.btn_calculate.Name = "btn_calculate"
        Me.btn_calculate.Size = New System.Drawing.Size(61, 22)
        Me.btn_calculate.TabIndex = 4
        Me.btn_calculate.Text = "Calculate"
        Me.btn_calculate.UseVisualStyleBackColor = True
        '
        'btn_display
        '
        Me.btn_display.Location = New System.Drawing.Point(166, 59)
        Me.btn_display.Name = "btn_display"
        Me.btn_display.Size = New System.Drawing.Size(75, 22)
        Me.btn_display.TabIndex = 5
        Me.btn_display.Text = "Display"
        Me.btn_display.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(346, 59)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(22, 250)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(399, 23)
        Me.btnLoad.TabIndex = 7
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 333)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Top student"
        '
        'txtTopStud
        '
        Me.txtTopStud.Location = New System.Drawing.Point(82, 330)
        Me.txtTopStud.Name = "txtTopStud"
        Me.txtTopStud.Size = New System.Drawing.Size(339, 20)
        Me.txtTopStud.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtTopStud)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btn_display)
        Me.Controls.Add(Me.btn_calculate)
        Me.Controls.Add(Me.txtdisplay)
        Me.Controls.Add(Me.txtnumstudents)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "frmBursary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtnumstudents As TextBox
    Friend WithEvents txtdisplay As TextBox
    Friend WithEvents btn_calculate As Button
    Friend WithEvents btn_display As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTopStud As TextBox
End Class
