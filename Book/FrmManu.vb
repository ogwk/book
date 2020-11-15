Public Class FrmManu
    Private Sub btnRegistration_Click(sender As Object, e As EventArgs) Handles BtnAct.Click
        '***************************************
        '*　登録ボタンクリック
        '***************************************
        '画面遷移
        Dim clsForm As New clsMain With {
            .ProOpenForm = FrmBookDate
        }

        Call clsForm.SubOpenForm()

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        '***************************************
        '*　検索ボタンクリック
        '***************************************
        '画面遷移
        Dim clsForm As New clsMain With {
            .ProOpenForm = FrmSearch
        }

        Call clsForm.SubOpenForm()
    End Sub
End Class
