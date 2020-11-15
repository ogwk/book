Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを '本在庫DataSet.本在庫' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.本在庫TableAdapter.Fill(Me.本在庫DataSet.本在庫)

    End Sub

    Private Sub 本在庫BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles 本在庫BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.本在庫BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.本在庫DataSet)

    End Sub
End Class