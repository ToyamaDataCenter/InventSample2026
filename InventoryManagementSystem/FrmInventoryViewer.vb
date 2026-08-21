Public Class FrmInventoryViewer

    ''' <summary>
    ''' 追加済データの登録／未登録
    ''' </summary>
    Private fpIsRegisted As Boolean = True

    ''' <summary>
    ''' 画面へ表示する内容を保持するデータテーブル
    ''' </summary>
    Private fpInventoryDataTable As New DataTable

    ''' <summary>
    ''' 在庫データ接続クラス
    ''' </summary>
    Private fpInventoryAdapter As New ClsInventoryAdapter

    ''' <summary>
    ''' データグリッドビュー上の列インデックス
    ''' </summary>
    Private Enum InvGridColumns
        vSyoriKubun
        vHinmei
        vSuuryou
        vTani
        vKingaku
        vTantousya
        vBikou
        vSyoriDateTime

    End Enum


    ''' <summary>
    ''' フォーム開始時イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmInventoryInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 検索条件をリセットする
        Me.ClearInput()

    End Sub


    ''' <summary>
    ''' 検索ボタンイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        ' DBより最新の在庫データを取り込む
        Me.fpInventoryDataTable = fpInventoryAdapter.FillInventoryLog()


        '' 在庫データを検索条件に従い絞り込む
        Dim wViewDataRows As IEnumerable(Of DataRow) =
            (From
                 _dataRow In Me.fpInventoryDataTable
             Where
                 _dataRow.Field(Of String)("Tantousya") = Me.TxtTantou.Text.Trim And
                 _dataRow.Field(Of DateTime)("SyoriDateTime").Date = Me.DtpInputDate.Value.Date And
                 _dataRow.Field(Of String)("SyoriKubun") = {"1", "2"}(Me.CmbInputType.SelectedIndex))

        '' 検索結果を画面へ表示する
        Dim wRowCount As Integer = wViewDataRows.Count
        If (wRowCount = 0) Then
            MessageBox.Show(Me, "・検索条件に合致するデータがありません" & vbCrLf,
                            Me.Text,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1)
            Return ''処理から抜ける

        End If

        Me.DgvInventory.RowCount = wRowCount ' データグリッドの行数を設定


        For _dtIdx As Integer = 0 To wRowCount - 1
            Dim wDataRow As DataRow = wViewDataRows(_dtIdx)

            '' 在庫データを成型してグリッドへ設定する
            Me.DgvInventory.Item(InvGridColumns.vSyoriKubun, _dtIdx).Value =
                If(wDataRow.Field(Of String)("SyoriKubun") = "1", "入庫", "出庫")
            Me.DgvInventory.Item(InvGridColumns.vHinmei, _dtIdx).Value = wDataRow.Field(Of String)("Hinmei")
            Me.DgvInventory.Item(InvGridColumns.vSuuryou, _dtIdx).Value = wDataRow.Field(Of Integer)("Suuryou")
            Me.DgvInventory.Item(InvGridColumns.vTani, _dtIdx).Value = wDataRow.Field(Of String)("Tani")
            Me.DgvInventory.Item(InvGridColumns.vKingaku, _dtIdx).Value = wDataRow.Field(Of Integer)("Kingaku")
            Me.DgvInventory.Item(InvGridColumns.vTantousya, _dtIdx).Value = wDataRow.Field(Of String)("Tantousya")
            Me.DgvInventory.Item(InvGridColumns.vBikou, _dtIdx).Value = wDataRow.Field(Of String)("Bikou")
            Me.DgvInventory.Item(InvGridColumns.vSyoriDateTime, _dtIdx).Value = wDataRow.Field(Of DateTime)("SyoriDatetime").ToString("yy/MM/dd HH:mm")

        Next

    End Sub


    ''' <summary>
    ''' 終了ボタンイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()

    End Sub


    ''' <summary>
    ''' 入力データのクリア
    ''' </summary>
    Private Sub ClearInput()
        Me.TxtTantou.Clear()
        Me.CmbInputType.SelectedIndex = 0
        Me.TxtHinmei.Clear()
        Me.TxtBikou.Clear()
    End Sub

End Class