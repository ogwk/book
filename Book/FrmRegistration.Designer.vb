<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistration
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtBookName = New System.Windows.Forms.TextBox()
        Me.LblBookName = New System.Windows.Forms.Label()
        Me.LblAuther = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LblGenru = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.LblProperty = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtBookName
        '
        Me.TxtBookName.Location = New System.Drawing.Point(42, 49)
        Me.TxtBookName.Name = "TxtBookName"
        Me.TxtBookName.Size = New System.Drawing.Size(113, 19)
        Me.TxtBookName.TabIndex = 0
        '
        'LblBookName
        '
        Me.LblBookName.AutoSize = True
        Me.LblBookName.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblBookName.Location = New System.Drawing.Point(42, 31)
        Me.LblBookName.Name = "LblBookName"
        Me.LblBookName.Size = New System.Drawing.Size(32, 18)
        Me.LblBookName.TabIndex = 1
        Me.LblBookName.Text = "題名"
        '
        'LblAuther
        '
        Me.LblAuther.AutoSize = True
        Me.LblAuther.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblAuther.Location = New System.Drawing.Point(42, 103)
        Me.LblAuther.Name = "LblAuther"
        Me.LblAuther.Size = New System.Drawing.Size(32, 18)
        Me.LblAuther.TabIndex = 3
        Me.LblAuther.Text = "著者"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(42, 121)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(113, 19)
        Me.TextBox1.TabIndex = 2
        '
        'LblGenru
        '
        Me.LblGenru.AutoSize = True
        Me.LblGenru.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblGenru.Location = New System.Drawing.Point(45, 179)
        Me.LblGenru.Name = "LblGenru"
        Me.LblGenru.Size = New System.Drawing.Size(56, 18)
        Me.LblGenru.TabIndex = 5
        Me.LblGenru.Text = "ジャンル"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(45, 200)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox1.TabIndex = 6
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(48, 282)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox2.TabIndex = 8
        '
        'LblProperty
        '
        Me.LblProperty.AutoSize = True
        Me.LblProperty.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblProperty.Location = New System.Drawing.Point(48, 261)
        Me.LblProperty.Name = "LblProperty"
        Me.LblProperty.Size = New System.Drawing.Size(68, 18)
        Me.LblProperty.TabIndex = 7
        Me.LblProperty.Text = "プロパティ"
        '
        'FrmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 396)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.LblProperty)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LblGenru)
        Me.Controls.Add(Me.LblAuther)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LblBookName)
        Me.Controls.Add(Me.TxtBookName)
        Me.Name = "FrmRegistration"
        Me.Text = "FrmRegistration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtBookName As TextBox
    Friend WithEvents LblBookName As Label
    Friend WithEvents LblAuther As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LblGenru As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents LblProperty As Label
End Class
