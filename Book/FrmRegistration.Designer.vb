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
        Me.TxtAuther = New System.Windows.Forms.TextBox()
        Me.LblGenru = New System.Windows.Forms.Label()
        Me.CmbGenru = New System.Windows.Forms.ComboBox()
        Me.CmbProperty = New System.Windows.Forms.ComboBox()
        Me.LblProperty = New System.Windows.Forms.Label()
        Me.BtnAct = New System.Windows.Forms.Button()
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
        'TxtAuther
        '
        Me.TxtAuther.Location = New System.Drawing.Point(42, 121)
        Me.TxtAuther.Name = "TxtAuther"
        Me.TxtAuther.Size = New System.Drawing.Size(113, 19)
        Me.TxtAuther.TabIndex = 2
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
        'CmbGenru
        '
        Me.CmbGenru.FormattingEnabled = True
        Me.CmbGenru.Location = New System.Drawing.Point(45, 200)
        Me.CmbGenru.Name = "CmbGenru"
        Me.CmbGenru.Size = New System.Drawing.Size(121, 20)
        Me.CmbGenru.TabIndex = 6
        '
        'CmbProperty
        '
        Me.CmbProperty.FormattingEnabled = True
        Me.CmbProperty.Location = New System.Drawing.Point(48, 282)
        Me.CmbProperty.Name = "CmbProperty"
        Me.CmbProperty.Size = New System.Drawing.Size(121, 20)
        Me.CmbProperty.TabIndex = 8
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
        'BtnAct
        '
        Me.BtnAct.Location = New System.Drawing.Point(214, 310)
        Me.BtnAct.Name = "BtnAct"
        Me.BtnAct.Size = New System.Drawing.Size(115, 41)
        Me.BtnAct.TabIndex = 9
        Me.BtnAct.Text = "登録"
        Me.BtnAct.UseVisualStyleBackColor = True
        '
        'FrmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 396)
        Me.Controls.Add(Me.BtnAct)
        Me.Controls.Add(Me.CmbProperty)
        Me.Controls.Add(Me.LblProperty)
        Me.Controls.Add(Me.CmbGenru)
        Me.Controls.Add(Me.LblGenru)
        Me.Controls.Add(Me.LblAuther)
        Me.Controls.Add(Me.TxtAuther)
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
    Friend WithEvents TxtAuther As TextBox
    Friend WithEvents LblGenru As Label
    Friend WithEvents CmbGenru As ComboBox
    Friend WithEvents CmbProperty As ComboBox
    Friend WithEvents LblProperty As Label
    Friend WithEvents BtnAct As Button
End Class
