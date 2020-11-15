Imports System.Data.OleDb

Public Class frmConnectAccessDB
    '****************************************************
    '*　AccessDB接続
    '****************************************************
    '----------------------------------------------------
    '　変数
    '----------------------------------------------------
    Private strProvider As String
    Private DGView As DataGridView
    Private Adapter As OleDbDataAdapter

    Private strSQL As String
    Private strDataSource As String

    Private dbCon As OleDb.OleDbConnection
    Private dbCmd As OleDbCommand
    '----------------------------------------------------
    '　関数
    '----------------------------------------------------


    Public Property ProGetstrProvider() As String
        Get
            Return strProvider
        End Get
        Set(value As String)
            strProvider = value
        End Set
    End Property
    Public Property ProGetstrDataSource() As String
        Get
            Return strDataSource
        End Get
        Set(value As String)
            strDataSource = value
        End Set
    End Property
    Public WriteOnly Property ProSetDataGridView() As DataGridView
        '****************************************************
        '*　DataGridView取得
        '****************************************************
        Set(value As DataGridView)
            DGView = value
        End Set
    End Property
    Public WriteOnly Property ProSetAdapter() As OleDbDataAdapter
        '****************************************************
        '*　Adapter取得
        '****************************************************
        Set(value As OleDbDataAdapter)
            Adapter = value
        End Set
    End Property
    Public WriteOnly Property SetSQL() As String
        '****************************************************
        '*　SQL文取得
        '****************************************************
        Set(value As String)
            strSQL = value
        End Set
    End Property

    Public WriteOnly Property SetDataSource() As String
        '****************************************************
        '*　DB接続先取得
        '****************************************************
        Set(value As String)
            strDataSource = value
        End Set
    End Property
    'Public Sub SubConnectAccessDb()
    '    '    '****************************************************
    '    '    '*　DB接続
    '    '    '****************************************************
    '    '    'Accessへの接続情報の設定をします。
    '    '    Dim builder As OleDbConnectionStringBuilder = New OleDbConnectionStringBuilder()
    '    '    Dim strConnection As String

    '    '    'Access2007形式のファイルなのでこれを設定します。
    '    '    builder.Provider = "Microsoft.ACE.OLEDB.12.0"
    '    '    'Accessファイルへのパスを設定します。
    '    '    builder.DataSource = "C:\デスクトップ\01_ツール\04_本管理システム_.NET\Source\Book\Book\本在庫.accdb"

    '    '    strConnection = "Provider = Microsoft.ACE.OLEDB.12.0;" 
    '    '    strConnection = strConnection & "DataSource = C:\デスクトップ\01_ツール\04_本管理システム_.NET\Source\Book\Book\本在庫.accdb"


    '    '    dbCon.ConnectionString = strConnection
    '    '    dbCon.Open()


    'End Sub
    'Public Sub SubDisConnectAccessDb()
    '    '****************************************************
    '    '*　DBクローズ
    '    '***************************************************
    '    ' ACCESS DB クローズ
    '    dbCon.Close()
    '    dbCon.Dispose()

    'End Sub
    Public Sub SubRunsql(strsql As String)
        '****************************************************
        '*　SQLを実行する
        '****************************************************
        Dim builder As OleDbConnectionStringBuilder = New OleDbConnectionStringBuilder()

        'Access2007形式のファイルなのでこれを設定します。
        builder.Provider = "Microsoft.ACE.OLEDB.12.0"
        'Accessファイルへのパスを設定します。
        builder.DataSource = "C:\デスクトップ\01_ツール\04_本管理システム_.NET\Source\Book\Book\本在庫.accdb"
        Using conn As New OleDbConnection(builder.]
                ConnectionString)

            conn.Open()
            'SQL文とコネクションを設定します。
            Using cmd As New OleDbCommand(strsql, conn)
                cmd.CommandText = strsql
                'クエリ実行
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    Public Sub ShowDataTable()
        '****************************************************
        '*　DataGridViewにテーブルデータを表示
        '****************************************************

        '▼MDBへの接続設定
        '接続設定は環境に応じて書き換えてください。

        '接続文字列の作成
        Dim ConnectionString As String
        Dim CommandText As String
        Dim UserID As String = "Admin"
        Dim Password As String = ""


        ConnectionString = "Provider=" & "Provider=Microsoft.ACE.OLEDB.12.0;"
        ConnectionString &= "Data Source=" & strDataSource
        '''ConnectionString &= "User ID=" & UserID & ";"
        ''ConnectionString &= "Jet OLEDB:Database Password=" & Password

        'SQLのSELECT文を作成
        CommandText = strSQL

        '以上の設定からデータアダプターを生成
        Dim Adapter As New System.Data.OleDb.OleDbDataAdapter

        'Adapter(CommandText, ConnectionString)

        '▼データの読み込み
        Dim Table As New DataTable()
        Adapter.Fill(Table)

        '▼データソースを設定してDataGridViewにデータを表示
        Dim BindingSource1 As New BindingSource

        BindingSource1.DataSource = Table
        DGView.DataSource = BindingSource1

    End Sub

End Class

