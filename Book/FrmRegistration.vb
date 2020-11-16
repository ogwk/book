Imports System.Data.OleDb
Public Class FrmRegistration
    Private clsConnect As New frmConnectAccessDB

    Private Sub Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '***************************************
        '*　ロード
        '***************************************
        Dim Adapter As OleDbDataAdapter
        Dim strSQL As String
        'DBに接続
        clsConnect.ProGetstrProvider = "Microsoft.ACE.OLEDB.12.0"
        clsConnect.ProGetstrDataSource = "C:\デスクトップ\01_ツール\04_本管理システム_.NET\git\Book\本在庫.accdb"

        Call clsConnect.SubConnectAccessDb()
        '----------------------------------------------------
        '　ジャンルコマンド
        '----------------------------------------------------
        strSQL = ""
        strSQL = "SELECT ジャンル名 FROM ジャンルマスタ"
        clsConnect.SetSQL = strSQL

        Call clsConnect.ShowCmdBox(CmbGenru, "ジャンルコード", "ジャンル名")

        '----------------------------------------------------
        '　状態コマンド
        '----------------------------------------------------
        strSQL = ""
        strSQL = "SELECT 状態名 FROM 状態マスタ"
        clsConnect.SetSQL = strSQL

        Call clsConnect.ShowCmdBox(CmbProperty, "状態コード", "状態名")


    End Sub

    Private Sub cmdAct_Click(sender As Object, e As EventArgs) Handles BtnAct.Click
        '***************************************
        '*　登録ボタン押下
        '***************************************
        Dim strBookName As String
        Dim strAuther As String
        Dim strGenruCode As String
        Dim strPropertyCode As String
        Dim strGenru As String
        Dim strProperty As String
        Dim strErrMsg As String
        Dim strSQL As String
        '----------------------------------------------------
        '　データ取得
        '----------------------------------------------------
        With Me
            strBookName = .TxtBookName.Text.ToString
            strAuther = .TxtAuther.Text.ToString
            strGenruCode = .CmbGenru.Text.ToString
            strPropertyCode = .CmbProperty.Text.ToString
        End With

        '----------------------------------------------------
        '　コードから取得
        '----------------------------------------------------

        strSQL = ""
        strSQL = strSQL & "SELECT ジャンルコード FROM ジャンルマスタ"
        strSQL = strSQL & " WHERE ジャンル名 = '" & strGenruCode & "'"

        clsConnect.SetSQL = strSQL

        Dim dt As DataTable
        dt = clsConnect.GetDataTable
        If dt.Rows.Count < 1 Then
            strGenru = ""
        Else
            strGenru = dt.Rows(0).Item(0).ToString()
        End If

        strSQL = ""
        strSQL = strSQL & "SELECT 状態コード FROM 状態マスタ"
        strSQL = strSQL & " WHERE 状態名 = '" & strPropertyCode & "'"

        clsConnect.SetSQL = strSQL

        Dim dt2 As DataTable
        dt2 = clsConnect.GetDataTable
        If dt2.Rows.Count < 1 Then
            strProperty = ""
        Else
            strProperty = dt2.Rows(0).Item(0).ToString()
        End If
        '----------------------------------------------------
        '　チェック
        '----------------------------------------------------
        If FncBlank_Check(strBookName) = True Then
            strErrMsg = "本の題名を入力してください。"
            GoTo CHK_ERROR
        End If
        If FncBlank_Check(strAuther) = True Then
            strErrMsg = "著者名を入力してください。"
        End If
        If FncBlank_Check(strGenru) = True Then
            strErrMsg = "ジャンルを入力してください。"
        End If
        If FncBlank_Check(strProperty) = True Then
            strErrMsg = "状態名を入力してください。"
        End If
        '----------------------------------------------------
        '　SQL文作成
        '----------------------------------------------------
        strSQL = ""
        strSQL = "INSERT INTO 本在庫"
        strSQL = strSQL & " VALUES("
        strSQL = strSQL & "'" & strBookName & "',"
        strSQL = strSQL & "'" & strAuther & "',"
        strSQL = strSQL & "'" & strGenru & "',"
        strSQL = strSQL & "'" & strProperty & "')"

        clsConnect.SetSQL = strSQL
        Call clsConnect.SubRunsql()

        Exit Sub

CHK_ERROR:
        MsgBox(strErrMsg)
    End Sub
    Private Function FncBlank_Check(str As String) As Boolean
        '***************************************
        '*　空白☑
        '***************************************
        If str = "" Then
            FncBlank_Check = True
        Else
            FncBlank_Check = False
        End If
    End Function
End Class