Imports System.Xml

Public Class MainForm
    Dim avgGROW As Double
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim RankGM As String = GetPointsCutByRank(610)
        Dim Rank4000 As String = GetPointsCutByRank(4000)
        Dim Rank8000 As String = GetPointsCutByRank(8000)
        Dim Rank11500 As String = GetPointsCutByRank(11500)
        'Battle Log
        lblFamePoints.Text = "Fame Points: "
        lblBattlesPlayed.Text = "Battles Played: "
        lblClanFamePoints.Text = "Clan Fame Points: "
        'live

        lblClanRank.Text = "Clan's Position: "
        lblLiveGMCut.Text = "Top 1% (Legend of Global Map): " & RankGM

        cmd.Parameters.AddWithValue("@RankGM", RankGM)
        cmd.Parameters.AddWithValue("@Rank4000", Rank4000)
        cmd.Parameters.AddWithValue("@Rank8000", Rank8000)
        cmd.Parameters.AddWithValue("@Rank11500", Rank11500)


        lblLive4000Cut.Text = "Rank 4000 (3D Skin): " & Rank4000
        lblLive8000Cut.Text = "Rank 8000 (Tank): " & Rank8000
        lblLive11500Cut.Text = "Rank 11500 (Tank): " & Rank11500
        cmd.CommandText = "Insert into CutHistory Values(@Time, @RankGM, @Rank4000, @Rank8000, @Rank11500, @front, @server)"
        cmd.Parameters.AddWithValue("@Time", Date.Now.ToString("dd.MM.yyyy:HH"))
        cmd.Parameters.AddWithValue("@front", FrontID)
        cmd.Parameters.AddWithValue("@server", cboServer.SelectedItem)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        cboFront.SelectedIndex = 0
        cboServer.SelectedIndex = 0
        btnGet.PerformClick()
    End Sub

    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        dataX.Rows.Clear()
        cmd.CommandText = "select * from exp where front=@front and server=@server"
        cmd.Parameters.AddWithValue("@front", cboFront.SelectedItem)
        cmd.Parameters.AddWithValue("@server", cboServer.SelectedItem)
        Reader = cmd.ExecuteReader
        While Reader.Read
            Dim day As String
            Dim req As String
            Dim diff As String
            Dim grow As String
            Dim avg As String
            Dim front As String
            Dim server As String
            day = Reader.GetString(0)
            Try
                req = Reader.GetValue(1)
            Catch ex As Exception
                req = "0"
            End Try

            Try
                diff = Reader.GetValue(2)
            Catch ex As Exception
                diff = "0"
            End Try

            Try
                grow = Reader.GetValue(3)
            Catch ex As Exception
                grow = "0"
            End Try
            avg = Reader.GetValue(4)
            front = Reader.GetString(5)
            server = Reader.GetString(6)
            dataX.Rows.Add(day, req, diff, grow, avg, front, server)
        End While

        Reader.Close()
        For Each row As DataGridViewRow In dataX.Rows
            If row.Cells(4).Value <> 0 Then
                avgGROW = row.Cells(4).Value
            End If
        Next
        lblAVGGROW.Text = avgGROW
        GetExpectations()
    End Sub

    Private Sub BtnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        Dim GrowBool As Boolean = True
        Dim growArray As List(Of Double) = New List(Of Double)()

        For i As Integer = 0 To dataX.Rows.Count - 1
            cmd.CommandText = "update exp set req=@req, diff=@diff, grow=@grow, avg=@avg where day=@day and front=@front and server=@server"
            cmd.Parameters.AddWithValue("@front", cboFront.SelectedItem)
            cmd.Parameters.AddWithValue("@server", cboServer.SelectedItem)
            Dim day As String = dataX.Rows(i).Cells(0).Value
            Dim req As Double = dataX.Rows(i).Cells(1).Value
            Dim diff As Double
            Dim grow As Double
            Dim avgrow As Double
            If i > 0 Then
                diff = CDbl(dataX.Rows(i).Cells(1).Value) - CDbl(dataX.Rows(i - 1).Cells(1).Value)
            Else
                diff = CDbl(dataX.Rows(i).Cells(1).Value)
            End If

            If CDbl(dataX.Rows(i).Cells(1).Value) = 0 Then diff = 0
            If i > 0 Then
                grow = CDbl(dataX.Rows(i).Cells(2).Value) / CDbl(dataX.Rows(i - 1).Cells(2).Value)
            Else
                grow = 1
            End If

            If CDbl(dataX.Rows(i).Cells(2).Value) = 0 Then
                grow = 0
                GrowBool = False
            End If

            If GrowBool = True Then
                If i > 0 Then
                    Dim sumgrow As Double
                    For y As Integer = 0 To i
                        growArray.Add(CDbl(dataX.Rows(y).Cells(3).Value))
                        sumgrow += CDbl(dataX.Rows(y).Cells(3).Value)
                    Next
                    avgrow = growArray.Average

                Else
                    avgrow = 1
                End If
            Else
                avgrow = 0
            End If
            cmd.Parameters.AddWithValue("@day", day)
            cmd.Parameters.AddWithValue("@req", req)
            cmd.Parameters.AddWithValue("@diff", diff)
            cmd.Parameters.AddWithValue("@grow", grow)
            cmd.Parameters.AddWithValue("@avg", avgrow)
            cmd.ExecuteNonQuery()

        Next
        btnGet.PerformClick()
        For Each row As DataGridViewRow In dataX.Rows
            If row.Cells(4).Value > 0 Then
                avgGROW = row.Cells(4).Value
            End If
        Next
        lblAVGGROW.Text = Math.Round(avgGROW, 2)
    End Sub
    Private Sub GetExpectations()
        extable.Rows.Clear()
        Dim reqPoints As Double
        Dim lastDiff As Double
        Dim lastPoints As Double
        For Each row As DataGridViewRow In dataX.Rows
            If row.Cells(2).Value > 0 Then lastDiff = row.Cells(2).Value
            If row.Cells(1).Value > 0 Then lastPoints = row.Cells(1).Value
        Next
        For Each row As DataGridViewRow In dataX.Rows
            If row.Cells(1).Value = 0 Then
                reqPoints = (avgGROW * lastDiff) + lastPoints
                lastDiff = avgGROW * lastDiff
                extable.Rows.Add(row.Cells(0).Value, Math.Round(reqPoints))
                lastPoints = reqPoints
            End If
        Next
    End Sub

    Private Sub cboServer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServer.SelectedIndexChanged
        btnGet.PerformClick()
        APIRealm = cboServer.SelectedItem
    End Sub

    Private Sub cboFront_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFront.SelectedIndexChanged
        btnGet.PerformClick()
        FrontID = cboFront.SelectedItem
    End Sub
End Class
