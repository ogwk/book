Imports System.Data.OleDb

Public Class frmConnectAccessDB
    '****************************************************
    '*　AccessDB接続
    '****************************************************
    '----------------------------------------------------
    '　変数
    '----------------------------------------------------
    Public strProvider As String
    Public strDataSource As String
    Private DGView As DataGridView
    Private Adapter As OleDbDataAdapter

    Private strSQL As String

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
        '****************************************************
        '*　DB接続先取得
        '****************************************************
        Get
            Adapter = New OleDbDataAdapter(strSQL, dbCon)
            Return strDataSource
        End Get
        Set(value As String)
            strDataSource = value
        End Set
    End Property
    Public Property ProOleDataAdapter() As OleDbDataAdapter
        '****************************************************
        '*　DB接続先取得
        '****************************************************
        Get
            ProOleDataAdapter = New OleDbDataAdapter(strSQL, dbCon)
            Return ProOleDataAdapter
        End Get
        Set(value As OleDbDataAdapter)
            ProOleDataAdapter = value
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

    Public Sub SubConnectAccessDb()
        '****************************************************
        '*　DB接続
        '****************************************************
        'Accessへの接続情報の設定をします。
        Dim builder As OleDbConnectionStringBuilder = New OleDbConnectionStringBuilder()
        Dim strConnection As String

        'Access2007形式のファイルなのでこれを設定します。
        builder.Provider = strProvider
        'Accessファイルへのパスを設定します。
        builder.DataSource = strDataSource

        dbCon = New OleDbConnection(builder.ConnectionString)

        dbCon.Open()
    End Sub
    Public Sub SubDisConnectAccessDb()
        '****************************************************
        '*　DBクローズ
        '***************************************************
        ' ACCESS DB クローズ
        dbCon.Close()
        dbCon.Dispose()

    End Sub
    Public Sub SubRunsql()
        '****************************************************
        '*　SQLを実行する
        '****************************************************
        Dim builder As OleDbConnectionStringBuilder = New OleDbConnectionStringBuilder()

        'Access2007形式のファイルなのでこれを設定します。
        builder.Provider = strProvider
        'Accessファイルへのパスを設定します。
        builder.DataSource = strDataSource
        Using conn As New OleDbConnection(builder.ConnectionString)
            conn.Open()
            'SQL文とコネクションを設定します。
            Using cmd As New OleDbCommand(strSQL, conn)
                cmd.CommandText = strSQL
                'クエリ実行
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    Public Sub ShowDataTable()
        '****************************************************
        '*　DataGridViewにテーブルデータを表示
        '****************************************************
        Dim builder As OleDbConnectionStringBuilder = New OleDbConnectionStringBuilder()
        Dim dt As DataTable

        '接続文字列の作成
        Dim UserID As String = "Admin"
        Dim Password As String = ""

        'Access2007形式のファイルなのでこれを設定します。
        builder.Provider = strProvider
        'Accessファイルへのパスを設定します。
        builder.DataSource = strDataSource

        Using conn As New OleDbConnection(builder.ConnectionString)
            Using cmd As New OleDbCommand(builder.ConnectionString)
                Dim odda As OleDbDataAdapter = New OleDbDataAdapter()
                odda.SelectCommand = cmd
                odda.Fill(dt)
                DGView.DataSource = dt
            End Using
        End Using

    End Sub

    Public Property GetCmbBox() As ComboBox
        '****************************************************
        '*　コンボbox取得
        '****************************************************
        Get
            Return GetCmbBox
        End Get
        Set(value As ComboBox)
            GetCmbBox = value
        End Set
    End Property
    Public Sub ShowCmdBox(cmb As ComboBox, strData1 As String, strData2 As String)
        '****************************************************
        '*　コマンドboxにテーブルデータを表示
        '****************************************************
        Dim Adp As New OleDbDataAdapter

        'データアダプターを生成
        Adp = Me.ProOleDataAdapter

        'データの読み込み
        Dim DataTbl As New DataTable()
        Adp.Fill(DataTbl)

        cmb.DataSource = DataTbl

        '表示される値
        cmb.DisplayMember = strData1 & strData2

        '実際に選択される値
        cmb.ValueMember = strData2

    End Sub
    Public Function GetDataTable() As DataTable
        '****************************************************
        '*　データテーブルに結果を格納する
        '****************************************************
        Dim command As New OleDbCommand
        Dim Adp As New OleDbDataAdapter
        Dim dt As New DataTable

        'データアダプターを生成
        Adp = Me.ProOleDataAdapter

        command.Connection = dbCon
        command.CommandText = strSQL
        Adp.SelectCommand = command

        'SQL実行 結果をデータテーブルに格納
        Adp.Fill(dt)

        GetDataTable = dt

    End Function
End Class

