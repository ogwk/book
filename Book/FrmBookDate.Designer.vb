<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBookDate
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBookDate))
        Me.BtnRegistration = New System.Windows.Forms.Button()
        Me.本在庫DataSet = New Book.本在庫DataSet()
        Me.本在庫TableAdapter = New Book.本在庫DataSetTableAdapters.本在庫TableAdapter()
        Me.BtnUpDate = New System.Windows.Forms.Button()
        Me.TxtBookName = New System.Windows.Forms.TextBox()
        Me.TxtAuther = New System.Windows.Forms.TextBox()
        Me.TxtGenru = New System.Windows.Forms.TextBox()
        Me.TxtProperty = New System.Windows.Forms.TextBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.本在庫BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Book.本在庫DataSetTableAdapters.TableAdapterManager()
        Me.本在庫BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.本在庫BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.本在庫DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblBookName = New System.Windows.Forms.Label()
        Me.LblAuther = New System.Windows.Forms.Label()
        Me.LblGenru = New System.Windows.Forms.Label()
        Me.LblProperty = New System.Windows.Forms.Label()
        CType(Me.本在庫DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.本在庫BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.本在庫BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.本在庫BindingNavigator.SuspendLayout()
        CType(Me.本在庫DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRegistration
        '
        Me.BtnRegistration.Location = New System.Drawing.Point(41, 535)
        Me.BtnRegistration.Name = "BtnRegistration"
        Me.BtnRegistration.Size = New System.Drawing.Size(137, 50)
        Me.BtnRegistration.TabIndex = 0
        Me.BtnRegistration.Text = "登録"
        Me.BtnRegistration.UseVisualStyleBackColor = True
        '
        '本在庫DataSet
        '
        Me.本在庫DataSet.DataSetName = "本在庫DataSet"
        Me.本在庫DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '本在庫TableAdapter
        '
        Me.本在庫TableAdapter.ClearBeforeFill = True
        '
        'BtnUpDate
        '
        Me.BtnUpDate.Location = New System.Drawing.Point(209, 535)
        Me.BtnUpDate.Name = "BtnUpDate"
        Me.BtnUpDate.Size = New System.Drawing.Size(127, 50)
        Me.BtnUpDate.TabIndex = 3
        Me.BtnUpDate.Text = "更新"
        Me.BtnUpDate.UseVisualStyleBackColor = True
        '
        'TxtBookName
        '
        Me.TxtBookName.Location = New System.Drawing.Point(89, 399)
        Me.TxtBookName.Name = "TxtBookName"
        Me.TxtBookName.Size = New System.Drawing.Size(164, 19)
        Me.TxtBookName.TabIndex = 4
        '
        'TxtAuther
        '
        Me.TxtAuther.Location = New System.Drawing.Point(89, 465)
        Me.TxtAuther.Name = "TxtAuther"
        Me.TxtAuther.Size = New System.Drawing.Size(100, 19)
        Me.TxtAuther.TabIndex = 5
        '
        'TxtGenru
        '
        Me.TxtGenru.Location = New System.Drawing.Point(327, 399)
        Me.TxtGenru.Name = "TxtGenru"
        Me.TxtGenru.Size = New System.Drawing.Size(100, 19)
        Me.TxtGenru.TabIndex = 6
        '
        'TxtProperty
        '
        Me.TxtProperty.Location = New System.Drawing.Point(327, 465)
        Me.TxtProperty.Name = "TxtProperty"
        Me.TxtProperty.Size = New System.Drawing.Size(100, 19)
        Me.TxtProperty.TabIndex = 7
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(380, 535)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(111, 50)
        Me.BtnDelete.TabIndex = 8
        Me.BtnDelete.Text = "削除"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        '本在庫BindingSource
        '
        Me.本在庫BindingSource.DataMember = "本在庫"
        Me.本在庫BindingSource.DataSource = Me.本在庫DataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Book.本在庫DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ジャンルマスタTableAdapter = Nothing
        Me.TableAdapterManager.本在庫TableAdapter = Nothing
        Me.TableAdapterManager.状態マスタTableAdapter = Nothing
        '
        '本在庫BindingNavigator
        '
        Me.本在庫BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.本在庫BindingNavigator.BindingSource = Me.本在庫BindingSource
        Me.本在庫BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.本在庫BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.本在庫BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.本在庫BindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.本在庫BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.本在庫BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.本在庫BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.本在庫BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.本在庫BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.本在庫BindingNavigator.Name = "本在庫BindingNavigator"
        Me.本在庫BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.本在庫BindingNavigator.Size = New System.Drawing.Size(594, 25)
        Me.本在庫BindingNavigator.TabIndex = 9
        Me.本在庫BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "新規追加"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目の総数"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "削除"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "最初に移動"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "前に戻る"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "現在の場所"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "次に移動"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "最後に移動"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        '本在庫BindingNavigatorSaveItem
        '
        Me.本在庫BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.本在庫BindingNavigatorSaveItem.Image = CType(resources.GetObject("本在庫BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.本在庫BindingNavigatorSaveItem.Name = "本在庫BindingNavigatorSaveItem"
        Me.本在庫BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.本在庫BindingNavigatorSaveItem.Text = "データの保存"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        '本在庫DataGridView
        '
        Me.本在庫DataGridView.AutoGenerateColumns = False
        Me.本在庫DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.本在庫DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.本在庫DataGridView.DataSource = Me.本在庫BindingSource
        Me.本在庫DataGridView.Location = New System.Drawing.Point(89, 121)
        Me.本在庫DataGridView.Name = "本在庫DataGridView"
        Me.本在庫DataGridView.RowTemplate.Height = 21
        Me.本在庫DataGridView.Size = New System.Drawing.Size(402, 230)
        Me.本在庫DataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "題名"
        Me.DataGridViewTextBoxColumn1.HeaderText = "題名"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "著者"
        Me.DataGridViewTextBoxColumn2.HeaderText = "著者"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ジャンルコード"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ジャンルコード"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "状態コード"
        Me.DataGridViewTextBoxColumn4.HeaderText = "状態コード"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'LblBookName
        '
        Me.LblBookName.AutoSize = True
        Me.LblBookName.Location = New System.Drawing.Point(87, 384)
        Me.LblBookName.Name = "LblBookName"
        Me.LblBookName.Size = New System.Drawing.Size(29, 12)
        Me.LblBookName.TabIndex = 10
        Me.LblBookName.Text = "題名"
        '
        'LblAuther
        '
        Me.LblAuther.AutoSize = True
        Me.LblAuther.Location = New System.Drawing.Point(87, 450)
        Me.LblAuther.Name = "LblAuther"
        Me.LblAuther.Size = New System.Drawing.Size(29, 12)
        Me.LblAuther.TabIndex = 11
        Me.LblAuther.Text = "著者"
        '
        'LblGenru
        '
        Me.LblGenru.AutoSize = True
        Me.LblGenru.Location = New System.Drawing.Point(325, 384)
        Me.LblGenru.Name = "LblGenru"
        Me.LblGenru.Size = New System.Drawing.Size(42, 12)
        Me.LblGenru.TabIndex = 12
        Me.LblGenru.Text = "ジャンル"
        '
        'LblProperty
        '
        Me.LblProperty.AutoSize = True
        Me.LblProperty.Location = New System.Drawing.Point(325, 450)
        Me.LblProperty.Name = "LblProperty"
        Me.LblProperty.Size = New System.Drawing.Size(29, 12)
        Me.LblProperty.TabIndex = 13
        Me.LblProperty.Text = "状態"
        '
        'FrmBookDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 613)
        Me.Controls.Add(Me.LblProperty)
        Me.Controls.Add(Me.LblGenru)
        Me.Controls.Add(Me.LblAuther)
        Me.Controls.Add(Me.LblBookName)
        Me.Controls.Add(Me.本在庫DataGridView)
        Me.Controls.Add(Me.本在庫BindingNavigator)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.TxtProperty)
        Me.Controls.Add(Me.TxtGenru)
        Me.Controls.Add(Me.TxtAuther)
        Me.Controls.Add(Me.TxtBookName)
        Me.Controls.Add(Me.BtnUpDate)
        Me.Controls.Add(Me.BtnRegistration)
        Me.Name = "FrmBookDate"
        Me.Text = "FrmRegistration"
        CType(Me.本在庫DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.本在庫BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.本在庫BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.本在庫BindingNavigator.ResumeLayout(False)
        Me.本在庫BindingNavigator.PerformLayout()
        CType(Me.本在庫DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegistration As Button
    Friend WithEvents 本在庫DataSet As 本在庫DataSet
    Friend WithEvents 本在庫TableAdapter As 本在庫DataSetTableAdapters.本在庫TableAdapter
    Friend WithEvents BtnUpDate As Button
    Friend WithEvents TxtBookName As TextBox
    Friend WithEvents TxtAuther As TextBox
    Friend WithEvents TxtGenru As TextBox
    Friend WithEvents TxtProperty As TextBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents 本在庫BindingSource As BindingSource
    Friend WithEvents TableAdapterManager As 本在庫DataSetTableAdapters.TableAdapterManager
    Friend WithEvents 本在庫BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents 本在庫BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents 本在庫DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents LblBookName As Label
    Friend WithEvents LblAuther As Label
    Friend WithEvents LblGenru As Label
    Friend WithEvents LblProperty As Label
End Class
