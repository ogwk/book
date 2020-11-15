Imports System.Data.OleDb
Public Class FrmBookDate
    Private GetData As New frmConnectAccessDB
    Private clsForm As New clsMain

    Private Sub btnRegistration_Click(sender As Object, e As EventArgs) Handles BtnRegistration.Click
        '***************************************
        '*　登録ボタンクリック
        '***************************************
        '画面遷移
        With clsForm
            .ProOpenForm = FrmRegistration
        End With

        Call clsForm.SubOpensubForm()

    End Sub
    Private Sub FrmBookDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '*************************************************************
        '*　フォームロード
        '*************************************************************

        Call RequeryDataGridTable()

    End Sub

    Private Sub 本在庫BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles 本在庫BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.本在庫BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.本在庫DataSet)

    End Sub

    Private Sub 本在庫DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles 本在庫DataGridView.CellContentClick, 本在庫DataGridView.CellClick
        Dim lngRowNum As Integer

        With 本在庫DataGridView

            If 本在庫DataGridView.Rows.Count > 0 Then

                lngRowNum = .SelectedCells(0).RowIndex

                If .Rows(lngRowNum).Cells(0).Value.ToString <> "" Then
                    TxtBookName.Text = .Rows(lngRowNum).Cells(0).Value.ToString
                    TxtAuther.Text = .Rows(lngRowNum).Cells(1).Value.ToString
                    TxtGenru.Text = .Rows(lngRowNum).Cells(2).Value.ToString
                    TxtProperty.Text = .Rows(lngRowNum).Cells(3).Value.ToString
                End If
            End If
        End With
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub 本在庫DataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles 本在庫DataGridView.SelectionChanged


    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        '*************************************************************
        '*　削除ボタン押下
        '*************************************************************
        Dim strDataSource As String
        Dim strSQL As String
        Dim intRow As Integer
        Dim strBookName As String
        Dim strAutherName As String
        Dim strGenru As String
        Dim strProperty As String



        With 本在庫DataGridView
            '選択行取得
            intRow = .SelectedCells(0).RowIndex
            strBookName = .Rows(intRow).Cells(0).Value.ToString
            strAutherName = .Rows(intRow).Cells(1).Value.ToString
            strGenru = .Rows(intRow).Cells(2).Value.ToString
            strProperty = .Rows(intRow).Cells(3).Value.ToString
        End With

        strSQL = ""
        strSQL = strSQL & "DELETE * FROM 本在庫"
        strSQL = strSQL & " WHERE"
        strSQL = strSQL & " 題名 = '" & strBookName & "'"
        strSQL = strSQL & " AND 著者 = '" & strAutherName & "'"

        ' ACCESS DB レコード削除

        Call GetData.SubRunsql(strSQL)

        本在庫DataGridView.CurrentCell = 本在庫DataGridView.Rows(intRow).Cells(0)

        Call RequeryDataGridTable()

    End Sub

    Private Sub BtnUpDate_Click(sender As Object, e As EventArgs) Handles BtnUpDate.Click
        '*************************************************************
        '*　更新ボタン押下
        '*************************************************************
        Dim strDataSource As String
        Dim strSQL As String
        Dim intRow As Integer
        Dim strBookName As String
        Dim strAutherName As String
        Dim strGenruCode As String
        Dim strPropertyCode As String
        Dim strGenruName As String
        Dim strPropertyName As String


        With 本在庫DataGridView
            '選択行取得
            intRow = .SelectedCells(0).RowIndex
            strBookName = .Rows(intRow).Cells(0).Value.ToString
            strAutherName = .Rows(intRow).Cells(1).Value.ToString
            strGenruCode = .Rows(intRow).Cells(2).Value.ToString
            strPropertyCode = .Rows(intRow).Cells(3).Value.ToString
        End With

        strSQL = ""
        strSQL = strSQL & "UPDATE 本在庫"
        strSQL = strSQL & " SET"
        strSQL = strSQL & " 題名 = '" & TxtBookName.Text.ToString & "',"
        strSQL = strSQL & " 著者 = '" & TxtAuther.Text.ToString & "',"
        strSQL = strSQL & " ジャンルコード = '" & TxtGenru.Text.ToString & "',"
        strSQL = strSQL & " 状態コード = '" & TxtProperty.Text.ToString & "'"
        strSQL = strSQL & " WHERE"
        strSQL = strSQL & " 題名 = '" & strBookName & "'"
        strSQL = strSQL & " AND 著者 = '" & strAutherName & "'"

        ' ACCESS DB レコード削除

        Call GetData.SubRunsql(strSQL)

        本在庫DataGridView.CurrentCell = 本在庫DataGridView.Rows(intRow).Cells(0)

        Call RequeryDataGridTable()
    End Sub

    Private Sub RequeryDataGridTable()
        '*************************************************************
        '*　表示更新
        '*************************************************************
        Dim strSQL As String
        Dim dt As DataTable = New DataTable()
        'Accessへの接続情報の設定をします。
        Dim builder As OleDbConnectionStringBuilder = New OleDbConnectionStringBuilder()
        'Access2007形式のファイルなのでこれを設定します。
        builder.Provider = "Microsoft.ACE.OLEDB.12.0"
        'Accessファイルへのパスを設定します。
        builder.DataSource = "C:\デスクトップ\01_ツール\04_本管理システム_.NET\Source\Book\Book\本在庫.accdb"
        '接続情報を使ってコネクションを生成します。
        Using conn As New OleDbConnection(builder.ConnectionString)
            'SQL文とコネクションを設定します。
            strSQL = ""
            strSQL = strSQL & "SELECT * FROM 本在庫"
            'strSQL = strSQL & "SELECT HZK.題名, HZK.著者, GMST.ジャンル名, PMST.状態名"
            'strSQL = strSQL & " FROM (本在庫 AS HZK LEFT JOIN ジャンルマスタ AS GMST"
            'strSQL = strSQL & " ON HZK.ジャンルコード = GMST.ジャンルコード)"
            'strSQL = strSQL & " LEFT JOIN 状態マスタ AS PMST"
            'strSQL = strSQL & " ON HZK.状態コード = PMST.状態コード"

            Using cmd As New OleDbCommand(strSQL, conn)
                'Accessファイルへの橋渡しのアダプターを設定します。
                Dim odda As OleDbDataAdapter = New OleDbDataAdapter()
                'SELECTコマンドを設定します。
                odda.SelectCommand = cmd
                'SELECTの実行及びフェッチ
                odda.Fill(dt)
                'グリッドに表示します。
                本在庫DataGridView.DataSource = dt
            End Using
        End Using
    End Sub


End Class