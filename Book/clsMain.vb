Imports System.Data.OleDb
Public Class clsMain
    Private P_frmOpen As Form
    Private P_frmClose As Form
    '***************************************
    '*　フォーム
    '***************************************
    Public WriteOnly Property ProOpenForm() As Form
        '=======================================
        '=　遷移画面の取得(Open)
        '=======================================

        Set(ByVal frm As Form)
            P_frmOpen = frm
        End Set
    End Property

    Public WriteOnly Property ProCloseForm() As Form
        '=======================================
        '=　遷移画面の取得(Close)
        '=======================================

        Set(ByVal frm As Form)
            P_frmClose = frm
        End Set
    End Property

    Public Sub SubOpenForm()
        '=======================================
        '=　画面の遷移
        '=======================================
        P_frmOpen.Show()
    End Sub

    Public Sub SubOpensubForm()
        '=======================================
        '=　sub画面の遷移
        '=======================================
        P_frmOpen.ShowDialog()
    End Sub

    '***************************************
    '*　コントロール
    '***************************************
    Private P_TxtBox As TextBox
    Private P_StrTxt As String
    Public WriteOnly Property ProSetTextBox() As TextBox
        '=======================================
        '=　テキストボックスに指定の値を設定(対象のテキストボックス取得）
        '=======================================
        Set(ByVal TxtBox As TextBox)

            P_TxtBox = TxtBox
        End Set
    End Property
    Public WriteOnly Property ProSetText() As String
        '=======================================
        '=　対象の文字列取得
        '=======================================
        Set(ByVal strTxt As String)
            P_StrTxt = strTxt
        End Set
    End Property

    Public Sub SubSetTextBox()
        '=======================================
        '=　テキストボックスに指定の値を設定
        '=======================================
        P_TxtBox.Text = P_StrTxt
    End Sub


    '***************************************
    '*　データセット
    '***************************************
    Private P_strTargetColumnName As String
    Private P_StrCondition As String
    Private P_StrGetFilter As String

    Public WriteOnly Property ProSetColumnName() As String
        '=======================================
        '=　フィルター条件設定
        '=======================================
        Set(ByVal StrTargetColumn As String)

            P_strTargetColumnName = StrTargetColumn

        End Set
    End Property
    Public WriteOnly Property ProSetCondition() As String
        '=======================================
        '=　フィルター条件設定
        '=======================================
        Set(ByVal StrCondition As String)
            If P_StrCondition <> "" Then

            Else
                P_StrCondition = StrCondition
            End If
        End Set
    End Property
    Public ReadOnly Property ProGetFilTer() As String
        '=======================================
        '=　フィルター条件設定
        '=======================================
        Get
            P_StrGetFilter = P_strTargetColumnName & " LIKE '" & P_StrCondition & "'"
            Return P_StrGetFilter
        End Get

    End Property

    '***************************************
    '*　データベース
    '***************************************
    Private P_strMDBPath As String
    Public WriteOnly Property ProSetDataSource As String
        '=======================================
        '=　MDBパス取得
        '=======================================
        Set(ByVal strMDBPath As String)
            P_strMDBPath = strMDBPath
        End Set
    End Property

End Class
