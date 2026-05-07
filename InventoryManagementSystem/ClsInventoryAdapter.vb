Imports System.Text
Imports System.Transactions
Imports Microsoft.Data.SqlClient

Public Class ClsInventoryAdapter

    Private mConnectionStringBuilder As SqlConnectionStringBuilder

    Public Sub New()
        Me.mConnectionStringBuilder =
            New SqlConnectionStringBuilder(My.Settings.ConnectionString)
    End Sub

    Private ReadOnly Property ConnectionString As String
        Get
            Return Me.mConnectionStringBuilder.ConnectionString
        End Get
    End Property

    Public Function FillInventoryLog() As DataTable

        Dim wNewDataTable As New DataTable

        Using wConnection = New SqlConnection(Me.ConnectionString)
            Try

                wConnection.Open()

                Using wDataAdapter As New SqlDataAdapter


                    wDataAdapter.SelectCommand = New SqlCommand("select * from InventoryLog", wConnection)

                    wDataAdapter.Fill(wNewDataTable)

                End Using


                wConnection.Close()

            Catch ex As Exception
                MessageBox.Show("データの取得に失敗しました。" & vbCrLf & ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Throw

            End Try
        End Using


        Return wNewDataTable

    End Function

    ''' <summary>
    ''' データベースに追加する
    ''' </summary>
    ''' <returns>更新件数</returns>
    Public Function InsertInventoryLog(ByVal wUpdateDataTable As DataTable) As Integer

        Dim wUpdateCount As Integer = 0

        Dim wSblInsetCommant As New StringBuilder

        Dim wInputColumnName As IEnumerable(Of String) =
                    {
                        "SyoriKubun",
                        "Hinmei",
                        "Suuryou",
                        "Tani",
                        "Kingaku",
                        "Tantousya",
                        "Bikou",
                        "SyoriDateTime"
                    }

        ' SQLインジェクションについて考慮の必要があるが割愛
        With wSblInsetCommant
            .Length = 0

            .Append("insert into InventoryLog values( ")
            .Append(String.Join(" ,", wInputColumnName.Select(Function(_columnName) "@" & _columnName)))
            .Append("  , getdate() ")
            .Append("  , getdate() ")
            .Append(")")

        End With

        Using wConnection = New SqlConnection(Me.ConnectionString)
            wConnection.Open()

            Dim wTransaction As SqlTransaction = wConnection.BeginTransaction()

            Try
                For Each _row As DataRow In wUpdateDataTable.Rows
                    If (_row.RowState = DataRowState.Added) Then
                        Dim wNewInsertCommand As New SqlCommand(wSblInsetCommant.ToString(),
                                                                wConnection,
                                                                wTransaction)
                        For Each _columnName In wInputColumnName
                            wNewInsertCommand.Parameters.AddWithValue("@" & _columnName, _row.Item(_columnName))
                        Next

                        wNewInsertCommand.ExecuteNonQuery()
                        wUpdateCount += 1
                    End If
                Next

                wTransaction.Commit()

            Catch ex As Exception
                wTransaction.Rollback()
                Throw ex

            Finally
                wConnection.Close()

            End Try


        End Using


        Return wUpdateCount

    End Function

End Class
