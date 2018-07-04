<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParentForm))
        Me.mnustr = New System.Windows.Forms.MenuStrip()
        Me.mnu_Open_Folder = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Output = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Save_Locations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Reset_Locations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Sort_Col_1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Sort_Col_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Sort_Col_3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Sort_Col_4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Sort_Col_5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Version = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnustr.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnustr
        '
        Me.mnustr.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnustr.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Open_Folder, Me.mnu_Output, Me.mnu_Save_Locations, Me.mnu_Reset_Locations, Me.mnu_Version})
        Me.mnustr.Location = New System.Drawing.Point(0, 0)
        Me.mnustr.Name = "mnustr"
        Me.mnustr.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.mnustr.Size = New System.Drawing.Size(1312, 28)
        Me.mnustr.TabIndex = 1
        Me.mnustr.Text = "MenuStrip1"
        '
        'mnu_Open_Folder
        '
        Me.mnu_Open_Folder.Name = "mnu_Open_Folder"
        Me.mnu_Open_Folder.Size = New System.Drawing.Size(89, 24)
        Me.mnu_Open_Folder.Text = "フォルダ開く"
        '
        'mnu_Output
        '
        Me.mnu_Output.Name = "mnu_Output"
        Me.mnu_Output.Size = New System.Drawing.Size(123, 24)
        Me.mnu_Output.Text = "連結ファイル出力"
        '
        'mnu_Save_Locations
        '
        Me.mnu_Save_Locations.Name = "mnu_Save_Locations"
        Me.mnu_Save_Locations.Size = New System.Drawing.Size(81, 24)
        Me.mnu_Save_Locations.Text = "位置保存"
        '
        'mnu_Reset_Locations
        '
        Me.mnu_Reset_Locations.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Sort_Col_1, Me.mnu_Sort_Col_2, Me.mnu_Sort_Col_3, Me.mnu_Sort_Col_4, Me.mnu_Sort_Col_5})
        Me.mnu_Reset_Locations.Name = "mnu_Reset_Locations"
        Me.mnu_Reset_Locations.Size = New System.Drawing.Size(51, 24)
        Me.mnu_Reset_Locations.Text = "整列"
        '
        'mnu_Sort_Col_1
        '
        Me.mnu_Sort_Col_1.Name = "mnu_Sort_Col_1"
        Me.mnu_Sort_Col_1.Size = New System.Drawing.Size(129, 26)
        Me.mnu_Sort_Col_1.Text = "列数１"
        '
        'mnu_Sort_Col_2
        '
        Me.mnu_Sort_Col_2.Name = "mnu_Sort_Col_2"
        Me.mnu_Sort_Col_2.Size = New System.Drawing.Size(129, 26)
        Me.mnu_Sort_Col_2.Text = "列数２"
        '
        'mnu_Sort_Col_3
        '
        Me.mnu_Sort_Col_3.Name = "mnu_Sort_Col_3"
        Me.mnu_Sort_Col_3.Size = New System.Drawing.Size(129, 26)
        Me.mnu_Sort_Col_3.Text = "列数３"
        '
        'mnu_Sort_Col_4
        '
        Me.mnu_Sort_Col_4.Name = "mnu_Sort_Col_4"
        Me.mnu_Sort_Col_4.Size = New System.Drawing.Size(129, 26)
        Me.mnu_Sort_Col_4.Text = "列数４"
        '
        'mnu_Sort_Col_5
        '
        Me.mnu_Sort_Col_5.Name = "mnu_Sort_Col_5"
        Me.mnu_Sort_Col_5.Size = New System.Drawing.Size(129, 26)
        Me.mnu_Sort_Col_5.Text = "列数５"
        '
        'mnu_Version
        '
        Me.mnu_Version.Name = "mnu_Version"
        Me.mnu_Version.Size = New System.Drawing.Size(105, 24)
        Me.mnu_Version.Text = "バージョン情報"
        '
        'ParentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 576)
        Me.Controls.Add(Me.mnustr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnustr
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ParentForm"
        Me.Text = "テキストファイル手動ソートくん"
        Me.mnustr.ResumeLayout(False)
        Me.mnustr.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnustr As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_Open_Folder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Output As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Save_Locations As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Reset_Locations As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Sort_Col_1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Sort_Col_2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Sort_Col_3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Sort_Col_4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Sort_Col_5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Version As System.Windows.Forms.ToolStripMenuItem

End Class
