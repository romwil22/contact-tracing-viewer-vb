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
        Me.readFileLabel = New System.Windows.Forms.Label()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.readButton = New System.Windows.Forms.Button()
        Me.fullnameBox = New System.Windows.Forms.TextBox()
        Me.fileNameBox = New System.Windows.Forms.TextBox()
        Me.detailsLabel = New System.Windows.Forms.Label()
        Me.studentNoBox = New System.Windows.Forms.TextBox()
        Me.courseYrSecbox = New System.Windows.Forms.TextBox()
        Me.birthGenderBox = New System.Windows.Forms.TextBox()
        Me.addressBox = New System.Windows.Forms.TextBox()
        Me.mobileNumBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'readFileLabel
        '
        Me.readFileLabel.AutoSize = True
        Me.readFileLabel.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.readFileLabel.Location = New System.Drawing.Point(2, 12)
        Me.readFileLabel.Name = "readFileLabel"
        Me.readFileLabel.Size = New System.Drawing.Size(82, 20)
        Me.readFileLabel.TabIndex = 0
        Me.readFileLabel.Text = "Read File:"
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft JhengHei UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(152, 6)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(221, 41)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Student Data"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Menu
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.closeButton)
        Me.Panel1.Controls.Add(Me.readButton)
        Me.Panel1.Controls.Add(Me.addressBox)
        Me.Panel1.Controls.Add(Me.birthGenderBox)
        Me.Panel1.Controls.Add(Me.mobileNumBox)
        Me.Panel1.Controls.Add(Me.courseYrSecbox)
        Me.Panel1.Controls.Add(Me.studentNoBox)
        Me.Panel1.Controls.Add(Me.fullnameBox)
        Me.Panel1.Controls.Add(Me.fileNameBox)
        Me.Panel1.Controls.Add(Me.detailsLabel)
        Me.Panel1.Controls.Add(Me.readFileLabel)
        Me.Panel1.Location = New System.Drawing.Point(12, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 325)
        Me.Panel1.TabIndex = 1
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.closeButton.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.Location = New System.Drawing.Point(392, 263)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(89, 39)
        Me.closeButton.TabIndex = 3
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = False
        '
        'readButton
        '
        Me.readButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.readButton.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.readButton.Location = New System.Drawing.Point(287, 263)
        Me.readButton.Name = "readButton"
        Me.readButton.Size = New System.Drawing.Size(89, 39)
        Me.readButton.TabIndex = 3
        Me.readButton.Text = "Read"
        Me.readButton.UseVisualStyleBackColor = False
        '
        'fullnameBox
        '
        Me.fullnameBox.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullnameBox.Location = New System.Drawing.Point(6, 71)
        Me.fullnameBox.Name = "fullnameBox"
        Me.fullnameBox.Size = New System.Drawing.Size(475, 24)
        Me.fullnameBox.TabIndex = 1
        Me.fullnameBox.Text = "Fullname"
        '
        'fileNameBox
        '
        Me.fileNameBox.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fileNameBox.Location = New System.Drawing.Point(84, 11)
        Me.fileNameBox.Name = "fileNameBox"
        Me.fileNameBox.Size = New System.Drawing.Size(120, 24)
        Me.fileNameBox.TabIndex = 1
        Me.fileNameBox.Text = "Enter filename"
        '
        'detailsLabel
        '
        Me.detailsLabel.AutoSize = True
        Me.detailsLabel.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailsLabel.Location = New System.Drawing.Point(2, 48)
        Me.detailsLabel.Name = "detailsLabel"
        Me.detailsLabel.Size = New System.Drawing.Size(65, 20)
        Me.detailsLabel.TabIndex = 0
        Me.detailsLabel.Text = "Details:"
        '
        'studentNoBox
        '
        Me.studentNoBox.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentNoBox.Location = New System.Drawing.Point(6, 101)
        Me.studentNoBox.Name = "studentNoBox"
        Me.studentNoBox.Size = New System.Drawing.Size(475, 24)
        Me.studentNoBox.TabIndex = 1
        Me.studentNoBox.Text = "Student Number"
        '
        'courseYrSecbox
        '
        Me.courseYrSecbox.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseYrSecbox.Location = New System.Drawing.Point(6, 131)
        Me.courseYrSecbox.Name = "courseYrSecbox"
        Me.courseYrSecbox.Size = New System.Drawing.Size(475, 24)
        Me.courseYrSecbox.TabIndex = 1
        Me.courseYrSecbox.Text = "Course/Year/Section"
        '
        'birthGenderBox
        '
        Me.birthGenderBox.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthGenderBox.Location = New System.Drawing.Point(6, 191)
        Me.birthGenderBox.Name = "birthGenderBox"
        Me.birthGenderBox.Size = New System.Drawing.Size(475, 24)
        Me.birthGenderBox.TabIndex = 1
        Me.birthGenderBox.Text = "Birthdate/Gender"
        '
        'addressBox
        '
        Me.addressBox.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressBox.Location = New System.Drawing.Point(6, 221)
        Me.addressBox.Name = "addressBox"
        Me.addressBox.Size = New System.Drawing.Size(475, 24)
        Me.addressBox.TabIndex = 1
        Me.addressBox.Text = "Address"
        '
        'mobileNumBox
        '
        Me.mobileNumBox.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobileNumBox.Location = New System.Drawing.Point(6, 161)
        Me.mobileNumBox.Name = "mobileNumBox"
        Me.mobileNumBox.Size = New System.Drawing.Size(475, 24)
        Me.mobileNumBox.TabIndex = 1
        Me.mobileNumBox.Text = "Mobile Number"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(512, 389)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.titleLabel)
        Me.Name = "Form1"
        Me.Text = "Contact Tracing Viewer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents readFileLabel As Label
    Friend WithEvents titleLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents closeButton As Button
    Friend WithEvents readButton As Button
    Friend WithEvents fileNameBox As TextBox
    Friend WithEvents detailsLabel As Label
    Friend WithEvents fullnameBox As TextBox
    Friend WithEvents addressBox As TextBox
    Friend WithEvents birthGenderBox As TextBox
    Friend WithEvents courseYrSecbox As TextBox
    Friend WithEvents studentNoBox As TextBox
    Friend WithEvents mobileNumBox As TextBox
End Class
