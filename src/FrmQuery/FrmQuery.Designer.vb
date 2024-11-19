<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuery
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
        Me.btnRun = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.query1 = New System.Windows.Forms.RadioButton()
        Me.query2 = New System.Windows.Forms.RadioButton()
        Me.query3 = New System.Windows.Forms.RadioButton()
        Me.query4 = New System.Windows.Forms.RadioButton()
        Me.query5 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(12, 223)
        Me.btnRun.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(99, 30)
        Me.btnRun.TabIndex = 1
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtOutput.Location = New System.Drawing.Point(0, 260)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(542, 80)
        Me.txtOutput.TabIndex = 2
        '
        'query1
        '
        Me.query1.AutoSize = True
        Me.query1.Checked = True
        Me.query1.Location = New System.Drawing.Point(12, 12)
        Me.query1.Name = "query1"
        Me.query1.Size = New System.Drawing.Size(332, 21)
        Me.query1.TabIndex = 3
        Me.query1.TabStop = True
        Me.query1.Text = "SELECT COUNT(*) FROM Production.Product"
        Me.query1.UseVisualStyleBackColor = True
        '
        'query2
        '
        Me.query2.AutoSize = True
        Me.query2.Location = New System.Drawing.Point(12, 40)
        Me.query2.Name = "query2"
        Me.query2.Size = New System.Drawing.Size(362, 21)
        Me.query2.TabIndex = 4
        Me.query2.Text = "SELECT SUM(ListPrice) FROM Production.Product"
        Me.query2.UseVisualStyleBackColor = True
        '
        'query3
        '
        Me.query3.Location = New System.Drawing.Point(12, 67)
        Me.query3.Name = "query3"
        Me.query3.Size = New System.Drawing.Size(478, 41)
        Me.query3.TabIndex = 5
        Me.query3.Text = "SELECT AVG(DATEDIFF(year,e.BirthDate,GETDATE())) FROM HumanResources.Employee e"
        Me.query3.UseVisualStyleBackColor = True
        '
        'query4
        '
        Me.query4.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.query4.Location = New System.Drawing.Point(12, 123)
        Me.query4.Name = "query4"
        Me.query4.Size = New System.Drawing.Size(465, 49)
        Me.query4.TabIndex = 6
        Me.query4.Text = "SELECT MAX(DepartmentID) from HumanResources.EmployeeDepartmentHistory"
        Me.query4.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.query4.UseVisualStyleBackColor = True
        '
        'query5
        '
        Me.query5.AutoSize = True
        Me.query5.Location = New System.Drawing.Point(12, 178)
        Me.query5.Name = "query5"
        Me.query5.Size = New System.Drawing.Size(488, 21)
        Me.query5.TabIndex = 7
        Me.query5.Text = "SELECT min(JobCandidateID) FROM HumanResources.JobCandidate"
        Me.query5.UseVisualStyleBackColor = True
        '
        'FrmQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 340)
        Me.Controls.Add(Me.query5)
        Me.Controls.Add(Me.query4)
        Me.Controls.Add(Me.query3)
        Me.Controls.Add(Me.query2)
        Me.Controls.Add(Me.query1)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnRun)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmQuery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExecuteScalar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents query1 As System.Windows.Forms.RadioButton
    Friend WithEvents query2 As System.Windows.Forms.RadioButton
    Friend WithEvents query3 As System.Windows.Forms.RadioButton
    Friend WithEvents query4 As System.Windows.Forms.RadioButton
    Friend WithEvents query5 As System.Windows.Forms.RadioButton

End Class
