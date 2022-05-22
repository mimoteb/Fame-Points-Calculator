<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblClanRank = New System.Windows.Forms.Label()
        Me.lblClanFamePoints = New System.Windows.Forms.Label()
        Me.lblBattlesPlayed = New System.Windows.Forms.Label()
        Me.lblFamePoints = New System.Windows.Forms.Label()
        Me.lblLive11500Cut = New System.Windows.Forms.Label()
        Me.lblLive8000Cut = New System.Windows.Forms.Label()
        Me.lblLive4000Cut = New System.Windows.Forms.Label()
        Me.lblLiveGMCut = New System.Windows.Forms.Label()
        Me.btnGet = New System.Windows.Forms.Button()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.dataX = New System.Windows.Forms.DataGridView()
        Me.clnDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnRank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnDiff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnGrowth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnAVGow = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnfront = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnserver = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblAVGGROW = New System.Windows.Forms.Label()
        Me.extable = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboServer = New System.Windows.Forms.ComboBox()
        Me.cboFront = New System.Windows.Forms.ComboBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dataX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.extable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnUpdate)
        Me.GroupBox3.Controls.Add(Me.lblClanRank)
        Me.GroupBox3.Controls.Add(Me.lblClanFamePoints)
        Me.GroupBox3.Controls.Add(Me.lblBattlesPlayed)
        Me.GroupBox3.Controls.Add(Me.lblFamePoints)
        Me.GroupBox3.Controls.Add(Me.lblLive11500Cut)
        Me.GroupBox3.Controls.Add(Me.lblLive8000Cut)
        Me.GroupBox3.Controls.Add(Me.lblLive4000Cut)
        Me.GroupBox3.Controls.Add(Me.lblLiveGMCut)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(772, 100)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Live Updates"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(691, 22)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblClanRank
        '
        Me.lblClanRank.AutoSize = True
        Me.lblClanRank.Location = New System.Drawing.Point(623, 68)
        Me.lblClanRank.Name = "lblClanRank"
        Me.lblClanRank.Size = New System.Drawing.Size(88, 15)
        Me.lblClanRank.TabIndex = 9
        Me.lblClanRank.Text = "Clan's Position:"
        '
        'lblClanFamePoints
        '
        Me.lblClanFamePoints.AutoSize = True
        Me.lblClanFamePoints.Location = New System.Drawing.Point(469, 68)
        Me.lblClanFamePoints.Name = "lblClanFamePoints"
        Me.lblClanFamePoints.Size = New System.Drawing.Size(102, 15)
        Me.lblClanFamePoints.TabIndex = 8
        Me.lblClanFamePoints.Text = "Clan Fame Points:"
        '
        'lblBattlesPlayed
        '
        Me.lblBattlesPlayed.AutoSize = True
        Me.lblBattlesPlayed.Location = New System.Drawing.Point(179, 68)
        Me.lblBattlesPlayed.Name = "lblBattlesPlayed"
        Me.lblBattlesPlayed.Size = New System.Drawing.Size(80, 15)
        Me.lblBattlesPlayed.TabIndex = 7
        Me.lblBattlesPlayed.Text = "Battles Played"
        '
        'lblFamePoints
        '
        Me.lblFamePoints.AutoSize = True
        Me.lblFamePoints.Location = New System.Drawing.Point(279, 33)
        Me.lblFamePoints.Name = "lblFamePoints"
        Me.lblFamePoints.Size = New System.Drawing.Size(75, 15)
        Me.lblFamePoints.TabIndex = 6
        Me.lblFamePoints.Text = "Fame Points:"
        '
        'lblLive11500Cut
        '
        Me.lblLive11500Cut.AutoSize = True
        Me.lblLive11500Cut.Location = New System.Drawing.Point(311, 68)
        Me.lblLive11500Cut.Name = "lblLive11500Cut"
        Me.lblLive11500Cut.Size = New System.Drawing.Size(104, 15)
        Me.lblLive11500Cut.TabIndex = 1
        Me.lblLive11500Cut.Text = "Rank 11500 (Tank):"
        '
        'lblLive8000Cut
        '
        Me.lblLive8000Cut.AutoSize = True
        Me.lblLive8000Cut.Location = New System.Drawing.Point(15, 68)
        Me.lblLive8000Cut.Name = "lblLive8000Cut"
        Me.lblLive8000Cut.Size = New System.Drawing.Size(98, 15)
        Me.lblLive8000Cut.TabIndex = 1
        Me.lblLive8000Cut.Text = "Rank 8000 (Tank):"
        '
        'lblLive4000Cut
        '
        Me.lblLive4000Cut.AutoSize = True
        Me.lblLive4000Cut.Location = New System.Drawing.Point(419, 33)
        Me.lblLive4000Cut.Name = "lblLive4000Cut"
        Me.lblLive4000Cut.Size = New System.Drawing.Size(113, 15)
        Me.lblLive4000Cut.TabIndex = 1
        Me.lblLive4000Cut.Text = "Rank 4000 (3D Skin):"
        '
        'lblLiveGMCut
        '
        Me.lblLiveGMCut.AutoSize = True
        Me.lblLiveGMCut.Location = New System.Drawing.Point(15, 33)
        Me.lblLiveGMCut.Name = "lblLiveGMCut"
        Me.lblLiveGMCut.Size = New System.Drawing.Size(176, 15)
        Me.lblLiveGMCut.TabIndex = 0
        Me.lblLiveGMCut.Text = "Top 1% (Legend of Global Map):"
        '
        'btnGet
        '
        Me.btnGet.Location = New System.Drawing.Point(752, 170)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(75, 23)
        Me.btnGet.TabIndex = 12
        Me.btnGet.Text = "Get"
        Me.btnGet.UseVisualStyleBackColor = True
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(752, 199)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(75, 23)
        Me.btnSet.TabIndex = 12
        Me.btnSet.Text = "Set"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'dataX
        '
        Me.dataX.AllowUserToAddRows = False
        Me.dataX.AllowUserToDeleteRows = False
        Me.dataX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataX.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnDay, Me.clnRank, Me.clnDiff, Me.clnGrowth, Me.clnAVGow, Me.clnfront, Me.clnserver})
        Me.dataX.Location = New System.Drawing.Point(19, 170)
        Me.dataX.Name = "dataX"
        Me.dataX.RowTemplate.Height = 25
        Me.dataX.Size = New System.Drawing.Size(711, 568)
        Me.dataX.TabIndex = 13
        '
        'clnDay
        '
        Me.clnDay.HeaderText = "Day"
        Me.clnDay.Name = "clnDay"
        Me.clnDay.Width = 50
        '
        'clnRank
        '
        Me.clnRank.HeaderText = "Required Points"
        Me.clnRank.Name = "clnRank"
        Me.clnRank.Width = 70
        '
        'clnDiff
        '
        Me.clnDiff.HeaderText = "Diff"
        Me.clnDiff.Name = "clnDiff"
        '
        'clnGrowth
        '
        Me.clnGrowth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clnGrowth.HeaderText = "grow"
        Me.clnGrowth.Name = "clnGrowth"
        Me.clnGrowth.Width = 59
        '
        'clnAVGow
        '
        Me.clnAVGow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clnAVGow.HeaderText = "avg"
        Me.clnAVGow.Name = "clnAVGow"
        Me.clnAVGow.Width = 51
        '
        'clnfront
        '
        Me.clnfront.HeaderText = "front"
        Me.clnfront.Name = "clnfront"
        '
        'clnserver
        '
        Me.clnserver.HeaderText = "server"
        Me.clnserver.Name = "clnserver"
        '
        'lblAVGGROW
        '
        Me.lblAVGGROW.AutoSize = True
        Me.lblAVGGROW.Location = New System.Drawing.Point(752, 225)
        Me.lblAVGGROW.Name = "lblAVGGROW"
        Me.lblAVGGROW.Size = New System.Drawing.Size(41, 15)
        Me.lblAVGGROW.TabIndex = 14
        Me.lblAVGGROW.Text = "Label1"
        '
        'extable
        '
        Me.extable.AllowUserToAddRows = False
        Me.extable.AllowUserToDeleteRows = False
        Me.extable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.extable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.extable.Location = New System.Drawing.Point(752, 363)
        Me.extable.Name = "extable"
        Me.extable.RowTemplate.Height = 25
        Me.extable.Size = New System.Drawing.Size(171, 375)
        Me.extable.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Day"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Required Points"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(752, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 40)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Expectations"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Server:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Front:"
        '
        'cboServer
        '
        Me.cboServer.FormattingEnabled = True
        Me.cboServer.Items.AddRange(New Object() {"eu", "ru", "na", "asia"})
        Me.cboServer.Location = New System.Drawing.Point(67, 141)
        Me.cboServer.Name = "cboServer"
        Me.cboServer.Size = New System.Drawing.Size(66, 23)
        Me.cboServer.TabIndex = 18
        '
        'cboFront
        '
        Me.cboFront.FormattingEnabled = True
        Me.cboFront.Items.AddRange(New Object() {"renaissance_bg", "metal_wars", "thunderstorm_bg"})
        Me.cboFront.Location = New System.Drawing.Point(198, 141)
        Me.cboFront.Name = "cboFront"
        Me.cboFront.Size = New System.Drawing.Size(123, 23)
        Me.cboFront.TabIndex = 19
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 748)
        Me.Controls.Add(Me.cboFront)
        Me.Controls.Add(Me.cboServer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.extable)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAVGGROW)
        Me.Controls.Add(Me.dataX)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.btnGet)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "MainForm"
        Me.Text = "Fame Points Calculator"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dataX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.extable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents clnAccount As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblLive8000Cut As Label
    Friend WithEvents lblLive4000Cut As Label
    Friend WithEvents lblLiveGMCut As Label
    Friend WithEvents lblLive11500Cut As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblClanRank As Label
    Friend WithEvents lblClanFamePoints As Label
    Friend WithEvents lblBattlesPlayed As Label
    Friend WithEvents lblFamePoints As Label
    Friend WithEvents btnGet As Button
    Friend WithEvents btnSet As Button
    Friend WithEvents dataX As DataGridView
    Friend WithEvents lblAVGGROW As Label
    Friend WithEvents extable As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboServer As ComboBox
    Friend WithEvents cboFront As ComboBox
    Friend WithEvents clnDay As DataGridViewTextBoxColumn
    Friend WithEvents clnRank As DataGridViewTextBoxColumn
    Friend WithEvents clnDiff As DataGridViewTextBoxColumn
    Friend WithEvents clnGrowth As DataGridViewTextBoxColumn
    Friend WithEvents clnAVGow As DataGridViewTextBoxColumn
    Friend WithEvents clnfront As DataGridViewTextBoxColumn
    Friend WithEvents clnserver As DataGridViewTextBoxColumn
End Class
