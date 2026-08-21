<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInventoryInput
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventoryInput))
        SplitContainer1 = New SplitContainer()
        CmbInputType = New ComboBox()
        NumKingaku = New NumericUpDown()
        NumSuryou = New NumericUpDown()
        Label7 = New Label()
        DtpInputDate = New DateTimePicker()
        Label3 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TxtTantou = New TextBox()
        TxtBikou = New TextBox()
        TxtTani = New TextBox()
        TxtHinmei = New TextBox()
        BtnAdd = New Button()
        Label8 = New Label()
        SplitContainer2 = New SplitContainer()
        BtnRegist = New Button()
        BtnExit = New Button()
        DgvInventory = New DataGridView()
        vSyoriKubun = New DataGridViewTextBoxColumn()
        vHinmei = New DataGridViewTextBoxColumn()
        vSuuryou = New DataGridViewTextBoxColumn()
        vTani = New DataGridViewTextBoxColumn()
        vKingaku = New DataGridViewTextBoxColumn()
        vTantousya = New DataGridViewTextBoxColumn()
        vBikou = New DataGridViewTextBoxColumn()
        vSyoriDateTime = New DataGridViewTextBoxColumn()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(NumKingaku, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumSuryou, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        CType(DgvInventory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.FixedPanel = FixedPanel.Panel1
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Margin = New Padding(3, 4, 3, 4)
        SplitContainer1.Name = "SplitContainer1"
        SplitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(CmbInputType)
        SplitContainer1.Panel1.Controls.Add(NumKingaku)
        SplitContainer1.Panel1.Controls.Add(NumSuryou)
        SplitContainer1.Panel1.Controls.Add(Label7)
        SplitContainer1.Panel1.Controls.Add(DtpInputDate)
        SplitContainer1.Panel1.Controls.Add(Label3)
        SplitContainer1.Panel1.Controls.Add(Label5)
        SplitContainer1.Panel1.Controls.Add(Label4)
        SplitContainer1.Panel1.Controls.Add(Label6)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Panel1.Controls.Add(Label1)
        SplitContainer1.Panel1.Controls.Add(TxtTantou)
        SplitContainer1.Panel1.Controls.Add(TxtBikou)
        SplitContainer1.Panel1.Controls.Add(TxtTani)
        SplitContainer1.Panel1.Controls.Add(TxtHinmei)
        SplitContainer1.Panel1.Controls.Add(BtnAdd)
        SplitContainer1.Panel1.Controls.Add(Label8)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(SplitContainer2)
        SplitContainer1.Size = New Size(933, 816)
        SplitContainer1.SplitterDistance = 281
        SplitContainer1.SplitterWidth = 5
        SplitContainer1.TabIndex = 0
        ' 
        ' CmbInputType
        ' 
        CmbInputType.DropDownStyle = ComboBoxStyle.DropDownList
        CmbInputType.FlatStyle = FlatStyle.System
        CmbInputType.FormattingEnabled = True
        CmbInputType.Items.AddRange(New Object() {"入庫", "出庫"})
        CmbInputType.Location = New Point(83, 55)
        CmbInputType.Margin = New Padding(3, 4, 3, 4)
        CmbInputType.Name = "CmbInputType"
        CmbInputType.Size = New Size(138, 28)
        CmbInputType.TabIndex = 5
        ' 
        ' NumKingaku
        ' 
        NumKingaku.Location = New Point(553, 93)
        NumKingaku.Margin = New Padding(3, 4, 3, 4)
        NumKingaku.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        NumKingaku.Name = "NumKingaku"
        NumKingaku.Size = New Size(98, 27)
        NumKingaku.TabIndex = 13
        NumKingaku.ThousandsSeparator = True
        NumKingaku.Value = New Decimal(New Integer() {999999999, 0, 0, 0})
        ' 
        ' NumSuryou
        ' 
        NumSuryou.DecimalPlaces = 2
        NumSuryou.Location = New Point(251, 93)
        NumSuryou.Margin = New Padding(3, 4, 3, 4)
        NumSuryou.Maximum = New Decimal(New Integer() {9999999, 0, 0, 131072})
        NumSuryou.Name = "NumSuryou"
        NumSuryou.Size = New Size(80, 27)
        NumSuryou.TabIndex = 9
        NumSuryou.ThousandsSeparator = True
        NumSuryou.Value = New Decimal(New Integer() {999999, 0, 0, 131072})
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(518, 99)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 20)
        Label7.TabIndex = 12
        Label7.Text = "金額"
        ' 
        ' DtpInputDate
        ' 
        DtpInputDate.CustomFormat = "yyyy/MM/dd hh:mm"
        DtpInputDate.Format = DateTimePickerFormat.Custom
        DtpInputDate.Location = New Point(286, 16)
        DtpInputDate.Margin = New Padding(3, 4, 3, 4)
        DtpInputDate.Name = "DtpInputDate"
        DtpInputDate.Size = New Size(150, 27)
        DtpInputDate.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(216, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 20)
        Label3.TabIndex = 8
        Label3.Text = "数量"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(216, 21)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 20)
        Label5.TabIndex = 2
        Label5.Text = "処理日時"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(14, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 20)
        Label4.TabIndex = 4
        Label4.Text = "処理区分"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(350, 99)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 20)
        Label6.TabIndex = 10
        Label6.Text = "単位"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(14, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 20)
        Label2.TabIndex = 6
        Label2.Text = "品名"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 20)
        Label1.TabIndex = 0
        Label1.Text = "担当者"
        ' 
        ' TxtTantou
        ' 
        TxtTantou.Location = New Point(83, 16)
        TxtTantou.Margin = New Padding(3, 4, 3, 4)
        TxtTantou.Name = "TxtTantou"
        TxtTantou.Size = New Size(114, 27)
        TxtTantou.TabIndex = 1
        ' 
        ' TxtBikou
        ' 
        TxtBikou.Location = New Point(14, 157)
        TxtBikou.Margin = New Padding(3, 4, 3, 4)
        TxtBikou.MaxLength = 512
        TxtBikou.Multiline = True
        TxtBikou.Name = "TxtBikou"
        TxtBikou.Size = New Size(914, 116)
        TxtBikou.TabIndex = 15
        TxtBikou.Text = resources.GetString("TxtBikou.Text")
        ' 
        ' TxtTani
        ' 
        TxtTani.Location = New Point(385, 93)
        TxtTani.Margin = New Padding(3, 4, 3, 4)
        TxtTani.Name = "TxtTani"
        TxtTani.Size = New Size(114, 27)
        TxtTani.TabIndex = 11
        ' 
        ' TxtHinmei
        ' 
        TxtHinmei.Location = New Point(83, 93)
        TxtHinmei.Margin = New Padding(3, 4, 3, 4)
        TxtHinmei.Name = "TxtHinmei"
        TxtHinmei.Size = New Size(114, 27)
        TxtHinmei.TabIndex = 7
        ' 
        ' BtnAdd
        ' 
        BtnAdd.Location = New Point(762, 101)
        BtnAdd.Margin = New Padding(3, 4, 3, 4)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(166, 48)
        BtnAdd.TabIndex = 16
        BtnAdd.Text = "追加"
        BtnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(14, 133)
        Label8.Name = "Label8"
        Label8.Size = New Size(39, 20)
        Label8.TabIndex = 14
        Label8.Text = "備考"
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Dock = DockStyle.Fill
        SplitContainer2.FixedPanel = FixedPanel.Panel2
        SplitContainer2.Location = New Point(0, 0)
        SplitContainer2.Margin = New Padding(3, 4, 3, 4)
        SplitContainer2.Name = "SplitContainer2"
        SplitContainer2.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(DgvInventory)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.Controls.Add(BtnRegist)
        SplitContainer2.Panel2.Controls.Add(BtnExit)
        SplitContainer2.Panel2MinSize = 38
        SplitContainer2.Size = New Size(933, 530)
        SplitContainer2.SplitterDistance = 459
        SplitContainer2.SplitterWidth = 5
        SplitContainer2.TabIndex = 0
        ' 
        ' BtnRegist
        ' 
        BtnRegist.Dock = DockStyle.Fill
        BtnRegist.Location = New Point(0, 0)
        BtnRegist.Margin = New Padding(3, 4, 3, 4)
        BtnRegist.Name = "BtnRegist"
        BtnRegist.Size = New Size(747, 66)
        BtnRegist.TabIndex = 0
        BtnRegist.Text = "登録"
        BtnRegist.UseVisualStyleBackColor = True
        ' 
        ' BtnExit
        ' 
        BtnExit.Dock = DockStyle.Right
        BtnExit.Location = New Point(747, 0)
        BtnExit.Margin = New Padding(3, 4, 3, 4)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(186, 66)
        BtnExit.TabIndex = 1
        BtnExit.Text = "終了"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' DgvInventory
        ' 
        DgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvInventory.Columns.AddRange(New DataGridViewColumn() {vSyoriKubun, vHinmei, vSuuryou, vTani, vKingaku, vTantousya, vBikou, vSyoriDateTime})
        DgvInventory.Dock = DockStyle.Fill
        DgvInventory.Location = New Point(0, 0)
        DgvInventory.Margin = New Padding(3, 4, 3, 4)
        DgvInventory.Name = "DgvInventory"
        DgvInventory.ReadOnly = True
        DgvInventory.RowHeadersWidth = 51
        DgvInventory.RowTemplate.Height = 25
        DgvInventory.Size = New Size(933, 459)
        DgvInventory.TabIndex = 1
        ' 
        ' vSyoriKubun
        ' 
        vSyoriKubun.HeaderText = "処理区分"
        vSyoriKubun.MinimumWidth = 6
        vSyoriKubun.Name = "vSyoriKubun"
        vSyoriKubun.ReadOnly = True
        vSyoriKubun.Width = 125
        ' 
        ' vHinmei
        ' 
        vHinmei.HeaderText = "品名"
        vHinmei.MinimumWidth = 6
        vHinmei.Name = "vHinmei"
        vHinmei.ReadOnly = True
        vHinmei.Width = 125
        ' 
        ' vSuuryou
        ' 
        vSuuryou.HeaderText = "数量"
        vSuuryou.MinimumWidth = 6
        vSuuryou.Name = "vSuuryou"
        vSuuryou.ReadOnly = True
        vSuuryou.Width = 125
        ' 
        ' vTani
        ' 
        vTani.HeaderText = "単位"
        vTani.MinimumWidth = 6
        vTani.Name = "vTani"
        vTani.ReadOnly = True
        vTani.Width = 125
        ' 
        ' vKingaku
        ' 
        vKingaku.HeaderText = "金額"
        vKingaku.MinimumWidth = 6
        vKingaku.Name = "vKingaku"
        vKingaku.ReadOnly = True
        vKingaku.Width = 125
        ' 
        ' vTantousya
        ' 
        vTantousya.HeaderText = "担当者"
        vTantousya.MinimumWidth = 6
        vTantousya.Name = "vTantousya"
        vTantousya.ReadOnly = True
        vTantousya.Width = 125
        ' 
        ' vBikou
        ' 
        vBikou.HeaderText = "備考"
        vBikou.MinimumWidth = 6
        vBikou.Name = "vBikou"
        vBikou.ReadOnly = True
        vBikou.Width = 125
        ' 
        ' vSyoriDateTime
        ' 
        vSyoriDateTime.HeaderText = "処理日時"
        vSyoriDateTime.MinimumWidth = 6
        vSyoriDateTime.Name = "vSyoriDateTime"
        vSyoriDateTime.ReadOnly = True
        vSyoriDateTime.Width = 125
        ' 
        ' FrmInventoryInput
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(933, 816)
        Controls.Add(SplitContainer1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FrmInventoryInput"
        Text = "FrmInventoryInput"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(NumKingaku, ComponentModel.ISupportInitialize).EndInit()
        CType(NumSuryou, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel2.ResumeLayout(False)
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        CType(DgvInventory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnRegist As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtHinmei As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents DtpInputDate As DateTimePicker
    Friend WithEvents CmbInputType As ComboBox
    Friend WithEvents NumSuryou As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTantou As TextBox
    Friend WithEvents NumKingaku As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtBikou As TextBox
    Friend WithEvents TxtTani As TextBox
    Friend WithEvents DgvInventory As DataGridView
    Friend WithEvents vSyoriKubun As DataGridViewTextBoxColumn
    Friend WithEvents vHinmei As DataGridViewTextBoxColumn
    Friend WithEvents vSuuryou As DataGridViewTextBoxColumn
    Friend WithEvents vTani As DataGridViewTextBoxColumn
    Friend WithEvents vKingaku As DataGridViewTextBoxColumn
    Friend WithEvents vTantousya As DataGridViewTextBoxColumn
    Friend WithEvents vBikou As DataGridViewTextBoxColumn
    Friend WithEvents vSyoriDateTime As DataGridViewTextBoxColumn
End Class
