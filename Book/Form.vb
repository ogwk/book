Public Class ComboBoxEx
    Inherits System.Windows.Forms.ComboBox

    Public ListMember1 As String
    Public ListMember2 As String

    Private Const ListWidth1 As Integer = 200
    Private Const ListWidth2 As Integer = 200

    Public Sub New()

        InitializeComponent()

        Me.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        Me.DropDownWidth = ListWidth1 + ListWidth2 + 20

    End Sub

    Protected Overrides Sub OnDrawItem(ByVal e As System.Windows.Forms.DrawItemEventArgs)

        MyBase.OnDrawItem(e)

        '▼データの内容を取得

        Dim ItemString1 As String
        Dim ItemString2 As String

        If e.Index < 0 Then
            ItemString1 = ""
            ItemString2 = ""
        Else
            ' データソース別項目取得
            Select Case TypeName(Me.Items(e.Index))
                Case "DataRowView"
                    ' DataTableなどの場合
                    Dim Row As DataRowView

                    Row = DirectCast(Me.Items(e.Index), DataRowView)

                    If IsDBNull(Row(ListMember1)) Then
                        ItemString1 = ""
                    Else
                        ItemString1 = Row(ListMember1)
                    End If
                    If IsDBNull(Row(ListMember2)) Then
                        ItemString2 = ""
                    Else
                        ItemString2 = Row(ListMember2)
                    End If
                Case "DictionaryEntry"
                    ' DictionaryEntryなどの場合
                    Dim Row As DictionaryEntry

                    Row = DirectCast(Me.Items(e.Index), DictionaryEntry)

                    ItemString1 = Me.Items(e.Index)(ListMember1)
                    ItemString2 = Me.Items(e.Index)(ListMember2)
                Case Else
                    ItemString1 = ""
                    ItemString2 = ""
            End Select
        End If

        '▼項目と線を描画

        Dim Rect As RectangleF
        Dim myBrush As Brush
        Dim LineLeft As Integer = e.Bounds.X + ListWidth1

        If e.State And DrawItemState.Selected Then
            myBrush = New SolidBrush(Color.White)
        Else
            myBrush = New SolidBrush(Me.ForeColor)
        End If

        '背景
        e.DrawBackground()

        'コード
        Rect = New RectangleF(e.Bounds.X, e.Bounds.Y, LineLeft, e.Bounds.Height)
        e.Graphics.DrawString(ItemString1, e.Font, myBrush, Rect)

        '区切り線
        e.Graphics.DrawLine(Pens.Black, LineLeft, e.Bounds.Y, LineLeft, e.Bounds.Y + e.Bounds.Height)

        '名前
        Rect = New RectangleF(LineLeft + 1, e.Bounds.Y, e.Bounds.Width - LineLeft - 1, e.Bounds.Height)
        e.Graphics.DrawString(ItemString2, e.Font, myBrush, Rect)
        e.DrawFocusRectangle()
        e.Graphics.Flush()

    End Sub
End Class
