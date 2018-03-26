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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_Date = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListView2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(768, 460)
        Me.SplitContainer1.SplitterDistance = 378
        Me.SplitContainer1.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Location = New System.Drawing.Point(3, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(299, 115)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Button_Add
        '
        Me.Button_Add.Location = New System.Drawing.Point(3, 124)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(70, 34)
        Me.Button_Add.TabIndex = 1
        Me.Button_Add.Text = "Add"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(230, 3)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(70, 34)
        Me.Button_Save.TabIndex = 2
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.Location = New System.Drawing.Point(79, 124)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(70, 34)
        Me.Button_Delete.TabIndex = 3
        Me.Button_Delete.Text = "Delete"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button_Save)
        Me.Panel1.Location = New System.Drawing.Point(3, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(307, 108)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label_Date)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Controls.Add(Me.Button_Delete)
        Me.Panel2.Controls.Add(Me.Button_Add)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(307, 165)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Id:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(79, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(52, 20)
        Me.TextBox1.TabIndex = 4
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Job"
        Me.ColumnHeader2.Width = 103
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Hours"
        Me.ColumnHeader3.Width = 118
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Day:"
        '
        'Label_Date
        '
        Me.Label_Date.AutoSize = True
        Me.Label_Date.Location = New System.Drawing.Point(211, 135)
        Me.Label_Date.Name = "Label_Date"
        Me.Label_Date.Size = New System.Drawing.Size(10, 13)
        Me.Label_Date.TabIndex = 5
        Me.Label_Date.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Job:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hours:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(79, 42)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(123, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(79, 71)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(123, 20)
        Me.TextBox3.TabIndex = 8
        '
        'ListView2
        '
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(0, 0)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(378, 460)
        Me.ListView2.TabIndex = 0
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Day"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Hours"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 460)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Button_Save As Button
    Friend WithEvents Button_Delete As Button
    Friend WithEvents Button_Add As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label_Date As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
End Class
