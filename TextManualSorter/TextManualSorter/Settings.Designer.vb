<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.gb_Separator = New System.Windows.Forms.GroupBox()
        Me.opt_None = New System.Windows.Forms.RadioButton()
        Me.opt_Tag2 = New System.Windows.Forms.RadioButton()
        Me.opt_Tag = New System.Windows.Forms.RadioButton()
        Me.chk_WriteFileName = New System.Windows.Forms.CheckBox()
        Me.tb_h = New System.Windows.Forms.TrackBar()
        Me.btn__Ok = New System.Windows.Forms.Button()
        Me.gb_Separator.SuspendLayout()
        CType(Me.tb_h, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_Separator
        '
        Me.gb_Separator.Controls.Add(Me.opt_None)
        Me.gb_Separator.Controls.Add(Me.opt_Tag2)
        Me.gb_Separator.Controls.Add(Me.opt_Tag)
        Me.gb_Separator.Location = New System.Drawing.Point(12, 7)
        Me.gb_Separator.Name = "gb_Separator"
        Me.gb_Separator.Size = New System.Drawing.Size(560, 99)
        Me.gb_Separator.TabIndex = 0
        Me.gb_Separator.TabStop = False
        Me.gb_Separator.Text = "セパレータ"
        '
        'opt_None
        '
        Me.opt_None.AutoSize = True
        Me.opt_None.Location = New System.Drawing.Point(7, 65)
        Me.opt_None.Name = "opt_None"
        Me.opt_None.Size = New System.Drawing.Size(42, 16)
        Me.opt_None.TabIndex = 2
        Me.opt_None.TabStop = True
        Me.opt_None.Text = "なし"
        Me.opt_None.UseVisualStyleBackColor = True
        '
        'opt_Tag2
        '
        Me.opt_Tag2.AutoSize = True
        Me.opt_Tag2.Location = New System.Drawing.Point(7, 42)
        Me.opt_Tag2.Name = "opt_Tag2"
        Me.opt_Tag2.Size = New System.Drawing.Size(191, 16)
        Me.opt_Tag2.TabIndex = 1
        Me.opt_Tag2.TabStop = True
        Me.opt_Tag2.Text = "<p> <br /> </p> <p> <br /> </p>"
        Me.opt_Tag2.UseVisualStyleBackColor = True
        '
        'opt_Tag
        '
        Me.opt_Tag.AutoSize = True
        Me.opt_Tag.Location = New System.Drawing.Point(7, 19)
        Me.opt_Tag.Name = "opt_Tag"
        Me.opt_Tag.Size = New System.Drawing.Size(105, 16)
        Me.opt_Tag.TabIndex = 0
        Me.opt_Tag.TabStop = True
        Me.opt_Tag.Text = "<p> <br /> </p>"
        Me.opt_Tag.UseVisualStyleBackColor = True
        '
        'chk_WriteFileName
        '
        Me.chk_WriteFileName.AutoSize = True
        Me.chk_WriteFileName.Location = New System.Drawing.Point(12, 112)
        Me.chk_WriteFileName.Name = "chk_WriteFileName"
        Me.chk_WriteFileName.Size = New System.Drawing.Size(156, 16)
        Me.chk_WriteFileName.TabIndex = 1
        Me.chk_WriteFileName.Text = "ファイル名を見出しとして書く"
        Me.chk_WriteFileName.UseVisualStyleBackColor = True
        '
        'tb_h
        '
        Me.tb_h.Location = New System.Drawing.Point(176, 112)
        Me.tb_h.Maximum = 6
        Me.tb_h.Minimum = 1
        Me.tb_h.Name = "tb_h"
        Me.tb_h.Size = New System.Drawing.Size(186, 45)
        Me.tb_h.TabIndex = 2
        Me.tb_h.Value = 1
        '
        'btn__Ok
        '
        Me.btn__Ok.Location = New System.Drawing.Point(12, 219)
        Me.btn__Ok.Name = "btn__Ok"
        Me.btn__Ok.Size = New System.Drawing.Size(560, 30)
        Me.btn__Ok.TabIndex = 3
        Me.btn__Ok.Text = "O K"
        Me.btn__Ok.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 261)
        Me.Controls.Add(Me.btn__Ok)
        Me.Controls.Add(Me.tb_h)
        Me.Controls.Add(Me.chk_WriteFileName)
        Me.Controls.Add(Me.gb_Separator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settings"
        Me.Text = "設定"
        Me.gb_Separator.ResumeLayout(False)
        Me.gb_Separator.PerformLayout()
        CType(Me.tb_h, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb_Separator As System.Windows.Forms.GroupBox
    Friend WithEvents opt_Tag As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Tag2 As System.Windows.Forms.RadioButton
    Friend WithEvents opt_None As System.Windows.Forms.RadioButton
    Friend WithEvents chk_WriteFileName As System.Windows.Forms.CheckBox
    Friend WithEvents tb_h As System.Windows.Forms.TrackBar
    Friend WithEvents btn__Ok As System.Windows.Forms.Button
End Class
