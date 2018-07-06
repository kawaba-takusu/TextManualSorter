<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChildTextForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChildTextForm))
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Re_Read = New System.Windows.Forms.Button()
        Me.chk_Yuko = New System.Windows.Forms.CheckBox()
        Me.txt_Naiyo = New System.Windows.Forms.TextBox()
        Me.lbl_Locate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(0, 0)
        Me.btn_Save.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(93, 38)
        Me.btn_Save.TabIndex = 0
        Me.btn_Save.Text = "保存"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Re_Read
        '
        Me.btn_Re_Read.Location = New System.Drawing.Point(101, 0)
        Me.btn_Re_Read.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Re_Read.Name = "btn_Re_Read"
        Me.btn_Re_Read.Size = New System.Drawing.Size(100, 38)
        Me.btn_Re_Read.TabIndex = 1
        Me.btn_Re_Read.Text = "読み直し"
        Me.btn_Re_Read.UseVisualStyleBackColor = True
        '
        'chk_Yuko
        '
        Me.chk_Yuko.AutoSize = True
        Me.chk_Yuko.Location = New System.Drawing.Point(209, 11)
        Me.chk_Yuko.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_Yuko.Name = "chk_Yuko"
        Me.chk_Yuko.Size = New System.Drawing.Size(71, 23)
        Me.chk_Yuko.TabIndex = 2
        Me.chk_Yuko.Text = "有効"
        Me.chk_Yuko.UseVisualStyleBackColor = True
        '
        'txt_Naiyo
        '
        Me.txt_Naiyo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Naiyo.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_Naiyo.Location = New System.Drawing.Point(-2, 61)
        Me.txt_Naiyo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Naiyo.MaxLength = 0
        Me.txt_Naiyo.Multiline = True
        Me.txt_Naiyo.Name = "txt_Naiyo"
        Me.txt_Naiyo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Naiyo.Size = New System.Drawing.Size(336, 250)
        Me.txt_Naiyo.TabIndex = 3
        '
        'lbl_Locate
        '
        Me.lbl_Locate.AutoSize = True
        Me.lbl_Locate.Location = New System.Drawing.Point(-3, 42)
        Me.lbl_Locate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Locate.Name = "lbl_Locate"
        Me.lbl_Locate.Size = New System.Drawing.Size(69, 19)
        Me.lbl_Locate.TabIndex = 4
        Me.lbl_Locate.Text = "Label1"
        '
        'ChildTextForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_Locate)
        Me.Controls.Add(Me.txt_Naiyo)
        Me.Controls.Add(Me.chk_Yuko)
        Me.Controls.Add(Me.btn_Re_Read)
        Me.Controls.Add(Me.btn_Save)
        Me.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChildTextForm"
        Me.Text = "KoTextForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_Re_Read As System.Windows.Forms.Button
    Friend WithEvents chk_Yuko As System.Windows.Forms.CheckBox
    Friend WithEvents txt_Naiyo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Locate As System.Windows.Forms.Label
End Class
