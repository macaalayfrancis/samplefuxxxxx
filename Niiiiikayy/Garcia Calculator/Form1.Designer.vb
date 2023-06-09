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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtOperator = New System.Windows.Forms.TextBox()
        Me.txtSecondOperand = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnMul = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnExp = New System.Windows.Forms.Button()
        Me.btnInt = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstOperand = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOperator
        '
        Me.txtOperator.Enabled = False
        Me.txtOperator.Location = New System.Drawing.Point(144, 216)
        Me.txtOperator.Name = "txtOperator"
        Me.txtOperator.Size = New System.Drawing.Size(87, 38)
        Me.txtOperator.TabIndex = 3
        Me.txtOperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSecondOperand
        '
        Me.txtSecondOperand.Location = New System.Drawing.Point(39, 162)
        Me.txtSecondOperand.Name = "txtSecondOperand"
        Me.txtSecondOperand.Size = New System.Drawing.Size(295, 38)
        Me.txtSecondOperand.TabIndex = 1
        Me.txtSecondOperand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtResult
        '
        Me.txtResult.Enabled = False
        Me.txtResult.Location = New System.Drawing.Point(39, 311)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(295, 38)
        Me.txtResult.TabIndex = 2
        Me.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnMul)
        Me.GroupBox1.Controls.Add(Me.btnMod)
        Me.GroupBox1.Controls.Add(Me.btnDiv)
        Me.GroupBox1.Controls.Add(Me.btnExp)
        Me.GroupBox1.Controls.Add(Me.btnInt)
        Me.GroupBox1.Controls.Add(Me.btnSub)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 415)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operators"
        '
        'btnMul
        '
        Me.btnMul.Location = New System.Drawing.Point(43, 156)
        Me.btnMul.Name = "btnMul"
        Me.btnMul.Size = New System.Drawing.Size(108, 60)
        Me.btnMul.TabIndex = 6
        Me.btnMul.Text = "*"
        Me.btnMul.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(43, 311)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(108, 60)
        Me.btnMod.TabIndex = 15
        Me.btnMod.Text = "MOD"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(179, 232)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(108, 60)
        Me.btnDiv.TabIndex = 14
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnExp
        '
        Me.btnExp.Location = New System.Drawing.Point(43, 232)
        Me.btnExp.Name = "btnExp"
        Me.btnExp.Size = New System.Drawing.Size(108, 60)
        Me.btnExp.TabIndex = 13
        Me.btnExp.Text = "^"
        Me.btnExp.UseVisualStyleBackColor = True
        '
        'btnInt
        '
        Me.btnInt.Location = New System.Drawing.Point(179, 156)
        Me.btnInt.Name = "btnInt"
        Me.btnInt.Size = New System.Drawing.Size(108, 60)
        Me.btnInt.TabIndex = 12
        Me.btnInt.Text = "\"
        Me.btnInt.UseVisualStyleBackColor = True
        '
        'btnSub
        '
        Me.btnSub.Location = New System.Drawing.Point(179, 74)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(108, 60)
        Me.btnSub.TabIndex = 11
        Me.btnSub.Text = "-"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(43, 74)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(108, 60)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(249, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 50)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "CALCULATOR"
        '
        'txtFirstOperand
        '
        Me.txtFirstOperand.Location = New System.Drawing.Point(39, 74)
        Me.txtFirstOperand.Name = "txtFirstOperand"
        Me.txtFirstOperand.Size = New System.Drawing.Size(295, 38)
        Me.txtFirstOperand.TabIndex = 0
        Me.txtFirstOperand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(499, 468)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(111, 51)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(620, 468)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 51)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtFirstOperand)
        Me.GroupBox2.Controls.Add(Me.txtSecondOperand)
        Me.GroupBox2.Controls.Add(Me.txtOperator)
        Me.GroupBox2.Controls.Add(Me.txtResult)
        Me.GroupBox2.Location = New System.Drawing.Point(379, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 371)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(146, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Result"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(115, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "2nd Operand"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(115, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "1st Operand"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(782, 531)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Garcia, Daisy"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOperator As TextBox
    Friend WithEvents txtSecondOperand As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnMul As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnExp As Button
    Friend WithEvents btnInt As Button
    Friend WithEvents btnSub As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstOperand As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
