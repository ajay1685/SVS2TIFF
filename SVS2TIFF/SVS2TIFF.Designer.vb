<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SVS2TIFF
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SVS2TIFF))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Btn_cancel = New System.Windows.Forms.Button()
        Me.CB_ProcessAll = New System.Windows.Forms.CheckBox()
        Me.Btn_info = New System.Windows.Forms.Button()
        Me.OutPut = New System.Windows.Forms.TextBox()
        Me.pBar_main = New System.Windows.Forms.ProgressBar()
        Me.Btn_convert = New System.Windows.Forms.Button()
        Me.Btn_selectfile = New System.Windows.Forms.Button()
        Me.TextBoxFileName = New System.Windows.Forms.TextBox()
        Me.Btn_clear = New System.Windows.Forms.Button()
        Me.Btn_test = New System.Windows.Forms.Button()
        Me.Chk_ometiff = New System.Windows.Forms.CheckBox()
        Me.Cbx_compression = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chk_bigtiff = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Btn_cancel
        '
        Me.Btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_cancel.Location = New System.Drawing.Point(428, 457)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.Btn_cancel.TabIndex = 18
        Me.Btn_cancel.Text = "Cancel"
        Me.Btn_cancel.UseVisualStyleBackColor = True
        '
        'CB_ProcessAll
        '
        Me.CB_ProcessAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CB_ProcessAll.AutoSize = True
        Me.CB_ProcessAll.Location = New System.Drawing.Point(26, 426)
        Me.CB_ProcessAll.Name = "CB_ProcessAll"
        Me.CB_ProcessAll.Size = New System.Drawing.Size(226, 17)
        Me.CB_ProcessAll.TabIndex = 17
        Me.CB_ProcessAll.Text = "Process all SVS && SCN files from the folder"
        Me.CB_ProcessAll.UseVisualStyleBackColor = True
        '
        'Btn_info
        '
        Me.Btn_info.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_info.Location = New System.Drawing.Point(423, 113)
        Me.Btn_info.Name = "Btn_info"
        Me.Btn_info.Size = New System.Drawing.Size(75, 23)
        Me.Btn_info.TabIndex = 16
        Me.Btn_info.Text = "Info"
        Me.Btn_info.UseVisualStyleBackColor = True
        '
        'OutPut
        '
        Me.OutPut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutPut.Location = New System.Drawing.Point(26, 113)
        Me.OutPut.Multiline = True
        Me.OutPut.Name = "OutPut"
        Me.OutPut.ReadOnly = True
        Me.OutPut.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.OutPut.Size = New System.Drawing.Size(373, 228)
        Me.OutPut.TabIndex = 15
        '
        'pBar_main
        '
        Me.pBar_main.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pBar_main.Location = New System.Drawing.Point(26, 367)
        Me.pBar_main.Name = "pBar_main"
        Me.pBar_main.Size = New System.Drawing.Size(373, 18)
        Me.pBar_main.TabIndex = 14
        '
        'Btn_convert
        '
        Me.Btn_convert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_convert.Location = New System.Drawing.Point(327, 457)
        Me.Btn_convert.Name = "Btn_convert"
        Me.Btn_convert.Size = New System.Drawing.Size(75, 23)
        Me.Btn_convert.TabIndex = 13
        Me.Btn_convert.Text = "Convert"
        Me.Btn_convert.UseVisualStyleBackColor = True
        '
        'Btn_selectfile
        '
        Me.Btn_selectfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_selectfile.Location = New System.Drawing.Point(423, 60)
        Me.Btn_selectfile.Name = "Btn_selectfile"
        Me.Btn_selectfile.Size = New System.Drawing.Size(75, 23)
        Me.Btn_selectfile.TabIndex = 12
        Me.Btn_selectfile.Text = "Select File"
        Me.Btn_selectfile.UseVisualStyleBackColor = True
        '
        'TextBoxFileName
        '
        Me.TextBoxFileName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxFileName.Location = New System.Drawing.Point(26, 60)
        Me.TextBoxFileName.Name = "TextBoxFileName"
        Me.TextBoxFileName.Size = New System.Drawing.Size(372, 20)
        Me.TextBoxFileName.TabIndex = 11
        '
        'Btn_clear
        '
        Me.Btn_clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_clear.Location = New System.Drawing.Point(423, 152)
        Me.Btn_clear.Name = "Btn_clear"
        Me.Btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.Btn_clear.TabIndex = 19
        Me.Btn_clear.Text = "Clear"
        Me.Btn_clear.UseVisualStyleBackColor = True
        '
        'Btn_test
        '
        Me.Btn_test.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_test.Location = New System.Drawing.Point(423, 191)
        Me.Btn_test.Name = "Btn_test"
        Me.Btn_test.Size = New System.Drawing.Size(75, 23)
        Me.Btn_test.TabIndex = 20
        Me.Btn_test.Text = "Test"
        Me.Btn_test.UseVisualStyleBackColor = True
        Me.Btn_test.Visible = False
        '
        'Chk_ometiff
        '
        Me.Chk_ometiff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Chk_ometiff.AutoSize = True
        Me.Chk_ometiff.Location = New System.Drawing.Point(26, 401)
        Me.Chk_ometiff.Name = "Chk_ometiff"
        Me.Chk_ometiff.Size = New System.Drawing.Size(103, 17)
        Me.Chk_ometiff.TabIndex = 21
        Me.Chk_ometiff.Text = "Write OME-TIFF"
        Me.Chk_ometiff.UseVisualStyleBackColor = True
        '
        'Cbx_compression
        '
        Me.Cbx_compression.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cbx_compression.FormattingEnabled = True
        Me.Cbx_compression.Location = New System.Drawing.Point(214, 457)
        Me.Cbx_compression.Name = "Cbx_compression"
        Me.Cbx_compression.Size = New System.Drawing.Size(96, 21)
        Me.Cbx_compression.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 461)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Compression:"
        '
        'Chk_bigtiff
        '
        Me.Chk_bigtiff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Chk_bigtiff.AutoSize = True
        Me.Chk_bigtiff.Location = New System.Drawing.Point(141, 401)
        Me.Chk_bigtiff.Name = "Chk_bigtiff"
        Me.Chk_bigtiff.Size = New System.Drawing.Size(91, 17)
        Me.Chk_bigtiff.TabIndex = 24
        Me.Chk_bigtiff.Text = "Write BigTIFF"
        Me.Chk_bigtiff.UseVisualStyleBackColor = True
        '
        'SVS2TIFF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 512)
        Me.Controls.Add(Me.Chk_bigtiff)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cbx_compression)
        Me.Controls.Add(Me.Chk_ometiff)
        Me.Controls.Add(Me.Btn_test)
        Me.Controls.Add(Me.Btn_clear)
        Me.Controls.Add(Me.Btn_cancel)
        Me.Controls.Add(Me.CB_ProcessAll)
        Me.Controls.Add(Me.Btn_info)
        Me.Controls.Add(Me.OutPut)
        Me.Controls.Add(Me.pBar_main)
        Me.Controls.Add(Me.Btn_convert)
        Me.Controls.Add(Me.Btn_selectfile)
        Me.Controls.Add(Me.TextBoxFileName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(545, 551)
        Me.Name = "SVS2TIFF"
        Me.Text = "SVS2TIFF: Slide scanner file converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Btn_cancel As Button
    Friend WithEvents CB_ProcessAll As CheckBox
    Friend WithEvents Btn_info As Button
    Friend WithEvents OutPut As TextBox
    Friend WithEvents pBar_main As ProgressBar
    Friend WithEvents Btn_convert As Button
    Friend WithEvents Btn_selectfile As Button
    Friend WithEvents TextBoxFileName As TextBox
    Friend WithEvents Btn_clear As Button
    Friend WithEvents Btn_test As Button
    Friend WithEvents Chk_ometiff As CheckBox
    Friend WithEvents Cbx_compression As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Chk_bigtiff As CheckBox
End Class
