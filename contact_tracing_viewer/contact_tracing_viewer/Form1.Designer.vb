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
        Me.fileNameBox = New System.Windows.Forms.TextBox()
        Me.readTextFileRichBox = New System.Windows.Forms.RichTextBox()
        Me.readButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
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
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.closeButton)
        Me.Panel1.Controls.Add(Me.readButton)
        Me.Panel1.Controls.Add(Me.readTextFileRichBox)
        Me.Panel1.Controls.Add(Me.fileNameBox)
        Me.Panel1.Controls.Add(Me.readFileLabel)
        Me.Panel1.Location = New System.Drawing.Point(12, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 352)
        Me.Panel1.TabIndex = 1
        '
        'fileNameBox
        '
        Me.fileNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fileNameBox.Location = New System.Drawing.Point(84, 11)
        Me.fileNameBox.Name = "fileNameBox"
        Me.fileNameBox.Size = New System.Drawing.Size(120, 23)
        Me.fileNameBox.TabIndex = 1
        Me.fileNameBox.Text = "Enter filename"
        '
        'readTextFileRichBox
        '
        Me.readTextFileRichBox.Location = New System.Drawing.Point(5, 49)
        Me.readTextFileRichBox.Name = "readTextFileRichBox"
        Me.readTextFileRichBox.Size = New System.Drawing.Size(476, 237)
        Me.readTextFileRichBox.TabIndex = 2
        Me.readTextFileRichBox.Text = ""
        '
        'readButton
        '
        Me.readButton.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.readButton.Location = New System.Drawing.Point(285, 298)
        Me.readButton.Name = "readButton"
        Me.readButton.Size = New System.Drawing.Size(89, 39)
        Me.readButton.TabIndex = 3
        Me.readButton.Text = "Read"
        Me.readButton.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.Location = New System.Drawing.Point(380, 298)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(89, 39)
        Me.closeButton.TabIndex = 3
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 417)
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
    Friend WithEvents readTextFileRichBox As RichTextBox
    Friend WithEvents fileNameBox As TextBox
End Class
